using SOLID.Enums;
using SOLID.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appenders
{
    public abstract class Appender : IAppender
    {
        protected readonly ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        protected int MessageCount { get; set; }

        public abstract void Appedn(string date, ReportLevel reportLevel, string message);

        protected bool CanAppend(ReportLevel reportLevel)
        {
            return reportLevel >= this.ReportLevel;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}," +
                $" Layout type: {this.layout.GetType().Name}, Report level: {this.ReportLevel}," +
                $" Messages appended: {this.MessageCount}";
        }
    }
}
