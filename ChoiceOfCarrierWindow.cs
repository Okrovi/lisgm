namespace LISGM
{
    public partial class ChoiceOfCarrierWindow : Form
    {
        OrderEditingWindow orderEditingWindow;
        DataDB dataDB = new DataDB();
        DatabaseInteraction databaseInteraction = new DatabaseInteraction();
        
        public ChoiceOfCarrierWindow()
        {
            InitializeComponent();
        }

        public ChoiceOfCarrierWindow(OrderEditingWindow orderEditingWindow)
        {
            this.orderEditingWindow = orderEditingWindow;
            InitializeComponent();
        }

        private void ChoiceOfCarrierWindow_Load(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestTypeCounterparty();

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxTypeCarrier.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void comboBoxTypeCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDB = databaseInteraction.RequestLocationCarrier(comboBoxTypeCarrier.SelectedItem.ToString());

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                comboBoxTerritory.Items.Add(dataDB.receivedData[i]);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if(comboBoxTypeCarrier.SelectedItem != null & comboBoxTerritory.SelectedItem != null)
            {
                dataDB = databaseInteraction.RequestCarrier(comboBoxTypeCarrier.SelectedItem.ToString(), comboBoxTerritory.SelectedItem.ToString());
                int columnId = 0;
                int columnMinVol = 0;
                int columnMaxVol = 0;
                int columnName = 0;
                int columnLocation = 0;
                int columnStreet = 0;
                int columnBuilding = 0;
                int columnHouse = 0;
                int columnOffice = 0;
                string minmaxvolume;
                string adressCarrier;

                tableLayoutPanelCarrier.Controls.Clear();

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    if (dataDB.columnName[i] == databaseInteraction.idCounterparty.Substring(1, databaseInteraction.idCounterparty.Length - 2))
                    {
                        columnId = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.minVolumeCarrier.Substring(1, databaseInteraction.minVolumeCarrier.Length - 2))
                    {
                        columnMinVol = i;
                    }

                    if (dataDB.columnName[i] == databaseInteraction.maxVolumeCarrier.Substring(1, databaseInteraction.maxVolumeCarrier.Length - 2))
                    {
                        columnMaxVol = i;
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
                    Button buttonChoiseCarrier = new Button();
                    buttonChoiseCarrier.Name = dataDB.receivedData[i == 0 ? columnId : columnId = columnId + dataDB.columnCount];
                    buttonChoiseCarrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
                    buttonChoiseCarrier.ForeColor = System.Drawing.Color.White;
                    buttonChoiseCarrier.Click += buttonChoiceCarrier_Click;

                    minmaxvolume = "";
                    minmaxvolume = minmaxvolume + dataDB.receivedData[i == 0 ? columnMinVol : columnMinVol = columnMinVol + dataDB.columnCount] + " // ";
                    minmaxvolume = minmaxvolume + dataDB.receivedData[i == 0 ? columnMaxVol : columnMaxVol = columnMaxVol + dataDB.columnCount];
                    TextBox textBoxMinMaxVolume = new TextBox();
                    textBoxMinMaxVolume.Text = minmaxvolume;
                    textBoxMinMaxVolume.Dock = DockStyle.Fill;

                    TextBox textBoxNameProvider = new TextBox();
                    textBoxNameProvider.Text = dataDB.receivedData[i == 0 ? columnName : columnName = columnName + dataDB.columnCount];
                    textBoxNameProvider.Dock = DockStyle.Fill;

                    adressCarrier = "";
                    adressCarrier = adressCarrier + dataDB.receivedData[i == 0 ? columnLocation : columnLocation = columnLocation + dataDB.columnCount] + " ";
                    adressCarrier = adressCarrier + dataDB.receivedData[i == 0 ? columnStreet : columnStreet = columnStreet + dataDB.columnCount] + " ";
                    adressCarrier = adressCarrier + dataDB.receivedData[i == 0 ? columnBuilding : columnBuilding = columnBuilding + dataDB.columnCount] + " ";
                    adressCarrier = adressCarrier + dataDB.receivedData[i == 0 ? columnHouse : columnHouse = columnHouse + dataDB.columnCount] + " ";
                    adressCarrier = adressCarrier + dataDB.receivedData[i == 0 ? columnOffice : columnOffice = columnOffice + dataDB.columnCount] + " ";
                    TextBox textBoxAdressCarrier = new TextBox();
                    textBoxAdressCarrier.Text = adressCarrier;
                    textBoxAdressCarrier.Dock = DockStyle.Fill;

                    tableLayoutPanelCarrier.Controls.Add(buttonChoiseCarrier);
                    tableLayoutPanelCarrier.Controls.Add(textBoxMinMaxVolume);
                    tableLayoutPanelCarrier.Controls.Add(textBoxNameProvider);
                    tableLayoutPanelCarrier.Controls.Add(textBoxAdressCarrier);
                }
            }
            else
            {
                MessageBox.Show("Выберете данные для поиска перевозчика!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChoiceCarrier_Click(object sender, EventArgs e)
        {
            Control button = (Control)sender;

            orderEditingWindow.dataOrder.idCarrier = button.Name;

            orderEditingWindow.dataOrder.idLogistician = orderEditingWindow.userApp.id;

            ListBox listBoxCarrierDelails = orderEditingWindow.carrierDetails();

            FillingCarrierData(button.Name, listBoxCarrierDelails);

            this.Close();
        }
        
        public void FillingCarrierData(string idCarrier, ListBox listBoxCarrierDelails)
        {
            if(idCarrier != "" & idCarrier != null)
            {
                listBoxCarrierDelails.Items.Clear();

                dataDB = databaseInteraction.RequestDataCounterparty(idCarrier);

                for (int i = 0; i < dataDB.columnCount; i++)
                {
                    listBoxCarrierDelails.Items.Add(dataDB.receivedData[i]);
                }
            }            
        }

        private void buttonTransportBySupplier_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Перевозка осуществляется поставщиком?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if(orderEditingWindow.dataOrder.idSupplier != "")
                {
                    orderEditingWindow.dataOrder.idCarrier = orderEditingWindow.dataOrder.idSupplier;

                    orderEditingWindow.dataOrder.idLogistician = orderEditingWindow.userApp.id;

                    ListBox listBoxCarrierDelails = orderEditingWindow.carrierDetails();

                    FillingCarrierData(orderEditingWindow.dataOrder.idSupplier, listBoxCarrierDelails);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Поставщик не выбран!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
    }
}
