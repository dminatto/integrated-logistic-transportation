namespace admin.domain.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
