using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
        /* Why derive from ControllerBase vs Controller???
          -> It is not strictily necessaary, just more to the point. The Controller class derives from 
             ControllerBase and adds some members that are needed to support Views.

          public class Controller : ControllerBase
           {
               public dynamic ViewBag {get;}
               public virtual ViewResult View(object model) {}
               // more view support stuff
           }
        */

        /*    In MVC i used Server.MapPath for accessing basepath and rootpath.
              Here IWebHostEnvironment is used for accessing basepath(Directory--wwwroot) and contentpath(FileUploaad-- root)
              IWebHostEnvironment must define inside constructor injection.
              I can define IWebHostEnvironment inside startup.cs and Controller.
          */
        public static IWebHostEnvironment _webHostEnvironment;
        public FileUploadsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
         
        }
         
    }
}
