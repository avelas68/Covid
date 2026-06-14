//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using HomeworkTHREE.Models;

//namespace HomeworkTHREE.Services
//{
//    public class FileServices
//    {
//        private readonly AppDbContext db;
//        public FileServices(AppDbContext db)
//        {
//            this.db = db;
//        }

//        static public void ImportData(string pathToFile, string date)
//        {


//            //using var db = new AppDbContext();
//            ////Get all lines from the file
//            //String[] lines = File.ReadAllLines(pathToFile);
//            ////Store information about cities
//            //foreach (var line in lines.Skip(1))
//            //{

//            //    String a = line.Replace("\"", "");

//            //    string[] nums = a.Split(new char[] { ',' });
//            //    var city = new MyCity
//            //    {
//            //        Name = nums[1],
//            //        Population = Convert.ToInt32(nums[11]),
//            //        Cases = Convert.ToInt32(nums[2]),
//            //        Deaths = Convert.ToInt32(nums[5]),
//            //        Tested = Convert.ToInt32(nums[8]),
//            //        Date = date

//            //    };
//            //    db.Cities.Add(city);
//            //}
//            //db.SaveChanges();

//        }

//        public List<MyCity> GetMyCities()
//        {
//            return db.Cities.ToList();
//        }


//    }
//}
