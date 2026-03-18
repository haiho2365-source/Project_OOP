using Project_OOP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    [Serializable]
    public class DailyNews : Publication
    {
        private int _trendLevel;

        public DailyNews() : base() { }

        public DailyNews(string id, string title, DateTime publishDate, int trendLevel)
            : base(id, title, publishDate)
        {
            this._trendLevel = trendLevel;
        }

        public int TrendLevel
        {
            get { return _trendLevel; }
            set 
            {
                if (value >= 0)
                {
                    this._trendLevel = value;
                }
                else
                {
                    Console.WriteLine("TrendLevel không hợp lệ!");
                }
            }
        }

        public override void DisplayContent()
        {
            string summary = Title;
            if (Title.Length > 50)
            {
                summary = Title.Substring(0, 50);
            }

            Console.WriteLine("--- DAILY NEWS ---");
            Console.WriteLine("Tiêu đề: " + summary);
            Console.WriteLine("Trend: " + TrendLevel);
        }
    }
}
