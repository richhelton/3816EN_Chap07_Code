using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB2.Model
{
    class MyConfig
    {
       public MyConfig()
        {

        }
        /****
         * Connectionstring
         * *****/
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["connectionString"];
            }
        }
        public static void CreateData()
        {
            CreateUnicasts();
            CreateMessageMaps();
        }


        #region Unicasts
        private static void CreateUnicasts()
        {

            UnicastBusConfigDB unicastBusCfgDB = new UnicastBusConfigDB();
            unicastBusCfgDB.ForwardReceivedMessagesTo = "MyAudits";
            CreateUnicasts(unicastBusCfgDB);

        }
        private static void CreateUnicasts(UnicastBusConfigDB unicastBusCfgDB)
        {
            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            MongoDatabase myConfig = server.GetDatabase("MyConfig");

            MongoCollection<BsonDocument> unicasts = myConfig.GetCollection<BsonDocument>("UnicastBusConfigDB");
            BsonDocument unicast = new BsonDocument {
                        { "ForwardReceivedMessagesTo", unicastBusCfgDB.ForwardReceivedMessagesTo },
                        { "DistributorControlAddress", unicastBusCfgDB.DistributorControlAddress },
                        { "DistributorDataAddress", unicastBusCfgDB.DistributorDataAddress },
                        { "TimeoutManagerAddress", unicastBusCfgDB.TimeoutManagerAddress },
                        { "TimeToBeReceivedOnForwardedMessages", unicastBusCfgDB.TimeToBeReceivedOnForwardedMessages.ToString() }
                        };

            unicasts.Insert(unicast);
        }
        public static List<UnicastBusConfigDB> GetUnicasts()
        {
            List<UnicastBusConfigDB> UniList = new List<UnicastBusConfigDB>();

            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            MongoDatabase myConfig = server.GetDatabase("MyConfig");

            MongoCollection<UnicastBusConfigDB> unicasts = myConfig.GetCollection<UnicastBusConfigDB>("UnicastBusConfigDB");
            foreach (var unicast in unicasts.FindAll())
            {
                UniList.Add(unicast);
            }

            return UniList;
        }
        public static void DeleteUnicasts()
        {
            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            MongoDatabase myConfig = server.GetDatabase("MyConfig");

            MongoCollection<UnicastBusConfigDB> unicasts = myConfig.GetCollection<UnicastBusConfigDB>("UnicastBusConfigDB");
            unicasts.Drop();
        } 

        #endregion
        #region MessageMaps
        private static void CreateMessageMaps()
        {
            MessageEndpointMappingDB mapping = new MessageEndpointMappingDB();
            mapping.Endpoint = "MySFTPClient";
            mapping.Messages = "MyMessages.SendCommand, MyMessages";
            CreateMessageMaps(mapping);
        }

        private static void CreateMessageMaps(MessageEndpointMappingDB mapping)
        {
            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            MongoDatabase myConfig = server.GetDatabase("MyConfig");

            MongoCollection<BsonDocument> endpoints = myConfig.GetCollection<BsonDocument>("MessageEndpointMappingDB");
            BsonDocument endpoint = new BsonDocument {
                        { "AssemblyName", mapping.AssemblyName },
                        { "Endpoint", mapping.Endpoint },
                        { "Messages", mapping.Messages },
                        { "Namespace", mapping.Namespace },
                        { "TypeFullName", mapping.TypeFullName }
                        };

            endpoints.Insert(endpoint);
        }
        public static List<MessageEndpointMappingDB> GetMessageMaps()
        {
            List<MessageEndpointMappingDB> endpointList = new List<MessageEndpointMappingDB>();

            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            MongoDatabase myConfig = server.GetDatabase("MyConfig");

            MongoCollection<MessageEndpointMappingDB> endpoints = myConfig.GetCollection<MessageEndpointMappingDB>("MessageEndpointMappingDB");
            foreach (var endpoint in endpoints.FindAll())
            {
                endpointList.Add(endpoint);
            }

            return endpointList;
        }
        public static void DeleteMessageMaps()
        {
            var client = new MongoClient(ConnectionString);
            var server = client.GetServer();
            MongoDatabase myConfig = server.GetDatabase("MyConfig");

            MongoCollection<MessageEndpointMappingDB> endpoints = myConfig.GetCollection<MessageEndpointMappingDB>("MessageEndpointMappingDB");
            endpoints.Drop();
        }
        #endregion

    }
}
