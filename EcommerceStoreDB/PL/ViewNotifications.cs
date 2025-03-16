using System;
using System.Data;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class ViewNotifications : Form
    {
        private string role;
        private string username;
        private NotificationManager notificationManager;

        public ViewNotifications(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;

            notificationManager = new NotificationManager();

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvNotifications.Columns.Clear();

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Notification ID",
                DataPropertyName = "NOTIFICATIONID",
                Name = "ColumnNotificationID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Username",
                DataPropertyName = "USERNAME",
                Name = "ColumnUsername",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Message",
                DataPropertyName = "MESSAGE",
                Name = "ColumnMessage",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Role",
                DataPropertyName = "ROLE",
                Name = "ColumnRole",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "STATUS",
                Name = "ColumnStatus",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Notification Date",
                DataPropertyName = "NOTIFYDATE",
                Name = "ColumnNotifyDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvNotifications.AutoGenerateColumns = false;
        }

        private void LoadNotificationData()
        {
            try
            {
                DataTable dt = notificationManager.GetNotifications(role);
                dgvNotifications.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewNotifications_Load(object sender, EventArgs e)
        {
            LoadNotificationData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNotifications.Columns[e.ColumnIndex].Name == "ColumnAction")
            {
                var notificationId = dgvNotifications.Rows[e.RowIndex].Cells["ColumnNotificationID"].Value.ToString();
                UpdateNotificationStatus(notificationId, "COMPLETED");
            }
        }

        private void UpdateNotificationStatus(string notificationId, string newStatus)
        {
            try
            {
                if (notificationManager.UpdateNotificationStatus(notificationId, newStatus))
                {
                    MessageBox.Show("Notification status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNotificationData();
                }
                else
                {
                    MessageBox.Show("Failed to update notification status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
