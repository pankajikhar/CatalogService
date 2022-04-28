using MassTransit;
using OrderApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService
{
    public class OrderConsumer : IConsumer<Order>
    {

        public async Task Consume(ConsumeContext<Order> context)
        {
            var msg = context.Message;

            await Console.Out.WriteLineAsync(msg.ToString());
        }
    }
}
