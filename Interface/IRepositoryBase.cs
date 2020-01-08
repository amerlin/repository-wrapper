namespace repo_pattner.Interface
{
    public interface IRepositoryBase<T>
    {
        public void Create(T entity);
        public void Delete(T entity);
        public void Update(T entity);
    }
}