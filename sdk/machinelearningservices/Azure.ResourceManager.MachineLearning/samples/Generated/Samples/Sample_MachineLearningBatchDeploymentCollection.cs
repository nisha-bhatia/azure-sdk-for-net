// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningBatchDeploymentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateWorkspaceBatchDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/BatchDeployment/createOrUpdate.json
            // this example is just showing the usage of "BatchDeployments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningBatchEndpointResource created on azure
            // for more information of creating MachineLearningBatchEndpointResource, please refer to the document of MachineLearningBatchEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            ResourceIdentifier machineLearningBatchEndpointResourceId = MachineLearningBatchEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            MachineLearningBatchEndpointResource machineLearningBatchEndpoint = client.GetMachineLearningBatchEndpointResource(machineLearningBatchEndpointResourceId);

            // get the collection of this MachineLearningBatchDeploymentResource
            MachineLearningBatchDeploymentCollection collection = machineLearningBatchEndpoint.GetMachineLearningBatchDeployments();

            // invoke the operation
            string deploymentName = "testDeploymentName";
            MachineLearningBatchDeploymentData data = new MachineLearningBatchDeploymentData(new AzureLocation("string"), new MachineLearningBatchDeploymentProperties
            {
                Compute = "string",
                ErrorThreshold = 1,
                RetrySettings = new MachineLearningBatchRetrySettings
                {
                    MaxRetries = 1,
                    Timeout = XmlConvert.ToTimeSpan("PT5M"),
                },
                MiniBatchSize = 1L,
                LoggingLevel = MachineLearningBatchLoggingLevel.Info,
                Model = new MachineLearningIdAssetReference(new ResourceIdentifier("string")),
                MaxConcurrencyPerInstance = 1,
                OutputAction = MachineLearningBatchOutputAction.SummaryOnly,
                OutputFileName = "string",
                Resources = new MachineLearningDeploymentResourceConfiguration
                {
                    InstanceCount = 1,
                    InstanceType = "string",
                    Properties =
{
["string"] = BinaryData.FromObjectAsJson(new Dictionary<string, object>
{
["cd3c37dc-2876-4ca4-8a54-21bd7619724a"] = null
})
},
                },
                Description = "string",
                Properties =
{
["string"] = "string"
},
                CodeConfiguration = new MachineLearningCodeConfiguration("string")
                {
                    CodeId = new ResourceIdentifier("string"),
                },
                EnvironmentId = "string",
                EnvironmentVariables =
{
["string"] = "string"
},
            })
            {
                Kind = "string",
                Identity = new ManagedServiceIdentity("SystemAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("string")] = new UserAssignedIdentity()
},
                },
                Sku = new MachineLearningSku("string")
                {
                    Tier = MachineLearningSkuTier.Free,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                Tags = { },
            };
            ArmOperation<MachineLearningBatchDeploymentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, deploymentName, data);
            MachineLearningBatchDeploymentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningBatchDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceBatchDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/BatchDeployment/get.json
            // this example is just showing the usage of "BatchDeployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningBatchEndpointResource created on azure
            // for more information of creating MachineLearningBatchEndpointResource, please refer to the document of MachineLearningBatchEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            ResourceIdentifier machineLearningBatchEndpointResourceId = MachineLearningBatchEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            MachineLearningBatchEndpointResource machineLearningBatchEndpoint = client.GetMachineLearningBatchEndpointResource(machineLearningBatchEndpointResourceId);

            // get the collection of this MachineLearningBatchDeploymentResource
            MachineLearningBatchDeploymentCollection collection = machineLearningBatchEndpoint.GetMachineLearningBatchDeployments();

            // invoke the operation
            string deploymentName = "testDeploymentName";
            MachineLearningBatchDeploymentResource result = await collection.GetAsync(deploymentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningBatchDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListWorkspaceBatchDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/BatchDeployment/list.json
            // this example is just showing the usage of "BatchDeployments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningBatchEndpointResource created on azure
            // for more information of creating MachineLearningBatchEndpointResource, please refer to the document of MachineLearningBatchEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            ResourceIdentifier machineLearningBatchEndpointResourceId = MachineLearningBatchEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            MachineLearningBatchEndpointResource machineLearningBatchEndpoint = client.GetMachineLearningBatchEndpointResource(machineLearningBatchEndpointResourceId);

            // get the collection of this MachineLearningBatchDeploymentResource
            MachineLearningBatchDeploymentCollection collection = machineLearningBatchEndpoint.GetMachineLearningBatchDeployments();

            // invoke the operation and iterate over the result
            string orderBy = "string";
            int? top = 1;
            await foreach (MachineLearningBatchDeploymentResource item in collection.GetAllAsync(orderBy: orderBy, top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningBatchDeploymentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetWorkspaceBatchDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/BatchDeployment/get.json
            // this example is just showing the usage of "BatchDeployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningBatchEndpointResource created on azure
            // for more information of creating MachineLearningBatchEndpointResource, please refer to the document of MachineLearningBatchEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            ResourceIdentifier machineLearningBatchEndpointResourceId = MachineLearningBatchEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            MachineLearningBatchEndpointResource machineLearningBatchEndpoint = client.GetMachineLearningBatchEndpointResource(machineLearningBatchEndpointResourceId);

            // get the collection of this MachineLearningBatchDeploymentResource
            MachineLearningBatchDeploymentCollection collection = machineLearningBatchEndpoint.GetMachineLearningBatchDeployments();

            // invoke the operation
            string deploymentName = "testDeploymentName";
            bool result = await collection.ExistsAsync(deploymentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetWorkspaceBatchDeployment()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/BatchDeployment/get.json
            // this example is just showing the usage of "BatchDeployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningBatchEndpointResource created on azure
            // for more information of creating MachineLearningBatchEndpointResource, please refer to the document of MachineLearningBatchEndpointResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string endpointName = "testEndpointName";
            ResourceIdentifier machineLearningBatchEndpointResourceId = MachineLearningBatchEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, endpointName);
            MachineLearningBatchEndpointResource machineLearningBatchEndpoint = client.GetMachineLearningBatchEndpointResource(machineLearningBatchEndpointResourceId);

            // get the collection of this MachineLearningBatchDeploymentResource
            MachineLearningBatchDeploymentCollection collection = machineLearningBatchEndpoint.GetMachineLearningBatchDeployments();

            // invoke the operation
            string deploymentName = "testDeploymentName";
            NullableResponse<MachineLearningBatchDeploymentResource> response = await collection.GetIfExistsAsync(deploymentName);
            MachineLearningBatchDeploymentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningBatchDeploymentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
