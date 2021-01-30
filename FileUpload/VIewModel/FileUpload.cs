using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FileUpload.VIewModel
{
    public class FileUpload
    {
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
                        
        public static IFormFile files { get; set; }
    }
}
