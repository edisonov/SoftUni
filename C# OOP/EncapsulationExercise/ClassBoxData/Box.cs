using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Lenght 
        {
            get => this.lenght;

            private set
            {
                this.ThrowIfInvalidSide(value, nameof(Lenght));
                this.lenght = value;
            }
        }

        public double Width 
        {
            get => this.width;

            private set
            {
                this.ThrowIfInvalidSide(value, nameof(Width));
                this.width = value;
            }
        }

        public double Height 
        {
            get => this.height;

            private set
            {
                this.ThrowIfInvalidSide(value, nameof(Height    ));
                this.height = value;
            }
        }

        public double GetSurfaceArea()
        {
            return 2 * this.Lenght * this.Width + 
                2 * this.Lenght * this.Height + 
                2 * this.Width * this.Height;
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * this.Lenght * this.Height) + (2 * this.Width * this.Height);
        }

        public double GetVolume()
        {
            return this.Height * this.Lenght * this.Width;  
        }

        private void ThrowIfInvalidSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new AggregateException($"{side} cannot be zero or negative.");
            }
        }
    }
}
