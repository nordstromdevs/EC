using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_excercises
{
    class Orderline
    {
        private ProductEntity _productEntity;
        private Decimal _price;
        private int _quantity;

        public Decimal Price { get { return _price; } }
        public ProductEntity Entity { get { return _productEntity; } }

        public Orderline(ProductEntity entity, int quantity, Decimal price)
        {
            _productEntity = entity;
            _price = price;
            _quantity = quantity;
        }

        public override string ToString()
        {
            var result = _productEntity.ToString();
            result += string.Format($", Price={_price}, Quantity={_quantity}");

            return result;
        }


    }
}
