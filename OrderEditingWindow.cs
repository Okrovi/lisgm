using System.Text.RegularExpressions;

namespace LISGM
{
    public partial class OrderEditingWindow : Form
    {
        static DatabaseInteraction databaseInteraction = new DatabaseInteraction();
        public UserApp userApp = new UserApp();
        OrderWindow orderWindow = new OrderWindow();

        string[][] goodsInOrder = new string[databaseInteraction.rowsReceived][];
        public string[][] goodsInOrderAdder = new string[databaseInteraction.rowsReceived][];
        string[][] goodsInOrderDeliting = new string[databaseInteraction.rowsReceived][];

        public DataOrder dataOrder = new DataOrder();
        DataDB dataDB = new DataDB();

        private bool saveStateButtaAddItem = false;
        private bool saveStateButtaRemItem = false;

        public OrderEditingWindow()
        {
            InitializeComponent();
        }

        public OrderEditingWindow(UserApp userApp, OrderWindow orderWindow)
        {
            this.userApp = userApp;
            this.orderWindow = orderWindow;
            InitializeComponent();
        }

        public ListBox supplierDetails()
        {
            return listBoxDetailsSupplier;
        }

        public ListBox carrierDetails()
        {
            return listBoxDetailsCarrier;
        }

        public TableLayoutPanel tableProducts()
        {
            return tableLayoutPanelAddedGoods;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonValueProvider_Click(object sender, EventArgs e)
        {
            ChoiceOfSupplierWindow choiceOfSupplierWindow = new ChoiceOfSupplierWindow(this);
            choiceOfSupplierWindow.Show();
        }

        private void buttonValueCarrier_Click(object sender, EventArgs e)
        {
            ChoiceOfCarrierWindow choiceOfCarrierWindow = new ChoiceOfCarrierWindow(this);
            choiceOfCarrierWindow.Show();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            ProductSelectionWindow productSelectionWindow = new ProductSelectionWindow(this);
            productSelectionWindow.Show();

            buttonRemItem.Enabled = false;
        }

        private void buttonRemItem_Click(object sender, EventArgs e)
        {
            int countRows = tableLayoutPanelAddedGoods.Controls.Count / 8;
            int positionCheckBox = 0;

            if(tableLayoutPanelAddedGoods.Controls.Count >= 8)
            {
                for (int i = 0; i < countRows; i++)
                {
                    Control checkBox = tableLayoutPanelAddedGoods.Controls[positionCheckBox];
                    CheckBox checkBoxDetails = (CheckBox)checkBox;

                    if (checkBoxDetails.Checked == true)
                    {
                        for(int j = 0; j < goodsInOrderDeliting.Length; j++)
                        {
                            if(goodsInOrderDeliting[j] == null)
                            {
                                goodsInOrderDeliting[j] = new string[4];
                                goodsInOrderDeliting[j][0] = dataOrder.id;
                                goodsInOrderDeliting[j][1] = tableLayoutPanelAddedGoods.Controls[positionCheckBox].Name;
                                goodsInOrderDeliting[j][2] = tableLayoutPanelAddedGoods.Controls[positionCheckBox + 3].Name;
                                goodsInOrderDeliting[j][3] = tableLayoutPanelAddedGoods.Controls[positionCheckBox + 5].Text;
                                break;
                            }

                            if (j == databaseInteraction.rowsReceived - 1)
                            {
                                MessageBox.Show("Превышено количество изменений в заказе, сохраните изменения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                        for (int j = 0; j < 8; j++)
                        {
                            tableLayoutPanelAddedGoods.Controls.RemoveAt(positionCheckBox);                            
                        }

                        continue;
                    }

                    positionCheckBox = positionCheckBox + 8;
                }

                if(tableLayoutPanelAddedGoods.Controls.Count == 0)
                {
                    buttonValueSupplier.Enabled = true;
                }

                buttonAddItem.Enabled = false;
            }            
        }

        public DataOrder dataOrderDetails()
        {
            return dataOrder;
        }

        private void OrderEditingWindow_Load(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestDataSelectedOrder(this.Name);
            int columnId = 0;
            int columnStartDate = 0;
            int columnEndDate = 0;
            int columnIdManager = 0;
            int columnIdSupplier = 0;
            int columnIdLogistician = 0;
            int columnIdCarrier = 0;
            int columnStatusOrder = 0;
            int columnStatusDelivery = 0;
            int columnStatusProcess = 0;

            tableLayoutPanelAddedGoods.Controls.Clear();

            for (int i = 0; i < dataDB.columnCount; i++)
            {
                if (dataDB.columnName[i] == databaseInteraction.idOrder.Substring(1, databaseInteraction.idOrder.Length - 2))
                {
                    columnId = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.dateStartOrder.Substring(1, databaseInteraction.dateStartOrder.Length - 2))
                {
                    columnStartDate = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.dateEndOrder.Substring(1, databaseInteraction.dateEndOrder.Length - 2))
                {
                    columnEndDate = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.idManagerOrder.Substring(1, databaseInteraction.idManagerOrder.Length - 2))
                {
                    columnIdManager = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.idSupplierOrder.Substring(1, databaseInteraction.idSupplierOrder.Length - 2))
                {
                    columnIdSupplier = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.idLogisticianOrder.Substring(1, databaseInteraction.idLogisticianOrder.Length - 2))
                {
                    columnIdLogistician = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.idCarrierOrder.Substring(1, databaseInteraction.idCarrierOrder.Length - 2))
                {
                    columnIdCarrier = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.statusOrder.Substring(1, databaseInteraction.statusOrder.Length - 2))
                {
                    columnStatusOrder = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.statusDelivery.Substring(1, databaseInteraction.statusDelivery.Length - 2))
                {
                    columnStatusDelivery = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.statusProcessOrder.Substring(1, databaseInteraction.statusProcessOrder.Length - 2))
                {
                    columnStatusProcess = i;
                }
            }

            dataOrder.id = dataDB.receivedData[columnId];
            dataOrder.dateStart = dataDB.receivedData[columnStartDate];
            dataOrder.dateEnd = dataDB.receivedData[columnEndDate];
            dataOrder.idManager = dataDB.receivedData[columnIdManager];
            dataOrder.idSupplier = dataDB.receivedData[columnIdSupplier];
            dataOrder.idLogistician = dataDB.receivedData[columnIdLogistician];
            dataOrder.idCarrier = dataDB.receivedData[columnIdCarrier];
            dataOrder.statusOrder = dataDB.receivedData[columnStatusOrder];
            dataOrder.statusDelivered = dataDB.receivedData[columnStatusDelivery];
            dataOrder.statusProcessOrder = dataDB.receivedData[columnStatusProcess];

            labelOrderStartValue.Text = dataOrder.dateStart;
            labelOrderEndValue.Text = dataOrder.dateEnd;

            if(dataOrder.idManager != "" & dataOrder.idManager != null)
            {
                dataDB = databaseInteraction.RequestDetailsUser(dataOrder.idManager);
                int columnName = 0;
                int columnnumberPhone = 0;
                int columnEmail = 0;

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    if (dataDB.columnName[i] == "name")
                    {
                        columnName = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.phonenumberUser.Substring(1, databaseInteraction.phonenumberUser.Length - 2))
                    {
                        columnnumberPhone = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.emailUser.Substring(1, databaseInteraction.emailUser.Length - 2))
                    {
                        columnEmail = i;
                    }
                }

                labelValueManager.Text = dataDB.receivedData[columnName] + " " + dataDB.receivedData[columnnumberPhone] + " " + dataDB.receivedData[columnEmail];                
            }

            for (int i = 0; i < dataDB.receivedData.Length; i++)
            {
                if (dataDB.receivedData[i] == null)
                {
                    break;
                }

                dataDB.receivedData[i] = null;
            }

            if (dataOrder.idLogistician != "" & dataOrder.idLogistician != null)
            {
                dataDB = databaseInteraction.RequestDetailsUser(dataOrder.idLogistician);
                int columnName = 0;
                int columnnumberPhone = 0;
                int columnEmail = 0;

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    if (dataDB.columnName[i] == "name")
                    {
                        columnName = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.phonenumberUser.Substring(1, databaseInteraction.phonenumberUser.Length - 2))
                    {
                        columnnumberPhone = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.emailUser.Substring(1, databaseInteraction.emailUser.Length - 2))
                    {
                        columnEmail = i;
                    }
                }

                labelValueLogistican.Text = dataDB.receivedData[columnName] + " " + dataDB.receivedData[columnnumberPhone] + " " + dataDB.receivedData[columnEmail];
            }            

            ChoiceOfSupplierWindow choiceOfSupplierWindow = new ChoiceOfSupplierWindow();
            choiceOfSupplierWindow.FillingSupplierData(dataOrder.idSupplier, this.listBoxDetailsSupplier);

            ChoiceOfCarrierWindow choiceOfCarrierWindow = new ChoiceOfCarrierWindow();
            choiceOfCarrierWindow.FillingCarrierData(dataOrder.idCarrier, this.listBoxDetailsCarrier);

            dataDB = databaseInteraction.RequestAllGoodsInOrdrer(dataOrder.id);
            int columnIdProdOrder = 0;
            int columnNameProdOrder = 0;
            int columnOccupiedVolume = 0;
            int columnIdShopOrder = 0;
            int columnNameShopOrder = 0;
            int columnAdressShopOrder = 0;
            int columnAmountProd = 0;
            int columnAmountDeliveredProd = 0;
            int columnStatusDeliveryProd = 0;

            for (int i = 0; i < dataDB.columnCount; i++)
            {
                if (dataDB.columnName[i] == databaseInteraction.idProdProdOrderFK.Substring(1, databaseInteraction.idProdProdOrderFK.Length - 2))
                {
                    columnIdProdOrder = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.idShopProdOrderFK.Substring(1, databaseInteraction.idShopProdOrderFK.Length - 2))
                {
                    columnIdShopOrder = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.amountProdProdOrder.Substring(1, databaseInteraction.amountProdProdOrder.Length - 2))
                {
                    columnAmountProd = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.amounDeliveredProdProdOrder.Substring(1, databaseInteraction.amounDeliveredProdProdOrder.Length - 2))
                {
                    columnAmountDeliveredProd = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.statusDeliveryProdOrder.Substring(1, databaseInteraction.statusDeliveryProdOrder.Length - 2))
                {
                    columnStatusDeliveryProd = i;
                }

                if (dataDB.columnName[i] == "nameprod")
                {
                    columnNameProdOrder = i;
                }

                if (dataDB.columnName[i] == "occupiedvolume")
                {
                    columnOccupiedVolume = i;
                }

                if (dataDB.columnName[i] == "nameshop")
                {
                    columnNameShopOrder = i;
                }

                if (dataDB.columnName[i] == "adressshop")
                {
                    columnAdressShopOrder = i;
                }
            }


            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                goodsInOrder[i] = new string[9];
                goodsInOrder[i][0] = dataDB.receivedData[i == 0 ? columnIdProdOrder : columnIdProdOrder = columnIdProdOrder + dataDB.columnCount];
                goodsInOrder[i][1] = dataDB.receivedData[i == 0 ? columnNameProdOrder : columnNameProdOrder = columnNameProdOrder + dataDB.columnCount];
                goodsInOrder[i][2] = dataDB.receivedData[i == 0 ? columnOccupiedVolume : columnOccupiedVolume = columnOccupiedVolume + dataDB.columnCount];
                goodsInOrder[i][3] = dataDB.receivedData[i == 0 ? columnIdShopOrder : columnIdShopOrder = columnIdShopOrder + dataDB.columnCount];
                goodsInOrder[i][4] = dataDB.receivedData[i == 0 ? columnNameShopOrder : columnNameShopOrder = columnNameShopOrder + dataDB.columnCount];
                goodsInOrder[i][5] = dataDB.receivedData[i == 0 ? columnAdressShopOrder : columnAdressShopOrder = columnAdressShopOrder + dataDB.columnCount];
                Regex regex = new Regex(@",");
                string newsting = regex.Replace(dataDB.receivedData[i == 0 ? columnAmountProd : columnAmountProd = columnAmountProd + dataDB.columnCount], ".");
                goodsInOrder[i][6] = newsting;
                goodsInOrder[i][7] = dataDB.receivedData[i == 0 ? columnAmountDeliveredProd : columnAmountDeliveredProd = columnAmountDeliveredProd + dataDB.columnCount];
                goodsInOrder[i][8] = dataDB.receivedData[i == 0 ? columnStatusDeliveryProd : columnStatusDeliveryProd = columnStatusDeliveryProd + dataDB.columnCount];

                CheckBox checkBox = new CheckBox();
                checkBox.Name = goodsInOrder[i][0];
                if(goodsInOrder[i][8] == databaseInteraction.TEXTSTATUSPRODUCTEND)
                {
                    checkBox.Enabled = false;
                }
                checkBox.Dock = DockStyle.Top;

                TextBox textBoxProductName = new TextBox();
                textBoxProductName.Text = goodsInOrder[i][1];
                textBoxProductName.Dock = DockStyle.Fill;

                TextBox textBoxOccupiedVolume = new TextBox();
                textBoxOccupiedVolume.Text = goodsInOrder[i][2];
                textBoxOccupiedVolume.Dock = DockStyle.Fill;

                TextBox textBoxShopName = new TextBox();
                textBoxShopName.Name = goodsInOrder[i][3];
                textBoxShopName.Text = goodsInOrder[i][4];
                textBoxShopName.Dock = DockStyle.Fill;

                TextBox textBoxShopAdress = new TextBox();
                textBoxShopAdress.Text = goodsInOrder[i][5];
                textBoxShopAdress.Dock = DockStyle.Fill;

                TextBox textBoxOrderedQuantity = new TextBox();
                textBoxOrderedQuantity.Text = dataDB.receivedData[columnAmountProd];
                textBoxOrderedQuantity.MaxLength = 6;
                textBoxOrderedQuantity.Dock = DockStyle.Fill;

                TextBox textBoxQuantityDelivered = new TextBox();
                textBoxQuantityDelivered.Text = goodsInOrder[i][7];
                textBoxQuantityDelivered.MaxLength = 6;
                textBoxQuantityDelivered.Dock = DockStyle.Fill;

                TextBox textBoxStatus = new TextBox();
                textBoxStatus.Text = goodsInOrder[i][8];
                textBoxStatus.Dock = DockStyle.Fill;

                tableLayoutPanelAddedGoods.Controls.Add(checkBox);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxProductName);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxOccupiedVolume);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxShopName);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxShopAdress);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxOrderedQuantity);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxQuantityDelivered);
                tableLayoutPanelAddedGoods.Controls.Add(textBoxStatus);
            }

            if (dataOrder.statusProcessOrder == databaseInteraction.TEXTSTATUSPROCESSSTART || dataOrder.statusProcessOrder == databaseInteraction.TEXTSTATUSCONFIRMCREATE)
            {
                if (userApp.employeesPosition == databaseInteraction.EMPPOSMANAGER || userApp.employeesPosition == databaseInteraction.EMPPOSADMIN)
                {
                    if (dataOrder.statusOrder != databaseInteraction.TEXTSTATUSCONFIRM)
                    {
                        if (goodsInOrder[0] == null)
                        {
                            buttonValueSupplier.Enabled = true;
                        }

                        if(dataOrder.idSupplier != "")
                        {
                            buttonAddItem.Enabled = true;
                            saveStateButtaAddItem = true;
                        }

                        buttonRemItem.Enabled = true;
                        saveStateButtaRemItem = true;

                        if(dataOrder.idSupplier != "" & dataOrder.idSupplier != null)
                        {
                            buttonConfirmSupplier.Enabled = true;
                        }                        
                    }

                    int googdsDelivered = 1;
                    for (int i = 0; i < goodsInOrder.Length; i++)
                    {
                        if (goodsInOrder[i] != null)
                        {
                            if (goodsInOrder[i][8] != databaseInteraction.TEXTSTATUSPRODUCTEND)
                            {
                                googdsDelivered = 0;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (googdsDelivered == 1)
                    {
                        buttonOrderComlection.Enabled = true;
                    }
                }

                if (userApp.employeesPosition == databaseInteraction.EMPPOSLOGISTITCIAN || userApp.employeesPosition == databaseInteraction.EMPPOSADMIN)
                {
                    if (dataOrder.statusDelivered != databaseInteraction.TEXTSTATUSCONFIRM)
                    {
                        buttonValueCarrier.Enabled = true;

                        if(dataOrder.idCarrier != "" & dataOrder.idCarrier != null)
                        {
                            buttonConfirmCarrier.Enabled = true;
                        }                        
                    }
                    else
                    {
                        int countRows = tableLayoutPanelAddedGoods.Controls.Count / 8;
                        int positionCheckBox = 0;

                        if (tableLayoutPanelAddedGoods.Controls.Count >= 8)
                        {
                            for (int i = 0; i < countRows; i++)
                            {
                                Control checkBox = tableLayoutPanelAddedGoods.Controls[positionCheckBox];
                                CheckBox checkBoxDetails = (CheckBox)checkBox;

                                if (tableLayoutPanelAddedGoods.Controls[positionCheckBox + 7].Text == databaseInteraction.TEXTSTATUSPRODUCTSTART)
                                {
                                    buttonDelireved.Enabled = true;
                                    break;
                                }

                                positionCheckBox = positionCheckBox + 8;
                            }
                        }
                    }
                }
            }
        }

        public void ButtonActivationAddItem()
        {
            buttonAddItem.Enabled = true;
            saveStateButtaAddItem = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int noProblems = 1;

            if(dataOrder.idSupplier != "" & dataOrder.idSupplier != null)
            {
                dataDB = databaseInteraction.ValueChangeIdSupplier(dataOrder.idSupplier, dataOrder.id);
                if (dataDB.entryCheck != 1)
                {
                    noProblems = 0;
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            if(dataOrder.idLogistician != "" & dataOrder.idLogistician != null)
            {
                dataDB = databaseInteraction.ValueChangeIdLogistician(dataOrder.idLogistician, dataOrder.id);
                if (dataDB.entryCheck != 1)
                {
                    noProblems = 0;
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            if(dataOrder.idCarrier != "" & dataOrder.idCarrier != null)
            {
                dataDB = databaseInteraction.ValueChangeIdCarrier(dataOrder.idCarrier, dataOrder.id);
                if (dataDB.entryCheck != 1)
                {
                    noProblems = 0;
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            int saveCount = 0;
            for(int i = 0; i < goodsInOrderAdder.Length; i++)
            {
                if(goodsInOrderAdder[i] == null)
                {
                    break;
                }

                saveCount++;
            }

            if(saveCount > 0)
            {
                buttonRemItem.Enabled = saveStateButtaRemItem;

                for(int i = 0; i < saveCount; i++)
                {
                    dataDB = databaseInteraction.NewProdInOrder(goodsInOrderAdder[i][0],goodsInOrderAdder[i][1],goodsInOrderAdder[i][2],goodsInOrderAdder[i][3],goodsInOrderAdder[i][4]);
                }
            }

            int removeCount = 0;
            for (int i = 0; i < goodsInOrderDeliting.Length; i++)
            {
                if (goodsInOrderDeliting[i] == null)
                {
                    break;
                }

                removeCount++;
            }

            if (removeCount > 0)
            {
                buttonAddItem.Enabled = saveStateButtaAddItem;

                for (int i = 0; i < removeCount; i++)
                {
                    dataDB = databaseInteraction.RemoveProdInOrder(goodsInOrderDeliting[i][0],goodsInOrderDeliting[i][1],goodsInOrderDeliting[i][2],goodsInOrderDeliting[i][3]);
                }
            }

            if (noProblems == 1)
            {
                MessageBox.Show("Данные сохранены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                orderWindow.OrderListUpdate();
            }
        }

        private void buttonConfirmSupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердить поставщика?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataDB = databaseInteraction.ValueChangeConfirmStatusOrder(dataOrder.id);
                if (dataDB.entryCheck != 1)
                {
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    buttonValueSupplier.Enabled = false;
                    buttonConfirmSupplier.Enabled = false;
                    buttonAddItem.Enabled = false;
                    buttonRemItem.Enabled = false;
                }
            }                                   
        }

        private void buttonConfirmCarrier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердить перевозчика?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                dataDB = databaseInteraction.ValueChangeConfirmStatusDelivery(dataOrder.id);
                if (dataDB.entryCheck != 1)
                {
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataOrder.idLogistician = userApp.id;
                    buttonValueCarrier.Enabled = false;
                    buttonConfirmCarrier.Enabled = false;
                    buttonDelireved.Enabled = true;
                }
            }                        
        }

        private void buttonOrderComlection_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Завершить заказ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataDB = databaseInteraction.ValueChangeSatusProcess(dataOrder.id);
                if (dataDB.entryCheck != 1)
                {
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                
                this.Close();

                orderWindow.OrderListUpdate();
            }
        }

        private void buttonDelireved_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердить доставку выбранных товаров?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int countRows = tableLayoutPanelAddedGoods.Controls.Count / 8;
                int positionCheckBox = 0;

                if (tableLayoutPanelAddedGoods.Controls.Count >= 8)
                {
                    for (int i = 0; i < countRows; i++)
                    {
                        Control checkBox = tableLayoutPanelAddedGoods.Controls[positionCheckBox];
                        CheckBox checkBoxDetails = (CheckBox)checkBox;

                        if (checkBoxDetails.Checked == true)
                        {
                            if(tableLayoutPanelAddedGoods.Controls[positionCheckBox + 6].Text != "")
                            {
                                try
                                {
                                    double value = double.Parse(tableLayoutPanelAddedGoods.Controls[positionCheckBox + 6].Text);

                                    Regex regex = new Regex(@",");
                                    string newstring = regex.Replace(tableLayoutPanelAddedGoods.Controls[positionCheckBox + 6].Text, ".");

                                    dataDB = databaseInteraction.ValueChangeSatusDelivered(dataOrder.id, goodsInOrder[i][0], goodsInOrder[i][3], goodsInOrder[i][6], newstring, userApp.id);
                                    if (dataDB.entryCheck != 1)
                                    {
                                        MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        tableLayoutPanelAddedGoods.Controls[positionCheckBox].Enabled = false;
                                        tableLayoutPanelAddedGoods.Controls[positionCheckBox + 7].Text = databaseInteraction.TEXTSTATUSPRODUCTEND;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Введите число с запятой!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }                               
                            }
                            else
                            {
                                MessageBox.Show($"Введите количество для товара - {goodsInOrder[i][1]}!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }

                        positionCheckBox = positionCheckBox + 8;
                    }
                }
            }
        }

        private void buttonSaveDataInFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вывести данные в файл?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OrderFile orderFile = new OrderFile(this.dataOrder, this.goodsInOrder);

                if(orderFile.WritingToFile() != -1)
                {
                    MessageBox.Show("Данные успешно сохранены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произоша ошибка при сохранении данных на диск!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
