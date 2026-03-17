using System;

namespace Project_OOP
{
    [Serializable]
    public class Guest : Person
    {
        private string _sessionId;
        public Guest() : base() 
        { 
        }
        public Guest(string sessionId)
            : base("GUEST_ID", "Ẩn danh", "No Email")
        {
            this._sessionId = sessionId;
        }
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine("[KHÁCH TRUY CẬP]");
            string displaySession = "Mã phiên làm việc (Session): " + this.SessionId;
            Console.WriteLine(displaySession);
            Console.WriteLine("Trạng thái: " + this.FullName);
            Console.WriteLine("-------------------------");
        }
    }
}
