using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnAboutStatesWebAPI.Models;

namespace LearnAboutStatesWebAPI.Controllers
{
    public class StatesController : ApiController
    {
        private State[] states = new State[]
        {
            new State
            {
                Code = "CA",
                Description = "California State",
                MapUri = @"http://en.wikipedia.org/wiki/California",
                Name = "California"
            },
            new State()
            {
                Code = "WA",
                Description = "Washington State",
                MapUri = @"http://en.wikipedia.org/wiki/Washington_(state)",
                Name = "Washington"
            }
        };

        public IEnumerable<State> GetAllStates()
        {
            return states;
        }

        public IHttpActionResult GetState(string code)
        {
            var state = states.FirstOrDefault((s) => s.Code == code);
            if (state == null)
            {
                return NotFound();
            }
            return Ok(state);
        }

    }
}
