using BusinessLayer.Model;
using BusinessLayer.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

namespace BusinessLayer.Helpers
{

    public static class JsonHelper
    {
        static OrderRepository orderRepository = OrderRepository.Instance;
        static TableRepository tableRepository = TableRepository.Instance;

        public static void ToTxtJson()
        {
            string json = JsonConvert.SerializeObject(orderRepository.Orders, Newtonsoft.Json.Formatting.Indented);

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.txt");

            File.WriteAllText(path, json);

            Console.WriteLine($"JSON сохранен в файл: {path}");
        }
        public static void FromTxtJson()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db.txt");
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Dispose();
            }

            string json = File.ReadAllText(path);

            List<Order> orders = JsonConvert.DeserializeObject<List<Order>>(json) ?? new List<Order>();
            orderRepository.Orders = orders;
            tableRepository.Orders = orders;
        }

    }
}
