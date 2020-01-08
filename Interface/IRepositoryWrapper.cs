using repo_pattner.Models;

namespace repo_pattner.Interface
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}