using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer.Model
{
    public class Order
    {
        public int Table { get; set; }
        public string Name { get; set; }
        public string Starter { get; set; }
        public string MainPlate { get; set; }
        public string Drink { get; set; }
        public string Dessert { get; set; }

        [JsonIgnore]
        public string Data
        {
            get { return $"T{Table} {Name} - Стартер: {Starter}, Главное блюдо: {MainPlate}, Напиток: {Drink} и Десерт: {Dessert}"; }
        }
    }
}
