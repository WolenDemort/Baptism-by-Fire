using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Linq;

public class SaveSystem : IStorageSystem
{
    public void SaveNewFile(SaveKey key, object data)
    { 
        
        string path = BuildPath(key.ToString());
        string json = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        
        using (var fileStream=new StreamWriter(path))
        {
            fileStream.Write(json);
        }
    }
    public void SaveOldFile(SaveKey key, object data)
    {
        string path = BuildPath(key.ToString());
              
        List<object> allData = new List<object>();

        if (File.Exists(path))
        {
            string existingJson = File.ReadAllText(path);
            try
            {
                var loaded = JsonConvert.DeserializeObject<List<object>>(existingJson);
                if (loaded != null) allData.AddRange(loaded);
            }
            catch
            {
                try
                {                   
                    var nested = JsonConvert.DeserializeObject<List<List<object>>>(existingJson);
                    if (nested != null)
                        allData.AddRange(nested.SelectMany(x => x));
                }
                catch
                {
                    Debug.LogError("Неверный формат файла, будет создан новый");
                }
            }
        }

        
        if (data is IEnumerable enumerable && !(data is string))
        {
            foreach (var item in enumerable)
                allData.Add(item);
        }
        else
        {
            allData.Add(data);
        }

        
        string json = JsonConvert.SerializeObject(allData, Formatting.Indented, new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            TypeNameHandling = TypeNameHandling.Auto 
        });

        
        string tempPath = path + ".tmp";
        File.WriteAllText(tempPath, json);

        if (File.Exists(path))
            File.Delete(path);
        File.Move(tempPath, path);

    }
    public void Load<T>(SaveKey key, Action<T> callBack)
    {
        string path = BuildPath(key.ToString());
        if (File.Exists(path))
        {
            using (var fileStream = new StreamReader(path))
            {
                var json = fileStream.ReadToEnd();
                var data = JsonConvert.DeserializeObject<T>(json);
                callBack?.Invoke(data);
            }
        }
        
    }



    private string BuildPath(string key)
    {
        return Path.Combine(Application.persistentDataPath, key);
    }

    
}

public enum SaveKey
{
    Shop, PlayingDeck, Money, AllCardsPlayer, Test
}

public interface IStorageSystem
{
    void SaveNewFile(SaveKey key, object data);
    public void SaveOldFile(SaveKey key, object newData);
    void Load<T>(SaveKey key, Action<T> callBack);
}