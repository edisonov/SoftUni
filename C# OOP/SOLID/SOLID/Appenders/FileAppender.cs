using SOLID.Enums;
using SOLID.Loggers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.Appenders
{
    public class FileAppender : Appender
    {
        private readonly ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Appedn(string date, ReportLevel reportLevel, string message)
        {
            if (!this.CanAppend(reportLevel))
            {
                return;
            }

            this.MessageCount += 1;

            string content = string.Format(layout.Template, date, reportLevel, message) +
                Environment.NewLine;

            this.logFile.Write(content);
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";

        }
    }
}
