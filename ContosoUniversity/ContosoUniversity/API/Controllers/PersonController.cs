// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using ContosoUniversity.Models;

namespace ContosoUniversity.API.Controllers
{
    [Route( "api/person" )]
    public class PersonController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> Get( )
        {
            return new Person[] { new Person( ) };
        }

        //atd. ..

        // GET api/values/5
        //[HttpGet( "{id}" )]
        //public string Get( int id )
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post( [FromBody]string value )
        //{
        //}

        //// PUT api/values/5
        //[HttpPut( "{id}" )]
        //public void Put( int id, [FromBody]string value )
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete( "{id}" )]
        //public void Delete( int id )
        //{
        //}
    }
}
