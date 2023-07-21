using System;

namespace HomeworkAPIsUI.Models
{
    public class PersonModel
    {
        public string name { get; set; } = string.Empty;
        public string height { get; set; } = string.Empty;
        public string mass { get; set; } = string.Empty;
        public string hair_color { get; set; } = string.Empty;
        public string skin_color { get; set; } = string.Empty;
        public string eye_color { get; set; } = string.Empty;
        public string birth_year { get; set; } = string.Empty;
        public string gender { get; set; } = string.Empty;
        public string homeworld { get; set; } = string.Empty;
        public string[] films { get; set; }
        public object[] species { get; set; }
        public string[] vehicles { get; set; }
        public string[] starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; } = string.Empty;

    }
}
