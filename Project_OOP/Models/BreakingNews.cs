using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    [Serializable]
    public class BreakingNews : DailyNews
    {
        private bool _isConfirmed;

        public BreakingNews() : base() { }

        public BreakingNews(string id, string title, DateTime publishDate, int trendLevel)
            : base(id, title, publishDate, trendLevel)
        {
            this._isConfirmed = false;
        }

        public void Confirm()
        {
            IsConfirmed = true;
        }
        public bool IsConfirmed
        {
            get
            {
                return this._isConfirmed;
            }
            set
            {
                this._isConfirmed = value;
            }
        }

        public override void DisplayContent()
        {
            Console.WriteLine("********************");
            Console.WriteLine("TIN KHẨN CẤP");
            if (IsConfirmed)
            {
                Console.WriteLine("Trạng thái: Đã xác thực");
            }

            base.DisplayContent();
        }
    }
}
