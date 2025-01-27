using System;
using System.Linq;
using System.Reflection;
using UnityEngine;


namespace SimplePrefs
{
    public sealed class PlayerPrefsLoader : IDataLoader
    {
        public T LoadData<T>(string keySecondary = "") where T : struct, IData
        {
            T data = new();

            object dataBox = (object)data;
            string keyPrimary;

            object[] dataAttributes = data.GetType().GetCustomAttributes(true);

            keyPrimary = ((SaveFieldPrimaryKeyAttribute)dataAttributes.FirstOrDefault(x => x is SaveFieldPrimaryKeyAttribute)).keyPrimary;

            if (keyPrimary == null || keyPrimary.Length == 0)
                throw new ArgumentException("Data type must hava the primary key");

            FieldInfo[] fields = data.GetType().GetFields();

            foreach (var field in fields)
            {
                object[] attrubutes = field.GetCustomAttributes(false);

                foreach (var attribute in attrubutes)
                {
                    if (attribute is SaveFieldSecondaryKeyAttribute)
                    {
                        field.SetValue(dataBox, keySecondary);
                    }

                    if (attribute is SaveFieldAttribute)
                    {
                        string fullKey = $"{keyPrimary}{keySecondary}_{field.Name}";
                        object loadedData = LoadPhysically(fullKey, field.FieldType);
                        field.SetValue(dataBox, Convert.ChangeType(loadedData, field.FieldType));
                        Debug.Log($"Load: {fullKey}: {loadedData}");
                    }
                }
            }

            return (T)dataBox;
        }

        public object LoadPhysically(string key, Type dataType)
        {

            if (dataType == typeof(int))
                return PlayerPrefs.GetInt(key);

            if (dataType == typeof(float))
                return PlayerPrefs.GetFloat(key);

            if (dataType == typeof(string))
                return PlayerPrefs.GetString(key);

            else
                throw new Exception("Unsopperted format");
        }
    }
}
