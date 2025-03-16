using System.Windows.Forms;

namespace EcommerceStoreDB
{
    partial class ManageInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInventory));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbgLogo = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblManageInventory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
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
            this.btnSignOut.TabIndex = 218;
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
            this.btnBack.Location = new System.Drawing.Point(939, 634);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 62);
            this.btnBack.TabIndex = 217;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // lblManageInventory
            // 
            this.lblManageInventory.AutoEllipsis = true;
            this.lblManageInventory.AutoSize = true;
            this.lblManageInventory.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageInventory.ForeColor = System.Drawing.Color.White;
            this.lblManageInventory.Location = new System.Drawing.Point(420, 64);
            this.lblManageInventory.Name = "lblManageInventory";
            this.lblManageInventory.Size = new System.Drawing.Size(576, 71);
            this.lblManageInventory.TabIndex = 75;
            this.lblManageInventory.Text = "MANAGE INVENTORY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.picbgLogo);
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.lblManageInventory);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 175);
            this.panel1.TabIndex = 216;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvInventory
            // 
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(38, 191);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 82;
            this.dgvInventory.RowTemplate.Height = 33;
            this.dgvInventory.Size = new System.Drawing.Size(1288, 435);
            this.dgvInventory.TabIndex = 222;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            this.dgvInventory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInventory_DataError);
            // 
            // ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 697);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageInventory";
            this.Text = "ManageInventory";
            this.Load += new System.EventHandler(this.ManageInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picbgLogo;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblManageInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}