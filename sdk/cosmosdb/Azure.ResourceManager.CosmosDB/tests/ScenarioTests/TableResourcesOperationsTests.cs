// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;
using Azure.ResourceManager.CosmosDB.Models;
using System.Collections.Generic;
using static Azure.Core.Pipeline.TaskExtensions;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    [TestFixture]
    public class TableResourcesOperationsTests : CosmosDBManagementClientBase
    {
        private const string tableName1 = "tableName2527";
        private const string tableName2 = "tableName22527";
        private string databaseAccountName;
        private string resourceGroupName;
        public TableResourcesOperationsTests()
            : base(true)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                InitializeClients();
                this.databaseAccountName = Recording.GenerateAssetName(CosmosDBTestUtilities.databaseAccountName);
                this.resourceGroupName = Recording.GenerateAssetName(CosmosDBTestUtilities.resourceGroupPrefix);
                TestContext.Progress.WriteLine("//////////////////TestResourcesOperationsTests/////////////////////////////");
                TestContext.Progress.WriteLine(this.databaseAccountName);
                TestContext.Progress.WriteLine(this.resourceGroupName);
                await CosmosDBTestUtilities.TryRegisterResourceGroupAsync(ResourceGroupsOperations,
                    CosmosDBTestUtilities.location,
                    this.resourceGroupName);
            }
        }

        [TearDown]
        public async Task CleanupResourceGroup()
        {
            await CleanupResourceGroupsAsync();
        }

        [TestCase]
        public async Task TableCRUDTest()
        {
            CosmosDBManagementClient cosmosDBMgmtClient = GetCosmosDBManagementClient();

            // create database account
            List<Location> locationList = new List<Location>();
            locationList.Add(new Location(id: null, locationName: "EAST US", documentEndpoint: null, provisioningState: null, failoverPriority: null, isZoneRedundant: null));
            IEnumerable<Location> locations = locationList;
            DatabaseAccountCreateUpdateParameters databaseAccountsCreateOrUpdateParameters = new DatabaseAccountCreateUpdateParameters(locations);
            databaseAccountsCreateOrUpdateParameters.Kind = DatabaseAccountKind.GlobalDocumentDB;
            databaseAccountsCreateOrUpdateParameters.Location = "EAST US";
            await WaitForCompletionAsync(await cosmosDBMgmtClient.DatabaseAccounts.StartCreateOrUpdateAsync(this.resourceGroupName, this.databaseAccountName, databaseAccountsCreateOrUpdateParameters));

            bool isDatabaseNameExists = cosmosDBMgmtClient.DatabaseAccounts.CheckNameExistsAsync(this.databaseAccountName).Result.Status == 200;
            if (!isDatabaseNameExists)
            {
                return;
            }

            // test create/update
            TableResource tableResource = new TableResource(tableName1);
            CreateUpdateOptions createUpdateOptions = new CreateUpdateOptions();
            TableCreateUpdateParameters tableCreateUpdateParameters = new TableCreateUpdateParameters(tableResource, createUpdateOptions);
            TableGetResults tableGetResults1 = (await WaitForCompletionAsync(await cosmosDBMgmtClient.TableResources.StartCreateUpdateTableAsync(this.resourceGroupName, this.databaseAccountName, tableName1, tableCreateUpdateParameters))).Value;
            Assert.NotNull(tableGetResults1);

            TableGetResults tableGetResults2 = (await cosmosDBMgmtClient.TableResources.GetTableAsync(this.resourceGroupName, this.databaseAccountName, tableName1)).Value;
            Assert.NotNull(tableGetResults2);

            VerifyEqualTables(tableGetResults1, tableGetResults2);

            // test list

        }

        private void VerifyEqualTables(TableGetResults expectedValue, TableGetResults actualValue)
        {
            Assert.AreEqual(expectedValue.Resource.Id, actualValue.Resource.Id);
            Assert.AreEqual(expectedValue.Resource.Rid, actualValue.Resource.Rid);
            Assert.AreEqual(expectedValue.Resource.Ts, actualValue.Resource.Ts);
            Assert.AreEqual(expectedValue.Resource.Etag, actualValue.Resource.Etag);
        }
    }
}
