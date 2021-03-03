using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);

                var SurfaceArea = box.GetSurfaceArea();
                Console.WriteLine($"Surface Area - {SurfaceArea:f2}");

                var LateralSurfaceArea = box.GetLateralSurfaceArea();
                Console.WriteLine($"Lateral Surface Area - {LateralSurfaceArea:f2}");

                var Volume = box.GetVolume();
                Console.WriteLine($"Volume - {Volume:f2}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            
        }
    }
}
