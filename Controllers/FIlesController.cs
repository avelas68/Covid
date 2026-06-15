//using System;
//using System.Collections.Generic;
//using System.IO;
//using HomeworkTHREE.Services;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace HomeworkTHREE.Controllers
//{
//    public class FileController : Controller
//    {
//      //  private readonly FileServices FileServices;

//        //public FileController(FileServices FileServices)
//        //{
//        //    this.FileServices = FileServices;
//        //}
//        [HttpGet]
//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Upload(IFormFile file)
//        {
//            using var reader = new StreamReader(file.OpenReadStream());
//            var lines = new List<string>();
//            string line;
//            while ((line = reader.ReadLine()) != null)
//                lines.Add(line);
           

//            return View();
//        }

//    }
//}
