using System;

namespace SimplePrefs
{
    public interface IDataLoader
    {
        public object LoadPhysically(string key, Type dataType);

        public T LoadData<T>(string keySecondary = "") where T : struct, IData;
    }
}