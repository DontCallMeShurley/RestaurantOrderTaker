using BusinessLayer.Helpers;
using BusinessLayer.Model;
using BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class OrderService
    {
        OrderRepository orderRepository = OrderRepository.Instance;

        public void Add(Order newOrder)
        {
            if (!orderRepository.Orders.Contains(newOrder))
                orderRepository.Orders.Add(newOrder);
            JsonHelper.ToTxtJson();
        }

        public void Delete(int index)
        {
            orderRepository.Orders.RemoveAt(index);
            JsonHelper.ToTxtJson();
        }

        public void Edit(int index, Order newOrder)
        {
            orderRepository.Orders[index] = newOrder;
        }
        public void ManyOrders(List<Order> orders)
        {
            orderRepository.Orders.RemoveAll(x => x.Table == TableRepository.Instance.SelectedTable);
            orderRepository.Orders.AddRange(orders);
            JsonHelper.ToTxtJson();
        }
        public List<Order> GetAll()
        {
            return orderRepository.Orders;
        }
    }
}
