using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Loggers
{
    public interface ILayout
    {
        string Template { get; }
    }
}
