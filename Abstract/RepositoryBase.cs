using repo_pattner.Interface;

namespace repo_pattner.Abstract
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public RepositoryBase()
        {

        }

        public void Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}