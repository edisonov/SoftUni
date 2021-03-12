using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        private double height;
        private double width;
        private double radius;

        public Shape(double height, double width, double radius)
        {
            this.height = height;
            this.width = width;
            this.radius = radius;
        }

        public double Height
        {
            get => this.height;
            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get => this.width;
            set
            {
                this.width = value;
            }
        }

        public double Radius
        {
            get => this.radius;
            private set
            {
                this.radius = value;
            }
        }
        public double CalculatePerimeter(double height, double width)
        {
            return height * width;
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public virtual string Draw(Rectangle rectangle, Circle circle)
        {
            return 
        }
    }
}
