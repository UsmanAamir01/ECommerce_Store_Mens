using System.Data;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class NotificationManager
    {
        private readonly NotificationRepository repository;

        public NotificationManager()
        {
            repository = new NotificationRepository();
        }

        public DataTable GetNotifications(string role)
        {
            return repository.GetNotificationsByRole(role);
        }

        public bool UpdateNotificationStatus(string notificationId, string newStatus)
        {
            return repository.UpdateNotificationStatus(notificationId, newStatus);
        }
    }
}
