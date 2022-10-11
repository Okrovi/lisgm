namespace LISGM
{
    partial class ProductSelectionWindow
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
            this.labelProductSupplier = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.groupBoxChoiceShop = new System.Windows.Forms.GroupBox();
            this.buttonShowShop = new System.Windows.Forms.Button();
            this.labelStreet = new System.Windows.Forms.Label();
            this.comboBoxStreet = new System.Windows.Forms.ComboBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.labelTypeShop = new System.Windows.Forms.Label();
            this.comboBoxTypeShop = new System.Windows.Forms.ComboBox();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelShop = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.groupBoxChoiceShop.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProductSupplier
            // 
            this.labelProductSupplier.AutoSize = true;
            this.labelProductSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductSupplier.Location = new System.Drawing.Point(12, 9);
            this.labelProductSupplier.Name = "labelProductSupplier";
            this.labelProductSupplier.Size = new System.Drawing.Size(118, 15);
            this.labelProductSupplier.TabIndex = 0;
            this.labelProductSupplier.Text = "Товары поставщика";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(12, 27);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(175, 23);
            this.comboBoxProduct.TabIndex = 1;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // groupBoxChoiceShop
            // 
            this.groupBoxChoiceShop.Controls.Add(this.buttonShowShop);
            this.groupBoxChoiceShop.Controls.Add(this.labelStreet);
            this.groupBoxChoiceShop.Controls.Add(this.comboBoxStreet);
            this.groupBoxChoiceShop.Controls.Add(this.labelLocation);
            this.groupBoxChoiceShop.Controls.Add(this.comboBoxLocation);
            this.groupBoxChoiceShop.Controls.Add(this.labelTypeShop);
            this.groupBoxChoiceShop.Controls.Add(this.comboBoxTypeShop);
            this.groupBoxChoiceShop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxChoiceShop.ForeColor = System.Drawing.Color.Black;
            this.groupBoxChoiceShop.Location = new System.Drawing.Point(12, 73);
            this.groupBoxChoiceShop.Name = "groupBoxChoiceShop";
            this.groupBoxChoiceShop.Size = new System.Drawing.Size(175, 353);
            this.groupBoxChoiceShop.TabIndex = 2;
            this.groupBoxChoiceShop.TabStop = false;
            this.groupBoxChoiceShop.Text = "Выбор торговой точки";
            // 
            // buttonShowShop
            // 
            this.buttonShowShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonShowShop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowShop.ForeColor = System.Drawing.Color.White;
            this.buttonShowShop.Location = new System.Drawing.Point(6, 208);
            this.buttonShowShop.Name = "buttonShowShop";
            this.buttonShowShop.Size = new System.Drawing.Size(162, 27);
            this.buttonShowShop.TabIndex = 6;
            this.buttonShowShop.Text = "Показать";
            this.buttonShowShop.UseVisualStyleBackColor = false;
            this.buttonShowShop.Click += new System.EventHandler(this.buttonShowShop_Click);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.ForeColor = System.Drawing.Color.Black;
            this.labelStreet.Location = new System.Drawing.Point(6, 149);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(41, 15);
            this.labelStreet.TabIndex = 5;
            this.labelStreet.Text = "Улица";
            // 
            // comboBoxStreet
            // 
            this.comboBoxStreet.FormattingEnabled = true;
            this.comboBoxStreet.Location = new System.Drawing.Point(6, 167);
            this.comboBoxStreet.Name = "comboBoxStreet";
            this.comboBoxStreet.Size = new System.Drawing.Size(162, 23);
            this.comboBoxStreet.TabIndex = 4;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.ForeColor = System.Drawing.Color.Black;
            this.labelLocation.Location = new System.Drawing.Point(6, 92);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(111, 15);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Населенный пункт";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(6, 110);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(162, 23);
            this.comboBoxLocation.TabIndex = 2;
            this.comboBoxLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation_SelectedIndexChanged);
            // 
            // labelTypeShop
            // 
            this.labelTypeShop.AutoSize = true;
            this.labelTypeShop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypeShop.ForeColor = System.Drawing.Color.Black;
            this.labelTypeShop.Location = new System.Drawing.Point(6, 32);
            this.labelTypeShop.Name = "labelTypeShop";
            this.labelTypeShop.Size = new System.Drawing.Size(116, 15);
            this.labelTypeShop.TabIndex = 1;
            this.labelTypeShop.Text = "Тип торговой точки";
            // 
            // comboBoxTypeShop
            // 
            this.comboBoxTypeShop.FormattingEnabled = true;
            this.comboBoxTypeShop.Location = new System.Drawing.Point(6, 50);
            this.comboBoxTypeShop.Name = "comboBoxTypeShop";
            this.comboBoxTypeShop.Size = new System.Drawing.Size(162, 23);
            this.comboBoxTypeShop.TabIndex = 0;
            this.comboBoxTypeShop.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeShop_SelectedIndexChanged);
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.tableLayoutPanelShop);
            this.groupBoxShop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxShop.ForeColor = System.Drawing.Color.Black;
            this.groupBoxShop.Location = new System.Drawing.Point(193, 73);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(479, 353);
            this.groupBoxShop.TabIndex = 3;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "Торговые точки";
            // 
            // tableLayoutPanelShop
            // 
            this.tableLayoutPanelShop.AutoScroll = true;
            this.tableLayoutPanelShop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelShop.ColumnCount = 3;
            this.tableLayoutPanelShop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelShop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelShop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelShop.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelShop.Name = "tableLayoutPanelShop";
            this.tableLayoutPanelShop.RowCount = 1;
            this.tableLayoutPanelShop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelShop.Size = new System.Drawing.Size(473, 331);
            this.tableLayoutPanelShop.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(12, 432);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(175, 27);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(193, 27);
            this.textBoxAmount.MaxLength = 6;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(144, 23);
            this.textBoxAmount.TabIndex = 5;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(193, 9);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(72, 15);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Количество";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduct.Location = new System.Drawing.Point(497, 27);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(175, 27);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnit.Location = new System.Drawing.Point(343, 35);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(37, 15);
            this.labelUnit.TabIndex = 8;
            this.labelUnit.Text = "ЕДИЗ";
            // 
            // ProductSelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxShop);
            this.Controls.Add(this.groupBoxChoiceShop);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProductSupplier);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ProductSelectionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление продукта";
            this.Load += new System.EventHandler(this.ProductSelectionWindow_Load);
            this.groupBoxChoiceShop.ResumeLayout(false);
            this.groupBoxChoiceShop.PerformLayout();
            this.groupBoxShop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelProductSupplier;
        private ComboBox comboBoxProduct;
        private GroupBox groupBoxChoiceShop;
        private Button buttonShowShop;
        private Label labelStreet;
        private ComboBox comboBoxStreet;
        private Label labelLocation;
        private ComboBox comboBoxLocation;
        private Label labelTypeShop;
        private ComboBox comboBoxTypeShop;
        private GroupBox groupBoxShop;
        private TableLayoutPanel tableLayoutPanelShop;
        private Button buttonClose;
        private TextBox textBoxAmount;
        private Label labelAmount;
        private Button buttonAddProduct;
        private Label labelUnit;
    }
}