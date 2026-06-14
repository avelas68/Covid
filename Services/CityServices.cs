using System.Collections.Generic;
using System.Linq;
using HomeworkTHREE.Models;

namespace HomeworkTHREE.Services
{
    public class CityServices
    {
        private readonly AppDbContext db;
        public CityServices(AppDbContext db)
        {
            this.db = db;
        }
        public List<MyCity> GetMyCities()
        {
            return db.Cities.ToList();
        }


    }
}
