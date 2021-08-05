namespace Services.Models.Data
{

public class Tide
{

        public string disclaimer {get;set;}
        public string status {get;set;}
        public long latitude {get;set;}
        public long longitude {get;set;}
        public origin origin {get;set;}
        public datums datums {get;set;}
        public long timestamp {get;set;}
        public string datetime {get;set;}
        public string unit {get;set;}
        public string timezone {get;set;}
        public string datum {get;set;}
        public extreme[] extremes {get;set;}
        public height[] heights {get;set;}
        public string copyright {get;set;}
        }
}