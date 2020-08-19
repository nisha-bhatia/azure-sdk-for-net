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
            var testWorkspace = new NotebookWorkspaceName("testWorkspaceName");
            var armProxy = new ARMProxyResource();
            var response = await NotebookWorkspacesOperations.StartCreateOrUpdateAsync(resourceName, "testAccountName", testWorkspace, armProxy);
            Assert.IsNotNull(response);
            //var handler2 = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };
            //var mockContext = new Mock<PartitionContext>("65");
            //using (MockContext context = MockContext.Start(this.GetType()))
            //{
            // Create client
            //var context = new MockContext<>();
            //// var clientMock = new Mock<IDurableClient>(); // can't do this IDurableClient is from a Track1 library!!
            //CosmosDBManagementClient cosmosDBMgmtClient = CosmosDBTestUtilities.GetCosmosDBClient(context, handler);

            //// Get operations
            //var operations = cosmosDBMgmtClient.Operations.List();

            //// Verify operations are returned
            //Assert.NotNull(operations);
            //Assert.IsNotEmpty(operations);
            //}
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
