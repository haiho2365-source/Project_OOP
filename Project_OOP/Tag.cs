using System;

namespace Project_OOP
{
    public class Tag
    {
        private string _tagName;
        private int _clickCount;

        public string TagName { get; set; }
        public int ClickCount { get; set; }

        public Tag()
        {
            ClickCount = 0;
        }

        public Tag(string tagName)
        {
            TagName = tagName;
            ClickCount = 0;
        }

        public void Click()
        {
            ClickCount = ClickCount + 1;
        }
    }
}