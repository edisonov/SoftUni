using SOLID.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Layouts
{
    public class JsonLayout : ILayout
    {
        public string Template => @"""log"": {{
  ""date"": ""{0}"",
  ""level"": ""{1}"",
  ""message"": ""{2}""
}},";
            
        
    }
}
