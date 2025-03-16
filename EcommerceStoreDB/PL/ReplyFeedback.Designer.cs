namespace EcommerceStoreDB
{
    partial class ReplyFeedback
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplyFeedback));
            this.dgvManageFeedback = new System.Windows.Forms.DataGridView();
            this.sALARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbgLogo = new System.Windows.Forms.PictureBox();
            this.lblManageFeedback = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageFeedback
            // 
            this.dgvManageFeedback.AutoGenerateColumns = false;
            this.dgvManageFeedback.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvManageFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageFeedback.DataSource = this.sALARYBindingSource;
            this.dgvManageFeedback.Location = new System.Drawing.Point(14, 182);
            this.dgvManageFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvManageFeedback.Name = "dgvManageFeedback";
            this.dgvManageFeedback.RowHeadersWidth = 51;
            this.dgvManageFeedback.RowTemplate.Height = 24;
            this.dgvManageFeedback.Size = new System.Drawing.Size(1314, 441);
            this.dgvManageFeedback.TabIndex = 128;
            this.dgvManageFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageFeedback_CellContentClick);
            // 
            // sALARYBindingSource
            // 
            this.sALARYBindingSource.DataMember = "SALARY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.picbgLogo);
            this.panel1.Controls.Add(this.lblManageFeedback);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 175);
            this.panel1.TabIndex = 184;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(14, 46);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(76, 89);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 117;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(1178, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 115;
            this.picLogo.TabStop = false;
            // 
            // picbgLogo
            // 
            this.picbgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.picbgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbgLogo.Location = new System.Drawing.Point(1166, 0);
            this.picbgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbgLogo.Name = "picbgLogo";
            this.picbgLogo.Size = new System.Drawing.Size(175, 175);
            this.picbgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbgLogo.TabIndex = 116;
            this.picbgLogo.TabStop = false;
            // 
            // lblManageFeedback
            // 
            this.lblManageFeedback.AutoEllipsis = true;
            this.lblManageFeedback.AutoSize = true;
            this.lblManageFeedback.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageFeedback.ForeColor = System.Drawing.Color.White;
            this.lblManageFeedback.Location = new System.Drawing.Point(412, 64);
            this.lblManageFeedback.Name = "lblManageFeedback";
            this.lblManageFeedback.Size = new System.Drawing.Size(537, 71);
            this.lblManageFeedback.TabIndex = 75;
            this.lblManageFeedback.Text = "MANAGE FEEDBACK";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1139, 633);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 62);
            this.btnBack.TabIndex = 185;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReplyFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvManageFeedback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplyFeedback";
            this.Text = "ReplyInquiry";
            this.Load += new System.EventHandler(this.ReplyFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARYBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageFeedback;
        private System.Windows.Forms.BindingSource sALARYBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManageFeedback;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picbgLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Button btnBack;
    }
}