using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                tableLayoutPanelShop.Controls.Clear();

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
                    RadioButton radioButton = new RadioButton();
                    radioButton.Name = dataDB.receivedData[i == 0 ? columnId : columnId = columnId + dataDB.columnCount];
                    radioButton.Dock = DockStyle.Top;

                    TextBox textBoxNameShop = new TextBox();
                    textBoxNameShop.Text = dataDB.receivedData[i == 0 ? columnName : columnName = columnName + dataDB.columnCount];
                    textBoxNameShop.Dock = DockStyle.Fill;

                    adressShop = "";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnLocation : columnLocation = columnLocation + dataDB.columnCount] + " ";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnStreet : columnStreet = columnStreet + dataDB.columnCount] + " ";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnBuilding : columnBuilding = columnBuilding + dataDB.columnCount] + " ";
                    adressShop = adressShop + dataDB.receivedData[i == 0 ? columnHouse : columnHouse = columnHouse + dataDB.columnCount] + " ";
                    TextBox textBoxAdressShop = new TextBox();
                    textBoxAdressShop.Text = adressShop;
                    textBoxAdressShop.Dock = DockStyle.Fill;

                    tableLayoutPanelShop.Controls.Add(radioButton);
                    tableLayoutPanelShop.Controls.Add(textBoxNameShop);
                    tableLayoutPanelShop.Controls.Add(textBoxAdressShop);
                }
            }
            else
            {
                MessageBox.Show("Выберете данные для поиска торговой точки!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int countRows = tableLayoutPanelShop.RowCount;
            int positionRadioButton = 0;
            int checkItemAdded = 0;

            if(textBoxAmount.Text != "" & comboBoxProduct.SelectedItem != null)
            {
                if(tableLayoutPanelShop.Controls.Count > 0)
                {
                    TableLayoutPanel tableLayoutPanelAddedGoods = orderEditingWindow.tableProducts();

                    for (int i = 0; i < countRows; i++)
                    {
                        Control radioButton = tableLayoutPanelShop.Controls[positionRadioButton];
                        Control textShopName = tableLayoutPanelShop.Controls[positionRadioButton + 1];
                        Control textAdressShop = tableLayoutPanelShop.Controls[positionRadioButton + 2];
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
                                        checkBox.Dock = DockStyle.Top;

                                        TextBox textBoxProductName = new TextBox();
                                        textBoxProductName.Text = comboBoxProduct.SelectedItem.ToString();
                                        textBoxProductName.Dock = DockStyle.Fill;

                                        TextBox textBoxOccupiedVolume = new TextBox();
                                        textBoxOccupiedVolume.Text = idAndNameProduct[positionInArray][2];
                                        textBoxOccupiedVolume.Dock = DockStyle.Fill;

                                        TextBox textBoxShopName = new TextBox();
                                        textBoxShopName.Name = radioButton.Name;
                                        textBoxShopName.Text = textShopName.Text;
                                        textBoxShopName.Dock = DockStyle.Fill;

                                        TextBox textBoxShopAdress = new TextBox();
                                        textBoxShopAdress.Text = textAdressShop.Text;
                                        textBoxShopAdress.Dock = DockStyle.Fill;

                                        TextBox textBoxOrderedQuantity = new TextBox();
                                        textBoxOrderedQuantity.Text = textBoxAmount.Text;
                                        textBoxOrderedQuantity.MaxLength = 6;
                                        textBoxOrderedQuantity.Dock = DockStyle.Fill;

                                        TextBox textBoxQuantityDelivered = new TextBox();
                                        textBoxQuantityDelivered.Text = "";
                                        textBoxQuantityDelivered.MaxLength = 6;
                                        textBoxQuantityDelivered.Dock = DockStyle.Fill;

                                        TextBox textBoxStatus = new TextBox();
                                        textBoxStatus.Text = "ВРАБОТЕ";
                                        textBoxStatus.Dock = DockStyle.Fill;

                                        tableLayoutPanelAddedGoods.Controls.Add(checkBox);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxProductName);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxOccupiedVolume);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxShopName);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxShopAdress);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxOrderedQuantity);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxQuantityDelivered);
                                        tableLayoutPanelAddedGoods.Controls.Add(textBoxStatus);

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
                                }
                            }
                        }
                        positionRadioButton = positionRadioButton + 3;

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
    }
}
