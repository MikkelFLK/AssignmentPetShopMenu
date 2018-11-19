
using Microsoft.EntityFrameworkCore;
using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStoreMenu.Infrastrucure.DatawDB.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        private readonly PetStoreMenuContextcs db;

        public UserRepository(PetStoreMenuContextcs context)
        {
            db = context;
        }

        public void Add(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
        }

        public void Edit(User entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public User Get(long id)
        {
            return db.Users.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }

        public void Remove(long id)
        {
            var item = db.Users.FirstOrDefault(b => b.Id == id);
            db.Users.Remove(item);
            db.SaveChanges();
        }
    }
}
