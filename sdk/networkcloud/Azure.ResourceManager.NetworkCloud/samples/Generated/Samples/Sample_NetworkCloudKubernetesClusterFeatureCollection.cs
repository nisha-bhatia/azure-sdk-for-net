// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudKubernetesClusterFeatureCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/KubernetesClusterFeatures_Create.json
            // this example is just showing the usage of "KubernetesClusterFeatures_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudKubernetesClusterFeatureResource
            NetworkCloudKubernetesClusterFeatureCollection collection = networkCloudKubernetesCluster.GetNetworkCloudKubernetesClusterFeatures();

            // invoke the operation
            string featureName = "featureName";
            NetworkCloudKubernetesClusterFeatureData data = new NetworkCloudKubernetesClusterFeatureData(new AzureLocation("location"))
            {
                Options = { new StringKeyValuePair("featureOptionName", "featureOptionValue") },
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2"
},
            };
            ArmOperation<NetworkCloudKubernetesClusterFeatureResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, featureName, data);
            NetworkCloudKubernetesClusterFeatureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudKubernetesClusterFeatureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/KubernetesClusterFeatures_Get.json
            // this example is just showing the usage of "KubernetesClusterFeatures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudKubernetesClusterFeatureResource
            NetworkCloudKubernetesClusterFeatureCollection collection = networkCloudKubernetesCluster.GetNetworkCloudKubernetesClusterFeatures();

            // invoke the operation
            string featureName = "featureName";
            NetworkCloudKubernetesClusterFeatureResource result = await collection.GetAsync(featureName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudKubernetesClusterFeatureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListFeaturesForTheKubernetesCluster()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/KubernetesClusterFeatures_ListByKubernetesCluster.json
            // this example is just showing the usage of "KubernetesClusterFeatures_ListByKubernetesCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudKubernetesClusterFeatureResource
            NetworkCloudKubernetesClusterFeatureCollection collection = networkCloudKubernetesCluster.GetNetworkCloudKubernetesClusterFeatures();

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudKubernetesClusterFeatureResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudKubernetesClusterFeatureData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/KubernetesClusterFeatures_Get.json
            // this example is just showing the usage of "KubernetesClusterFeatures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudKubernetesClusterFeatureResource
            NetworkCloudKubernetesClusterFeatureCollection collection = networkCloudKubernetesCluster.GetNetworkCloudKubernetesClusterFeatures();

            // invoke the operation
            string featureName = "featureName";
            bool result = await collection.ExistsAsync(featureName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetKubernetesClusterFeature()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/preview/2024-06-01-preview/examples/KubernetesClusterFeatures_Get.json
            // this example is just showing the usage of "KubernetesClusterFeatures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudKubernetesClusterResource created on azure
            // for more information of creating NetworkCloudKubernetesClusterResource, please refer to the document of NetworkCloudKubernetesClusterResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            ResourceIdentifier networkCloudKubernetesClusterResourceId = NetworkCloudKubernetesClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName);
            NetworkCloudKubernetesClusterResource networkCloudKubernetesCluster = client.GetNetworkCloudKubernetesClusterResource(networkCloudKubernetesClusterResourceId);

            // get the collection of this NetworkCloudKubernetesClusterFeatureResource
            NetworkCloudKubernetesClusterFeatureCollection collection = networkCloudKubernetesCluster.GetNetworkCloudKubernetesClusterFeatures();

            // invoke the operation
            string featureName = "featureName";
            NullableResponse<NetworkCloudKubernetesClusterFeatureResource> response = await collection.GetIfExistsAsync(featureName);
            NetworkCloudKubernetesClusterFeatureResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudKubernetesClusterFeatureData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
