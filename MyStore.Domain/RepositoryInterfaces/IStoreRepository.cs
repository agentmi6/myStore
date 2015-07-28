using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.RepositoryInterfaces
{
    public interface IStoreRepository
    {
        List<Store> Getall();
        void Create(Store store);
        void Delete(int id);
    }
}
