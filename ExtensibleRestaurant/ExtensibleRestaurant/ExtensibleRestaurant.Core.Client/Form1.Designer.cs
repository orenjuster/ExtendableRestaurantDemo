namespace ExtensibleRestaurant.Core.Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMenuItems = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalWithTax = new System.Windows.Forms.Label();
            this.labelRestaurantName = new System.Windows.Forms.Label();
            this.panelCustomActions = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose menu item:";
            // 
            // comboBoxMenuItems
            // 
            this.comboBoxMenuItems.FormattingEnabled = true;
            this.comboBoxMenuItems.Location = new System.Drawing.Point(184, 20);
            this.comboBoxMenuItems.Name = "comboBoxMenuItems";
            this.comboBoxMenuItems.Size = new System.Drawing.Size(318, 33);
            this.comboBoxMenuItems.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(509, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add to order";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(12, 105);
            this.textBoxOrder.Multiline = true;
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(613, 228);
            this.textBoxOrder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(71, 336);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(46, 25);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total with tax:";
            // 
            // labelTotalWithTax
            // 
            this.labelTotalWithTax.AutoSize = true;
            this.labelTotalWithTax.Location = new System.Drawing.Point(136, 361);
            this.labelTotalWithTax.Name = "labelTotalWithTax";
            this.labelTotalWithTax.Size = new System.Drawing.Size(46, 25);
            this.labelTotalWithTax.TabIndex = 6;
            this.labelTotalWithTax.Text = "0.00";
            // 
            // labelRestaurantName
            // 
            this.labelRestaurantName.AutoSize = true;
            this.labelRestaurantName.Location = new System.Drawing.Point(11, 12);
            this.labelRestaurantName.Name = "labelRestaurantName";
            this.labelRestaurantName.Size = new System.Drawing.Size(0, 25);
            this.labelRestaurantName.TabIndex = 7;
            // 
            // panelCustomActions
            // 
            this.panelCustomActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelCustomActions.Location = new System.Drawing.Point(643, 12);
            this.panelCustomActions.Name = "panelCustomActions";
            this.panelCustomActions.Size = new System.Drawing.Size(341, 384);
            this.panelCustomActions.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 408);
            this.Controls.Add(this.panelCustomActions);
            this.Controls.Add(this.labelRestaurantName);
            this.Controls.Add(this.labelTotalWithTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBoxMenuItems);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMenuItems;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalWithTax;
        private System.Windows.Forms.Label labelRestaurantName;
        private System.Windows.Forms.FlowLayoutPanel panelCustomActions;
    }
}

