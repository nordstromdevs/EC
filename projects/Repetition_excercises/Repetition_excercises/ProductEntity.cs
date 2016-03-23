using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_excercises
{
    class ProductEntity
    {
        private ProductStateEnum _state;
        private string _name;
        private int _id;

        public ProductStateEnum State { get { return _state; } }

        public ProductEntity(ProductStateEnum state, string name, int id)
        {
            _state = state;
            _name = name;
            _id = id;
        }

        public override string ToString()
        {
            var result = string.Format($"ID={_id}, Name={_name}, Status={_state}");
            return result;
        }




    }
}
