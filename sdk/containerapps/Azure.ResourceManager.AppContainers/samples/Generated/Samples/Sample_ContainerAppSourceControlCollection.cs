// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppSourceControlCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateContainerAppSourceControl()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/SourceControls_CreateOrUpdate.json
            // this example is just showing the usage of "ContainerAppsSourceControls_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppSourceControlResource
            ContainerAppSourceControlCollection collection = containerApp.GetContainerAppSourceControls();

            // invoke the operation
            string sourceControlName = "current";
            ContainerAppSourceControlData data = new ContainerAppSourceControlData
            {
                RepoUri = new Uri("https://github.com/xwang971/ghatest"),
                Branch = "master",
                GitHubActionConfiguration = new ContainerAppGitHubActionConfiguration
                {
                    RegistryInfo = new ContainerAppRegistryInfo
                    {
                        RegistryServer = "test-registry.azurecr.io",
                        RegistryUserName = "test-registry",
                        RegistryPassword = "<registrypassword>",
                    },
                    AzureCredentials = new ContainerAppCredentials
                    {
                        ClientId = "<clientid>",
                        ClientSecret = "<clientsecret>",
                        TenantId = Guid.Parse("<tenantid>"),
                        Kind = "feaderated",
                    },
                    ContextPath = "./",
                    GitHubPersonalAccessToken = "test",
                    Image = "image/tag",
                },
            };
            ArmOperation<ContainerAppSourceControlResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sourceControlName, data);
            ContainerAppSourceControlResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppSourceControlData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetContainerAppSSourceControl()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/SourceControls_Get.json
            // this example is just showing the usage of "ContainerAppsSourceControls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppSourceControlResource
            ContainerAppSourceControlCollection collection = containerApp.GetContainerAppSourceControls();

            // invoke the operation
            string sourceControlName = "current";
            ContainerAppSourceControlResource result = await collection.GetAsync(sourceControlName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppSourceControlData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAppSSourceControls()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/SourceControls_ListByContainer.json
            // this example is just showing the usage of "ContainerAppsSourceControls_ListByContainerApp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppSourceControlResource
            ContainerAppSourceControlCollection collection = containerApp.GetContainerAppSourceControls();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppSourceControlResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppSourceControlData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetContainerAppSSourceControl()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/SourceControls_Get.json
            // this example is just showing the usage of "ContainerAppsSourceControls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppSourceControlResource
            ContainerAppSourceControlCollection collection = containerApp.GetContainerAppSourceControls();

            // invoke the operation
            string sourceControlName = "current";
            bool result = await collection.ExistsAsync(sourceControlName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetContainerAppSSourceControl()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/SourceControls_Get.json
            // this example is just showing the usage of "ContainerAppsSourceControls_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppResource created on azure
            // for more information of creating ContainerAppResource, please refer to the document of ContainerAppResource
            string subscriptionId = "651f8027-33e8-4ec4-97b4-f6e9f3dc8744";
            string resourceGroupName = "workerapps-rg-xj";
            string containerAppName = "testcanadacentral";
            ResourceIdentifier containerAppResourceId = ContainerAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, containerAppName);
            ContainerAppResource containerApp = client.GetContainerAppResource(containerAppResourceId);

            // get the collection of this ContainerAppSourceControlResource
            ContainerAppSourceControlCollection collection = containerApp.GetContainerAppSourceControls();

            // invoke the operation
            string sourceControlName = "current";
            NullableResponse<ContainerAppSourceControlResource> response = await collection.GetIfExistsAsync(sourceControlName);
            ContainerAppSourceControlResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppSourceControlData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
