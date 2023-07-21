using System;

namespace HomeworkAPIsUI.Models
{
    public class FilmsModel
    {
        public string title { get; set; } = "";
        public int episode_id { get; set; }
        public string opening_crawl { get; set; } = string.Empty;
        public string director { get; set; } = string.Empty;
        public string producer { get; set; } = string.Empty;
        public string release_date { get; set; } = string.Empty;
        public string[] characters { get; set; }
        public string[] planets { get; set; }
        public string[] starships { get; set; }
        public string[] vehicles { get; set; }
        public string[] species { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; } = string.Empty;


    }
}
