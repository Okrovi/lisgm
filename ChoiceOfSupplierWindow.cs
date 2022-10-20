namespace LISGM
{
    public partial class ChoiceOfSupplierWindow : Form
    {
        DatabaseInteraction databaseInteraction = new DatabaseInteraction();
        DataDB dataDB = new DataDB();

        private OrderEditingWindow orderEditingWindow;

        public ChoiceOfSupplierWindow()
        {
            InitializeComponent();
        }

        public ChoiceOfSupplierWindow(OrderEditingWindow orderEditingWindow)
        {
            this.orderEditingWindow = orderEditingWindow;
            InitializeComponent();
        }

        private void ChoiceOfSupplierWindow_Load(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestCategoryProd();

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxCategory.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestGoodsFromAllSuppliers(comboBoxCategory.SelectedItem.ToString());

            comboBoxItem.Items.Clear();

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxItem.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if(comboBoxCategory.SelectedItem != null)
            {
                dataDB = databaseInteraction.RequestSupplier(comboBoxItem.SelectedItem.ToString());
                int columnId = 0;
                int columnPrice = 0;
                int columnName = 0;
                int columnLocation = 0;
                int columnStreet = 0;
                int columnBuilding = 0;
                int columnHouse = 0;
                int columnOffice = 0;
                string adressSupplier;

                flowLayoutPanelListSupplier.Controls.Clear();

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    if (dataDB.columnName[i] == databaseInteraction.idCounterparty.Substring(1, databaseInteraction.idCounterparty.Length - 2))
                    {
                        columnId = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.priceProd.Substring(1, databaseInteraction.priceProd.Length - 2))
                    {
                        columnPrice = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.nameCounterparty.Substring(1, databaseInteraction.nameCounterparty.Length - 2))
                    {
                        columnName = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.locationCounterparty.Substring(1, databaseInteraction.locationCounterparty.Length - 2))
                    {
                        columnLocation = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.streetCounterparty.Substring(1, databaseInteraction.streetCounterparty.Length - 2))
                    {
                        columnStreet = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.buildingCounterparty.Substring(1, databaseInteraction.buildingCounterparty.Length - 2))
                    {
                        columnBuilding = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.houseCounterparty.Substring(1, databaseInteraction.houseCounterparty.Length - 2))
                    {
                        columnHouse = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.officeCounterparty.Substring(1, databaseInteraction.officeCounterparty.Length - 2))
                    {
                        columnOffice = i;
                    }
                }

                for (int i = 0; i < dataDB.rowsCount; i++)
                {
                    Button buttonChoiceSupplier = new Button();
                    buttonChoiceSupplier.Name = dataDB.receivedData[i == 0 ? columnId : columnId = columnId + dataDB.columnCount];
                    buttonChoiceSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
                    buttonChoiceSupplier.ForeColor = System.Drawing.Color.White;
                    buttonChoiceSupplier.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    buttonChoiceSupplier.Location = new System.Drawing.Point(3, 3);
                    buttonChoiceSupplier.Size = new System.Drawing.Size(80, 23);
                    buttonChoiceSupplier.Text = "Выбор";
                    buttonChoiceSupplier.UseVisualStyleBackColor = false;
                    buttonChoiceSupplier.Click += buttonChoiceSupplier_Click;

                    TextBox textBoxPrice = new TextBox();
                    textBoxPrice.Text = dataDB.receivedData[i == 0 ? columnPrice : columnPrice = columnPrice + dataDB.columnCount];
                    textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    textBoxPrice.Location = new System.Drawing.Point(89, 5);
                    textBoxPrice.Name = "textBoxPrice";
                    textBoxPrice.Size = new System.Drawing.Size(80, 22);

                    TextBox textBoxNameSupplier = new TextBox();
                    textBoxNameSupplier.Text = dataDB.receivedData[i == 0 ? columnName : columnName = columnName + dataDB.columnCount];
                    textBoxNameSupplier.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    textBoxNameSupplier.Location = new System.Drawing.Point(175, 5);
                    textBoxNameSupplier.Name = "textBoxName";
                    textBoxNameSupplier.Size = new System.Drawing.Size(200, 22);

                    adressSupplier = "";
                    adressSupplier = adressSupplier + dataDB.receivedData[i == 0 ? columnLocation : columnLocation = columnLocation + dataDB.columnCount] + " ";
                    adressSupplier = adressSupplier + dataDB.receivedData[i == 0 ? columnStreet : columnStreet = columnStreet + dataDB.columnCount] + " ";
                    adressSupplier = adressSupplier + dataDB.receivedData[i == 0 ? columnBuilding : columnBuilding = columnBuilding + dataDB.columnCount] + " ";
                    adressSupplier = adressSupplier + dataDB.receivedData[i == 0 ? columnHouse : columnHouse = columnHouse + dataDB.columnCount] + " ";
                    adressSupplier = adressSupplier + dataDB.receivedData[i == 0 ? columnOffice : columnOffice = columnOffice + dataDB.columnCount] + " ";
                    TextBox textBoxAdressSupplier = new TextBox();
                    textBoxAdressSupplier.Text = adressSupplier;
                    textBoxAdressSupplier.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    textBoxAdressSupplier.Location = new System.Drawing.Point(381, 5);
                    textBoxAdressSupplier.Name = "textBoxAdress";
                    textBoxAdressSupplier.Size = new System.Drawing.Size(364, 22);

                    Panel panelSelectionInstance = new Panel();
                    panelSelectionInstance.Controls.Add(buttonChoiceSupplier);
                    panelSelectionInstance.Controls.Add(textBoxPrice);
                    panelSelectionInstance.Controls.Add(textBoxNameSupplier);
                    panelSelectionInstance.Controls.Add(textBoxAdressSupplier);
                    panelSelectionInstance.Location = new System.Drawing.Point(3, 3);
                    panelSelectionInstance.Name = "panelSelectionInstance";
                    panelSelectionInstance.Size = new System.Drawing.Size(748, 31);

                    flowLayoutPanelListSupplier.Controls.Add(panelSelectionInstance);
                }
            }
            else
            {
                MessageBox.Show("Выберете данные для поиска поставщика!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChoiceSupplier_Click(object sender, EventArgs e)
        {
            Control button = (Control)sender;

            orderEditingWindow.dataOrder.idSupplier = button.Name;
            orderEditingWindow.ButtonActivationAddItem();

            ListBox listBoxSupplierDelails = orderEditingWindow.supplierDetails();

            FillingSupplierData(button.Name, listBoxSupplierDelails);

            this.Close();
        }

        public void FillingSupplierData(string idSupplier, ListBox listBoxSupplierDelails)
        {
            if(idSupplier != "" & idSupplier != null)
            {
                listBoxSupplierDelails.Items.Clear();

                dataDB = databaseInteraction.RequestDataCounterparty(idSupplier);

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    listBoxSupplierDelails.Items.Add(dataDB.receivedData[i]);
                }
            }            
        }
    }
}
