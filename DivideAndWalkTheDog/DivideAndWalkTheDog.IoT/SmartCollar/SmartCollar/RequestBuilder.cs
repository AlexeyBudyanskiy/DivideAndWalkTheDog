using System;
using System.IO;
using System.Net;

namespace SmartCollar
{
    public static class RequestBuilder
    {
        public static void SendCoords(Coord coord)
        {
            var request = WebRequest.Create($"http://localhost:42598/collar/setCoords?x={coord.X}&y={coord.Y}");
            var response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            response.Close();
            Console.WriteLine($"Successfull request. Coords: x={coord.X}&y={coord.Y}");
        }
    }
}
