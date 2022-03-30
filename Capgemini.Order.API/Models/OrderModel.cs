using System;

namespace Capgemini.Order.API.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Client { get; set; }
        public string Adrees { get; set; }
        public string Product { get; set; }
    }
}