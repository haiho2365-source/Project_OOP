using System;

namespace Project_OOP
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(Person recipient, string message)
        {
            string userEmail = recipient.Email;

            string formattedMessage = "[Popup] Hiển thị trên màn hình của: " + userEmail + " | Nội dung: " + message;
            Console.WriteLine(formattedMessage);
        }
    }
}