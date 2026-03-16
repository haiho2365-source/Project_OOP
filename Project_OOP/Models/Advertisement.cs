using System;

namespace Project_OOP
{
    public class Advertisement
    {
        private string _sponsorName;
        private string _content;

        public string SponsorName { get; set; }
        public string Content { get; set; }

        public Advertisement()
        {
        }

        public Advertisement(string sponsorName, string content)
        {
            SponsorName = sponsorName;
            Content = content;
        }

        public string ShowAd()
        {
            return $"Advertisement" +
                $"\nSponsor: {SponsorName}" +
                $"\nContent: {Content}";
        }
    }
}