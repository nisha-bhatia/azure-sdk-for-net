// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ConnectivityConfigurationResource
    {
        // ConnectivityConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ConnectivityConfigurationsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkManagerConnectivityConfigurationGet.json
            // this example is just showing the usage of "ConnectivityConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectivityConfigurationResource created on azure
            // for more information of creating ConnectivityConfigurationResource, please refer to the document of ConnectivityConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestConnectivityConfig";
            ResourceIdentifier connectivityConfigurationResourceId = ConnectivityConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            ConnectivityConfigurationResource connectivityConfiguration = client.GetConnectivityConfigurationResource(connectivityConfigurationResourceId);

            // invoke the operation
            ConnectivityConfigurationResource result = await connectivityConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectivityConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConnectivityConfigurationsPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ConnectivityConfigurationsPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkManagerConnectivityConfigurationPut.json
            // this example is just showing the usage of "ConnectivityConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectivityConfigurationResource created on azure
            // for more information of creating ConnectivityConfigurationResource, please refer to the document of ConnectivityConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestConnectivityConfig";
            ResourceIdentifier connectivityConfigurationResourceId = ConnectivityConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            ConnectivityConfigurationResource connectivityConfiguration = client.GetConnectivityConfigurationResource(connectivityConfigurationResourceId);

            // invoke the operation
            ConnectivityConfigurationData data = new ConnectivityConfigurationData()
            {
                Description = "Sample Configuration",
                ConnectivityTopology = ConnectivityTopology.HubAndSpoke,
                Hubs =
{
new ConnectivityHub()
{
ResourceId = new ResourceIdentifier("subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Network/virtualNetworks/myTestConnectivityConfig"),
ResourceType = new ResourceType("Microsoft.Network/virtualNetworks"),
}
},
                IsGlobal = GlobalMeshSupportFlag.True,
                AppliesToGroups =
{
new ConnectivityGroupItem("subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.Network/networkManagers/testNetworkManager/networkGroups/group1",GroupConnectivity.None)
{
UseHubGateway = HubGatewayUsageFlag.True,
IsGlobal = GlobalMeshSupportFlag.False,
}
},
                DeleteExistingPeering = DeleteExistingPeering.True,
            };
            ArmOperation<ConnectivityConfigurationResource> lro = await connectivityConfiguration.UpdateAsync(WaitUntil.Completed, data);
            ConnectivityConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectivityConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConnectivityConfigurationsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ConnectivityConfigurationsDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/NetworkManagerConnectivityConfigurationDelete.json
            // this example is just showing the usage of "ConnectivityConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectivityConfigurationResource created on azure
            // for more information of creating ConnectivityConfigurationResource, please refer to the document of ConnectivityConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestConnectivityConfig";
            ResourceIdentifier connectivityConfigurationResourceId = ConnectivityConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            ConnectivityConfigurationResource connectivityConfiguration = client.GetConnectivityConfigurationResource(connectivityConfigurationResourceId);

            // invoke the operation
            bool? force = false;
            await connectivityConfiguration.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine($"Succeeded");
        }
    }
}
