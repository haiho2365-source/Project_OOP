using System;

namespace Project_OOP
{
    public class EmailService : INotificationService
    {
        public void SendNotification(Person recipient, string message)
        {
            string userEmail = recipient.Email;

            string formattedMessage = "[Email] Đang gửi thư tới: " + userEmail + " | Nội dung: " + message;
            Console.WriteLine(formattedMessage);
        }
    }
}