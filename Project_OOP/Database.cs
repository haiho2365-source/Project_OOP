using System;
using System.Collections.Generic;

namespace Project_OOP
{
    [Serializable]
    public class Database
    {
        private List<Subscriber> _subscribers;
        private List<Admin> _admins;

        public Database()
        {
            this._subscribers = new List<Subscriber>();
            this._admins = new List<Admin>();
        }

        public List<Subscriber> Subscribers
        {
            get { return this._subscribers; }
        }

        public List<Admin> Admins
        {
            get { return this._admins; }
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            this._subscribers.Add(subscriber);
        }

        public bool IsEmailExists(string email)
        {
            int i;
            for (i = 0; i < this._subscribers.Count; i = i + 1)
            {
                if (this._subscribers[i].Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}