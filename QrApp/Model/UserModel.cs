using QrApp.Concrete;
using System.Reflection.Metadata.Ecma335;

namespace QrApp.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? stockName { get; set; }
        public int quantity { get; set; }
        public string? status { get; set; }
        public string? requestType { get; set; }
        public string? sourceLocation { get; set; }
        public string? destinationLocation { get; set; }
        public string? requestedBy { get; set; }
        public string? requestedFor { get; set; }
        public string? rnd { get; set; }
        public string? demandTime { get; set; }


        public UserModel()
        {

        }

        public UserModel(User user)
        {
            Id = user.Id;
            Name = user.Name;
            stockName = user.stockName;
            quantity = user.quantity;
            status = user.status;
            requestType = user.requestType;
            sourceLocation = user.sourceLocation;
            destinationLocation = user.destinationLocation;
            requestedBy = user.requestedBy;
            requestedFor = user.requestedFor;
            rnd = user.rnd;
            demandTime = user.demandTime;
           
        }

        public User getValuesLikeDbType()
        {
            return new User()
            {
                Id = Id,
                Name = Name,
                stockName = stockName,
                quantity = quantity,
                status = status,
                requestType = requestType,
                sourceLocation = sourceLocation,
                destinationLocation = destinationLocation,
                requestedBy = requestedBy,
                requestedFor = requestedFor,
                rnd = rnd,
                demandTime = demandTime 
            };
        }
    }
}
