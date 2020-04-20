using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testprojectaspnetcore3_1.Data;
using testprojectaspnetcore3_1.Service;

namespace testprojectaspnetcore3_1.Repository
{
    public class KalaRepository:IkalaRepositroy
    {
        private readonly ApplicationDbContext _db;

        public KalaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<Kala> FindAll()
        { 
           var kales = _db.Kalas.ToList();
           return kales;
        }

        public Kala FindById(int id)
        {
           var kala= _db.Kalas.Find(id);
           return kala;
        }

        public bool isExists(int id)
        {
          var exists = _db.Kalas.Any(k => k.KalaId == id);
          return exists;
        }

        public bool Create(Kala entity)
        {
            _db.Kalas.Add(entity);
            return Save();
        }

        public bool Update(Kala entity)
        {
            _db.Kalas.Update(entity);
            return Save();
        }

        public bool Delete(Kala entity)
        {
            _db.Kalas.Remove(entity);
            return Save();
        }

        public bool Save()
        {
            var change = _db.SaveChanges();
            return change > 0;
        }
    }
}
