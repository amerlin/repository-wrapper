using identity.Repository;
using repo_pattner.Abstract;
using repo_pattner.Models;

namespace repo_pattner.Repository
{
       public class OwnerRepository : RepositoryBase<Account>, IOwnerRepository
    {
        public OwnerRepository(/*RepositoryContext repositoryContext*/)
            :base(/*repositoryContext*/)
        {
        }
    }
}