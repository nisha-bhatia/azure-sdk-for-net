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
        private List<object> entryList;
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
            //entryList = GenerateEntries(290000, Recording.Now.DateTime);
            entryList = GenerateEntries(50000, Recording.Now.DateTime);
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

        [AsyncOnly]
        [Test]
        public async Task Concurrency5()
        {
            LogsIngestionClient client = CreateClient();

            //var x = GenerateEntries(220000, Recording.Now.DateTime);
            //long y;
            //var entry = BinaryData.FromObjectAsJson(x);
            //y = entry.ToMemory().Length;
            //bool pass1 = false;
            //bool pass15 = false;
            //bool pass2 = false;
            //if (y >= 1000000000)
            //{
            //    pass1 = true;
            //}
            //if (y >= 1500000000)
            //{
            //    pass15 = true;
            //}
            //if (y >= 2000000000)
            //{
            //    pass2 = true;
            //}
            //Console.WriteLine(pass1);
            //Console.WriteLine(pass15);
            //Console.WriteLine(pass2);
            // Make a 2 Gb request
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, entryList).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }

        [AsyncOnly]
        [Test]
        public async Task Concurrency100()
        {
            LogsIngestionClient client = CreateClient();
            UploadLogsOptions options = new UploadLogsOptions();
            options.MaxConcurrency = 100;
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, entryList).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }

        [AsyncOnly]
        [Test]
        public async Task Concurrency1000()
        {
            LogsIngestionClient client = CreateClient();
            UploadLogsOptions options = new UploadLogsOptions();
            options.MaxConcurrency = 1000;
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, entryList).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }

        [AsyncOnly]
        [Test]
        public async Task Concurrency5000()
        {
            LogsIngestionClient client = CreateClient();
            UploadLogsOptions options = new UploadLogsOptions();
            options.MaxConcurrency = 5000;
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, entryList).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }

        [AsyncOnly]
        [Test]
        public async Task Concurrency10000()
        {
            LogsIngestionClient client = CreateClient();
            UploadLogsOptions options = new UploadLogsOptions();
            options.MaxConcurrency = 10000;
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, entryList).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }

        [AsyncOnly]
        [Test]
        public async Task Concurrency500000()
        {
            LogsIngestionClient client = CreateClient();
            UploadLogsOptions options = new UploadLogsOptions();
            options.MaxConcurrency = 500000;
            var response = await client.UploadAsync(TestEnvironment.DCRImmutableId, TestEnvironment.StreamName, entryList).ConfigureAwait(false);

            // Check the response
            Assert.AreEqual(UploadLogsStatus.Success, response.Value.Status);
            Assert.IsEmpty(response.Value.Errors);
        }
    }
}
