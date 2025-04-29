using Rebus.Bus;

namespace Thunders.TechTest.OutOfBox.Queues
{
    public class RebusMessageSender(IBus bus) : IMessageSender
    {
        public virtual async Task SendLocal(object message)
        {
            var policy = PollyResiliencePolicy.CreatePolicy();
            await policy.ExecuteAsync(async () => await bus.SendLocal(message));
        }
        
        public virtual async Task Publish(object message)
        {
            var policy = PollyResiliencePolicy.CreatePolicy();
            await policy.ExecuteAsync(async () => await bus.Publish(message));
        }
    }
}
