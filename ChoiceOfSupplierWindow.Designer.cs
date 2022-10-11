namespace LISGM
{
    partial class ChoiceOfSupplierWindow
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxSupplier = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSupplier = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonShow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShow.ForeColor = System.Drawing.Color.White;
            this.buttonShow.Location = new System.Drawing.Point(596, 26);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(176, 27);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 26);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(163, 23);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Категория товаров";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(181, 26);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(163, 23);
            this.comboBoxItem.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Товар";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(12, 430);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(176, 27);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxSupplier
            // 
            this.groupBoxSupplier.Controls.Add(this.tableLayoutPanelSupplier);
            this.groupBoxSupplier.Location = new System.Drawing.Point(12, 57);
            this.groupBoxSupplier.Name = "groupBoxSupplier";
            this.groupBoxSupplier.Size = new System.Drawing.Size(760, 370);
            this.groupBoxSupplier.TabIndex = 13;
            this.groupBoxSupplier.TabStop = false;
            this.groupBoxSupplier.Text = "Поставщики";
            // 
            // tableLayoutPanelSupplier
            // 
            this.tableLayoutPanelSupplier.AutoScroll = true;
            this.tableLayoutPanelSupplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelSupplier.ColumnCount = 4;
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelSupplier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSupplier.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanelSupplier.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelSupplier.Name = "tableLayoutPanelSupplier";
            this.tableLayoutPanelSupplier.RowCount = 1;
            this.tableLayoutPanelSupplier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSupplier.Size = new System.Drawing.Size(754, 348);
            this.tableLayoutPanelSupplier.TabIndex = 0;
            // 
            // ChoiceOfSupplierWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBoxSupplier);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonShow);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ChoiceOfSupplierWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор поставщика";
            this.Load += new System.EventHandler(this.ChoiceOfSupplierWindow_Load);
            this.groupBoxSupplier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonShow;
        private ComboBox comboBoxCategory;
        private Label label2;
        private ComboBox comboBoxItem;
        private Label label3;
        private Button buttonClose;
        private GroupBox groupBoxSupplier;
        private TableLayoutPanel tableLayoutPanelSupplier;
    }
}