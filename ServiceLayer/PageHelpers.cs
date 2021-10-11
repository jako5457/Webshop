using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class PageHelpers
    {

        public static int PageCount<T>(this IQueryable<T> query,int PageSize)
        {
            double count = query.Count();

            count = Math.Ceiling(count / PageSize);

            return Convert.ToInt32(count);
        }

        public static async Task<int> PageCountAsync<T>(this IQueryable<T> query, int PageSize)
        {
            double count = await query.CountAsync();

            count = Math.Ceiling(count / PageSize);

            return Convert.ToInt32(count);
        }

        public static IQueryable<T> Page<T>(this IQueryable<T> query,int page,int PageSize)
        {
            if (PageSize == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(PageSize), "pagesize cannot be zero.");
            }

            if (page != 0)
            {
                query = query.Skip(page * PageSize);
            }

            return query.Take(PageSize);
        }

    }
}
