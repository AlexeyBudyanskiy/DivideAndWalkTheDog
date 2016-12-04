using System;
using System.Collections.Generic;
using System.Threading;

namespace SmartCollar
{
    public class Program
    {
        public static List<Coord> CoordsList = new List<Coord>();
        public static void Main(string[] args)
        {
            CoordsInitializer.Initialize(CoordsList);

            for (var i = 0; i < CoordsList.Count; i++)
            {
                RequestBuilder.SendCoords(CoordsList[i]);
                Thread.Sleep(5000);

                if (i == CoordsList.Count - 1)
                {
                    i = 0;
                }
            }
                
            Console.ReadLine();
        }       
    }
}
