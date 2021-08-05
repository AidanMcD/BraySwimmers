using System;
using System.Collections.Generic;
using Services.Interface;

namespace Services.Models
{
    public class SunDataStrategy:IDataStrategy
    {
        public enum State
        {
            Settting,Rising             
        }

        public DateTime Time {get; set;}

        public string GetData(Dictionary<string, string> parameters)
        {
            
        }
    }
}