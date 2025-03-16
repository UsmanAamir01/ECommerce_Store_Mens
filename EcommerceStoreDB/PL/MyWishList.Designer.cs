namespace EcommerceStoreDB
{
    partial class MyWishList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyWishList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbgLogo = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMoveToCart = new System.Windows.Forms.Button();
            this.wishlistListView = new System.Windows.Forms.ListView();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.picbgLogo);
            this.panel1.Controls.Add(this.pbHome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 175);
            this.panel1.TabIndex = 163;
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
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(503, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 71);
            this.label4.TabIndex = 75;
            this.label4.Text = "WISHLIST";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Red;
            this.btnRemoveItem.FlatAppearance.BorderSize = 2;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(675, 566);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(322, 62);
            this.btnRemoveItem.TabIndex = 179;
            this.btnRemoveItem.Text = "REMOVE ITEM";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnMoveToCart
            // 
            this.btnMoveToCart.BackColor = System.Drawing.Color.Green;
            this.btnMoveToCart.FlatAppearance.BorderSize = 2;
            this.btnMoveToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToCart.ForeColor = System.Drawing.Color.White;
            this.btnMoveToCart.Location = new System.Drawing.Point(345, 566);
            this.btnMoveToCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveToCart.Name = "btnMoveToCart";
            this.btnMoveToCart.Size = new System.Drawing.Size(322, 62);
            this.btnMoveToCart.TabIndex = 178;
            this.btnMoveToCart.Text = "MOVE TO CART";
            this.btnMoveToCart.UseVisualStyleBackColor = false;
            this.btnMoveToCart.Click += new System.EventHandler(this.btnMoveToCart_Click);
            // 
            // wishlistListView
            // 
            this.wishlistListView.FullRowSelect = true;
            this.wishlistListView.GridLines = true;
            this.wishlistListView.HideSelection = false;
            this.wishlistListView.Location = new System.Drawing.Point(39, 181);
            this.wishlistListView.MultiSelect = false;
            this.wishlistListView.Name = "wishlistListView";
            this.wishlistListView.Size = new System.Drawing.Size(1289, 377);
            this.wishlistListView.TabIndex = 180;
            this.wishlistListView.UseCompatibleStateImageBehavior = false;
            this.wishlistListView.View = System.Windows.Forms.View.Details;
            this.wishlistListView.SelectedIndexChanged += new System.EventHandler(this.wishlistListView_SelectedIndexChanged);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnSignOut.FlatAppearance.BorderSize = 2;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(1141, 633);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(201, 62);
            this.btnSignOut.TabIndex = 182;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(938, 633);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 62);
            this.btnBack.TabIndex = 181;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MyWishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.wishlistListView);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnMoveToCart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyWishList";
            this.Text = "MyWishList";
            this.Load += new System.EventHandler(this.MyWishList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picbgLogo;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnMoveToCart;
        private System.Windows.Forms.ListView wishlistListView;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnBack;
    }
}