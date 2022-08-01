using Microsoft.AspNetCore.Mvc;
using TestApplicationApi.Data;
using TestApplicationApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApplicationApi.Controllers
{
    
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DbHelper _db;

        
        public TestController(EF_DataContext eF_DataContext)
        {
            _db=new DbHelper(eF_DataContext);
        }
        // GET: api/<TestController>
        [HttpGet]
        [Route("api/[controller]/GetContacts")]
        public IActionResult Get()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<ContactModel>data=_db.GetContacts();
                
                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }

                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET api/<TestController>/5
        [HttpGet]
        [Route("api/[controller]/GetContactByEmail{email}")]
        public IActionResult Get(string email)
        {
            ResponseType type = ResponseType.Success;
            try
            {
                ContactModel data = _db.GetContactByEmail(email);

                if (data==null)
                {
                    type = ResponseType.NotFound;
                }

                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // POST api/<TestController>
        [HttpPost]
        [Route("api/[controller]/SaveContact")]
        public IActionResult Post([FromBody] ContactModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveContact(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch(Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/<TestController>/5
        [HttpPut]
        [Route("api/[controller]/UpdateContact")]
        public IActionResult Put( [FromBody] ContactModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveContact(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<TestController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteContact{email}")]
        public IActionResult Delete(string email)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.DeleteContact(email);   
                return Ok(ResponseHandler.GetAppResponse(type, "Delete Successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }
    }
}
