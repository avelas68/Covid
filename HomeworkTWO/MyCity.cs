using System;
namespace HomeworkTWO
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
        //public MyCity(string name, int population, int cases, int deaths, int tested, string date)
        //{
        //    this.name = name;
        //    this.population = population;
        //    this.cases = cases;
        //    this.deaths = deaths;
        //    this.tested = tested;
        //    this.date = date;
        //}
        //public MyCity(string name, int population, string date)
        //{
        //    this.name = name;
        //    this.population = population;
        //    this.date = date;
        //}
        //public override string ToString()
        //{
        //    return $"[{Id}, {Cities} {Population} {Date} {Cases} {Deaths} {Tested}]";
        //}

    }
}
