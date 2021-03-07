using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawObjects = new List<IDrawable>();

            drawObjects.Add(new Rectangle(6, 4));
            drawObjects.Add(new Circle(5));

            foreach (var item in drawObjects)
            {
                item.Draw();
            }


        }
    }
}
