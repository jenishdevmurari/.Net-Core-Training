using Microsoft.AspNetCore.Mvc;
using Validators.Validators;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Validators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {

        // POST api/<MyController>
        // Inbuilt Using Data Anotation
         [HttpPost]
        public ContentResult Post([FromForm] RegisterClass obj)
        {

           //  Console.WriteLine($"Congratulation {obj.Username} You are successfully Register");
            Console.WriteLine("Your Username is : " + obj.Username);
            Console.WriteLine("Your Password is : " + obj.Password);

            return Content("Congratulation {obj.Username} You are successfully Register", "text/plain");
        }



        //Custom using IValidObject
        [HttpPost("Object")]
        public ContentResult Post1([FromForm] RegisterClass1 obj)
        {
           
            Console.WriteLine($"Congratulation {obj.Username} You are successfully Register");
            Console.WriteLine("Your Username is : " + obj.Username);
            Console.WriteLine("Your Password is : " + obj.Password);

            return Content("Congratulation {obj.Username} You are successfully Register", "text/plain");
        }




        // Fluent validation 
        [HttpPut("valid")]
        public ContentResult Post2([FromForm] RegisterClass2 obj)
        {
            return Content($"Congratulation {obj.Username} You are successfully Register \n Your Username is :{obj.Username} \n Your Password is : {obj.Password}", "plain/text");
        }
        


    }


 
}