namespace LISGM
{
    public partial class OrderWindow : Form
    {
        AuthorizationsWindow screenAuthorizations = new AuthorizationsWindow();
        UserApp userApp = new UserApp();
        DatabaseInteraction databaseInteraction = new DatabaseInteraction();
        DataDB dataDB = new DataDB();
        

        public OrderWindow()
        {
            InitializeComponent();
        }

        public OrderWindow(AuthorizationsWindow screenAuthorizations, UserApp userApp)
        {
            this.screenAuthorizations = screenAuthorizations;
            this.userApp = userApp;
            InitializeComponent();
        }

       private void OpenOrderEditingWindow(object sender, EventArgs e)
        {
            OrderEditingWindow orderEditingWindow = new OrderEditingWindow(userApp,this);
            orderEditingWindow.Name = (sender as GroupBox).Name;
            orderEditingWindow.Text = (sender as GroupBox).Text;
            orderEditingWindow.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.screenAuthorizations.Show();
            this.Close();
        }

        private void OrderWindow_Load(object sender, EventArgs e)
        {
            fillingOrderField(0);
            
            if(userApp.employeesPosition == databaseInteraction.EMPPOSMANAGER || userApp.employeesPosition == databaseInteraction.EMPPOSADMIN)
            {
                buttonNewOrder.Enabled = true;
            }

            if (userApp.employeesPosition == databaseInteraction.EMPPOSLOGISTITCIAN || userApp.employeesPosition == databaseInteraction.EMPPOSADMIN)
            {
                buttonNotLogisticianOrder.Enabled = true;
            }
        }

        private void fillingOrderField(int fillingType)
        {
            if (fillingType == 0)
            {
                if(userApp.employeesPosition == databaseInteraction.EMPPOSMANAGER)
                {
                    dataDB = databaseInteraction.RequestAllOrdersManager(userApp.id);
                }

                if(userApp.employeesPosition == databaseInteraction.EMPPOSLOGISTITCIAN)
                {
                    dataDB = databaseInteraction.RequestAllOrdersLogistician(userApp.id);
                }

                if (userApp.employeesPosition == databaseInteraction.EMPPOSADMIN)
                {
                    dataDB = databaseInteraction.RequestAllOrdersAdmin();
                }
            }

            if (fillingType == 1)
            {
                if (userApp.employeesPosition == databaseInteraction.EMPPOSMANAGER)
                {
                    dataDB = databaseInteraction.RequestAllOrdersManagerArhive(userApp.id);
                }

                if (userApp.employeesPosition == databaseInteraction.EMPPOSLOGISTITCIAN)
                {
                    dataDB = databaseInteraction.RequestAllOrdersLogisticianArhive(userApp.id);
                }

                if (userApp.employeesPosition == databaseInteraction.EMPPOSADMIN)
                {
                    dataDB = databaseInteraction.RequestAllOrdersAdminArhive();
                }
            }

            if(fillingType == 2)
            {
                dataDB = databaseInteraction.RequestAllOrdersNotLogistician();
            }

            int columnId = 0;
            int columnStartDate = 0;
            int columnEndDate = 0;
            int columnIdManager = 0;
            int columnIdSupplier = 0;
            int columnIdLogistician = 0;
            int columnIdCarrier = 0;

            flowLayoutPanel1.Controls.Clear();

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
            }

