using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingList1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorsController : ControllerBase
    {

        [Route("/error-development")]
        public IActionResult HandleErrorDevelopment([FromServices] IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }

     
            var exeptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()!;


            return Problem(detail: exeptionHandlerFeature.Error.StackTrace,
                title: exeptionHandlerFeature.Error.Message);
            
        }

        [HttpGet("Throw")]
        public IActionResult Throw()
        {
            throw new Exception("Sample Exception");
        }
    }
}
