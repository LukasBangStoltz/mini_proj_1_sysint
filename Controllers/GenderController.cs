using Microsoft.AspNetCore.Mvc;

namespace MiniProject1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController : ControllerBase
    {
        

        [HttpPost("getost")]
        public string GetOst()

        {
            utils.GetClient("url");


            return "Ost";
        }

        
        //https://ipapi.co/104.110.0.0/json/
        //https://api.genderize.io/?name=kim&country_id=US
    }
}