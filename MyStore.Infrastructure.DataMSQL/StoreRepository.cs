using MyStore.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Infrastructure.DataMSQL
{
    public class StoreRepository : IStoreRepository
    {
        public List<Domain.Store> Getall()
        {
            throw new NotImplementedException();
        }

        public void Create(Domain.Store store)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
