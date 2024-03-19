using AspireMessaging.Contracts;
using MassTransit;
using System.Diagnostics;

namespace AspireMessaging.ApiService
{
    public class HelloWorldMessageConsumer : IConsumer<MessageContract>
    {
        public async Task Consume(ConsumeContext<MessageContract> context)
        {
            Debug.WriteLine($"Received: {context.Message.Message}");
            await Task.CompletedTask;
        }
    }
}
