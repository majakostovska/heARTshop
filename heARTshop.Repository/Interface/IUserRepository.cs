using heARTshop.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace heARTshop.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<heARTshopApplicationUser> GetAll();
        heARTshopApplicationUser Get(string id);
        void Insert(heARTshopApplicationUser entity);
        void Update(heARTshopApplicationUser entity);
        void Delete(heARTshopApplicationUser entity);
    }
}
