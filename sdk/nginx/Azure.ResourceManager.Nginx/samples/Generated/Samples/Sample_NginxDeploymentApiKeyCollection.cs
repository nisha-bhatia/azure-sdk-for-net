// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Nginx.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Nginx.Samples
{
    public partial class Sample_NginxDeploymentApiKeyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiKeysCreateOrUpdate()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-11-01-preview/examples/ApiKeys_CreateOrUpdate.json
            // this example is just showing the usage of "ApiKeys_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // get the collection of this NginxDeploymentApiKeyResource
            NginxDeploymentApiKeyCollection collection = nginxDeployment.GetNginxDeploymentApiKeys();

            // invoke the operation
            string apiKeyName = "myApiKey";
            NginxDeploymentApiKeyCreateOrUpdateContent content = new NginxDeploymentApiKeyCreateOrUpdateContent();
            ArmOperation<NginxDeploymentApiKeyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, apiKeyName, content);
            NginxDeploymentApiKeyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxDeploymentApiKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiKeysGet()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-11-01-preview/examples/ApiKeys_Get.json
            // this example is just showing the usage of "ApiKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // get the collection of this NginxDeploymentApiKeyResource
            NginxDeploymentApiKeyCollection collection = nginxDeployment.GetNginxDeploymentApiKeys();

            // invoke the operation
            string apiKeyName = "myApiKey";
            NginxDeploymentApiKeyResource result = await collection.GetAsync(apiKeyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NginxDeploymentApiKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiKeysList()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-11-01-preview/examples/ApiKeys_List.json
            // this example is just showing the usage of "ApiKeys_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // get the collection of this NginxDeploymentApiKeyResource
            NginxDeploymentApiKeyCollection collection = nginxDeployment.GetNginxDeploymentApiKeys();

            // invoke the operation and iterate over the result
            await foreach (NginxDeploymentApiKeyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NginxDeploymentApiKeyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiKeysGet()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-11-01-preview/examples/ApiKeys_Get.json
            // this example is just showing the usage of "ApiKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // get the collection of this NginxDeploymentApiKeyResource
            NginxDeploymentApiKeyCollection collection = nginxDeployment.GetNginxDeploymentApiKeys();

            // invoke the operation
            string apiKeyName = "myApiKey";
            bool result = await collection.ExistsAsync(apiKeyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiKeysGet()
        {
            // Generated from example definition: specification/nginx/resource-manager/NGINX.NGINXPLUS/preview/2024-11-01-preview/examples/ApiKeys_Get.json
            // this example is just showing the usage of "ApiKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NginxDeploymentResource created on azure
            // for more information of creating NginxDeploymentResource, please refer to the document of NginxDeploymentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string deploymentName = "myDeployment";
            ResourceIdentifier nginxDeploymentResourceId = NginxDeploymentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deploymentName);
            NginxDeploymentResource nginxDeployment = client.GetNginxDeploymentResource(nginxDeploymentResourceId);

            // get the collection of this NginxDeploymentApiKeyResource
            NginxDeploymentApiKeyCollection collection = nginxDeployment.GetNginxDeploymentApiKeys();

            // invoke the operation
            string apiKeyName = "myApiKey";
            NullableResponse<NginxDeploymentApiKeyResource> response = await collection.GetIfExistsAsync(apiKeyName);
            NginxDeploymentApiKeyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NginxDeploymentApiKeyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
