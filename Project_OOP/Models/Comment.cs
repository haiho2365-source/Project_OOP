using System;

namespace Project_OOP
{
    [Serializable]
    public class Comment
    {
        private string _content;
        private Person _author;
        private DateTime _timestamp;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public Person Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public Comment()
        {
            _timestamp = DateTime.Now;
        }

        public Comment(string content, Person author)
        {
            _content = content;
            _author = author;
            _timestamp = DateTime.Now;
        }
    }
}
