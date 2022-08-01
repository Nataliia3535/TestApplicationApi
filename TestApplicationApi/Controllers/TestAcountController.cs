using Microsoft.AspNetCore.Mvc;
using TestApplicationApi.Data;
using TestApplicationApi.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApplicationApi.Controllers
{
    
    [ApiController]
    public class TestAcountController : ControllerBase
    {
        private readonly DbHelper _db;


        public TestAcountController(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);
        }
        // GET: api/<TestAcountController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestAcountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [Route("api/[controller]/SaveAccount")]
        public IActionResult Post([FromBody] AcountModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveAccount(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/<TestAcountController>/5
        [HttpPut]
        [Route("api/[controller]/UpdateAccount")]
        public IActionResult Put([FromBody] AcountModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveAccount(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<TestAcountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
