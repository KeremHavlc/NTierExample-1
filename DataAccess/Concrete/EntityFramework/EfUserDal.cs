using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        private readonly SimpleContextDb _context;

        public EfUserDal(SimpleContextDb context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Userss.Add(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Userss.Remove(user);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Userss.ToList();
        }

        public User GetById(int id)
        {
            var result = _context.Userss.Where(p=>p.Id == id).SingleOrDefault();
            if (result == null)
            {
                throw new Exception("Kullanıcı Bulunamadı!");
            }
            return result;
        }

        public void Update(User user)
        {
            _context.Userss.Update(user);
            _context.SaveChanges();
        }
    }
}
