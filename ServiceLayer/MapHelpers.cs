using Microsoft.EntityFrameworkCore;
using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer
{
    public static class MapHelpers
    {
        #region Product

        public static IQueryable<ProductDto> ToDto(this IQueryable<Datalayer.Entity.Product> products)
        {
            return products
                       .Include(p => p.Manufacturer)
                       .Select(p => new ProductDto() {
                           ProductId = p.ProductId,
                           Name = p.Name,
                           Description = p.Description,
                           ManufacturerName = p.Manufacturer.Name,
                           Price = p.Price
                       });
        }

        #endregion

    }
}
