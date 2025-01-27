namespace SimplePrefs
{
    public interface IDataSaver {

        public void SetPhysically(string key, object value);

        public void SaveData<T>(T data) where T: struct, IData;

        public void ApplyChanges();
    }
}