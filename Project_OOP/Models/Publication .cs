using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Project_Desktop
{
    [Serializable]
    public abstract class Publication
    {
        protected string _id;
        protected string _title;
        protected DateTime _publishDate;
        protected int _viewCount = 0;
        protected bool _isApproved;
        protected DateTime _airTime = DateTime.Now;
        protected string _content;
        protected string _videoUrl;
        public Publication()
        {
            this._isApproved = false;
        }

        public Publication(string id, string title, DateTime publishDate)
        {
            this._id = id;
            this._title = title;
            this._publishDate = publishDate;
           
        }

        public string Id
        {
            get { return this._id; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                   this._id = value;
                }
            }
        }

        public string Title
        {
            get { return this._title; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this._title = value;
                }
            }
        }

        public DateTime PublishDate
        {
            get { return this._publishDate; }
            set
            {
                if (value <= DateTime.Now)
                {
                    this._publishDate = value;
                }
            }
        }

        public bool IsApproved
        {
            get { return this._isApproved; }
            set { this._isApproved = value; }
        }
        public int ViewCount
        {
            get { return this._viewCount; }
        }

        public DateTime AirTime
        { 
            get { return this._airTime; } 
            set { this._airTime = value; }
        }

        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        public string VideoUrl
        {
            get { return this._videoUrl; }
            set { this._videoUrl = value; }
        }


        public void IncrementView()
        {
            this._viewCount++;
        }

        public abstract void DisplayContent();
    }
}
