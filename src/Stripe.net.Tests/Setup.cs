using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class Setup : IAssemblyContext
    {
        void IAssemblyContext.OnAssemblyStart()
        {
            var apiKey = "sk_test_H6laumw3ZO9BQ4r3eL58fUcM";

            var envKey = Environment.GetEnvironmentVariable("stripe_test_secret_key");
            if (!string.IsNullOrEmpty(envKey)) apiKey = envKey;

            StripeConfiguration.SetApiKey(apiKey);
        }

        void IAssemblyContext.OnAssemblyComplete()
        {
            // great, we're done!
        }
    }
}