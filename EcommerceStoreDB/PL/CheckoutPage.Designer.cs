namespace EcommerceStoreDB
{
    partial class CheckoutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbgLogo = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerDetails = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCashOnDelivery = new System.Windows.Forms.RadioButton();
            this.rbtnPaypal = new System.Windows.Forms.RadioButton();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvCheckout = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.CustomerDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.picbgLogo);
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 175);
            this.panel1.TabIndex = 162;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(1178, 12);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 113;
            this.picLogo.TabStop = false;
            // 
            // picbgLogo
            // 
            this.picbgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.picbgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbgLogo.Location = new System.Drawing.Point(1166, 1);
            this.picbgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbgLogo.Name = "picbgLogo";
            this.picbgLogo.Size = new System.Drawing.Size(175, 175);
            this.picbgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbgLogo.TabIndex = 114;
            this.picbgLogo.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.White;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(39, 46);
            this.pbHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(76, 89);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 77;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(501, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 71);
            this.label4.TabIndex = 75;
            this.label4.Text = "CHECKOUT";
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Controls.Add(this.textBox4);
            this.CustomerDetails.Controls.Add(this.textBox3);
            this.CustomerDetails.Controls.Add(this.textBox2);
            this.CustomerDetails.Controls.Add(this.textBox1);
            this.CustomerDetails.Controls.Add(this.label5);
            this.CustomerDetails.Controls.Add(this.label1);
            this.CustomerDetails.Controls.Add(this.label3);
            this.CustomerDetails.Controls.Add(this.label2);
            this.CustomerDetails.Location = new System.Drawing.Point(39, 246);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(300, 300);
            this.CustomerDetails.TabIndex = 163;
            this.CustomerDetails.TabStop = false;
            this.CustomerDetails.Text = "CustomerDetails";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 31);
            this.textBox4.TabIndex = 171;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 31);
            this.textBox3.TabIndex = 170;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 31);
            this.textBox2.TabIndex = 169;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 31);
            this.textBox1.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 167;
            this.label5.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 164;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 166;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 165;
            this.label2.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCashOnDelivery);
            this.groupBox2.Controls.Add(this.rbtnPaypal);
            this.groupBox2.Controls.Add(this.rbtnCreditCard);
            this.groupBox2.Location = new System.Drawing.Point(996, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 300);
            this.groupBox2.TabIndex = 173;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Method";
            // 
            // rbtnCashOnDelivery
            // 
            this.rbtnCashOnDelivery.AutoSize = true;
            this.rbtnCashOnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCashOnDelivery.Location = new System.Drawing.Point(49, 222);
            this.rbtnCashOnDelivery.Name = "rbtnCashOnDelivery";
            this.rbtnCashOnDelivery.Size = new System.Drawing.Size(199, 29);
            this.rbtnCashOnDelivery.TabIndex = 2;
            this.rbtnCashOnDelivery.TabStop = true;
            this.rbtnCashOnDelivery.Text = "CashOnDelivery";
            this.rbtnCashOnDelivery.UseVisualStyleBackColor = true;
            this.rbtnCashOnDelivery.CheckedChanged += new System.EventHandler(this.rbtnCashOnDelivery_CheckedChanged);
            // 
            // rbtnPaypal
            // 
            this.rbtnPaypal.AutoSize = true;
            this.rbtnPaypal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnPaypal.Location = new System.Drawing.Point(49, 141);
            this.rbtnPaypal.Name = "rbtnPaypal";
            this.rbtnPaypal.Size = new System.Drawing.Size(139, 29);
            this.rbtnPaypal.TabIndex = 1;
            this.rbtnPaypal.TabStop = true;
            this.rbtnPaypal.Text = "DebitCard";
            this.rbtnPaypal.UseVisualStyleBackColor = true;
            this.rbtnPaypal.CheckedChanged += new System.EventHandler(this.rbtnDebitCard_CheckedChanged);
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCreditCard.Location = new System.Drawing.Point(49, 62);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(146, 29);
            this.rbtnCreditCard.TabIndex = 0;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "CreditCard";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            this.rbtnCreditCard.CheckedChanged += new System.EventHandler(this.rbtnCreditCard_CheckedChanged);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 2;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(1141, 635);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(201, 62);
            this.btnSignOut.TabIndex = 175;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(938, 635);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 62);
            this.btnBack.TabIndex = 174;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(665, 587);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(239, 62);
            this.btnCancel.TabIndex = 177;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Red;
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 2;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(418, 587);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(239, 62);
            this.btnPlaceOrder.TabIndex = 176;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dgvCheckout
            // 
            this.dgvCheckout.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCheckout.Location = new System.Drawing.Point(383, 246);
            this.dgvCheckout.Name = "dgvCheckout";
            this.dgvCheckout.RowHeadersWidth = 82;
            this.dgvCheckout.RowTemplate.Height = 33;
            this.dgvCheckout.Size = new System.Drawing.Size(580, 300);
            this.dgvCheckout.TabIndex = 178;
            this.dgvCheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckout_CellContentClick);
            // 
            // CheckoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.dgvCheckout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CustomerDetails);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckoutPage";
            this.Text = "CheckoutPage";
            this.Load += new System.EventHandler(this.CheckoutPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.CustomerDetails.ResumeLayout(false);
            this.CustomerDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picbgLogo;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox CustomerDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnCashOnDelivery;
        private System.Windows.Forms.RadioButton rbtnPaypal;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvCheckout;
    }
}