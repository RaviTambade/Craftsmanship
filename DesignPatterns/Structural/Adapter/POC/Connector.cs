namespace Transflower.DesignPatterns.Adapter.POC;

    internal class Connector : IConnector
    {
        private readonly DataSource _dataSource;

        public Connector(DataSource dataSource)
        {
            this._dataSource = dataSource;
        }

        public List<User> GetData()
        {
            return this._dataSource.GetSpecificData();
        }
    }

