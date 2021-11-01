using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class BasketModel
    {

        public int ProductId { get; set; }

        public int Amount { get; set; } = 1;

        public double Price { get; set; }

        public string name { get; set; }

    }
}
