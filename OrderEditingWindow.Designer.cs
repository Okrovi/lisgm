namespace LISGM
{
    partial class OrderEditingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEditingWindow));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonValueSupplier = new System.Windows.Forms.Button();
            this.buttonValueCarrier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelireved = new System.Windows.Forms.Button();
            this.buttonRemItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOrderStartText = new System.Windows.Forms.Label();
            this.labelOrderStartValue = new System.Windows.Forms.Label();
            this.labelOrderEndText = new System.Windows.Forms.Label();
            this.labelOrderEndValue = new System.Windows.Forms.Label();
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelAddedGoods = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxDetailsSupplier = new System.Windows.Forms.ListBox();
            this.listBoxDetailsCarrier = new System.Windows.Forms.ListBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelLogistican = new System.Windows.Forms.Label();
            this.labelValueManager = new System.Windows.Forms.Label();
            this.labelValueLogistican = new System.Windows.Forms.Label();
            this.buttonConfirmSupplier = new System.Windows.Forms.Button();
            this.buttonConfirmCarrier = new System.Windows.Forms.Button();
            this.buttonOrderComlection = new System.Windows.Forms.Button();
            this.buttonSaveDataInFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBoxItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(481, 622);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(250, 27);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonValueSupplier
            // 
            this.buttonValueSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonValueSupplier.Enabled = false;
            this.buttonValueSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonValueSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonValueSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValueSupplier.Location = new System.Drawing.Point(12, 119);
            this.buttonValueSupplier.Name = "buttonValueSupplier";
            this.buttonValueSupplier.Size = new System.Drawing.Size(198, 27);
            this.buttonValueSupplier.TabIndex = 3;
            this.buttonValueSupplier.Text = "Выбор поставщика";
            this.buttonValueSupplier.UseVisualStyleBackColor = false;
            this.buttonValueSupplier.Click += new System.EventHandler(this.buttonValueProvider_Click);
            // 
            // buttonValueCarrier
            // 
            this.buttonValueCarrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonValueCarrier.Enabled = false;
            this.buttonValueCarrier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonValueCarrier.ForeColor = System.Drawing.Color.White;
            this.buttonValueCarrier.Location = new System.Drawing.Point(12, 399);
            this.buttonValueCarrier.Name = "buttonValueCarrier";
            this.buttonValueCarrier.Size = new System.Drawing.Size(198, 27);
            this.buttonValueCarrier.TabIndex = 4;
            this.buttonValueCarrier.Text = "Выбор перевозчика";
            this.buttonValueCarrier.UseVisualStyleBackColor = false;
            this.buttonValueCarrier.Click += new System.EventHandler(this.buttonValueCarrier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.buttonDelireved);
            this.panel1.Controls.Add(this.buttonRemItem);
            this.panel1.Controls.Add(this.buttonAddItem);
            this.panel1.Location = new System.Drawing.Point(229, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 27);
            this.panel1.TabIndex = 10;
            // 
            // buttonDelireved
            // 
            this.buttonDelireved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonDelireved.Enabled = false;
            this.buttonDelireved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelireved.ForeColor = System.Drawing.Color.White;
            this.buttonDelireved.Location = new System.Drawing.Point(619, 4);
            this.buttonDelireved.Name = "buttonDelireved";
            this.buttonDelireved.Size = new System.Drawing.Size(121, 23);
            this.buttonDelireved.TabIndex = 3;
            this.buttonDelireved.Text = "Доставлено";
            this.buttonDelireved.UseVisualStyleBackColor = false;
            this.buttonDelireved.Click += new System.EventHandler(this.buttonDelireved_Click);
            // 
            // buttonRemItem
            // 
            this.buttonRemItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonRemItem.Enabled = false;
            this.buttonRemItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemItem.ForeColor = System.Drawing.Color.White;
            this.buttonRemItem.Location = new System.Drawing.Point(130, 4);
            this.buttonRemItem.Name = "buttonRemItem";
            this.buttonRemItem.Size = new System.Drawing.Size(121, 23);
            this.buttonRemItem.TabIndex = 1;
            this.buttonRemItem.Text = "Удалить товар";
            this.buttonRemItem.UseVisualStyleBackColor = false;
            this.buttonRemItem.Click += new System.EventHandler(this.buttonRemItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonAddItem.Enabled = false;
            this.buttonAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddItem.ForeColor = System.Drawing.Color.White;
            this.buttonAddItem.Location = new System.Drawing.Point(3, 4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(121, 23);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "Добавить товар";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(737, 623);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(235, 26);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelOrderStartText
            // 
            this.labelOrderStartText.AutoSize = true;
            this.labelOrderStartText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderStartText.Location = new System.Drawing.Point(12, 9);
            this.labelOrderStartText.Name = "labelOrderStartText";
            this.labelOrderStartText.Size = new System.Drawing.Size(93, 15);
            this.labelOrderStartText.TabIndex = 13;
            this.labelOrderStartText.Text = "Дата создания:";
            // 
            // labelOrderStartValue
            // 
            this.labelOrderStartValue.AutoSize = true;
            this.labelOrderStartValue.Location = new System.Drawing.Point(111, 9);
            this.labelOrderStartValue.Name = "labelOrderStartValue";
            this.labelOrderStartValue.Size = new System.Drawing.Size(92, 15);
            this.labelOrderStartValue.TabIndex = 14;
            this.labelOrderStartValue.Text = "ОШИБКА ДАТЫ";
            // 
            // labelOrderEndText
            // 
            this.labelOrderEndText.AutoSize = true;
            this.labelOrderEndText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderEndText.Location = new System.Drawing.Point(294, 9);
            this.labelOrderEndText.Name = "labelOrderEndText";
            this.labelOrderEndText.Size = new System.Drawing.Size(111, 15);
            this.labelOrderEndText.TabIndex = 15;
            this.labelOrderEndText.Text = "Дата завершения:";
            // 
            // labelOrderEndValue
            // 
            this.labelOrderEndValue.AutoSize = true;
            this.labelOrderEndValue.Location = new System.Drawing.Point(411, 9);
            this.labelOrderEndValue.Name = "labelOrderEndValue";
            this.labelOrderEndValue.Size = new System.Drawing.Size(86, 15);
            this.labelOrderEndValue.TabIndex = 16;
            this.labelOrderEndValue.Text = "НЕ ЗАВЕРШЕН";
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.BackColor = System.Drawing.Color.White;
            this.groupBoxItem.Controls.Add(this.tableLayoutPanelAddedGoods);
            this.groupBoxItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxItem.ForeColor = System.Drawing.Color.Black;
            this.groupBoxItem.Location = new System.Drawing.Point(232, 191);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(740, 418);
            this.groupBoxItem.TabIndex = 17;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Заказанные товары";
            // 
            // tableLayoutPanelAddedGoods
            // 
            this.tableLayoutPanelAddedGoods.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelAddedGoods.ColumnCount = 8;
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelAddedGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAddedGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddedGoods.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelAddedGoods.Name = "tableLayoutPanelAddedGoods";
            this.tableLayoutPanelAddedGoods.RowCount = 1;
            this.tableLayoutPanelAddedGoods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAddedGoods.Size = new System.Drawing.Size(734, 396);
            this.tableLayoutPanelAddedGoods.TabIndex = 0;
            // 
            // listBoxDetailsSupplier
            // 
            this.listBoxDetailsSupplier.FormattingEnabled = true;
            this.listBoxDetailsSupplier.ItemHeight = 15;
            this.listBoxDetailsSupplier.Location = new System.Drawing.Point(12, 185);
            this.listBoxDetailsSupplier.Name = "listBoxDetailsSupplier";
            this.listBoxDetailsSupplier.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDetailsSupplier.Size = new System.Drawing.Size(198, 184);
            this.listBoxDetailsSupplier.TabIndex = 20;
            // 
            // listBoxDetailsCarrier
            // 
            this.listBoxDetailsCarrier.FormattingEnabled = true;
            this.listBoxDetailsCarrier.ItemHeight = 15;
            this.listBoxDetailsCarrier.Location = new System.Drawing.Point(12, 465);
            this.listBoxDetailsCarrier.Name = "listBoxDetailsCarrier";
            this.listBoxDetailsCarrier.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDetailsCarrier.Size = new System.Drawing.Size(198, 184);
            this.listBoxDetailsCarrier.TabIndex = 21;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManager.Location = new System.Drawing.Point(12, 42);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(73, 15);
            this.labelManager.TabIndex = 22;
            this.labelManager.Text = "Менеджер:";
            // 
            // labelLogistican
            // 
            this.labelLogistican.AutoSize = true;
            this.labelLogistican.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogistican.Location = new System.Drawing.Point(12, 70);
            this.labelLogistican.Name = "labelLogistican";
            this.labelLogistican.Size = new System.Drawing.Size(50, 15);
            this.labelLogistican.TabIndex = 23;
            this.labelLogistican.Text = "Логист:";
            // 
            // labelValueManager
            // 
            this.labelValueManager.AutoSize = true;
            this.labelValueManager.Location = new System.Drawing.Point(111, 42);
            this.labelValueManager.Name = "labelValueManager";
            this.labelValueManager.Size = new System.Drawing.Size(125, 15);
            this.labelValueManager.TabIndex = 24;
            this.labelValueManager.Text = "ОШИБКА МЕНЕДЖЕР";
            // 
            // labelValueLogistican
            // 
            this.labelValueLogistican.AutoSize = true;
            this.labelValueLogistican.Location = new System.Drawing.Point(111, 70);
            this.labelValueLogistican.Name = "labelValueLogistican";
            this.labelValueLogistican.Size = new System.Drawing.Size(81, 15);
            this.labelValueLogistican.TabIndex = 25;
            this.labelValueLogistican.Text = "НЕТ ДАННЫХ";
            // 
            // buttonConfirmSupplier
            // 
            this.buttonConfirmSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonConfirmSupplier.Enabled = false;
            this.buttonConfirmSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmSupplier.Location = new System.Drawing.Point(12, 152);
            this.buttonConfirmSupplier.Name = "buttonConfirmSupplier";
            this.buttonConfirmSupplier.Size = new System.Drawing.Size(198, 27);
            this.buttonConfirmSupplier.TabIndex = 26;
            this.buttonConfirmSupplier.Text = "Подтвердить";
            this.buttonConfirmSupplier.UseVisualStyleBackColor = false;
            this.buttonConfirmSupplier.Click += new System.EventHandler(this.buttonConfirmSupplier_Click);
            // 
            // buttonConfirmCarrier
            // 
            this.buttonConfirmCarrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonConfirmCarrier.Enabled = false;
            this.buttonConfirmCarrier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmCarrier.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmCarrier.Location = new System.Drawing.Point(12, 432);
            this.buttonConfirmCarrier.Name = "buttonConfirmCarrier";
            this.buttonConfirmCarrier.Size = new System.Drawing.Size(198, 27);
            this.buttonConfirmCarrier.TabIndex = 27;
            this.buttonConfirmCarrier.Text = "Подтвердить";
            this.buttonConfirmCarrier.UseVisualStyleBackColor = false;
            this.buttonConfirmCarrier.Click += new System.EventHandler(this.buttonConfirmCarrier_Click);
            // 
            // buttonOrderComlection
            // 
            this.buttonOrderComlection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonOrderComlection.Enabled = false;
            this.buttonOrderComlection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderComlection.ForeColor = System.Drawing.Color.White;
            this.buttonOrderComlection.Location = new System.Drawing.Point(722, 12);
            this.buttonOrderComlection.Name = "buttonOrderComlection";
            this.buttonOrderComlection.Size = new System.Drawing.Size(250, 27);
            this.buttonOrderComlection.TabIndex = 28;
            this.buttonOrderComlection.Text = "Завершение заказа";
            this.buttonOrderComlection.UseVisualStyleBackColor = false;
            this.buttonOrderComlection.Click += new System.EventHandler(this.buttonOrderComlection_Click);
            // 
            // buttonSaveDataInFile
            // 
            this.buttonSaveDataInFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonSaveDataInFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveDataInFile.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDataInFile.Location = new System.Drawing.Point(722, 42);
            this.buttonSaveDataInFile.Name = "buttonSaveDataInFile";
            this.buttonSaveDataInFile.Size = new System.Drawing.Size(250, 27);
            this.buttonSaveDataInFile.TabIndex = 29;
            this.buttonSaveDataInFile.Text = "Сохранение данных в файл";
            this.buttonSaveDataInFile.UseVisualStyleBackColor = false;
            this.buttonSaveDataInFile.Click += new System.EventHandler(this.buttonSaveDataInFile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(235, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 38);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(153, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(213, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(333, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(513, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(573, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // OrderEditingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonSaveDataInFile);
            this.Controls.Add(this.buttonOrderComlection);
            this.Controls.Add(this.buttonConfirmCarrier);
            this.Controls.Add(this.buttonConfirmSupplier);
            this.Controls.Add(this.labelValueLogistican);
            this.Controls.Add(this.labelValueManager);
            this.Controls.Add(this.labelLogistican);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.listBoxDetailsCarrier);
            this.Controls.Add(this.listBoxDetailsSupplier);
            this.Controls.Add(this.groupBoxItem);
            this.Controls.Add(this.labelOrderEndValue);
            this.Controls.Add(this.labelOrderEndText);
            this.Controls.Add(this.labelOrderStartValue);
            this.Controls.Add(this.labelOrderStartText);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonValueCarrier);
            this.Controls.Add(this.buttonValueSupplier);
            this.Controls.Add(this.buttonSave);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "OrderEditingWindow";
            this.Text = "OrderEditingWindow";
            this.Load += new System.EventHandler(this.OrderEditingWindow_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxItem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonSave;
        private Button buttonValueSupplier;
        private Button buttonValueCarrier;
        private Panel panel1;
        private Button buttonRemItem;
        private Button buttonAddItem;
        private Button buttonExit;
        private Label labelOrderStartText;
        private Label labelOrderStartValue;
        private Label labelOrderEndText;
        private Label labelOrderEndValue;
        private GroupBox groupBoxItem;
        private TableLayoutPanel tableLayoutPanelAddedGoods;
        private ListBox listBoxDetailsSupplier;
        private ListBox listBoxDetailsCarrier;
        private Button buttonDelireved;
        private Label labelManager;
        private Label labelLogistican;
        private Label labelValueManager;
        private Label labelValueLogistican;
        private Button buttonConfirmSupplier;
        private Button buttonConfirmCarrier;
        private Button buttonOrderComlection;
        private Button buttonSaveDataInFile;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}