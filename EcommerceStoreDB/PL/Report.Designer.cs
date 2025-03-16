namespace EcommerceStoreDB
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.lblReportNamee = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblReportIDD = new System.Windows.Forms.Label();
            this.txtReportIDD = new System.Windows.Forms.TextBox();
            this.btnDeleteReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblViewReport = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.txtViewReport = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dtpGenerateDate = new System.Windows.Forms.DateTimePicker();
            this.lblGenerateReport = new System.Windows.Forms.Label();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.txtReportDescription = new System.Windows.Forms.TextBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblReportID = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTotalRevenue = new System.Windows.Forms.Button();
            this.lblReportName = new System.Windows.Forms.Label();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvViewReport = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbgLogo = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportNamee
            // 
            this.lblReportNamee.AutoSize = true;
            this.lblReportNamee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportNamee.ForeColor = System.Drawing.Color.Black;
            this.lblReportNamee.Location = new System.Drawing.Point(6, 347);
            this.lblReportNamee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportNamee.Name = "lblReportNamee";
            this.lblReportNamee.Size = new System.Drawing.Size(219, 32);
            this.lblReportNamee.TabIndex = 51;
            this.lblReportNamee.Text = "REPORT NAME";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(0, 806);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(435, 62);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Controls.Add(this.lblReportIDD);
            this.panel5.Controls.Add(this.txtReportIDD);
            this.panel5.Controls.Add(this.btnDeleteReport);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1168, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 872);
            this.panel5.TabIndex = 63;
            // 
            // lblReportIDD
            // 
            this.lblReportIDD.AutoSize = true;
            this.lblReportIDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportIDD.ForeColor = System.Drawing.Color.White;
            this.lblReportIDD.Location = new System.Drawing.Point(58, 178);
            this.lblReportIDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportIDD.Name = "lblReportIDD";
            this.lblReportIDD.Size = new System.Drawing.Size(133, 32);
            this.lblReportIDD.TabIndex = 64;
            this.lblReportIDD.Text = "Report ID";
            // 
            // txtReportIDD
            // 
            this.txtReportIDD.BackColor = System.Drawing.Color.White;
            this.txtReportIDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportIDD.ForeColor = System.Drawing.Color.Black;
            this.txtReportIDD.Location = new System.Drawing.Point(64, 214);
            this.txtReportIDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReportIDD.Multiline = true;
            this.txtReportIDD.Name = "txtReportIDD";
            this.txtReportIDD.Size = new System.Drawing.Size(308, 45);
            this.txtReportIDD.TabIndex = 9;
            this.txtReportIDD.TextChanged += new System.EventHandler(this.txtReportIDD_TextChanged);
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteReport.FlatAppearance.BorderSize = 0;
            this.btnDeleteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteReport.Location = new System.Drawing.Point(126, 328);
            this.btnDeleteReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.Size = new System.Drawing.Size(178, 55);
            this.btnDeleteReport.TabIndex = 10;
            this.btnDeleteReport.Text = "DELETE";
            this.btnDeleteReport.UseVisualStyleBackColor = false;
            this.btnDeleteReport.Click += new System.EventHandler(this.btnDeleteReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delete Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(184, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 61);
            this.label3.TabIndex = 46;
            this.label3.Text = "REPORT PORTAL";
            // 
            // lblViewReport
            // 
            this.lblViewReport.AutoSize = true;
            this.lblViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewReport.ForeColor = System.Drawing.Color.Black;
            this.lblViewReport.Location = new System.Drawing.Point(294, 301);
            this.lblViewReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewReport.Name = "lblViewReport";
            this.lblViewReport.Size = new System.Drawing.Size(190, 37);
            this.lblViewReport.TabIndex = 3;
            this.lblViewReport.Text = "View Report";
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.Black;
            this.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewReport.FlatAppearance.BorderSize = 2;
            this.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.ForeColor = System.Drawing.Color.White;
            this.btnViewReport.Location = new System.Drawing.Point(575, 336);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(159, 62);
            this.btnViewReport.TabIndex = 8;
            this.btnViewReport.Text = "VIEW";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // txtViewReport
            // 
            this.txtViewReport.BackColor = System.Drawing.Color.White;
            this.txtViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewReport.ForeColor = System.Drawing.Color.Black;
            this.txtViewReport.Location = new System.Drawing.Point(233, 342);
            this.txtViewReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViewReport.Multiline = true;
            this.txtViewReport.Name = "txtViewReport";
            this.txtViewReport.Size = new System.Drawing.Size(308, 54);
            this.txtViewReport.TabIndex = 7;
            this.txtViewReport.TextChanged += new System.EventHandler(this.txtViewReport_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 872);
            this.splitter1.TabIndex = 47;
            this.splitter1.TabStop = false;
            // 
            // dtpGenerateDate
            // 
            this.dtpGenerateDate.Location = new System.Drawing.Point(37, 431);
            this.dtpGenerateDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpGenerateDate.Name = "dtpGenerateDate";
            this.dtpGenerateDate.Size = new System.Drawing.Size(350, 31);
            this.dtpGenerateDate.TabIndex = 2;
            this.dtpGenerateDate.ValueChanged += new System.EventHandler(this.dtpGenerateDate_ValueChanged);
            // 
            // lblGenerateReport
            // 
            this.lblGenerateReport.AutoSize = true;
            this.lblGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateReport.ForeColor = System.Drawing.Color.White;
            this.lblGenerateReport.Location = new System.Drawing.Point(31, 395);
            this.lblGenerateReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerateReport.Name = "lblGenerateReport";
            this.lblGenerateReport.Size = new System.Drawing.Size(216, 32);
            this.lblGenerateReport.TabIndex = 53;
            this.lblGenerateReport.Text = "Generated Date";
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.AutoSize = true;
            this.lblReportDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportDescription.ForeColor = System.Drawing.Color.White;
            this.lblReportDescription.Location = new System.Drawing.Point(31, 692);
            this.lblReportDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(249, 32);
            this.lblReportDescription.TabIndex = 53;
            this.lblReportDescription.Text = "Report Description";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(31, 506);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(199, 32);
            this.lblTotalRevenue.TabIndex = 53;
            this.lblTotalRevenue.Text = "Total Revenue";
            // 
            // txtReportDescription
            // 
            this.txtReportDescription.BackColor = System.Drawing.Color.White;
            this.txtReportDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportDescription.ForeColor = System.Drawing.Color.Black;
            this.txtReportDescription.Location = new System.Drawing.Point(37, 729);
            this.txtReportDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReportDescription.Multiline = true;
            this.txtReportDescription.Name = "txtReportDescription";
            this.txtReportDescription.Size = new System.Drawing.Size(308, 49);
            this.txtReportDescription.TabIndex = 5;
            this.txtReportDescription.TextChanged += new System.EventHandler(this.txtReportDescription_TextChanged);
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.BackColor = System.Drawing.Color.White;
            this.txtTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.txtTotalRevenue.Location = new System.Drawing.Point(37, 542);
            this.txtTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalRevenue.Multiline = true;
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(308, 49);
            this.txtTotalRevenue.TabIndex = 3;
            this.txtTotalRevenue.TextChanged += new System.EventHandler(this.txtTotalRevenue_TextChanged);
            // 
            // lblReportID
            // 
            this.lblReportID.AutoSize = true;
            this.lblReportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportID.ForeColor = System.Drawing.Color.White;
            this.lblReportID.Location = new System.Drawing.Point(24, 191);
            this.lblReportID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportID.Name = "lblReportID";
            this.lblReportID.Size = new System.Drawing.Size(133, 32);
            this.lblReportID.TabIndex = 53;
            this.lblReportID.Text = "Report ID";
            // 
            // txtReportID
            // 
            this.txtReportID.BackColor = System.Drawing.Color.White;
            this.txtReportID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportID.ForeColor = System.Drawing.Color.Black;
            this.txtReportID.Location = new System.Drawing.Point(30, 227);
            this.txtReportID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReportID.Multiline = true;
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.Size = new System.Drawing.Size(308, 49);
            this.txtReportID.TabIndex = 1;
            this.txtReportID.TextChanged += new System.EventHandler(this.txtReportID_TextChanged);
            // 
            // btnAddReport
            // 
            this.btnAddReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddReport.FlatAppearance.BorderSize = 0;
            this.btnAddReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddReport.Location = new System.Drawing.Point(100, 811);
            this.btnAddReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(148, 55);
            this.btnAddReport.TabIndex = 6;
            this.btnAddReport.Text = "ADD";
            this.btnAddReport.UseVisualStyleBackColor = false;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-84, 409);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-84, 281);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnTotalRevenue);
            this.panel1.Controls.Add(this.lblReportName);
            this.panel1.Controls.Add(this.txtReportName);
            this.panel1.Controls.Add(this.dtpGenerateDate);
            this.panel1.Controls.Add(this.lblGenerateReport);
            this.panel1.Controls.Add(this.lblReportDescription);
            this.panel1.Controls.Add(this.lblTotalRevenue);
            this.panel1.Controls.Add(this.txtReportDescription);
            this.panel1.Controls.Add(this.txtTotalRevenue);
            this.panel1.Controls.Add(this.lblReportID);
            this.panel1.Controls.Add(this.txtReportID);
            this.panel1.Controls.Add(this.btnAddReport);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 872);
            this.panel1.TabIndex = 62;
            // 
            // btnTotalRevenue
            // 
            this.btnTotalRevenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTotalRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalRevenue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTotalRevenue.FlatAppearance.BorderSize = 0;
            this.btnTotalRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalRevenue.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRevenue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTotalRevenue.Location = new System.Drawing.Point(37, 618);
            this.btnTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotalRevenue.Name = "btnTotalRevenue";
            this.btnTotalRevenue.Size = new System.Drawing.Size(308, 55);
            this.btnTotalRevenue.TabIndex = 56;
            this.btnTotalRevenue.Text = "TOTAL REVENUE";
            this.btnTotalRevenue.UseVisualStyleBackColor = false;
            this.btnTotalRevenue.Click += new System.EventHandler(this.btnTotalRevenue_Click);
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.ForeColor = System.Drawing.Color.White;
            this.lblReportName.Location = new System.Drawing.Point(31, 286);
            this.lblReportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(181, 32);
            this.lblReportName.TabIndex = 55;
            this.lblReportName.Text = "Report Name";
            // 
            // txtReportName
            // 
            this.txtReportName.BackColor = System.Drawing.Color.White;
            this.txtReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportName.ForeColor = System.Drawing.Color.Black;
            this.txtReportName.Location = new System.Drawing.Point(30, 323);
            this.txtReportName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReportName.Multiline = true;
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(308, 49);
            this.txtReportName.TabIndex = 54;
            this.txtReportName.TextChanged += new System.EventHandler(this.txtReportName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvViewReport);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Controls.Add(this.picbgLogo);
            this.panel2.Controls.Add(this.btnViewReport);
            this.panel2.Controls.Add(this.lblReportNamee);
            this.panel2.Controls.Add(this.txtViewReport);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblViewReport);
            this.panel2.Location = new System.Drawing.Point(388, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 872);
            this.panel2.TabIndex = 64;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvViewReport
            // 
            this.dgvViewReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewReport.Location = new System.Drawing.Point(31, 446);
            this.dgvViewReport.Name = "dgvViewReport";
            this.dgvViewReport.RowHeadersWidth = 82;
            this.dgvViewReport.RowTemplate.Height = 33;
            this.dgvViewReport.Size = new System.Drawing.Size(722, 408);
            this.dgvViewReport.TabIndex = 119;
            this.dgvViewReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewReport_CellContentClick);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(334, 28);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 117;
            this.picLogo.TabStop = false;
            // 
            // picbgLogo
            // 
            this.picbgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(27)))), ((int)(((byte)(96)))));
            this.picbgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbgLogo.Location = new System.Drawing.Point(322, 17);
            this.picbgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbgLogo.Name = "picbgLogo";
            this.picbgLogo.Size = new System.Drawing.Size(175, 175);
            this.picbgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbgLogo.TabIndex = 118;
            this.picbgLogo.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 866);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportNamee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblReportIDD;
        private System.Windows.Forms.TextBox txtReportIDD;
        private System.Windows.Forms.Button btnDeleteReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblViewReport;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.TextBox txtViewReport;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DateTimePicker dtpGenerateDate;
        private System.Windows.Forms.Label lblGenerateReport;
        private System.Windows.Forms.Label lblReportDescription;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.TextBox txtReportDescription;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.Label lblReportID;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picbgLogo;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.DataGridView dgvViewReport;
        private System.Windows.Forms.Button btnTotalRevenue;
    }
}