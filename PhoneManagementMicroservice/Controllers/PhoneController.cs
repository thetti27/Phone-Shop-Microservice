using Microsoft.AspNetCore.Mvc;
using PhoneManagementMicroservice.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneManagementMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {

 //Implementation of services
//-------------------------------------------------------------
        private readonly IPhoneService _phoneService;

       public PhoneController(IPhoneService phoneService)
        {
           _phoneService = phoneService??throw new ArgumentNullException(nameof(phoneService));
        }

//-------------------------------------------------------------

        /// <summary>
        /// Get all phone detais
        /// </summary>
        /// <returns>This GET method returns a list of all of the phone details</returns>

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_phoneService.GetPhones()) ;
        }
//-------------------------------------------------------------

        /// <summary>
        /// Get phone by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the phone with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var phone = _phoneService.GetPhone(id);
            return phone != null ? Ok(phone) : NoContent();
        }

//-------------------------------------------------------------

        /// <summary>
        /// Add phones
        /// </summary>
        /// <param name="phone"></param>
        /// <returns>Returns the added phone</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Phone phone)
        {
            return Ok(_phoneService.AddPhone(phone));
        }

//-------------------------------------------------------------       
        /// <summary>
        /// Update the phone
        /// </summary>
        /// <param name="phone"></param>
        /// <returns> Return the updatd phone </returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Phone phone)
        {
            return Ok(_phoneService.UpdatePhone(phone));
        }

//-------------------------------------------------------------

        /// <summary>
        /// Delete the phone with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <return></return>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _phoneService.DeletePhone(id);
            return result.HasValue & result == true ? Ok($"phone with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the student with ID:{id}.");
        
        }
            
    
    
    }



}
