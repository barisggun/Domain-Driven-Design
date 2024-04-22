namespace Order.Domain.SeedWork;

public interface IUnitOfWork
{
    //repositorylerin içerisindeki transactionların da yönetildiği en son aşama. aslında o transactionun sonlanması işi. ef için düşünürsek o bizim için db context objemiz bizim için unit of work oluyor. 

    Task<int> SaveChangesAsync();
}