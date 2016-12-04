using System.Web.Http;
using System.Web.Mvc;
using DivideAndWalkTheDog.WEB.Models;

namespace DivideAndWalkTheDog.WEB.Controllers
{
    public class CollarController : ApiController
    {
        private static Coord _currentCoord;

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("collar/setCoords")]
        public IHttpActionResult SetCoords(string x, string y)
        {
            if (x == null || y == null)
            {
                return BadRequest();
            }

            var coord = new Coord
            {
                X = x,
                Y = y
            };

            _currentCoord = coord;
            return Ok();
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("collar/getCoords")]
        public IHttpActionResult GetCoords()
        {
            if (_currentCoord != null)
            {
                return Redirect($"https://maps.google.com/?hl=ru&q=loc:{_currentCoord.X},{_currentCoord.Y}");
            }

            return NotFound();
        }
    }
}
