// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_VirtualMachineScaleSetVmRunCommandResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualMachineScaleSetVMRunCommands()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_Get.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetVmRunCommandResource created on azure
            // for more information of creating VirtualMachineScaleSetVmRunCommandResource, please refer to the document of VirtualMachineScaleSetVmRunCommandResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            string runCommandName = "myRunCommand";
            ResourceIdentifier virtualMachineScaleSetVmRunCommandResourceId = VirtualMachineScaleSetVmRunCommandResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, runCommandName);
            VirtualMachineScaleSetVmRunCommandResource virtualMachineScaleSetVmRunCommand = client.GetVirtualMachineScaleSetVmRunCommandResource(virtualMachineScaleSetVmRunCommandResourceId);

            // invoke the operation
            VirtualMachineScaleSetVmRunCommandResource result = await virtualMachineScaleSetVmRunCommand.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualMachineScaleSetVMRunCommand()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_Delete.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetVmRunCommandResource created on azure
            // for more information of creating VirtualMachineScaleSetVmRunCommandResource, please refer to the document of VirtualMachineScaleSetVmRunCommandResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            string runCommandName = "myRunCommand";
            ResourceIdentifier virtualMachineScaleSetVmRunCommandResourceId = VirtualMachineScaleSetVmRunCommandResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, runCommandName);
            VirtualMachineScaleSetVmRunCommandResource virtualMachineScaleSetVmRunCommand = client.GetVirtualMachineScaleSetVmRunCommandResource(virtualMachineScaleSetVmRunCommandResourceId);

            // invoke the operation
            await virtualMachineScaleSetVmRunCommand.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateVirtualMachineScaleSetVMRunCommand()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-07-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_Update.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetVmRunCommandResource created on azure
            // for more information of creating VirtualMachineScaleSetVmRunCommandResource, please refer to the document of VirtualMachineScaleSetVmRunCommandResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            string runCommandName = "myRunCommand";
            ResourceIdentifier virtualMachineScaleSetVmRunCommandResourceId = VirtualMachineScaleSetVmRunCommandResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, runCommandName);
            VirtualMachineScaleSetVmRunCommandResource virtualMachineScaleSetVmRunCommand = client.GetVirtualMachineScaleSetVmRunCommandResource(virtualMachineScaleSetVmRunCommandResourceId);

            // invoke the operation
            VirtualMachineRunCommandUpdate runCommand = new VirtualMachineRunCommandUpdate
            {
                Source = new VirtualMachineRunCommandScriptSource
                {
                    ScriptUri = new Uri("https://mystorageaccount.blob.core.windows.net/scriptcontainer/MyScript.ps1"),
                    ScriptUriManagedIdentity = new RunCommandManagedIdentity
                    {
                        ObjectId = "4231e4d2-33e4-4e23-96b2-17888afa6072",
                    },
                },
            };
            ArmOperation<VirtualMachineScaleSetVmRunCommandResource> lro = await virtualMachineScaleSetVmRunCommand.UpdateAsync(WaitUntil.Completed, runCommand);
            VirtualMachineScaleSetVmRunCommandResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
