using Polly;
using Polly.Timeout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.OutOfBox.Queues
{
    public static class PollyResiliencePolicy
    {
        public static IAsyncPolicy CreatePolicy()
        {
            var timeoutPolicy = Policy.TimeoutAsync(10, TimeoutStrategy.Pessimistic);

            var retryPolicy = Policy.Handle<Exception>()
                .WaitAndRetryAsync(
                    retryCount: 3,
                    sleepDurationProvider: attempt => TimeSpan.FromSeconds(2)
                );

            return Policy.WrapAsync(retryPolicy, timeoutPolicy);
        }
    }
}
