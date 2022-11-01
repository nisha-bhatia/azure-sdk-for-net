// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using NUnit.Framework;
using System.Security.Cryptography;

namespace Azure.Monitor.Ingestion.Tests
{
    public class ConcurrencyTest : RecordedTestBase<MonitorIngestionTestEnvironment>
    {
        private const int Mb = 1024 * 1024;
        public ConcurrencyTest(bool isAsync) : base(isAsync, RecordedTestMode.Live)
        {
        }

        /* please refer to https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/template/Azure.Template/tests/TemplateClientLiveTests.cs to write tests. */

        private LogsIngestionClient CreateClient(HttpPipelinePolicy policy = null)
        {
            var options = new LogsIngestionClientOptions();
            options.Retry.MaxRetries = 0;
            if (policy != null)
            {
                options.AddPolicy(policy, HttpPipelinePosition.PerCall);
            }
            var clientOptions = InstrumentClientOptions(options);
            return InstrumentClient(new LogsIngestionClient(new Uri(TestEnvironment.DCREndpoint), TestEnvironment.Credential, clientOptions));
        }

        private static List<object> GenerateEntries(int numEntries, DateTime recordingNow)
        {
            var entries = new List<object>();
            for (int i = 0; i < numEntries; i++)
            {
                entries.Add(new object[] {
                    new {
                        Time = recordingNow,
                        Computer = "Computer" + new string('*', 5000),
                        AdditionalContext = i
                    }
                });
            }
            return entries;
        }

        [Test]
        public async Task Concurrency5()
        {
            LogsIngestionClient client = CreateClient();

            var x = GenerateEntries(1000000, Recording.Now.DateTime);
            long y;
            var entry = BinaryData.FromObjectAsJson(x);
            y = entry.ToMemory().Length;
            bool pass = false;
            if (y >= 2000000000)
            {
                pass = true;
            }
            Console.WriteLine(pass);
            // Make a 2 Gb request
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, GenerateEntries(1000, Recording.Now.DateTime)).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }
    }
}
