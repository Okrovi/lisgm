namespace LISGM
{
    partial class OrderWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNotLogisticianOrder = new System.Windows.Forms.Button();
            this.buttonArhive = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAreaNamfeField = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonNotLogisticianOrder);
            this.panel1.Controls.Add(this.buttonArhive);
            this.panel1.Controls.Add(this.buttonNewOrder);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 637);
            this.panel1.TabIndex = 0;
            // 
            // buttonNotLogisticianOrder
            // 
            this.buttonNotLogisticianOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonNotLogisticianOrder.Enabled = false;
            this.buttonNotLogisticianOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNotLogisticianOrder.ForeColor = System.Drawing.Color.White;
            this.buttonNotLogisticianOrder.Location = new System.Drawing.Point(0, 96);
            this.buttonNotLogisticianOrder.Name = "buttonNotLogisticianOrder";
            this.buttonNotLogisticianOrder.Size = new System.Drawing.Size(168, 52);
            this.buttonNotLogisticianOrder.TabIndex = 9;
            this.buttonNotLogisticianOrder.Text = "Заказы без логиста";
            this.buttonNotLogisticianOrder.UseVisualStyleBackColor = false;
            this.buttonNotLogisticianOrder.Click += new System.EventHandler(this.buttonNotLogisticianOrder_Click);
            // 
            // buttonArhive
            // 
            this.buttonArhive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonArhive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArhive.ForeColor = System.Drawing.Color.White;
            this.buttonArhive.Location = new System.Drawing.Point(0, 248);
            this.buttonArhive.Name = "buttonArhive";
            this.buttonArhive.Size = new System.Drawing.Size(168, 52);
            this.buttonArhive.TabIndex = 8;
            this.buttonArhive.Text = "Архив заказов";
            this.buttonArhive.UseVisualStyleBackColor = false;
            this.buttonArhive.Click += new System.EventHandler(this.buttonArhive_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonNewOrder.Enabled = false;
            this.buttonNewOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewOrder.ForeColor = System.Drawing.Color.White;
            this.buttonNewOrder.Location = new System.Drawing.Point(0, 31);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(168, 52);
            this.buttonNewOrder.TabIndex = 2;
            this.buttonNewOrder.Text = "Добавить заказ";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(0, 582);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(168, 52);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход из приложения";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(0, 161);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(168, 52);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить панель";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(204, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 603);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelAreaNamfeField
            // 
            this.labelAreaNamfeField.AutoSize = true;
            this.labelAreaNamfeField.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAreaNamfeField.Location = new System.Drawing.Point(204, 12);
            this.labelAreaNamfeField.Name = "labelAreaNamfeField";
            this.labelAreaNamfeField.Size = new System.Drawing.Size(88, 28);
            this.labelAreaNamfeField.TabIndex = 2;
            this.labelAreaNamfeField.Text = "ЗАКАЗЫ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.panel2.Location = new System.Drawing.Point(183, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 637);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.panel3.Location = new System.Drawing.Point(298, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 9);
            this.panel3.TabIndex = 4;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelAreaNamfeField);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "OrderWindow";
            this.ShowIcon = false;
            this.Text = "Заказы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderWindow_FormClosed);
            this.Load += new System.EventHandler(this.OrderWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button buttonExit;
        private Button buttonNewOrder;
        private Button buttonUpdate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonArhive;
        private Button buttonNotLogisticianOrder;
        private Label labelAreaNamfeField;
        private Panel panel2;
        private Panel panel3;
    }
}