
using Zenject;


namespace SimplePrefs
{
    public sealed class GameDataSaveLoader
    {
        private IDataSaver _dataSaver;
        private IDataLoader _dataLoader;


       // [Inject]
        public GameDataSaveLoader(IDataSaver dataSaver, IDataLoader loader)
        {
            _dataSaver = dataSaver;
            _dataLoader = loader;
        }

       public void SaveMoney(DataSaves dataSavesMoney)
       {
            _dataSaver.SaveData(dataSavesMoney);
 
       }
        public DataSaves LoadMoney() {

            return _dataLoader.LoadData<DataSaves>();
        }

    }
}