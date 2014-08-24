using NServiceBus;

namespace Subscriber2
{
    using NServiceBus.Features;

    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.Features.Disable<AutoSubscribe>();//The class Subscriber2Endpoint is demonstrating explicit subscriptions

            Configure.With()
              .DefaultBuilder()
                //this overrides the NServiceBus default convention of IEvent
               .UseTransport<SqlServer>()
               .UseNHibernateSubscriptionPersister() // Persist the Subscription in SQL Server
               .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("MyMessages"));
        }
    }
}
