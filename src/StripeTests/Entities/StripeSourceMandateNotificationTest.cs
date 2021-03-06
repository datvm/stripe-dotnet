namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeSourceMandateNotificationTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.source_mandate_notification.json");
            var mandate = Mapper<StripeSourceMandateNotification>.MapFromJson(json);
            Assert.NotNull(mandate);
            Assert.IsType<StripeSourceMandateNotification>(mandate);
            Assert.NotNull(mandate.Id);
            Assert.Equal("source_mandate_notification", mandate.Object);
        }
    }
}
