// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.CosmosDB;
using Azure.Management.Resources;
using Azure.Management.Resources.Models;
using Moq;

namespace CosmosDB.Tests
{
    public class CosmosDBTestUtilities
    {
        // Location to run tests.
        public static string LOCATION = "eastus2";

        //public static CosmosDBManagementClient GetCosmosDBClient(MockContext context, RecordedDelegatingHandler handler)
        //{
        //    handler.IsPassThrough = true;
        //    CosmosDBManagementClient client = context.GetServiceClient<CosmosDBManagementClient>(handlers: handler);
        //    return client;
        //}

        //public static string CreateResourceGroup(ResourcesManagementClient resourcesClient)
        //{
        //    const string testPrefix = "CosmosDBResourceGroup";
        //    var rgname = TestUtilities.GenerateName(testPrefix);

        //    var resourceGroupDefinition = new ResourceGroup
        //    {
        //        Location = LOCATION
        //    };

        //    if (!(bool)resourcesClient.ResourceGroups.CheckExistenceAsync(rgname).GetAwaiter().GetResult())
        //        resourcesClient.ResourceGroups.CreateOrUpdate(rgname, resourceGroupDefinition);
        //    return rgname;
        //}

        //public static ResourceManagementClient GetResourceManagementClient(MockContext context, RecordedDelegatingHandler handler)
        //{
        //    handler.IsPassThrough = true;
        //    ResourceManagementClient resourcesClient = context.GetServiceClient<ResourceManagementClient>(handlers: handler);
        //    return resourcesClient;
        //}
    }
}
