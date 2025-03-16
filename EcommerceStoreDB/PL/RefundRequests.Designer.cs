namespace EcommerceStoreDB
{
    partial class RefundRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundRequests));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblRefundRequests = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnRequestRefund = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtRefundAmount = new System.Windows.Forms.TextBox();
            this.dgvRefundRequests = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.lblRefundRequests);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 175);
            this.panel1.TabIndex = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1177, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1165, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.White;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(30, 46);
            this.pbHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(76, 89);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 78;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // lblRefundRequests
            // 
            this.lblRefundRequests.AutoEllipsis = true;
            this.lblRefundRequests.AutoSize = true;
            this.lblRefundRequests.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundRequests.ForeColor = System.Drawing.Color.White;
            this.lblRefundRequests.Location = new System.Drawing.Point(405, 46);
            this.lblRefundRequests.Name = "lblRefundRequests";
            this.lblRefundRequests.Size = new System.Drawing.Size(515, 71);
            this.lblRefundRequests.TabIndex = 75;
            this.lblRefundRequests.Text = "REFUND REQUESTS";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMessage.Location = new System.Drawing.Point(492, 595);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(379, 37);
            this.lblMessage.TabIndex = 208;
            this.lblMessage.Text = "Message will appear here";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.White;
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.ForeColor = System.Drawing.Color.Black;
            this.txtOrderID.Location = new System.Drawing.Point(336, 215);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(308, 37);
            this.txtOrderID.TabIndex = 205;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.Location = new System.Drawing.Point(173, 215);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(130, 37);
            this.lblProductName.TabIndex = 203;
            this.lblProductName.Text = "OrderID";
            // 
            // btnRequestRefund
            // 
            this.btnRequestRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnRequestRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestRefund.FlatAppearance.BorderSize = 2;
            this.btnRequestRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestRefund.ForeColor = System.Drawing.Color.White;
            this.btnRequestRefund.Location = new System.Drawing.Point(532, 516);
            this.btnRequestRefund.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRequestRefund.Name = "btnRequestRefund";
            this.btnRequestRefund.Size = new System.Drawing.Size(304, 62);
            this.btnRequestRefund.TabIndex = 204;
            this.btnRequestRefund.Text = "REQUEST REFUND";
            this.btnRequestRefund.UseVisualStyleBackColor = false;
            this.btnRequestRefund.Click += new System.EventHandler(this.btnRequestRefund_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 2;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(1139, 634);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(201, 62);
            this.btnSignOut.TabIndex = 202;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(936, 634);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 62);
            this.btnBack.TabIndex = 201;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(151, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 209;
            this.label2.Text = "REASON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(4, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 37);
            this.label3.TabIndex = 210;
            this.label3.Text = "REFUND AMOUNT";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.ForeColor = System.Drawing.Color.Black;
            this.txtReason.Location = new System.Drawing.Point(336, 350);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(308, 37);
            this.txtReason.TabIndex = 211;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // txtRefundAmount
            // 
            this.txtRefundAmount.BackColor = System.Drawing.Color.White;
            this.txtRefundAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundAmount.ForeColor = System.Drawing.Color.Black;
            this.txtRefundAmount.Location = new System.Drawing.Point(336, 469);
            this.txtRefundAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRefundAmount.Multiline = true;
            this.txtRefundAmount.Name = "txtRefundAmount";
            this.txtRefundAmount.Size = new System.Drawing.Size(308, 37);
            this.txtRefundAmount.TabIndex = 212;
            this.txtRefundAmount.TextChanged += new System.EventHandler(this.txtRefundAmount_TextChanged);
            // 
            // dgvRefundRequests
            // 
            this.dgvRefundRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRefundRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefundRequests.Location = new System.Drawing.Point(689, 215);
            this.dgvRefundRequests.Name = "dgvRefundRequests";
            this.dgvRefundRequests.RowHeadersWidth = 82;
            this.dgvRefundRequests.RowTemplate.Height = 33;
            this.dgvRefundRequests.Size = new System.Drawing.Size(639, 293);
            this.dgvRefundRequests.TabIndex = 213;
            this.dgvRefundRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefundRequests_CellContentClick);
            // 
            // RefundRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.dgvRefundRequests);
            this.Controls.Add(this.txtRefundAmount);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnRequestRefund);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RefundRequests";
            this.Text = "RefundRequests";
            this.Load += new System.EventHandler(this.RefundRequests_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblRefundRequests;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnRequestRefund;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtRefundAmount;
        private System.Windows.Forms.DataGridView dgvRefundRequests;
    }
}