using Microsoft.AspNetCore.Mvc;
using TestApplicationApi.Data;
using TestApplicationApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApplicationApi.Controllers
{
    
    [ApiController]
    public class TestIncidentController : ControllerBase
    {
        private readonly DbHelper _db;


        public TestIncidentController(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);
        }
        // GET: api/<TestIncidentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestIncidentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestIncidentController>
        [HttpPost]
        [Route("api/[controller]/SaveIncident")]
        public IActionResult Post([FromBody] IncidentModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveIncident(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/<TestIncidentController>/5
        [HttpPut]
        [Route("api/[controller]/Incident")]
        public IActionResult Put([FromBody] IncidentModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveIncident(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<TestIncidentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
