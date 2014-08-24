using NServiceBus;

namespace MyPublisher
{
    class EndpointConfig :  IConfigureThisEndpoint, AsA_Publisher,IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
                .DefaultBuilder()  // Ensure the default builder is there
                .UseTransport<SqlServer>()  // Use SQL Server Queues
               .UseNHibernateSubscriptionPersister() // Persist the Subscription in SQL Server
               .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("MyMessages"));
        }
    }
}
