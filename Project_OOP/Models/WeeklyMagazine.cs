using Project_OOP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    [Serializable]
    public class WeeklyMagazine : Publication
    {
        private string _author;
        private List<string> _references;
        public List<string> References
        {
            get
            {
                return this._references;
            }
            set
            {
                if (value != null)
                {
                    this._references = value;
                }
            }
        }
        public WeeklyMagazine() : base()
        {
            this._references = new List<string>();
        }

        public WeeklyMagazine(string id, string title, DateTime publishDate, string author)
            : base(id, title, publishDate)
        {
            this._author = author;
            this._references = new List<string>();
        }

        public string Author
        {
            get { return _author; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this._author = value;
                }
            }
        }

        public void AddReference(string link)
        {
            this.References.Add(link);
        }

        public override void DisplayContent()
        {
            Console.WriteLine("--- WEEKLY MAGAZINE ---");
            Console.WriteLine("Tiêu đề: " + Title);
            Console.WriteLine("Tác giả: " + Author);
            Console.WriteLine("Nguồn tham khảo:");

            for (int i = 0; i < References.Count; i++)
            {
                Console.WriteLine(" + " + References[i]);
            }
        }
    }
}
