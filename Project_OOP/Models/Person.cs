using System;

namespace Project_OOP
{
    [Serializable] 
    public abstract class Person
    {
        protected string _id;
        protected string _fullName;
        protected string _email;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Person()
        {
        }
        public Person(string id, string fullName, string email)
        {
            this._id = id;
            this._fullName = fullName;
            this._email = email;
        }
        public abstract void ShowInfo();
    }
}
