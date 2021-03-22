using SOLID.Appenders;
using SOLID.Core.Facturies;
using SOLID.Enums;
using SOLID.Layouts;
using SOLID.Loggers;
using System;
using System.Collections.Generic;

namespace SOLID
{
    public class StartUp
    {
        private static IAppenderFactory appenderFactory;
        private static ILayoutFactory layoutFactory;

        public static void Main(string[] args)
        {
            

            appenderFactory = new AppenderFactory();
            layoutFactory = new LayoutFactory();

            int n = int.Parse(Console.ReadLine());

            IAppender[] appenders = ReadAppenders(n);

            ILogger logger = new Logger();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);
                ReportLevel reportLevel = Enum.Parse<ReportLevel>(parts[0], true);
                string date = parts[1];
                string message = parts[2];

                switch (reportLevel)
                {
                    case ReportLevel.Info:
                        logger.Info(date, message);
                        break;
                    case ReportLevel.Warning:
                        logger.Warning(date, message);
                        break;
                    case ReportLevel.Error:
                        logger.Error(date, message);
                        break;
                    case ReportLevel.Critical:
                        logger.Critical(date, message);
                        break;
                    case ReportLevel.Fatal:
                        logger.Fatal(date, message);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(logger);
        }

        private static IAppender[] ReadAppenders(int n)
        {
            IAppender[] appenders = new IAppender[n];

            for (int i = 0; i < n; i++)
            {
                string[] appenderParts = Console.ReadLine().Split();

                string appenderType = appenderParts[0];
                string layoutType = appenderParts[1];
                ReportLevel reportLevel =
                    appenderParts.Length == 3 ?
                    Enum.Parse<ReportLevel>(appenderParts[2], true) :
                    ReportLevel.Info;

                ILayout layout = layoutFactory.CreateLayout(layoutType);

                IAppender appender = appenderFactory.CreateAppender(appenderType,
                    layout, reportLevel);

                appenders[i] = appender;
            }

            return appenders;
        }
    }
}
