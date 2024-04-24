using MediatR;

namespace Order.Domain.Events;

public class OrderStartedDomainEvent : INotification
{
    public string BuyerFirstName { get; set; }
    public string BuyerLastName { get; set; }
    public AggregateModels.OrderModels.Order Order { get; set; }

    public OrderStartedDomainEvent(string buyerFirstName, string buyerLastName, AggregateModels.OrderModels.Order order)
    {
        BuyerFirstName = buyerFirstName;
        BuyerLastName = buyerLastName;
        Order = order;
    }
}