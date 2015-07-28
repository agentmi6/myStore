using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.RepositortInterface
{
    public interface IUserRepository
    {
        List<User> GetAll();
        void Create(User user);
        void Delete(int id);
    }
}
