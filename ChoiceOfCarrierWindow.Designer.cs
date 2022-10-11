namespace LISGM
{
    partial class ChoiceOfCarrierWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeCarrier = new System.Windows.Forms.ComboBox();
            this.comboBoxTerritory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTransportBySupplier = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBoxCarrier = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxCarrier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип перевозчика";
            // 
            // comboBoxTypeCarrier
            // 
            this.comboBoxTypeCarrier.FormattingEnabled = true;
            this.comboBoxTypeCarrier.Location = new System.Drawing.Point(12, 26);
            this.comboBoxTypeCarrier.Name = "comboBoxTypeCarrier";
            this.comboBoxTypeCarrier.Size = new System.Drawing.Size(163, 23);
            this.comboBoxTypeCarrier.TabIndex = 1;
            this.comboBoxTypeCarrier.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeCarrier_SelectedIndexChanged);
            // 
            // comboBoxTerritory
            // 
            this.comboBoxTerritory.FormattingEnabled = true;
            this.comboBoxTerritory.Location = new System.Drawing.Point(181, 26);
            this.comboBoxTerritory.Name = "comboBoxTerritory";
            this.comboBoxTerritory.Size = new System.Drawing.Size(163, 23);
            this.comboBoxTerritory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(181, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Территория работы";
            // 
            // buttonTransportBySupplier
            // 
            this.buttonTransportBySupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonTransportBySupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTransportBySupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTransportBySupplier.ForeColor = System.Drawing.Color.White;
            this.buttonTransportBySupplier.Location = new System.Drawing.Point(350, 26);
            this.buttonTransportBySupplier.Name = "buttonTransportBySupplier";
            this.buttonTransportBySupplier.Size = new System.Drawing.Size(163, 27);
            this.buttonTransportBySupplier.TabIndex = 4;
            this.buttonTransportBySupplier.Text = "Перевозка поставщиком";
            this.buttonTransportBySupplier.UseVisualStyleBackColor = false;
            this.buttonTransportBySupplier.Click += new System.EventHandler(this.buttonTransportBySupplier_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonShow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShow.ForeColor = System.Drawing.Color.White;
            this.buttonShow.Location = new System.Drawing.Point(596, 25);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(176, 27);
            this.buttonShow.TabIndex = 5;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBoxCarrier
            // 
            this.groupBoxCarrier.Controls.Add(this.tableLayoutPanelCarrier);
            this.groupBoxCarrier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCarrier.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCarrier.Location = new System.Drawing.Point(12, 55);
            this.groupBoxCarrier.Name = "groupBoxCarrier";
            this.groupBoxCarrier.Size = new System.Drawing.Size(760, 370);
            this.groupBoxCarrier.TabIndex = 6;
            this.groupBoxCarrier.TabStop = false;
            this.groupBoxCarrier.Text = "Перевозчики";
            // 
            // tableLayoutPanelCarrier
            // 
            this.tableLayoutPanelCarrier.AutoScroll = true;
            this.tableLayoutPanelCarrier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelCarrier.ColumnCount = 4;
            this.tableLayoutPanelCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCarrier.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanelCarrier.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelCarrier.Name = "tableLayoutPanelCarrier";
            this.tableLayoutPanelCarrier.RowCount = 1;
            this.tableLayoutPanelCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelCarrier.Size = new System.Drawing.Size(754, 348);
            this.tableLayoutPanelCarrier.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(12, 428);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(176, 27);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ChoiceOfCarrierWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxCarrier);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonTransportBySupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTerritory);
            this.Controls.Add(this.comboBoxTypeCarrier);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ChoiceOfCarrierWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевозчики";
            this.Load += new System.EventHandler(this.ChoiceOfCarrierWindow_Load);
            this.groupBoxCarrier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxTypeCarrier;
        private ComboBox comboBoxTerritory;
        private Label label2;
        private Button buttonTransportBySupplier;
        private Button buttonShow;
        private GroupBox groupBoxCarrier;
        private Button buttonClose;
        private TableLayoutPanel tableLayoutPanelCarrier;
    }
}