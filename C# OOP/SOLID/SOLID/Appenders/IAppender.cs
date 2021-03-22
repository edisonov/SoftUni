using SOLID.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appenders
{
    public interface IAppender
    { 
        ReportLevel ReportLevel { get; set; }
        void Appedn(string date, ReportLevel reportLevel, string message);
    }
}
