using System;

namespace Project_OOP
{
    [Serializable]
    public class Guest : Person
    {
        private string _sessionId;
        public string SessionId
        {
            get { return _sessionId; }
            set { _sessionId = value; }
        }
        public Guest() : base() 
        { 
        }
        public Guest(string sessionId)
            : base("GUEST_ID", "Ẩn danh", "No Email")
        {
            this._sessionId = sessionId;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("[KHÁCH TRUY CẬP]");
            Console.WriteLine("Mã phiên làm việc (Session): " + this.SessionId);
            Console.WriteLine("Trạng thái: " + this.FullName); // Lấy từ lớp cha
            Console.WriteLine("-------------------------");
        }
    }
}
