// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryCredentialSetResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CredentialSetGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2024-11-01-preview/examples/CredentialSetGet.json
            // this example is just showing the usage of "CredentialSets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryCredentialSetResource created on azure
            // for more information of creating ContainerRegistryCredentialSetResource, please refer to the document of ContainerRegistryCredentialSetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string credentialSetName = "myCredentialSet";
            ResourceIdentifier containerRegistryCredentialSetResourceId = ContainerRegistryCredentialSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, credentialSetName);
            ContainerRegistryCredentialSetResource containerRegistryCredentialSet = client.GetContainerRegistryCredentialSetResource(containerRegistryCredentialSetResourceId);

            // invoke the operation
            ContainerRegistryCredentialSetResource result = await containerRegistryCredentialSet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryCredentialSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CredentialSetDelete()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2024-11-01-preview/examples/CredentialSetDelete.json
            // this example is just showing the usage of "CredentialSets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryCredentialSetResource created on azure
            // for more information of creating ContainerRegistryCredentialSetResource, please refer to the document of ContainerRegistryCredentialSetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string credentialSetName = "myCredentialSet";
            ResourceIdentifier containerRegistryCredentialSetResourceId = ContainerRegistryCredentialSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, credentialSetName);
            ContainerRegistryCredentialSetResource containerRegistryCredentialSet = client.GetContainerRegistryCredentialSetResource(containerRegistryCredentialSetResourceId);

            // invoke the operation
            await containerRegistryCredentialSet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CredentialSetUpdate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2024-11-01-preview/examples/CredentialSetUpdate.json
            // this example is just showing the usage of "CredentialSets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryCredentialSetResource created on azure
            // for more information of creating ContainerRegistryCredentialSetResource, please refer to the document of ContainerRegistryCredentialSetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string credentialSetName = "myCredentialSet";
            ResourceIdentifier containerRegistryCredentialSetResourceId = ContainerRegistryCredentialSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, credentialSetName);
            ContainerRegistryCredentialSetResource containerRegistryCredentialSet = client.GetContainerRegistryCredentialSetResource(containerRegistryCredentialSetResourceId);

            // invoke the operation
            ContainerRegistryCredentialSetPatch patch = new ContainerRegistryCredentialSetPatch
            {
                AuthCredentials = {new ContainerRegistryAuthCredential
{
Name = ContainerRegistryCredentialName.Credential1,
UsernameSecretIdentifier = "https://myvault.vault.azure.net/secrets/username2",
PasswordSecretIdentifier = "https://myvault.vault.azure.net/secrets/password2",
}},
            };
            ArmOperation<ContainerRegistryCredentialSetResource> lro = await containerRegistryCredentialSet.UpdateAsync(WaitUntil.Completed, patch);
            ContainerRegistryCredentialSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryCredentialSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
