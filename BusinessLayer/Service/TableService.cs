using BusinessLayer.Model;
using BusinessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Service
{
    public class TableService
    {
        TableRepository tableRepository = TableRepository.Instance;

        public void Add(Order newOrder)
        {
            tableRepository.Orders.Add(newOrder);
        }

        public void Delete(string index)
        {
            tableRepository.Orders = tableRepository.Orders.Where(x => x.Data != index).ToList();
        }

        public void Edit(int index, Order newOrder)
        {
            tableRepository.Orders[index] = newOrder;
        }

        public List<Order> GetAll()
        {
            return tableRepository.Orders.Where(x => x.Table == TableRepository.Instance.SelectedTable).ToList();
        }
    }
}
