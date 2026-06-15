using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace HomeworkTHREE.Models
{
    public class MyCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
        public int Tested { get; set; }
        public string Date { get; set; }



        public override string ToString()
        {
            return $"[{Id}, {Name} {Population}, {Cases}, {Deaths}, {Tested}, {Date}]";
        }
    }
}