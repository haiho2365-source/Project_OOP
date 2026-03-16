using System;

namespace Project_OOP
{
    [Serializable]
    public class Comment
    {
        private string _content;
        private Person _author;
        private DateTime _timestamp;

        public string Content { get; set; }
        public Person Author { get; set; }
        public DateTime Timestamp { get; set; }

        public Comment()
        {
            Timestamp = DateTime.Now;
        }

        public Comment(string content, Person author)
        {
            Content = content;
            Author = author;
            Timestamp = DateTime.Now;
        }
    }
}