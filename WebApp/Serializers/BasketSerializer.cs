using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using System.Text;

namespace WebApp.Serializers
{
    public static class BasketSerializer
    {

        public static string ToStorageString(this List<BasketModel> models)
        {
            StringBuilder builder = new();

            int count = 0;
            foreach (var model in models)
            {

                builder.Append($"{model.ProductId};;{model.Price};;{model.name};;{model.Amount}");

                if (count != models.Count)
                {
                    if (models.Count != 1)
                    {
                        builder.Append(";;;");
                    }
                }

                count++;
            }

            return builder.ToString();
        }

        public static List<BasketModel> ToBasketModels(this string str)
        {

            string[] Segments = str.Split(";;;");

            List<BasketModel> basket = new();

            foreach (var segment in Segments)
            {
                if (segment.Length != 0)
                {
                    string[] points = segment.Split(";;");
                    BasketModel model = new();

                    model.ProductId = Convert.ToInt32(points[0]);
                    model.Price = Convert.ToDouble(points[1]);
                    model.name = points[2];
                    model.Amount = Convert.ToInt32(points[3]);

                    basket.Add(model);
                }
            }
            return basket;
        }

    }
}
