using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.BuyerModels;

public class Buyer : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Buyer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}