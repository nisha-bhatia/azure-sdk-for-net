// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Hci.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_ArcSettingResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetArcSetting()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/GetArcSetting.json
            // this example is just showing the usage of "ArcSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            ArcSettingResource result = await arcSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArcSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteArcSetting()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/DeleteArcSetting.json
            // this example is just showing the usage of "ArcSettings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            await arcSetting.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchArcSetting()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/PatchArcSetting.json
            // this example is just showing the usage of "ArcSettings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            ArcSettingPatch patch = new ArcSettingPatch
            {
                ConnectivityProperties = BinaryData.FromObjectAsJson(new
                {
                    enabled = "true",
                    serviceConfigurations = new object[]
            {
new
{
port = "6516",
serviceName = "WAC",
}
            },
                }),
            };
            ArcSettingResource result = await arcSetting.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArcSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GeneratePassword_GeneratePassword()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/GeneratePassword.json
            // this example is just showing the usage of "ArcSettings_GeneratePassword" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            ArcPasswordCredential result = await arcSetting.GeneratePasswordAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateIdentity_CreateArcIdentity()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/CreateArcIdentity.json
            // this example is just showing the usage of "ArcSettings_CreateIdentity" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            ArmOperation<ArcIdentityResult> lro = await arcSetting.CreateIdentityAsync(WaitUntil.Completed);
            ArcIdentityResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ConsentAndInstallDefaultExtensions_ConsentAndInstallDefaultExtensions()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/ConsentAndInstallDefaultExtensions.json
            // this example is just showing the usage of "ArcSettings_ConsentAndInstallDefaultExtensions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            ArcSettingResource result = await arcSetting.ConsentAndInstallDefaultExtensionsAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArcSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task InitializeDisableProcess_TriggerARCDisable()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/InitializeDisableProcess.json
            // this example is just showing the usage of "ArcSettings_InitializeDisableProcess" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArcSettingResource created on azure
            // for more information of creating ArcSettingResource, please refer to the document of ArcSettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string arcSettingName = "default";
            ResourceIdentifier arcSettingResourceId = ArcSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, arcSettingName);
            ArcSettingResource arcSetting = client.GetArcSettingResource(arcSettingResourceId);

            // invoke the operation
            await arcSetting.InitializeDisableProcessAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
