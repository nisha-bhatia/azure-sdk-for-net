// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using Azure.ResourceManager.CosmosDB.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Azure.ResourceManager.CosmosDB.Tests.ScenarioTests
{
    [TestFixture]
    public class GraphResourcesOperationsTests : CosmosDBManagementClientBase
    {
        protected string resourceGroupName;
        protected string databaseAccountName = "dbGraph1";
        protected string databaseName = "databaseName1002";
        protected string databaseName2 = "databaseName21002";
        protected string gremlinGraphName = "gremlinGraphName1002";

        protected string graphThroughputType = "Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/throughputSettings";
        protected int sampleThroughput = 700;
        protected Dictionary<string, string> additionalProperties = new Dictionary<string, string>
        {
            {"foo","bar" }
        };
        protected Dictionary<string, string> tags = new Dictionary<string, string>
        {
            {"key3","value3"},
            {"key4","value4"}
        };

        public GraphResourcesOperationsTests()
            : base(true)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                InitializeClients();
                resourceGroupName = Recording.GenerateAssetName(CosmosDBTestUtilities.ResourceGroupPrefix);
                await CosmosDBTestUtilities.TryRegisterResourceGroupAsync(ResourceGroupsOperations, CosmosDBTestUtilities.Location, resourceGroupName);
            }
        }

        [TearDown]
        public void CleanupResourceGroup()
        {
            //await CleanupResourceGroupsAsync();
        }

        [TestCase]
        public async Task GraphCRUDTests()
        {
            var locations = new List<Location>();
            Location loc = new Location();
            loc.LocationName = CosmosDBTestUtilities.Location;
            loc.FailoverPriority = 0;
            loc.IsZoneRedundant = false;
            locations.Add(loc);

            DatabaseAccountCreateUpdateParameters databaseAccountCreateUpdateParameters = new DatabaseAccountCreateUpdateParameters(locations);
            databaseAccountCreateUpdateParameters.Location = CosmosDBTestUtilities.Location;
            databaseAccountCreateUpdateParameters.Capabilities.Add(new Capability("EnableGremlin"));
            databaseAccountCreateUpdateParameters.ConsistencyPolicy = new ConsistencyPolicy(DefaultConsistencyLevel.Eventual);

            await WaitForCompletionAsync(await CosmosDBManagementClient.DatabaseAccounts.StartCreateOrUpdateAsync(resourceGroupName, databaseAccountName, databaseAccountCreateUpdateParameters));

            Task<Response> taskIsDatabaseNameExists = CosmosDBManagementClient.DatabaseAccounts.CheckNameExistsAsync(databaseAccountName);
            Response isDatabaseNameExists = taskIsDatabaseNameExists.ConfigureAwait(false).GetAwaiter().GetResult();
            Assert.AreEqual(200, isDatabaseNameExists.Status);

            GremlinDatabaseCreateUpdateParameters gremlinDatabaseCreateUpdateParameters = new GremlinDatabaseCreateUpdateParameters(new GremlinDatabaseResource(databaseName), new CreateUpdateOptions());

            var gremlinDatabaseResponse = await WaitForCompletionAsync(await CosmosDBManagementClient.GremlinResources.StartCreateUpdateGremlinDatabaseAsync(resourceGroupName, databaseAccountName, databaseName, gremlinDatabaseCreateUpdateParameters));
            GremlinDatabaseGetResults gremlinDatabaseGetResults = gremlinDatabaseResponse.Value;
            Assert.NotNull(gremlinDatabaseGetResults);
            Assert.AreEqual(databaseName, gremlinDatabaseGetResults.Name);

            var gremlinDatabaseResponse1 = await WaitForCompletionAsync(await CosmosDBManagementClient.GremlinResources.StartCreateUpdateGremlinDatabaseAsync(resourceGroupName, databaseAccountName, databaseName, gremlinDatabaseCreateUpdateParameters));
            GremlinDatabaseGetResults gremlinDatabaseGetResults1 = gremlinDatabaseResponse.Value;
            Assert.NotNull(gremlinDatabaseGetResults);
            Assert.AreEqual(databaseName, gremlinDatabaseGetResults1.Name);

            VerifyEqualGremlinDatabases(gremlinDatabaseGetResults, gremlinDatabaseGetResults1);


        }

        private void VerifyEqualGremlinDatabases(GremlinDatabaseGetResults expectedValue, GremlinDatabaseGetResults actualValue)
        {
            Assert.AreEqual(expectedValue.Id, actualValue.Id);
            Assert.AreEqual(expectedValue.Name, actualValue.Name);
            Assert.AreEqual(expectedValue.Location, actualValue.Location);
            Assert.AreEqual(expectedValue.Tags, actualValue.Tags);
            Assert.AreEqual(expectedValue.Type, actualValue.Type);

            Assert.AreEqual(expectedValue.Options, actualValue.Options);

            Assert.AreEqual(expectedValue.Resource.Id, actualValue.Resource.Id);
            Assert.AreEqual(expectedValue.Resource.Rid, actualValue.Resource.Rid);
            Assert.AreEqual(expectedValue.Resource.Ts, actualValue.Resource.Ts);
            Assert.AreEqual(expectedValue.Resource.Etag, actualValue.Resource.Etag);
        }
    }
}
