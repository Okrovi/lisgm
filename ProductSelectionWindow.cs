using System.Text.RegularExpressions;

namespace LISGM
{
    public partial class ProductSelectionWindow : Form
    {
        OrderEditingWindow orderEditingWindow;
        static DatabaseInteraction databaseInteraction = new DatabaseInteraction();
        DataDB dataDB = new DataDB();

        string[][] idAndNameProduct = new string[databaseInteraction.rowsReceived][];

        public ProductSelectionWindow()
        {
            InitializeComponent();
        }

        public ProductSelectionWindow(OrderEditingWindow orderEditingWindow)
        {
            this.orderEditingWindow = orderEditingWindow;
            InitializeComponent();
        }

        private void ProductSelectionWindow_Load(object sender, EventArgs e)
        {    
            dataDB = databaseInteraction.RequestGoodsSupplier(orderEditingWindow.dataOrder.idSupplier);
            int columnIdProd = 0;
            int columnNameProd = 0;
            int columnOccupiedVolume = 0;

            for (int i = 0; i < dataDB.columnCount; i++)
            {
                if (dataDB.columnName[i] == databaseInteraction.idProd.Substring(1, databaseInteraction.idProd.Length - 2))
                {
                    columnIdProd = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.nameGoods.Substring(1, databaseInteraction.nameGoods.Length - 2))
                {
                    columnNameProd = i;
                }

                if (dataDB.columnName[i] == databaseInteraction.occupiedVolueProd.Substring(1, databaseInteraction.occupiedVolueProd.Length - 2))
                {
                    columnOccupiedVolume = i;
                }
            }

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                idAndNameProduct[i] = new string[3];
                idAndNameProduct[i][0] = dataDB.receivedData[i == 0 ? columnIdProd : columnIdProd = columnIdProd + dataDB.columnCount];
                idAndNameProduct[i][1] = dataDB.receivedData[i == 0 ? columnNameProd : columnNameProd = columnNameProd + dataDB.columnCount];
                idAndNameProduct[i][2] = dataDB.receivedData[i == 0 ? columnOccupiedVolume : columnOccupiedVolume = columnOccupiedVolume + dataDB.columnCount];

                comboBoxProduct.Items.Add(idAndNameProduct[i][1]);
            }

            dataDB = databaseInteraction.RequestAllTypesShop();

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxTypeShop.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestUnitProd(comboBoxProduct.SelectedItem.ToString());

            labelUnit.Text = dataDB.receivedData[0];
        }

        private void comboBoxTypeShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestLocationShop(comboBoxTypeShop.SelectedItem.ToString());

            comboBoxLocation.Items.Clear();

            for(int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxLocation.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestStreetShop(comboBoxLocation.SelectedItem.ToString());

            comboBoxStreet.Items.Clear();

            for( int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxStreet.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void buttonShowShop_Click(object sender, EventArgs e)
        {
            if(comboBoxTypeShop.SelectedItem != null & comboBoxLocation.SelectedItem != null & comboBoxStreet.SelectedItem != null)
            {
                dataDB = databaseInteraction.RequestShops(comboBoxTypeShop.SelectedItem.ToString(), comboBoxLocation.SelectedItem.ToString(), comboBoxStreet.SelectedItem.ToString());
                int columnId = 0;
                int columnName = 0;
                int columnLocation = 0;
                int columnStreet = 0;
                int columnBuilding = 0;
                int columnHouse = 0;
                string adressShop;

                flowLayoutPanelListShop.Controls.Clear();

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    if (dataDB.columnName[i] == databaseInteraction.idShop.Substring(1, databaseInteraction.idShop.Length - 2))
                    {
                        columnId = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.nameShop.Substring(1, databaseInteraction.nameShop.Length - 2))
                    {
                        columnName = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.locationShop.Substring(1, databaseInteraction.locationShop.Length - 2))
                    {
                        columnLocation = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.streetShop.Substring(1, databaseInteraction.streetShop.Length - 2))
                    {
                        columnStreet = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.buildingShop.Substring(1, databaseInteraction.buildingShop.Length - 2))
                    {
                        columnBuilding = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.houseShop.Substring(1, databaseInteraction.houseShop.Length - 2))
                    {
                        columnHouse = i;
                    }
                }

                for (int i = 0; i < dataDB.rowsCount; i++)
                {
                    RadioButton rBChoiseShop = new RadioButton();
                    rBChoiseShop.Name = dataDB.receivedData[i == 0 ? columnId : columnId = columnId + dataDB.columnCount];
                    rBChoiseShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
                    rBChoiseShop.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    rBChoiseShop.Location = new System.Drawing.Point(3, 3);
                    rBChoiseShop.Size = new System.Drawing.Size(27, 23);
                    rBChoiseShop.UseVisualStyleBackColor = false;
                    rBChoiseShop.Click += new System.EventHandler(rBChoiseShop_CheckedChanged);

                    TextBox textBoxNameShop = new TextBox();
                    textBoxNameShop.Text = dataDB.receivedData[i == 0 ? columnName : columnName = columnName + dataDB.columnCount];
                    textBoxNameShop.Location = new System.Drawing.Point(36, 3);
                    textBoxNameShop.Name = "nameShop";
                    textBoxNameShop.Size = new System.Drawing.Size(150, 23);

                    adressShop = "";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnLocation : columnLocation = columnLocation + dataDB.columnCount] + " ";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnStreet : columnStreet = columnStreet + dataDB.columnCount] + " ";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnBuilding : columnBuilding = columnBuilding + dataDB.columnCount] + " ";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnHouse : columnHouse = columnHouse + dataDB.columnCount] + " ";
                    TextBox textBoxAdressShop = new TextBox();
                    textBoxAdressShop.Text = adressShop;
                    textBoxAdressShop.Location = new System.Drawing.Point(187, 3);
                    textBoxAdressShop.Name = "adressShop";
                    textBoxAdressShop.Size = new System.Drawing.Size(277, 23);

