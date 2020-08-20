// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;
using System.Threading.Tasks;
using CosmosDB.Tests;
using Azure.Core.TestFramework;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    [TestFixture]
    public class OperationsTests : CosmosDBManagementClientBase
    {
        public string resourceName;
        public OperationsTests(): base(true)
        {
            resourceName = "sample689323531";
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            InitializeClients();
            await RecordedDelegatingHandler.TryRegisterResourceGroupAsync(ResourceGroupsOperations, "East US", resourceName);
        }

        [TearDown]
        public async Task CleanupResourceGroup()
        {
            await CleanupResourceGroupsAsync();
        }

        [TestCase, Order(1)]
        public async Task ListOperationsTest()
        {
            var cosmosDBClient = GetCosmosDBManagementClient();
            // Get operations
            var operations = cosmosDBClient.Operations.ListAsync();

            // Verify operations are returned
            Assert.NotNull(operations);
            Assert.IsNotEmpty(await operations.ToEnumerableAsync());
        }
    }
}
