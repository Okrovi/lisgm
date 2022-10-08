using Npgsql;

namespace LISGM
{
    internal class DatabaseInteraction
    {
        ConfigurationData configurationData = new ConfigurationData();

        // Structure for storing the response from the database
        DataDB dataDB = new DataDB();

        public DatabaseInteraction()
        {
            if (configurationData.loadConf() == -1)
            {
                MessageBox.Show("Проблема с сохранением файла конфигурации!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    IPAdressDB = configurationData.ValueFromConf("IPDB");
                    PortDB = configurationData.ValueFromConf("PORTDB");
                    loginToConnect = configurationData.ValueFromConf("LOGINTOCONNECT");
                    passwordToConnect = configurationData.ValueFromConf("PASSTOCONNECT");
                    nameDB = configurationData.ValueFromConf("NAMEDB");

                    EMPPOSMANAGER = configurationData.ValueFromConf("EMPPOSMANAGER");
                    EMPPOSLOGISTITCIAN = configurationData.ValueFromConf("EMPPOSLOGISTICIAN");
                    EMPPOSADMIN = configurationData.ValueFromConf("EMPPOSADMIN");

                    POSNAMESUPPLIER = configurationData.ValueFromConf("POSNAMESUPPLIER");

                    userappTable = "\"" + configurationData.ValueFromConf("USERAPPTABLE") + "\"";
                    empposTable = "\"" + configurationData.ValueFromConf("EMPPOSTABLE") + "\"";
                    categoryProdTable = "\"" + configurationData.ValueFromConf("CATEGORYPRODTABLE") + "\"";
                    productTable = "\"" + configurationData.ValueFromConf("PRODUCTTABLE") + "\"";
                    priceProdTable = "\"" + configurationData.ValueFromConf("PRICEPRODTABLE") + "\"";
                    counterpartyTable = "\"" + configurationData.ValueFromConf("COUNTERPARTYTABLE") + "\"";
                    typeCounterpartyTable = "\"" + configurationData.ValueFromConf("TYPECOUNTERPARTYTABLE") + "\"";
                    typeShopTable = "\"" + configurationData.ValueFromConf("TYPESHOPTABLE") + "\"";
                    unitProdTable = "\"" + configurationData.ValueFromConf("UNITPRODTABLE") + "\"";
                    shopTable = "\"" + configurationData.ValueFromConf("SHOPTABLE") + "\"";
                    orderTable = "\"" + configurationData.ValueFromConf("ORDERTABLE") + "\"";
                    prodOrderTable = "\"" + configurationData.ValueFromConf("PRODORDERTABLE") + "\"";

                    idUser = "\"" + configurationData.ValueFromConf("IDUSER") + "\"";
                    idEmployeesPositionFK = "\"" + configurationData.ValueFromConf("IDEMPLOYEESPOSITIONFK") + "\"";
                    surnameUser = "\"" + configurationData.ValueFromConf("SURNAMEUSER") + "\"";
                    firstnameUser = "\"" + configurationData.ValueFromConf("FIRSTNAMEUSER") + "\"";
                    patronymicUser = "\"" + configurationData.ValueFromConf("PATRONYMICUSER") + "\"";
                    phonenumberUser = "\"" + configurationData.ValueFromConf("PHONENUMBERUSER") + "\"";
                    emailUser = "\"" + configurationData.ValueFromConf("EMAILUSER") + "\"";
                    loginUser = "\"" + configurationData.ValueFromConf("LOGINUSER") + "\"";
                    passwordUser = "\"" + configurationData.ValueFromConf("PASSWORDUSER") + "\"";

                    idEmpPos = "\"" + configurationData.ValueFromConf("IDEMPPOS") + "\"";
                    nameEmpPos = "\"" + configurationData.ValueFromConf("NAMEEMPPOS") + "\"";

                    idCategoryProd = "\"" + configurationData.ValueFromConf("IDCATEGORYPROD") + "\"";
                    nameCategoryProd = "\"" + configurationData.ValueFromConf("NAMECATEGORYPROD") + "\"";

                    nameGoods = "\"" + configurationData.ValueFromConf("NAMEGOODS") + "\"";
                    idCategoryProdFK = "\"" + configurationData.ValueFromConf("IDCATEGORYPRODFK") + "\"";
                    idProd = "\"" + configurationData.ValueFromConf("IDPROD") + "\"";
                    idUnitFK = "\"" + configurationData.ValueFromConf("IDUNITFK") + "\"";
                    occupiedVolueProd = "\"" + configurationData.ValueFromConf("OCCUPUIEDVOLUMEPROD") + "\"";

                    idProdFK = "\"" + configurationData.ValueFromConf("IDPRODFK") + "\"";
                    idCounterpartyFK = "\"" + configurationData.ValueFromConf("IDCOUNTERPARTYFK") + "\"";
                    priceProd = "\"" + configurationData.ValueFromConf("PRICEPROD") + "\"";

                    idCounterparty = "\"" + configurationData.ValueFromConf("IDCOUNTERPARTY") + "\"";
                    idTypeCounterpartyFK = "\"" + configurationData.ValueFromConf("IDTYPECOUNTERPARTYFK") + "\"";
                    nameCounterparty = "\"" + configurationData.ValueFromConf("NAMECOUNTERPARTY") + "\"";
                    indexCounterparty = "\"" + configurationData.ValueFromConf("INDEXCOUNTERPARTY") + "\"";
                    locationCounterparty = "\"" + configurationData.ValueFromConf("LOCATIONCOUNTERPARTY") + "\"";
                    streetCounterparty = "\"" + configurationData.ValueFromConf("STREETCOUNTERPARTY") + "\"";
                    buildingCounterparty = "\"" + configurationData.ValueFromConf("BUILDINGCOUNTERPARTY") + "\"";
                    houseCounterparty = "\"" + configurationData.ValueFromConf("HOUSECOUNTERPARTY") + "\"";
                    officeCounterparty = "\"" + configurationData.ValueFromConf("OFFICECOUNTERPARTY") + "\"";
                    INNCounterparty = "\"" + configurationData.ValueFromConf("INNCOUNTERPARTY") + "\"";
                    BICCounterparty = "\"" + configurationData.ValueFromConf("BICCOUNTERPARTY") + "\"";
                    numberphoneCounterparty = "\"" + configurationData.ValueFromConf("NUMBERPHONECOUNTERPARTY") + "\"";
                    emailCounterparty = "\"" + configurationData.ValueFromConf("EMAILCOUNTERPARTY") + "\"";
                    minVolumeCarrier = "\"" + configurationData.ValueFromConf("MINVOLUMECARRIER") + "\"";
                    maxVolumeCarrier = "\"" + configurationData.ValueFromConf("MAXVOLUMECARRIER") + "\"";

                    idTypeCounterparty = "\"" + configurationData.ValueFromConf("IDTYPECOUNTERPARTY") + "\"";
                    nameTypeCounterparty = "\"" + configurationData.ValueFromConf("NAMETYPECOUNTERPARTY") + "\"";

                    idTypeShop = "\"" + configurationData.ValueFromConf("IDTYPESHOP") + "\"";
                    nameTypeShop = "\"" + configurationData.ValueFromConf("NAMETYPESHOP") + "\"";

                    idUnit = "\"" + configurationData.ValueFromConf("IDUNIT") + "\"";
                    nameUnit = "\"" + configurationData.ValueFromConf("NAMEUNIT") + "\"";

                    idShop = "\"" + configurationData.ValueFromConf("IDSHOP") + "\"";
                    idTypeShopFK = "\"" + configurationData.ValueFromConf("IDTYPESHOPFK") + "\"";
                    locationShop = "\"" + configurationData.ValueFromConf("LOCATIONSHOP") + "\"";
                    streetShop = "\"" + configurationData.ValueFromConf("STREETSHOP") + "\"";
                    buildingShop = "\"" + configurationData.ValueFromConf("BUILDINGSHOP") + "\"";
                    houseShop = "\"" + configurationData.ValueFromConf("HOUSESHOP") + "\"";
                    nameShop = "\"" + configurationData.ValueFromConf("NAMESHOP") + "\"";

                    rowsReceived = Int32.Parse(configurationData.ValueFromConf("ROWSRECEIVED"));
                }
                catch
                {
                    MessageBox.Show("Проблема с файлом конфигурации!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }            
        }

        // Database connection data
        static string IPAdressDB { get; set; }
        static string PortDB { get; set; }
        static string loginToConnect { get; set; }
        static string passwordToConnect { get; set; }
        static string nameDB { get; set; }


        // Employes position
        // Manager
        public string EMPPOSMANAGER { get; set; }
        // Logistician
        public string EMPPOSLOGISTITCIAN { get; set; }
        // Admin
        public string EMPPOSADMIN { get; set; }

        // Counterparty position name
        // Supplier
        string POSNAMESUPPLIER { get; set; }

        // Realated values of table names
        string userappTable { get; set; }
        string empposTable { get; set; }
        string categoryProdTable { get; set; }
        string productTable { get; set; }
        string priceProdTable { get; set; }
        string counterpartyTable { get; set; }
        string typeCounterpartyTable { get; set; }
        string typeShopTable { get; set; }
        string unitProdTable { get; set; }
        string shopTable { get; set; }
        string orderTable { get; set; }
        string prodOrderTable { get; set; }

        // Related values of column names
        // table - userappTable
        public string idUser { get; set; }
        public string idEmployeesPositionFK { get; set; }
        public string surnameUser { get; set; }
        public string firstnameUser { get; set; }
        public string patronymicUser { get; set; }
        public string phonenumberUser { get; set; }
        public string emailUser { get; set; }
        public string loginUser { get; set; }
        public string passwordUser { get; set; }
        // table - empposTable
        string idEmpPos { get; set; }
        string nameEmpPos { get; set; }
        // table - categoryProdTable
        string idCategoryProd { get; set; }
        string nameCategoryProd { get; set; }
        // table - productTable
        public string nameGoods { get; set; }
        string idCategoryProdFK { get; set; }
        public string idProd { get; set; }
        string idUnitFK { get; set; }
        public string occupiedVolueProd { get; set; }
        // table - priceProdTable
        string idProdFK { get; set; }
        string idCounterpartyFK { get; set; }
        public string priceProd { get; set; }
        // table - counterpartyTable
        public string idCounterparty { get; set; }
        public string idTypeCounterpartyFK { get; set; }
        public string nameCounterparty { get; set; }
        public string indexCounterparty { get; set; }
        public string locationCounterparty { get; set; }
        public string streetCounterparty { get; set; }
        public string buildingCounterparty { get; set; }
        public string houseCounterparty { get; set; }
        public string officeCounterparty { get; set; }
        public string INNCounterparty { get; set; }
        public string BICCounterparty { get; set; }
        public string numberphoneCounterparty { get; set; }
        public string emailCounterparty { get; set; }
        public string minVolumeCarrier { get; set; }
        public string maxVolumeCarrier { get; set; }
        // table - typeCounterpartyTable
        string idTypeCounterparty { get; set; }
        string nameTypeCounterparty { get; set; }
        // table - typeShopTable
        string idTypeShop { get; set; }
        string nameTypeShop { get; set; }
        // table - unitProdTable
        string idUnit { get; set; }
        string nameUnit { get; set; }
        // table - shopTable
        public string idShop { get; set; }
        public string idTypeShopFK { get; set; }
        public string locationShop { get; set; }
        public string streetShop { get; set; }
        public string buildingShop { get; set; }
        public string houseShop { get; set; }
        public string nameShop { get; set; }

        // Related values of column names
        // table - orderTable
        public string idOrder = "\"id\"";
        public string dateStartOrder = "\"order_date\"";
        public string dateEndOrder = "\"execuption_date\"";
        public string idManagerOrder = "\"id_manager\"";
        public string idSupplierOrder = "\"id_supplier\"";
        public string idLogisticianOrder = "\"id_logistician\"";
        public string idCarrierOrder = "\"id_carrier\"";
        public string statusProcessOrder = "\"status_process\"";
        public string statusOrder = "\"status_order\"";
        public string statusDelivery = "\"status_delivery\"";
        string confirmOrderDate = "\"confirm_order_date\"";
        string confirmDeliveryDate = "\"confirm_delivery_date\"";
        // table - prodOrderTable
        public string idOrderProdOrderFK = "\"id_order\"";
        public string idProdProdOrderFK = "\"id_prod\"";
        public string idShopProdOrderFK = "\"id_shop\"";
        public string amountProdProdOrder = "\"amount_order\"";
        public string amounDeliveredProdProdOrder = "\"amount_delivered\"";
        public string statusDeliveryProdOrder = "\"status_delivery\"";
        string idUserappProdOrderFK = "\"id_emp\"";

        // Status field text
        // status process
        public string TEXTSTATUSPROCESSSTART = "ВРАБОТЕ";
        public string TEXTSTATUSPROCESSEND = "ЗАВЕРШЕН";
        public string TEXTSTATUSCONFIRMCREATE = "СОЗДАН";
        // status confirm supplier and carrier
        public string TEXTSTATUSCONFIRM = "ПОДТВЕРЖДЕН";
        // status product in order
        public string TEXTSTATUSPRODUCTSTART = "ВРАБОТЕ";
        public string TEXTSTATUSPRODUCTEND = "ДОСТАВЛЕН";


        // Maximum number of rows to receive
        public int rowsReceived { get; set; }

        // Reading data from the database
        public void GetInf()
        {
            try
            {
                string connectionString = String.Format("Host={0};Port={1};Username={2};Password={3};Database={4}", IPAdressDB, PortDB, loginToConnect, passwordToConnect, nameDB);

                using (var connectDB = new NpgsqlConnection(connectionString))
                {
                    connectDB.Open();

                    using (var comandDB = new NpgsqlCommand(dataDB.msgToDB, connectDB))
                    {
                        try
                        {
                            using (var readerResponse = comandDB.ExecuteReader())
                            {
                                string[] columnName = new string[readerResponse.FieldCount];

                                for (int i = 0; i < readerResponse.FieldCount; i++)
                                {
                                    columnName[i] = readerResponse.GetName(i);
                                }

                                dataDB.columnName = columnName;

                                string[] values = new string[rowsReceived * readerResponse.FieldCount];
                                int position_number = 0;

                                while (readerResponse.Read())
                                {
                                    for (int i = 0; i < readerResponse.FieldCount; i++)
                                    {
                                        values[position_number] = readerResponse.GetValue(i).ToString();
                                        position_number++;
                                    }
                                }

                                dataDB.columnCount = readerResponse.FieldCount;
                                dataDB.rowsCount = position_number / dataDB.columnCount;
                                dataDB.receivedData = values;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Проблема с запросом на получение данных от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connectDB.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проблема с подключением к базе данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        // Writing data to the database
        public void GiveInf()
        {
            try
            {
                string connectionString = String.Format("Host={0};Port={1};Username={2};Password={3};Database={4}", IPAdressDB, PortDB, loginToConnect, passwordToConnect, nameDB);

                using (var connectDB = new NpgsqlConnection(connectionString))
                {
                    connectDB.Open();

                    using (var comandDB = new NpgsqlCommand(dataDB.msgToDB, connectDB))
                    {
                        try
                        {
                            dataDB.entryCheck = comandDB.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Проблема с запросом на запись в базу данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connectDB.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проблема с подключением к базе данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // request autorization window
        public DataDB RequestAutorization(string login, string password)
        {
            dataDB.msgToDB = $"SELECT {idUser},{surnameUser},{firstnameUser},{patronymicUser},{phonenumberUser},{emailUser},{loginUser},{passwordUser}," +
                $"(SELECT {nameEmpPos} FROM {empposTable} WHERE {userappTable}.{idEmployeesPositionFK} = {empposTable}.{idEmpPos}) AS {idEmployeesPositionFK} " +
                $"FROM {userappTable} " +
                $"WHERE {loginUser} = '{login}' " +
                $"AND {passwordUser} = '{password}'";

            GetInf();
            return dataDB;
        }
        //

        // request choice of supplier window
        public DataDB RequestCategoryProd()
        {
            dataDB.msgToDB = $"SELECT {nameCategoryProd} " +
                $"FROM {categoryProdTable};";
            GetInf();
            return dataDB;
        }

        public DataDB RequestGoodsFromAllSuppliers(string categoryProd)
        {
            dataDB.msgToDB = $"SELECT {nameGoods} " +
                $"FROM {productTable} " +
                $"WHERE {idCategoryProdFK} = (SELECT {idCategoryProd} FROM {categoryProdTable} WHERE {nameCategoryProd} = '{categoryProd}');";
            GetInf();
            return dataDB;
        }

        public DataDB RequestSupplier(string choiceProd)
        {
            dataDB.msgToDB = $"SELECT {counterpartyTable}.{idCounterparty}, {priceProdTable}.{priceProd}, {counterpartyTable}.{nameCounterparty}, {counterpartyTable}.{locationCounterparty}, {counterpartyTable}.{streetCounterparty}, {counterpartyTable}.{buildingCounterparty}, {counterpartyTable}.{houseCounterparty}, {counterpartyTable}.{officeCounterparty} " +
                $"FROM {counterpartyTable} " +
                $"INNER JOIN {priceProdTable} " +
                $"ON {counterpartyTable}.{idCounterparty} = {priceProdTable}.{idCounterpartyFK} " +
                $"WHERE {priceProdTable}.{idProdFK} = (SELECT {idProd} FROM {productTable} WHERE {nameGoods} = '{choiceProd}');";

            GetInf();
            return dataDB;
        }
        //

        // request choice of carrier window
        public DataDB RequestTypeCounterparty()
        {
            dataDB.msgToDB = $"SELECT {nameTypeCounterparty} " +
                $"FROM {typeCounterpartyTable} " +
                $"WHERE {nameTypeCounterparty} != '{POSNAMESUPPLIER}';";

            GetInf();
            return dataDB;
        }

        public DataDB RequestLocationCarrier(string typeCarrier)
        {
            dataDB.msgToDB = $"SELECT {locationCounterparty} " +
                $"FROM {counterpartyTable} " +
                $"WHERE {idTypeCounterpartyFK} = (SELECT {idTypeCounterparty} FROM {typeCounterpartyTable} WHERE {nameTypeCounterparty} = '{typeCarrier}') " +
                $"GROUP BY {locationCounterparty};";

            GetInf();
            return dataDB;
        }

        public DataDB RequestCarrier(string typeCarrier, string locationCarrier)
        {
            dataDB.msgToDB = $"SELECT {idCounterparty}, {minVolumeCarrier}, {maxVolumeCarrier}, {nameCounterparty}, {locationCounterparty}, {streetCounterparty}, {buildingCounterparty}, {houseCounterparty}, {officeCounterparty} " +
                $"FROM {counterpartyTable} " +
                $"WHERE {idTypeCounterpartyFK} = (SELECT {idTypeCounterparty} FROM {typeCounterpartyTable} WHERE {nameTypeCounterparty} = '{typeCarrier}') " +
                $"AND {locationCounterparty} = '{locationCarrier}';";

            GetInf();
            return dataDB;
        }

        public DataDB RequestDataCounterparty(string idcounterparty)
        {
            dataDB.msgToDB = $"SELECT concat('ID: ',{idCounterparty}) AS {idCounterparty}," +
                $"concat('Название: ',{nameCounterparty}) AS {nameCounterparty}," +
                $"concat('Индекс: ',{indexCounterparty}) AS {indexCounterparty}," +
                $"concat('Нас.пункт: ',{locationCounterparty}) AS {locationCounterparty}," +
                $"concat('Улица: ',{streetCounterparty}) AS {streetCounterparty}," +
                $"concat('Строение: ',{buildingCounterparty}) AS {buildingCounterparty}," +
                $"concat('Дом: ',{houseCounterparty}) AS {houseCounterparty}," +
                $"concat('Офис: ',{officeCounterparty}) AS {officeCounterparty}," +
                $"concat('ИНН: ',{INNCounterparty}) AS {INNCounterparty}," +
                $"concat('БИК: ',{BICCounterparty}) AS {BICCounterparty}," +
                $"concat('Телефон: ',{numberphoneCounterparty}) AS {numberphoneCounterparty}," +
                $"concat('Почта: ',{emailCounterparty}) AS {emailCounterparty}," +
                $"concat('Мин. объем: ',{minVolumeCarrier}) AS {minVolumeCarrier}," +
                $"concat('Макс. объем: ',{maxVolumeCarrier}) AS {maxVolumeCarrier} " +
                $"FROM {counterpartyTable} " +
                $"WHERE {idCounterparty} = '{idcounterparty}';";

            GetInf();
            return dataDB;
        }
        //

        // request product selection window
        public DataDB RequestGoodsSupplier(string idsupplier)
        {
            dataDB.msgToDB = $"SELECT {productTable}.{idProd},{productTable}.{nameGoods},{productTable}.{occupiedVolueProd} " +
                $"FROM {productTable} " +
                $"INNER JOIN {priceProdTable} " +
                $"ON {productTable}.{idProd} = {priceProdTable}.{idProdFK} " +
                $"WHERE {priceProdTable}.{idCounterpartyFK} = '{idsupplier}';";
            GetInf();
            return dataDB;
        }

        public DataDB RequestAllTypesShop()
        {
            dataDB.msgToDB = $"SELECT {nameTypeShop} " +
                $"FROM {typeShopTable};";

            GetInf();
            return dataDB;
        }

        public DataDB RequestUnitProd(string nameprod)
        {
            dataDB.msgToDB = $"SELECT {unitProdTable}.{nameUnit} " +
               $"FROM {unitProdTable} " +
               $"INNER JOIN {productTable} " +
               $"ON {unitProdTable}.{idUnit} = {productTable}.{idUnitFK} " +
               $"WHERE {productTable}.{nameGoods} = '{nameprod}';";

            GetInf();
            return dataDB;
        }

        public DataDB RequestLocationShop(string typeshop)
        {
            dataDB.msgToDB = $"SELECT {locationShop} " +
                $"FROM {shopTable} " +
                $"WHERE {idTypeShopFK} = (SELECT {idTypeShop} FROM {typeShopTable} WHERE {nameTypeShop} = '{typeshop}') " +
                $"GROUP BY {locationShop};";

            GetInf();
            return dataDB;
        }

        public DataDB RequestStreetShop(string locationshop)
        {
            dataDB.msgToDB = $"SELECT {streetShop} " +
                $"FROM {shopTable} " +
                $"WHERE {locationShop} = '{locationshop}' " +
                $"GROUP BY {streetShop};";

            GetInf();
            return dataDB;
        }

        public DataDB RequestShops(string typeshop, string locationshop, string streetshop)
        {
            dataDB.msgToDB = $"SELECT {idShop},{nameShop},{locationShop},{streetShop},{buildingShop},{houseShop} " +
                $"FROM {shopTable} " +
                $"WHERE {idTypeShopFK} = (SELECT {idTypeShop} FROM {typeShopTable} WHERE {nameTypeShop} = '{typeshop}') " +
                $"AND {locationShop} = '{locationshop}' " +
                $"AND {streetShop} = '{streetshop}';";

            GetInf();
            return dataDB;
        }
        //

        // adding a new order
        public DataDB NewOrderEntry(string iduser)
        {
            dataDB.msgToDB = $"INSERT INTO {orderTable} ({dateStartOrder},{idManagerOrder},{statusProcessOrder}) " +
                $"VALUES (LOCALTIMESTAMP,'{iduser}','{TEXTSTATUSCONFIRMCREATE}');";

            GiveInf();
            return dataDB;
        }

        public DataDB RequestIDNewOrder(string iduser)
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{idManagerOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {idManagerOrder} = '{iduser}' " +
                $"AND {statusProcessOrder} = '{TEXTSTATUSCONFIRMCREATE}';";

            GetInf();
            return dataDB;
        }

        public DataDB StatusChangeOrder(string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {statusProcessOrder} = '{TEXTSTATUSPROCESSSTART}' " +
                $"WHERE {idManagerOrder} = '{idorder}' " +
                $"AND {statusProcessOrder} = '{TEXTSTATUSCONFIRMCREATE}';";

            GiveInf();
            return dataDB;
        }
        //

        // request order window
        public DataDB RequestAllOrdersManager(string iduser)
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSSTART}' " +
                $"AND {idManagerOrder} = '{iduser}' " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }

        public DataDB RequestAllOrdersLogistician(string iduser)
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSSTART}' " +
                $"AND {idLogisticianOrder} = '{iduser}' " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }

        public DataDB RequestAllOrdersAdmin()
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSSTART}' " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }

        public DataDB RequestAllOrdersNotLogistician()
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSSTART}' " +
                $"AND {idLogisticianOrder} IS NULL " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }

        public DataDB RequestAllOrdersManagerArhive(string iduser)
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSEND}' " +
                $"AND {idManagerOrder} = '{iduser}' " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }

        public DataDB RequestAllOrdersLogisticianArhive(string iduser)
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSEND}' " +
                $"AND {idLogisticianOrder} = '{iduser}' " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }

        public DataDB RequestAllOrdersAdminArhive()
        {
            dataDB.msgToDB = $"SELECT {idOrder},{dateStartOrder},{dateEndOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idManagerOrder} = {userappTable}.{idUser}) AS {idManagerOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idSupplierOrder} = {counterpartyTable}.{idCounterparty}) AS {idSupplierOrder}," +
                $"(SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) FROM {userappTable} WHERE {orderTable}.{idLogisticianOrder} = {userappTable}.{idUser}) AS {idLogisticianOrder}," +
                $"(SELECT {nameCounterparty} FROM {counterpartyTable} WHERE {orderTable}.{idCarrierOrder} = {counterpartyTable}.{idCounterparty}) AS {idCarrierOrder} " +
                $"FROM {orderTable} " +
                $"WHERE {statusProcessOrder} = '{TEXTSTATUSPROCESSEND}' " +
                $"ORDER BY {idOrder} DESC;";

            GetInf();
            return dataDB;
        }
        //

        // order editing window
        public DataDB RequestDataSelectedOrder(string idorder)
        {
            dataDB.msgToDB = $"SELECT * " +
                $"FROM {orderTable} " +
                $"WHERE {idOrder} = '{idorder}';";

            GetInf();
            return dataDB;
        }

        public DataDB RequestDetailsUser(string iduser)
        {
            dataDB.msgToDB = $"SELECT concat({surnameUser},' ',{firstnameUser},' ',{patronymicUser}) AS \"name\"," +
                $"{phonenumberUser},{emailUser} " +
                $"FROM {userappTable} " +
                $"WHERE {idUser} = '{iduser}';";

            GetInf();
            return dataDB;
        }

        public DataDB ValueChangeIdSupplier(string idmanager, string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {idSupplierOrder} = '{idmanager}' " +
                $"WHERE {idOrder} = '{idorder}';";

            GiveInf();
            return dataDB;
        }

        public DataDB ValueChangeIdLogistician(string idlogist, string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {idLogisticianOrder} = '{idlogist}' " +
                $"WHERE {idOrder} = '{idorder}';";

            GiveInf();
            return dataDB;
        }

        public DataDB ValueChangeIdCarrier(string idcarrier, string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {idCarrierOrder} = '{idcarrier}' " +
                $"WHERE {idOrder} = '{idorder}';";

            GiveInf();
            return dataDB;
        }

        public DataDB ValueChangeConfirmStatusOrder(string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {statusOrder} = '{TEXTSTATUSCONFIRM}',{confirmOrderDate} = LOCALTIMESTAMP " +
                $"WHERE {idOrder} = '{idorder}';";

            GiveInf();
            return dataDB;
        }

        public DataDB ValueChangeConfirmStatusDelivery(string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {statusDelivery} = '{TEXTSTATUSCONFIRM}',{confirmDeliveryDate} = LOCALTIMESTAMP " +
                $"WHERE {idOrder} = '{idorder}';";

            GiveInf();
            return dataDB;
        }

        public DataDB RequestAllGoodsInOrdrer(string idorder)
        {
            dataDB.msgToDB = $"SELECT {idProdProdOrderFK}," +
                $"(SELECT {nameGoods} FROM {productTable} WHERE {productTable}.{idProd} = {prodOrderTable}.{idProdProdOrderFK}) AS \"nameprod\"," +
                $"(SELECT {occupiedVolueProd} FROM {productTable} WHERE {productTable}.{idProd} = {prodOrderTable}.{idProdProdOrderFK}) AS \"occupiedvolume\"," +
                $"{idShopProdOrderFK}," +
                $"(SELECt {nameShop} FROM {shopTable} WHERE {shopTable}.{idShop} = {prodOrderTable}.{idShopProdOrderFK}) AS \"nameshop\"," +
                $"(SELECT concat({locationShop},' ',{streetShop},' ',{buildingShop},' ',{houseShop}) FROM {shopTable} WHERE {shopTable}.{idShop} = {prodOrderTable}.{idShopProdOrderFK}) AS \"adressshop\"," +
                $"{amountProdProdOrder},{amounDeliveredProdProdOrder},{statusDeliveryProdOrder} " +
                $"FROM {prodOrderTable} " +
                $"WHERE {idOrderProdOrderFK} = '{idorder}';";

            GetInf();
            return dataDB;
        }

        public DataDB NewProdInOrder(string idorder, string idprod, string idshop, string amountorder, string statusdelivery)
        {
            dataDB.msgToDB = $"INSERT INTO {prodOrderTable} ({idOrderProdOrderFK},{idProdProdOrderFK},{idShopProdOrderFK},{amountProdProdOrder},{statusDeliveryProdOrder}) " +
                $"VALUES ('{idorder}','{idprod}','{idshop}','{amountorder}','{statusdelivery}');";

            GiveInf();
            return dataDB;
        }

        public DataDB RemoveProdInOrder(string idorder, string idprod, string idshop, string amountprod)
        {
            dataDB.msgToDB = $"DELETE FROM {prodOrderTable} " +
                $"WHERE {idOrderProdOrderFK} = '{idorder}' " +
                $"AND {idProdProdOrderFK} = '{idprod}' " +
                $"AND {idShopProdOrderFK} = '{idshop}' " +
                $"AND {amountProdProdOrder} = '{amountprod}';";

            GiveInf();
            return dataDB;
        }

        public DataDB ValueChangeSatusProcess(string idorder)
        {
            dataDB.msgToDB = $"UPDATE {orderTable} " +
                $"SET {statusProcessOrder} = '{TEXTSTATUSPROCESSEND}',{dateEndOrder} = LOCALTIMESTAMP " +
                $"WHERE {idOrder} = '{idorder}';";

            GiveInf();
            return dataDB;
        }

        public DataDB ValueChangeSatusDelivered(string idorder, string idprod, string idshop, string amountorder, string amountdelivery, string user)
        {
            dataDB.msgToDB = $"UPDATE {prodOrderTable} " +
                $"SET {statusDelivery} = '{TEXTSTATUSPRODUCTEND}',{amounDeliveredProdProdOrder} = '{amountdelivery}',{idUserappProdOrderFK} = '{user}' " +
                $"WHERE {idOrderProdOrderFK} = '{idorder}' " +
                $"AND {idProdProdOrderFK} = '{idprod}' " +
                $"AND {idShopProdOrderFK} = '{idshop}' " +
                $"AND {amountProdProdOrder} = '{amountorder}';";

            GiveInf();
            return dataDB;
        }
        //
    }
}
