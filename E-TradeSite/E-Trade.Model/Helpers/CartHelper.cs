using E_Trade.Model.Entity.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Trade.Model.Helpers
{
    public class CartHelper
    {
        private Dictionary<int, ProductVM> _cart = null;

        public CartHelper()
        {
            _cart = new Dictionary<int, ProductVM>();
        }

        public List<ProductVM> CartList
        {
            get
            {
                return _cart.Values.ToList();
            }
        }


        public void AddCart(ProductVM item)
        {
            if (!_cart.ContainsKey(item.Id))
                _cart.Add(item.Id, item);
            else
                this.IncreaseCart(item.Id);
        }

        public void IncreaseCart(int id) => _cart[id].Quantity++;

        public void DecreaseCart(int id)
        {
            _cart[id].Quantity--;
            if (_cart[id].Quantity <= 0)
            {
                this.RemoveCart(id);
            }
        }

        public void RemoveCart(int id) => _cart.Remove(id);
    }
}