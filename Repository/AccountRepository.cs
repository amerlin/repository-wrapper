using identity.Repository;
using repo_pattner.Abstract;
using repo_pattner.Interface;

namespace repo_pattner.Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository() : base()
        {

        }

        public void SpecificCreate()
        {
            throw new System.NotImplementedException();
        }
    }
}