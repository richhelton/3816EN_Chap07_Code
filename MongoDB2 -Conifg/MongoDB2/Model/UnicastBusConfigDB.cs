using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using NServiceBus.Config;

namespace MongoDB2.Model
{
    public class UnicastBusConfigDB
    {


        public ObjectId id { get; set; }
 
        public virtual ICollection<MessageEndpointMappingDB> messageMaps { get; set; }

        // Summary:
        //     Gets/sets the address for sending control messages to the distributor.
        [ConfigurationProperty("DistributorControlAddress", IsRequired = false)]
        public string DistributorControlAddress { get; set; }
        //
        // Summary:
        //     Gets/sets the distributor's data address - used as the return address of
        //     messages sent by this endpoint.
        [ConfigurationProperty("DistributorDataAddress", IsRequired = false)]
        public string DistributorDataAddress { get; set; }
        //
        // Summary:
        //     Gets/sets the address to which messages received will be forwarded.
        [ConfigurationProperty("ForwardReceivedMessagesTo", IsRequired = false)]
        public string ForwardReceivedMessagesTo { get; set; }
        //
        // Summary:
        //     Contains the mappings from message types (or groups of them) to endpoints.
//        [ConfigurationProperty("MessageEndpointMappings", IsRequired = false)]
//       public MessageEndpointMappingCollection MessageEndpointMappings { get; set; }
        //
        // Summary:
        //     Gets/sets the address that the timeout manager will use to send and receive
        //     messages.
        [ConfigurationProperty("TimeoutManagerAddress", IsRequired = false)]
        public string TimeoutManagerAddress { get; set; }
        //
        // Summary:
        //     Gets/sets the time to be received set on forwarded messages
        [ConfigurationProperty("TimeToBeReceivedOnForwardedMessages", IsRequired = false)]
        public TimeSpan TimeToBeReceivedOnForwardedMessages { get; set; }


    }

    public partial class MessageEndpointMappingDB
    {
        public ObjectId id { get; set; }

        public ObjectId UnicastBusConfigDBId { get; set; }
 
        // Summary:
        //     The message assembly for the endpoint mapping.
        [ConfigurationProperty("Assembly", IsRequired = false)]
        public string AssemblyName { get; set; }
        //
        // Summary:
        //     The endpoint named according to "queue@machine".
        [ConfigurationProperty("Endpoint", IsRequired = true)]
        public string Endpoint { get; set; }
        //
        // Summary:
        //     A string defining the message assembly, or single message type.
        [ConfigurationProperty("Messages", IsRequired = false)]
        public string Messages { get; set; }
        //
        // Summary:
        //     The message type. Define this if you want to map all the types in the namespace
        //     to the endpoint.
        //
        // Remarks:
        //     Sub-namespaces will not be mapped.
        [ConfigurationProperty("Namespace", IsRequired = false)]
        public string Namespace { get; set; }
        //
        // Summary:
        //     The fully qualified name of the message type. Define this if you want to
        //     map a single message type to the endpoint.
        //
        // Remarks:
        //     Type will take preference above namespace
        [ConfigurationProperty("Type", IsRequired = false)]
        public string TypeFullName { get; set; }
    
    }



}
