using Flux.Client;
using NUnit.Framework;
using WireMock.ResponseBuilders;
using WireMock.Server;

namespace Flux.Tests.Flux
{
    public class AbstractFluxClientTest : AbstractMockServerTest
    {
        protected FluxClient FluxClient;
        protected FluentMockServer MockServer;

        protected const string SuccessData = "#datatype,string,long,dateTime:RFC3339,dateTime:RFC3339,dateTime:RFC3339,long,string,string,string,string\n" 
                                           + "#group,false,false,false,false,false,false,false,false,false,true\n" + "#default,_result,,,,,,,,,\n" 
                                           + ",result,table,_start,_stop,_time,_value,_field,_measurement,host,region\n" 
                                           + ",,0,1970-01-01T00:00:10Z,1970-01-01T00:00:20Z,1970-01-01T00:00:10Z,10,free,mem,A,west\n" 
                                           + ",,0,1970-01-01T00:00:10Z,1970-01-01T00:00:20Z,1970-01-01T00:00:10Z,20,free,mem,B,west\n" 
                                           + ",,0,1970-01-01T00:00:20Z,1970-01-01T00:00:30Z,1970-01-01T00:00:20Z,11,free,mem,A,west\n" 
                                           + ",,0,1970-01-01T00:00:20Z,1970-01-01T00:00:30Z,1970-01-01T00:00:20Z,22,free,mem,B,west";

        [SetUp]
        public new void SetUp()
        {
            MockServer = FluentMockServer.Start();
            
            FluxClient = FluxClientFactory.Create(MockServer.Urls[0]);           
        }

        [TearDown]
        public void ShutdownServer()
        {
            MockServer.Stop();
        }

        protected IResponseBuilder CreateResponse()
        {
            return CreateResponse(SuccessData);
        }
    }
}