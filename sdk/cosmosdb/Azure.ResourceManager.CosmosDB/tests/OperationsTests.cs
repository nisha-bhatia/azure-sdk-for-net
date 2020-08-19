// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.


using NUnit.Framework;
using System.Threading.Tasks;
using Azure.Management.Resources;
using Azure.Management.Resources.Models;
using System;
using CosmosDB.Tests;
using System.Net;
using Moq;
using System.Runtime.CompilerServices;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.Core.TestFramework;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    [TestFixture]
    public class OperationsTests : CosmosDBManagementClientBase
    {
        public string resourceName;
        public OperationsTests() : base(true)
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
        //[TestCase]
        //public async Task SampleTest()
        //{
        //    var ResourcesOperations = ResourcesManagementClient.ResourceGroups;
        //    await TryRegisterResourceGroupAsync(ResourcesOperations, "West US", "sample4");
        //    Console.WriteLine("past await");
        //}
        //public static async Task<ResourceGroup> TryRegisterResourceGroupAsync(ResourceGroupsOperations resourceGroupsOperations, string location, string resourceGroupName)
        //{
        //    var createResponse = await resourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new ResourceGroup(location));
        //    Assert.IsNotNull(createResponse);
        //    return createResponse.Value;
        //}
    }
}
