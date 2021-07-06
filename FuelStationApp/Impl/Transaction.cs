using FuelStationApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Transaction : Entity {
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
        
        public List<TransactionLine> TransactionLine { get; set; }


        public Transaction(Guid customerId, decimal discountValue, decimal totalValue) : base() {
            Date = DateTime.Now;
            CustomerID = customerId;
            DiscountValue = discountValue;
            TotalValue = totalValue;
          
        }

        public string GetDate() {
            string date = Date.ToString("yyyy-MM-dd");
            return date;
        }
    }
}
