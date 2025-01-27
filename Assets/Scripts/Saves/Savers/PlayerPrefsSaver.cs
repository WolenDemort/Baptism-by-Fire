using System;
using System.Linq;
using System.Reflection;
using UnityEngine;


namespace SimplePrefs
{
    public sealed class PlayerPrefsSaver : IDataSaver
    {
        public void ApplyChanges()
        {
            PlayerPrefs.Save();
        }

        public void SaveData<T>(T data) where T : struct, IData
        {
            string keyPrimary;
            string keySecondary = "";

            Type dataType = data.GetType();

            object[] dataAttributes = dataType.GetCustomAttributes(true);

            keyPrimary = ((SaveFieldPrimaryKeyAttribute)dataAttributes.FirstOrDefault(x => x is SaveFieldPrimaryKeyAttribute)).keyPrimary;

            if (keyPrimary == null || keyPrimary.Length == 0)
                throw new ArgumentException("Data type must have the primary key");

            FieldInfo[] fields = dataType.GetFields();

            foreach (var field in fields)
            {
                object[] attrubutes = field.GetCustomAttributes(false);

                foreach (var attribute in attrubutes)
                {
                    if (attribute is SaveFieldSecondaryKeyAttribute)
                    {
                        keySecondary = (string)field.GetValue(data);
                    }

                    if (attribute is SaveFieldAttribute)
                    {
                        string fullKey = $"{keyPrimary}{keySecondary}_{field.Name}";
                        object fieldValue = field.GetValue(data);
                        Debug.Log($"Save: {fullKey}: {fieldValue}");
                        SetPhysically(fullKey, fieldValue);
                    }
                }
            }
        }

        public void SetPhysically(string key, object value)
        {
            switch (value)
            {
                case int:
                    PlayerPrefs.SetInt(key, (int)value);
                    break;
                case float:
                    PlayerPrefs.SetFloat(key, (float)value);
                    break;
                case string:
                    PlayerPrefs.SetString(key, (string)value);
                    break;
            }
        }
    }
}