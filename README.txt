 /* Storage Scenarios:
            1.Database -- For small file uploads
            2.Physical Storage -- For large File Uploads
            3.Data Storage Service -- Azure Blob Storage */

        /* File Upload Scenarios:
            1.Buffering -- The entire file is read into an IFormFile which is used to process or save the file.
                      Upload small files with buffered model binding to physical storage.
                          -> To upload small files, use a MULTIPART FORM(Text--TEXTPART FORM)
                      Upload small files with buffered model binding to a database.
                          -> To store binary file data in a database define BYTE array
            2.Streaming -- The file is received from a multipart request and directly processed or saved by the app.
                          -> To upload large files. */


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


/* Here [FROMFORM] represent MULTIPART FORM. [FROMFORM] are action parameters of ActionMethod.
   Must remember MULTIPART FORM represent----file, image... 
   For text we used TEXT FORM.
 */

    //checking if file is empty or not?
    // defininig basepath and rootpath
    // checking rootpath and contentpath is exist or not?
    // Reading and Writing files using FileStream. I need to creater object of fileStream.
   // fileStream has four parameters (FileName, FilePath, FileMode, FileAccess)