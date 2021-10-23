using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Emails
{
    public interface IEmailSenderService
    {

        public Task SendRecieptAsync(OrderDto order, List<OrderProductDto> products);

    }
}