            for (int i = 0; i < dataDB.rowsCount; i++)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderWindow));
                GroupBox groupBoxOrder = new GroupBox();
                Label labelOrderDateStart = new Label();
                Label labelOrderDateStartValue = new Label();
                Label labelOrderDateEnd = new Label();
                Label labelOrderDateEndValue = new Label();
                PictureBox pictureBoxOrderManager = new PictureBox();
                TextBox textBoxManager = new TextBox();
                PictureBox pictureBoxOrderSupplier = new PictureBox();
                TextBox textBoxSupplier = new TextBox();
                PictureBox pictureBoxOrderLogistician = new PictureBox();
                TextBox textBoxLogistician = new TextBox();
                PictureBox pictureBoxOrderCarrier = new PictureBox();
                TextBox textBoxCarrier = new TextBox();

                groupBoxOrder.Controls.Add(labelOrderDateStart);
                groupBoxOrder.Controls.Add(labelOrderDateStartValue);
                groupBoxOrder.Controls.Add(labelOrderDateEnd);
                groupBoxOrder.Controls.Add(labelOrderDateEndValue);
                groupBoxOrder.Controls.Add(pictureBoxOrderManager);
                groupBoxOrder.Controls.Add(textBoxManager);
                groupBoxOrder.Controls.Add(pictureBoxOrderSupplier);
                groupBoxOrder.Controls.Add(textBoxSupplier);
                groupBoxOrder.Controls.Add(pictureBoxOrderLogistician);
                groupBoxOrder.Controls.Add(textBoxLogistician);
                groupBoxOrder.Controls.Add(pictureBoxOrderCarrier);
                groupBoxOrder.Controls.Add(textBoxCarrier);
                groupBoxOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                groupBoxOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(64)))));
                groupBoxOrder.DoubleClick += OpenOrderEditingWindow;
                groupBoxOrder.Text = dataDB.receivedData[i == 0 ? columnId : columnId = columnId + dataDB.columnCount];

                groupBoxOrder.Location = new System.Drawing.Point(20, 20);
                groupBoxOrder.Margin = new System.Windows.Forms.Padding(20);
                groupBoxOrder.Name = groupBoxOrder.Text;
                groupBoxOrder.Size = new System.Drawing.Size(269, 295);
                groupBoxOrder.TabIndex = 0;
                groupBoxOrder.TabStop = false;

                pictureBoxOrderCarrier.Enabled = false;
                pictureBoxOrderCarrier.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
                pictureBoxOrderCarrier.Location = new System.Drawing.Point(3, 183);
                pictureBoxOrderCarrier.Name = "pictureBox4";
                pictureBoxOrderCarrier.Size = new System.Drawing.Size(20, 20);
                pictureBoxOrderCarrier.TabIndex = 15;
                pictureBoxOrderCarrier.TabStop = false;

                pictureBoxOrderLogistician.Enabled = false;
                pictureBoxOrderLogistician.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
                pictureBoxOrderLogistician.Location = new System.Drawing.Point(3, 145);
                pictureBoxOrderLogistician.Name = "pictureBox3";
                pictureBoxOrderLogistician.Size = new System.Drawing.Size(20, 20);
                pictureBoxOrderLogistician.TabIndex = 14;
                pictureBoxOrderLogistician.TabStop = false;

                pictureBoxOrderSupplier.Enabled = false;
                pictureBoxOrderSupplier.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
                pictureBoxOrderSupplier.Location = new System.Drawing.Point(3, 107);
                pictureBoxOrderSupplier.Name = "pictureBox2";
                pictureBoxOrderSupplier.Size = new System.Drawing.Size(20, 20);
                pictureBoxOrderSupplier.TabIndex = 13;
                pictureBoxOrderSupplier.TabStop = false;

                pictureBoxOrderManager.Enabled = false;
                pictureBoxOrderManager.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
                pictureBoxOrderManager.Location = new System.Drawing.Point(3, 68);
                pictureBoxOrderManager.Name = "pictureBox1";
                pictureBoxOrderManager.Size = new System.Drawing.Size(20, 20);
                pictureBoxOrderManager.TabIndex = 12;
                pictureBoxOrderManager.TabStop = false;

                labelOrderDateStart.AutoSize = true;
                labelOrderDateStart.Location = new System.Drawing.Point(3, 20);
                labelOrderDateStart.Name = "labelOrderDateStart";
                labelOrderDateStart.Size = new System.Drawing.Size(69, 15);
                labelOrderDateStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                labelOrderDateStart.ForeColor = System.Drawing.Color.Black;
                labelOrderDateStart.TabIndex = 2;
                labelOrderDateStart.Text = "Дата заказа:";

                labelOrderDateStartValue.AutoSize = true;
                labelOrderDateStartValue.Location = new System.Drawing.Point(123, 20);
                labelOrderDateStartValue.Name = "labelOrderDateStartValue";
                labelOrderDateStartValue.Size = new System.Drawing.Size(61, 15);
                labelOrderDateStartValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                labelOrderDateStartValue.ForeColor = System.Drawing.Color.Black;
                labelOrderDateStartValue.TabIndex = 10;
                labelOrderDateStartValue.Text = dataDB.receivedData[i == 0 ? columnStartDate : columnStartDate = columnStartDate + dataDB.columnCount];

                labelOrderDateEnd.AutoSize = true;
                labelOrderDateEnd.Location = new System.Drawing.Point(3, 35);
                labelOrderDateEnd.Name = "labelOrderDateEnd";
                labelOrderDateEnd.Size = new System.Drawing.Size(102, 15);
                labelOrderDateEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                labelOrderDateEnd.ForeColor = System.Drawing.Color.Black;
                labelOrderDateEnd.TabIndex = 7;
                labelOrderDateEnd.Text = "Дата завершения:";

                labelOrderDateEndValue.AutoSize = true;
                labelOrderDateEndValue.Location = new System.Drawing.Point(123, 35);
                labelOrderDateEndValue.Name = "labelOrderDateEndValue";
                labelOrderDateEndValue.Size = new System.Drawing.Size(61, 15);
                labelOrderDateEndValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                labelOrderDateEndValue.ForeColor = System.Drawing.Color.Black;
                labelOrderDateEndValue.TabIndex = 11;
                labelOrderDateEndValue.Text = dataDB.receivedData[i == 0 ? columnEndDate : columnEndDate = columnEndDate + dataDB.columnCount];

                textBoxManager.Location = new System.Drawing.Point(29, 68);
                textBoxManager.Name = "textBoxManager";
                textBoxManager.Size = new System.Drawing.Size(179, 23);
                textBoxManager.BackColor = System.Drawing.Color.White;
                textBoxManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                textBoxManager.PlaceholderText = "Менеджер";
                textBoxManager.TabIndex = 3;
                textBoxManager.ReadOnly = true;
                textBoxManager.Text = dataDB.receivedData[i == 0 ? columnIdManager : columnIdManager = columnIdManager + dataDB.columnCount];

                textBoxSupplier.Location = new System.Drawing.Point(29, 107);
                textBoxSupplier.Name = "textBoxSupplier";
                textBoxSupplier.Size = new System.Drawing.Size(179, 23);
                textBoxSupplier.BackColor = System.Drawing.Color.White;
                textBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                textBoxSupplier.PlaceholderText = "Поставщик";
                textBoxSupplier.TabIndex = 8;
                textBoxSupplier.ReadOnly = true;
                textBoxSupplier.Text = dataDB.receivedData[i == 0 ? columnIdSupplier : columnIdSupplier = columnIdSupplier + dataDB.columnCount];

                textBoxLogistician.Location = new System.Drawing.Point(29, 145);
                textBoxLogistician.Name = "textBoxLogistician";
                textBoxLogistician.Size = new System.Drawing.Size(179, 23);
                textBoxLogistician.BackColor = System.Drawing.Color.White;
                textBoxLogistician.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                textBoxLogistician.PlaceholderText = "Логист";
                textBoxLogistician.TabIndex = 4;
                textBoxLogistician.ReadOnly = true;
                textBoxLogistician.Text = dataDB.receivedData[i == 0 ? columnIdLogistician : columnIdLogistician = columnIdLogistician + dataDB.columnCount];

                textBoxCarrier.Location = new System.Drawing.Point(29, 183);
                textBoxCarrier.Name = "textBoxCarrier";
                textBoxCarrier.Size = new System.Drawing.Size(179, 23);
                textBoxCarrier.BackColor = System.Drawing.Color.White;
                textBoxCarrier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                textBoxCarrier.PlaceholderText = "Перевозчки";
                textBoxCarrier.TabIndex = 9;
                textBoxCarrier.ReadOnly = true;
                textBoxCarrier.Text = dataDB.receivedData[i == 0 ? columnIdCarrier : columnIdCarrier = columnIdCarrier + dataDB.columnCount];

                this.flowLayoutPanel1.Controls.Add(groupBoxOrder);
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Создать новый заказ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                dataDB = databaseInteraction.NewOrderEntry(userApp.id);

                if (dataDB.entryCheck == 1)
                {
                    dataDB = databaseInteraction.RequestIDNewOrder(userApp.id);
                    int columnId = 0;

                    for (int i = 0; i < dataDB.columnCount; i++)
                    {
                        if (dataDB.columnName[i] == databaseInteraction.idUser.Substring(1, databaseInteraction.idUser.Length - 2))
                        {
                            columnId = i;
                        }
                    }

                    if (dataDB.columnName[columnId] == databaseInteraction.idOrder.Substring(1, databaseInteraction.idOrder.Length - 2))
                    {
                        OrderEditingWindow orderEditingWindow = new OrderEditingWindow(userApp, this);
                        orderEditingWindow.Name = dataDB.receivedData[columnId];
                        orderEditingWindow.Text = dataDB.receivedData[columnId];

                        orderEditingWindow.Show();

                        dataDB = databaseInteraction.StatusChangeOrder(userApp.id);

                        OrderListUpdate();

                        if (dataDB.entryCheck != 1)
                        {
                            MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в запросе к базе данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Нет ответа от базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void buttonArhive_Click(object sender, EventArgs e)
        {
            fillingOrderField(1);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            fillingOrderField(0);
        }

        private void buttonNotLogisticianOrder_Click(object sender, EventArgs e)
        {
            fillingOrderField(2);
        }

        public void OrderListUpdate()
        {
            fillingOrderField(0);
        }

        private void OrderWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
