using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;

namespace EcommerceStoreDB
{
    public partial class GenerateInvoice : Form
    {
        private String role;
        private String username;
        private Database db;
        public GenerateInvoice(string role, string username)
        {
            InitializeComponent();
            cmbPaymentMethod.Items.Add("Credit Card");
            cmbPaymentMethod.Items.Add("Debit Card");
            cmbPaymentMethod.Items.Add("Cash On Delivery");
            this.role = role;
            this.username = username;
            db = new Database();
        }





        private void LoadInvoiceData()
        {
            try
            {
                Database db = new Database();
                using (OracleConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT INVOICEDATE, USERNAME, SHIPPINGADDRESS, BILLINGADDRESS, CONTACT, PAYMENTMETHOD, DISCOUNT, SHIPPING, TAX, TOTAL FROM Invoice";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            dgvInvoice.Rows.Clear();
                            while (reader.Read())
                            {
                                object[] row = new object[10];
                                row[0] = reader["INVOICEDATE"];
                                row[1] = reader["USERNAME"];
                                row[2] = reader["SHIPPINGADDRESS"];
                                row[3] = reader["BILLINGADDRESS"];
                                row[4] = reader["CONTACT"];
                                row[5] = reader["PAYMENTMETHOD"];
                                row[6] = reader["DISCOUNT"];
                                row[7] = reader["SHIPPING"];
                                row[8] = reader["TAX"];
                                row[9] = reader["TOTAL"];
                                dgvInvoice.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoice data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetDiscountPercentage(string paymentMethod)
        {
            decimal discountPercentage = 0;

            switch (paymentMethod)
            {
                case "Credit Card":
                    discountPercentage = 20.00M;
                    break;
                case "Debit Card":
                    discountPercentage = 15.00M;
                    break;
                case "Cash On Delivery":
                    discountPercentage = 10.00M;
                    break;
                default:
                    break;
            }

            return discountPercentage;
        }

        private decimal CalculateTax(decimal subtotal)
        {
            return subtotal * 0.05M;
        }

        private decimal CalculateTotal(decimal subtotal, decimal discountAmount)
        {
            decimal tax = CalculateTax(subtotal);
            return subtotal - discountAmount + 5 + tax;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPaymentMethod = cmbPaymentMethod.SelectedItem?.ToString();

            decimal productPrice = GetProductPrice(txtProductName.Text);

            decimal quantity = 1;

            decimal subtotal = productPrice * quantity;

            decimal discountPercentage = 0;
            if (selectedPaymentMethod != null)
            {
                discountPercentage = GetDiscountPercentage(selectedPaymentMethod);
            }

            decimal discountAmount = subtotal * discountPercentage / 100;
            decimal shippingAmount = 5.00M;
            decimal taxAmount = CalculateTax(subtotal);
            decimal totalAmount = CalculateTotal(subtotal, discountAmount, shippingAmount, taxAmount);
            lblDiscountt.Text = $"${discountAmount:F2}";
            lblShippingg.Text = $"${shippingAmount:F2}";
            lblTaxx.Text = $"${taxAmount:F2}";
            lblPrice.Text = $"${totalAmount:F2}";
        }

        private decimal CalculateTotal(decimal subtotal, decimal discountAmount, decimal shippingAmount, decimal taxAmount)
        {
            return subtotal - discountAmount + shippingAmount + taxAmount;
        }




        private void GenerateInvoice_Load(object sender, EventArgs e)
        {
            decimal defaultDiscountAmount = 10.00M;
            decimal shippingAmount = 5.00M;
            decimal subtotal = shippingAmount + defaultDiscountAmount;
            decimal taxAmount = CalculateTax(subtotal);
            decimal totalAmount = CalculateTotal(subtotal, defaultDiscountAmount);

            lblShippingg.Text = $"${shippingAmount:F2}";
            lblDiscountt.Text = $"${defaultDiscountAmount:F2}";
            lblTaxx.Text = $"${taxAmount:F2}";
            lblPrice.Text = $"${totalAmount:F2}";


            dgvInvoice.Columns.Clear();
            dgvInvoice.Columns.Add("InvoiceDate", "Invoice Date");
            dgvInvoice.Columns.Add("Username", "Username");
            dgvInvoice.Columns.Add("ShippingAddress", "Shipping Address");
            dgvInvoice.Columns.Add("BillingAddress", "Billing Address");
            dgvInvoice.Columns.Add("Contact", "Contact");
            dgvInvoice.Columns.Add("PaymentMethod", "Payment Method");
            dgvInvoice.Columns.Add("Discount", "Discount");
            dgvInvoice.Columns.Add("Shipping", "Shipping");
            dgvInvoice.Columns.Add("Tax", "Tax");
            dgvInvoice.Columns.Add("Total", "Total");

            LoadInvoiceData();
        }






        private void dtpInvoice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShippingAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillingAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDiscountt_Click(object sender, EventArgs e)
        {

        }

        private void lblShippingg_Click(object sender, EventArgs e)
        {

        }

        private void lblTaxx_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtShippingAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtBillingAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtContact.Text) ||
                    cmbPaymentMethod.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();
                if (paymentMethod != "Credit Card" && paymentMethod != "Debit Card" && paymentMethod != "Cash On Delivery")
                {
                    MessageBox.Show("Please select a valid payment method.", "Payment Method Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Database db = new Database();
                using (OracleConnection conn = db.GetConnection())
                {
                    conn.Open();
                    decimal discountPercentage = GetDiscountPercentage(paymentMethod);

                    decimal subtotal = Convert.ToDecimal(lblShippingg.Text.Replace("$", "").Trim()) + Convert.ToDecimal(lblDiscountt.Text.Replace("$", "").Trim());
                    decimal discountAmount = subtotal * discountPercentage / 100;

                    decimal shippingAmount = 5.00M;
                    decimal taxAmount = CalculateTax(subtotal);
                    decimal totalAmount = CalculateTotal(subtotal, discountAmount, shippingAmount, taxAmount);

                    string query = @"
        INSERT INTO Invoice (INVOICEDATE, USERNAME, SHIPPINGADDRESS, BILLINGADDRESS, CONTACT, PAYMENTMETHOD, DISCOUNT, SHIPPING, TAX, TOTAL)
        VALUES (:InvoiceDate, :Username, :ShippingAddress, :BillingAddress, :Contact, :PaymentMethod, :Discount, :Shipping, :Tax, :Total)";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(":InvoiceDate", dtpInvoice.Value);
                        cmd.Parameters.Add(":Username", txtUsername.Text);
                        cmd.Parameters.Add(":ShippingAddress", txtShippingAddress.Text);
                        cmd.Parameters.Add(":BillingAddress", txtBillingAddress.Text);
                        cmd.Parameters.Add(":Contact", txtContact.Text);
                        cmd.Parameters.Add(":PaymentMethod", paymentMethod);
                        cmd.Parameters.Add(":Discount", discountAmount);
                        cmd.Parameters.Add(":Shipping", shippingAmount);
                        cmd.Parameters.Add(":Tax", taxAmount);
                        cmd.Parameters.Add(":Total", totalAmount);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInvoiceData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            CashierPortal cashierPortal = new CashierPortal(role, username);
            this.Hide();
            cashierPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private decimal GetProductPrice(string productName)
        {
            decimal productPrice = 0;

            Database db = new Database();
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT PRICE FROM PRODUCTS WHERE NAME = :ProductName";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":ProductName", OracleDbType.Varchar2).Value = productName;

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["PRICE"] != DBNull.Value)
                            {
                                productPrice = reader.GetDecimal(reader.GetOrdinal("PRICE"));
                            }
                            else
                            {
                                MessageBox.Show("Price is null for the given product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            return productPrice;
        }





        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            // ExportToPDF();
            // GenerateInvoicePdf();

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Invoice as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        PdfDocument pdfDoc = new PdfDocument(new PdfWriter(fs));
                        Document document = new Document(pdfDoc);

                        document.Add(new Paragraph("Invoice Report")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20));

                        string[] columnHeaders = new string[]
                        {
                    "INVOICEID", "INVOICEDATE", "USERNAME", "SHIPPINGADDRESS", "BILLINGADDRESS",
                    "CONTACT", "PAYMENTMETHOD", "DISCOUNT", "SHIPPING", "TAX", "TOTAL"
                        };

                        float[] columnWidths = new float[columnHeaders.Length];
                        for (int i = 0; i < columnHeaders.Length; i++)
                        {
                            columnWidths[i] = 1;
                        }

                        Table pdfTable = new Table(columnWidths);

                        foreach (string header in columnHeaders)
                        {
                            pdfTable.AddHeaderCell(new Paragraph(header)
                                .SetTextAlignment(TextAlignment.CENTER));

                        }

                        if (dgvInvoice.Rows.Count == 0)
                        {
                            MessageBox.Show("No data available in the DataGridView to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        foreach (DataGridViewRow row in dgvInvoice.Rows)
                        {
                            if (row.IsNewRow) continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                var cellValue = cell.Value?.ToString() ?? string.Empty;

                                pdfTable.AddCell(new Paragraph(cellValue)
                                    .SetTextAlignment(TextAlignment.CENTER));
                            }
                        }

                        document.Add(pdfTable);
                        document.Close();
                    }

                    MessageBox.Show("Invoice PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExportToPDF()
        {
            try
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

                if (!Directory.Exists(downloadsPath))
                {
                    Directory.CreateDirectory(downloadsPath);
                }

                string filePath = Path.Combine(downloadsPath, "Invoice.pdf");

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    document.Add(new Paragraph("Invoice Report").SetTextAlignment(TextAlignment.CENTER).SetFontSize(18));

                    Table table = new Table(dgvInvoice.ColumnCount);

                    foreach (DataGridViewColumn column in dgvInvoice.Columns)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
                    }

                    foreach (DataGridViewRow row in dgvInvoice.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? string.Empty)));
                        }
                    }

                    document.Add(table);
                }

                MessageBox.Show("Invoice exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GenerateInvoicePdf()
        {
            try
            {
                string pdfFilePath = "/Desktop/Invoices/Invoice" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";


                using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
                {
                    using (PdfDocument pdfDoc = new PdfDocument(new PdfWriter(fs)))
                    {
                        Document document = new Document(pdfDoc);

                        document.Add(new Paragraph("Invoice")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20));


                        document.Add(new Paragraph("\n"));

                        float[] columnWidths = new float[] { 10, 10, 20, 20, 10, 10, 10, 10, 10, 10 };

                        Table table = new Table(columnWidths);

                        table.AddHeaderCell("Invoice Date");
                        table.AddHeaderCell("Username");
                        table.AddHeaderCell("Shipping Address");
                        table.AddHeaderCell("Billing Address");
                        table.AddHeaderCell("Contact");
                        table.AddHeaderCell("Payment Method");
                        table.AddHeaderCell("Discount");
                        table.AddHeaderCell("Shipping");
                        table.AddHeaderCell("Tax");
                        table.AddHeaderCell("Total");

                        foreach (DataGridViewRow row in dgvInvoice.Rows)
                        {
                            if (row.IsNewRow) continue;

                            table.AddCell(row.Cells["InvoiceDate"].Value?.ToString());
                            table.AddCell(row.Cells["Username"].Value?.ToString());
                            table.AddCell(row.Cells["ShippingAddress"].Value?.ToString());
                            table.AddCell(row.Cells["BillingAddress"].Value?.ToString());
                            table.AddCell(row.Cells["Contact"].Value?.ToString());
                            table.AddCell(row.Cells["PaymentMethod"].Value?.ToString());
                            table.AddCell(row.Cells["Discount"].Value?.ToString());
                            table.AddCell(row.Cells["Shipping"].Value?.ToString());
                            table.AddCell(row.Cells["Tax"].Value?.ToString());
                            table.AddCell(row.Cells["Total"].Value?.ToString());
                        }

                        document.Add(table);

                        document.Add(new Paragraph("\nThank you for your purchase!"));

                        document.Close();
                    }
                }

                MessageBox.Show("Invoice PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}