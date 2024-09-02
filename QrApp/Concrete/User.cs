using NPoco;
using System.ComponentModel.DataAnnotations;

namespace QrApp.Concrete;
[TableName("Users")]
[PrimaryKey("Id", AutoIncrement = false)]

    public class User
    {
        [Key]
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
}

