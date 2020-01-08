using identity.Repository;

namespace repo_pattner.Interface
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        //specific method
        void SpecificCreate();

    }
}