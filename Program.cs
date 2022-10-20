namespace LISGM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            ConfigurationData configurationData = new ConfigurationData();
            if (configurationData.loadConf() == -1)
            {
                MessageBox.Show("Проблема с сохранением файла конфигурации!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthorizationsWindow());
        }
    }

    // Responsible for the data exchange structure between the database and the client
    public struct DataDB 
    {
        public string msgToDB { get; set; }
        public int columnCount { get; set; }
        public int rowsCount { get; set; }
        public string[] columnName { get; set; }
        public string[] receivedData { get; set; }
        public int entryCheck { get; set; }
    }

    public struct UserApp
    {
        public string id { get; set; }
        public string employeesPosition { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        public string patronymic { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
    }

    public struct DataOrder
    {
        public string id { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string idManager { get; set; }
        public string idSupplier { get; set; }
        public string idLogistician { get; set; }
        public string idCarrier { get; set; }        
        public string statusOrder { get; set; }
        public string statusDelivered { get; set; }
        public string statusProcessOrder { get; set; }
    }
}