                    Panel panelSelectionInstance = new Panel();
                    panelSelectionInstance.Controls.Add(rBChoiseShop);
                    panelSelectionInstance.Controls.Add(textBoxNameShop);
                    panelSelectionInstance.Controls.Add(textBoxAdressShop);
                    panelSelectionInstance.Name = "selectionInstance" + i.ToString();
                    panelSelectionInstance.Size = new System.Drawing.Size(467, 29);

                    flowLayoutPanelListShop.Controls.Add(panelSelectionInstance);
                }
            }
            else
            {
                MessageBox.Show("Выберете данные для поиска торговой точки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int countRows = flowLayoutPanelListShop.Controls.Count;
            int checkItemAdded = 0;

            if (textBoxAmount.Text != "" & comboBoxProduct.SelectedItem != null)
            {
                if(countRows > 0)
                {
                    FlowLayoutPanel flowLayoutPanelListProd = orderEditingWindow.tableProducts();

                    for (int i = 0; i < countRows; i++)
                    {
                        if(checkItemAdded == 1)
                        {
                            break;
                        }

                        Panel currentSelectionInstance = (Panel)flowLayoutPanelListShop.Controls[i];
                        Control radioButton = currentSelectionInstance.Controls[0];
                        Control textShopName = currentSelectionInstance.Controls[1];
                        Control textAdressShop = currentSelectionInstance.Controls[2];
                        RadioButton radioButtonDetails = (RadioButton)radioButton;

                        if (radioButtonDetails.Checked == true)
                        {
                            for (int j = 0; j < orderEditingWindow.goodsInOrderAdder.Length; j++)
                            {
                                if (orderEditingWindow.goodsInOrderAdder[j] == null)
                                {
                                    int positionInArray = 0;

                                    for (int k = 0; k < databaseInteraction.rowsReceived; k++)
                                    {
                                        if (comboBoxProduct.SelectedItem.ToString() == idAndNameProduct[k][1])
                                        {
                                            positionInArray = k;
                                            break;
                                        }
                                    }

                                    try
                                    {
                                        double value = double.Parse(textBoxAmount.Text);

                                        Regex regex = new Regex(@",");
                                        string newstring = regex.Replace(textBoxAmount.Text, ".");

                                        orderEditingWindow.goodsInOrderAdder[j] = new string[6];
                                        orderEditingWindow.goodsInOrderAdder[j][0] = orderEditingWindow.dataOrder.id;
                                        orderEditingWindow.goodsInOrderAdder[j][1] = idAndNameProduct[positionInArray][0];
                                        orderEditingWindow.goodsInOrderAdder[j][2] = radioButton.Name;
                                        orderEditingWindow.goodsInOrderAdder[j][3] = newstring;
                                        orderEditingWindow.goodsInOrderAdder[j][4] = databaseInteraction.TEXTSTATUSPRODUCTSTART;

                                        CheckBox checkBox = new CheckBox();
                                        checkBox.Name = radioButton.Name;
                                        checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
                                        checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                                        checkBox.Location = new System.Drawing.Point(3, 3);
                                        checkBox.Size = new System.Drawing.Size(15, 14);
                                        checkBox.UseVisualStyleBackColor = false;

                                        TextBox textBoxProductName = new TextBox();
                                        textBoxProductName.Text = comboBoxProduct.SelectedItem.ToString();
                                        textBoxProductName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxProductName.Location = new System.Drawing.Point(20, 3);
                                        textBoxProductName.Name = "textBoxNameProd";
                                        textBoxProductName.Size = new System.Drawing.Size(120, 22);

                                        TextBox textBoxOccupiedVolume = new TextBox();
                                        textBoxOccupiedVolume.Text = idAndNameProduct[positionInArray][2];
                                        textBoxOccupiedVolume.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxOccupiedVolume.Location = new System.Drawing.Point(141, 3);
                                        textBoxOccupiedVolume.Name = "textBoxVolumeProd";
                                        textBoxOccupiedVolume.Size = new System.Drawing.Size(60, 22);

                                        TextBox textBoxShopName = new TextBox();
                                        textBoxShopName.Name = radioButton.Name;
                                        textBoxShopName.Text = textShopName.Text;
                                        textBoxShopName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxShopName.Location = new System.Drawing.Point(202, 3);
                                        textBoxShopName.Size = new System.Drawing.Size(120, 22);

                                        TextBox textBoxShopAdress = new TextBox();
                                        textBoxShopAdress.Text = textAdressShop.Text;
                                        textBoxShopAdress.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxShopAdress.Location = new System.Drawing.Point(323, 3);
                                        textBoxShopAdress.Name = "textBoxAdress";
                                        textBoxShopAdress.Size = new System.Drawing.Size(180, 22);

                                        TextBox textBoxOrderedQuantity = new TextBox();
                                        textBoxOrderedQuantity.Text = textBoxAmount.Text;
                                        textBoxOrderedQuantity.MaxLength = 6;
                                        textBoxOrderedQuantity.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxOrderedQuantity.Location = new System.Drawing.Point(504, 3);
                                        textBoxOrderedQuantity.Name = "textBoxOrderedAmount";
                                        textBoxOrderedQuantity.Size = new System.Drawing.Size(60, 22);

                                        TextBox textBoxQuantityDelivered = new TextBox();
                                        textBoxQuantityDelivered.Text = "";
                                        textBoxQuantityDelivered.MaxLength = 6;
                                        textBoxQuantityDelivered.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxQuantityDelivered.Location = new System.Drawing.Point(565, 3);
                                        textBoxQuantityDelivered.Name = "textBoxDeliveredAmount";
                                        textBoxQuantityDelivered.Size = new System.Drawing.Size(60, 22);

                                        TextBox textBoxStatus = new TextBox();
                                        textBoxStatus.Text = "ВРАБОТЕ";
                                        textBoxStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                                        textBoxStatus.Location = new System.Drawing.Point(627, 3);
                                        textBoxStatus.Name = "textBoxStatusOrder";
                                        textBoxStatus.Size = new System.Drawing.Size(100, 22);

                                        Panel panelSelectionInstance = new Panel();
                                        panelSelectionInstance.Controls.Add(checkBox);
                                        panelSelectionInstance.Controls.Add(textBoxProductName);
                                        panelSelectionInstance.Controls.Add(textBoxOccupiedVolume);
                                        panelSelectionInstance.Controls.Add(textBoxShopName);
                                        panelSelectionInstance.Controls.Add(textBoxShopAdress);
                                        panelSelectionInstance.Controls.Add(textBoxOrderedQuantity);
                                        panelSelectionInstance.Controls.Add(textBoxQuantityDelivered);
                                        panelSelectionInstance.Controls.Add(textBoxStatus);
                                        panelSelectionInstance.Location = new System.Drawing.Point(3, 3);
                                        panelSelectionInstance.Name = "panelSelectionInstance";
                                        panelSelectionInstance.Size = new System.Drawing.Size(730, 29);

                                        flowLayoutPanelListProd.Controls.Add(panelSelectionInstance);

                                        this.Close();

                                        checkItemAdded = 1;
                                        break;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Введите число с запятой!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                }

                                if (j == databaseInteraction.rowsReceived - 1)
                                {
                                    MessageBox.Show("Превышено количество товаров в заказе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                        }

                        if (i == countRows - 1 & checkItemAdded == 0)
                        {
                            MessageBox.Show("Выберете торговую точку!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете торговую точку!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                  
            }
            else
            {
                MessageBox.Show("Выберете товар и введите количество!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void rBChoiseShop_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < flowLayoutPanelListShop.Controls.Count;i++)
            {
                Panel currentSelectionInstance = (Panel)flowLayoutPanelListShop.Controls[i];
                Control radioButton = currentSelectionInstance.Controls[0];
                RadioButton radioButtonDetails = (RadioButton)radioButton;

                radioButtonDetails.Checked = false;
            }

            RadioButton radioButtonChosen = (RadioButton)sender;
            radioButtonChosen.Checked = true;
        }
    }
}
