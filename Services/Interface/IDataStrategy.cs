using System.Collections.Generic;

namespace Services.Interface
{
    public interface IDataStrategy
    {
        public string GetData(Dictionary<string,string> parameters);
    }
}