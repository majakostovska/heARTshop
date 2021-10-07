using heARTshop.Domain.Identity;
using heARTshop.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heARTshop.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<heARTshopApplicationUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<heARTshopApplicationUser>();
        }
        public IEnumerable<heARTshopApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public heARTshopApplicationUser Get(string id)
        {
            return entities
               .Include(z => z.UserCart)
               .Include("UserCart.ProductInShoppingCarts")
               .Include("UserCart.ProductInShoppingCarts.Product")
               .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(heARTshopApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(heARTshopApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Update(entity);
            context.SaveChanges();

        }

        public void Delete(heARTshopApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
