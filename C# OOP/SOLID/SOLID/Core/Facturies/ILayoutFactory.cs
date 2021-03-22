using SOLID.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Core.Facturies
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
