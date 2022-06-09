// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Monitor.Ingestion.Tests
{
    public class IngestionClientTest: RecordedTestBase<IngestionClientTestEnvironment>
    {
        public IngestionClientTest(bool isAsync) : base(isAsync)
        {
        }

        /* please refer to https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/template/Azure.Template/tests/TemplateClientLiveTests.cs to write tests. */

        [RecordedTest]
        public void TestOperation()
        {
            Assert.IsTrue(true);
        }

        #region Helpers

        private static BinaryData GetContentFromResponse(Response r)
        {
            // Workaround azure/azure-sdk-for-net#21048, which prevents .Content from working when dealing with responses
            // from the playback system.

            MemoryStream ms = new MemoryStream();
            r.ContentStream.CopyTo(ms);
            return new BinaryData(ms.ToArray());
        }
        #endregion

        [Test]
        public void HelloIngestion()
        {
            var clientSecretCrendential = new ClientSecretCredential("72f988bf-86f1-41af-91ab-2d7cd011db47", "1b0fddd6-a6b5-4f72-a40d-90045a6081dd", "8ew8Q~4PxRXTaQkXDEQWAc0CRfcoVGimYatema2v");
            var dcrImmutableId = "dcr-54e5c6ad9aa444ec87cbe7f6621ba956";
            var dcrEndpoint = "https://nibhati-dce-ku6s.westus2-1.ingest.monitor.azure.com";
            var currentTime = DateTimeOffset.UtcNow.ToString("O");
            BinaryData data = BinaryData.FromObjectAsJson(
                // Use an anonymous type to create the payload
                new[] {
                    new
                    {
                        Time = currentTime,
                        Computer = "Computer1",
                        AdditionalContext = new
                        {
                            InstanceName = "user1",
                            TimeZone = "Pacific Time",
                            Level = 4,
                            CounterName = "AppMetric1",
                            CounterValue = 15.3
                        }
                    },
                    new
                    {
                        Time = currentTime,
                        Computer = "Computer2",
                        AdditionalContext = new
                        {
                            InstanceName = "user2",
                            TimeZone = "Central Time",
                            Level = 3,
                            CounterName = "AppMetric1",
                            CounterValue = 23.5
                        }
                    },
                });
            //string data = @"[
            //  {
            //    ""Time"": """+currentTime+ @""",
            //    ""Computer"": ""Computer1"",
            //    ""AdditionalContext"": {
            //        ""InstanceName"": ""user1"",
				        //    ""TimeZone"": ""Pacific Time"",
				        //    ""Level"": 4,
            //        ""CounterName"": ""AppMetric1"",
            //        ""CounterValue"": 15.3
            //    }
            //},
            //  {
            //    ""Time"": """ + currentTime + @""",
            //    ""Computer"": ""Computer2"",
            //    ""AdditionalContext"": {
            //        ""InstanceName"": ""user2"",
				        //    ""TimeZone"": ""Central Time"",
				        //    ""Level"": 3,
            //        ""CounterName"": ""AppMetric1"",
            //        ""CounterValue"": 23.5
            //    }
            //}
            //]";

            DataCollectionRuleClient client = new(
                new Uri(dcrEndpoint),
                clientSecretCrendential);
            /*
            ##################
            ### Step 3: send the data to Log Analytics via the DCR!
            ##################
            $body = $staticData;
            $headers = @{"Authorization"="Bearer $bearerToken";"Content-Type"="application/json"};
            $uri = "$dceEndpoint/dataCollectionRules/$dcrImmutableId/streams/Custom-MyTableRawData?api-version=2021-11-01-preview"

            $uploadResponse = Invoke-RestMethod -Uri $uri -Method "Post" -Body $body -Headers $headers -TransferEncoding "GZip"
            */
            // Use the REST docs to help shape the payload
            // https://docs.microsoft.com/en-us/rest/api/cognitiveservices-textanalytics/3.1preview4/sentiment/sentiment#examples
            //BinaryData data = BinaryData.FromObjectAsJson(
            //    // Use an anonymous type to create the payload
            //    new
            //    {
            //        documents =
            //            new[]
            //            {
            //                new
            //                {
            //                    text = "The park was clean and pretty. The bathrooms and restaurant were not clean."
            //                }
            //            }
            //    });

            // You can view in a site like https://jsonformatter.org/json-pretty-print
            // if you want to double check the request body
            //string json = data.ToString();
            //Console.WriteLine($"request:\n{json}");

            // Make the request
            Response response = client.Ingest(dcrImmutableId, "Custom-MyTableRawData", RequestContent.Create(data));

            // Check the response
            string json = response.Content.ToString();
            Console.WriteLine($"response:\n{json}");
            //// Parse the response into primitive types
            //IDictionary result = (IDictionary)response.Content.ToObjectFromJson();
            //IList documents = (IList)result["documents"];
            //IDictionary doc = (IDictionary)documents[0];
            //string sentiment = (string)doc["sentiment"];
            //Assert.AreEqual("mixed", sentiment);

            //// Parse the response using dynamic
            //dynamic result2 = JsonConvert.DeserializeObject<dynamic>(response.Content.ToString());
            //sentiment = result2.documents[0].sentiment;
            //Assert.AreEqual("mixed", sentiment);
        }
    }
}
