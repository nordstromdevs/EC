using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_excercises
{
    class Order
    {
        public List<Orderline> OrderLines { get; }
        public string CustomerName { get; }

        public Order(string customerName)
        {
            this.CustomerName = customerName;
            this.OrderLines = new List<Orderline>();
        }

        public void AddOrderLine(Orderline line)
        {
            this.OrderLines.Add(line);
        }

        public override string ToString()
        {
            var result = "";
            Decimal orderValue = 0.0m;
            foreach(var item in this.OrderLines)
            {
                result += item.ToString() + Environment.NewLine;
                if (item.Entity.State != ProductStateEnum.NotForSale)
                    orderValue += item.Price;
            }

            result += $"Order total {orderValue}" + Environment.NewLine;

            return result;
        }

    }
}
