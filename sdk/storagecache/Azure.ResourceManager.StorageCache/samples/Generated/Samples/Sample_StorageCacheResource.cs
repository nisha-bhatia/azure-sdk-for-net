// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StorageCache.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StorageCache.Samples
{
    public partial class Sample_StorageCacheResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CachesGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Get.json
            // this example is just showing the usage of "Caches_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            StorageCacheResource result = await storageCache.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageCacheData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CachesDelete()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Delete.json
            // this example is just showing the usage of "Caches_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            await storageCache.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CachesUpdate()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Update.json
            // this example is just showing the usage of "Caches_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            StorageCacheData data = new StorageCacheData(new AzureLocation("westus"))
            {
                SkuName = "Standard_2G",
                CacheSizeGB = 3072,
                Subnet = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scgroup/providers/Microsoft.Network/virtualNetworks/scvnet/subnets/sub1"),
                UpgradeSettings = new StorageCacheUpgradeSettings
                {
                    EnableUpgradeSchedule = true,
                    ScheduledOn = DateTimeOffset.Parse("2022-04-26T18:25:43.511Z"),
                },
                NetworkSettings = new StorageCacheNetworkSettings
                {
                    Mtu = 1500,
                    DnsServers = { IPAddress.Parse("10.1.22.33"), IPAddress.Parse("10.1.12.33") },
                    DnsSearchDomain = "contoso.com",
                    NtpServer = "time.contoso.com",
                },
                SecurityAccessPolicies = {new NfsAccessPolicy("default", new NfsAccessRule[]
{
new NfsAccessRule(NfsAccessRuleScope.Default, NfsAccessRuleAccess.ReadWrite)
{
AllowSuid = false,
AllowSubmountAccess = true,
EnableRootSquash = false,
}
}), new NfsAccessPolicy("restrictive", new NfsAccessRule[]
{
new NfsAccessRule(NfsAccessRuleScope.Host, NfsAccessRuleAccess.ReadWrite)
{
Filter = "10.99.3.145",
AllowSuid = true,
AllowSubmountAccess = true,
EnableRootSquash = false,
},
new NfsAccessRule(NfsAccessRuleScope.Network, NfsAccessRuleAccess.ReadWrite)
{
Filter = "10.99.1.0/24",
AllowSuid = true,
AllowSubmountAccess = true,
EnableRootSquash = false,
},
new NfsAccessRule(NfsAccessRuleScope.Default, NfsAccessRuleAccess.No)
{
AllowSuid = false,
AllowSubmountAccess = true,
EnableRootSquash = true,
AnonymousUID = "65534",
AnonymousGID = "65534",
}
})},
                DirectoryServicesSettings = new StorageCacheDirectorySettings
                {
                    ActiveDirectory = new StorageCacheActiveDirectorySettings(IPAddress.Parse("192.0.2.10"), "contosoAd.contoso.local", "contosoAd", "contosoSmb")
                    {
                        SecondaryDnsIPAddress = IPAddress.Parse("192.0.2.11"),
                    },
                    UsernameDownload = new StorageCacheUsernameDownloadSettings
                    {
                        EnableExtendedGroups = true,
                        UsernameSource = StorageCacheUsernameSourceType.AD,
                    },
                },
                Tags =
{
["Dept"] = "Contoso"
},
            };
            ArmOperation<StorageCacheResource> lro = await storageCache.UpdateAsync(WaitUntil.Completed, data);
            StorageCacheResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageCacheData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CachesUpdateLdapOnly()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Update_ldap_only.json
            // this example is just showing the usage of "Caches_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            StorageCacheData data = new StorageCacheData(new AzureLocation("westus"))
            {
                SkuName = "Standard_2G",
                CacheSizeGB = 3072,
                Subnet = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scgroup/providers/Microsoft.Network/virtualNetworks/scvnet/subnets/sub1"),
                UpgradeSettings = new StorageCacheUpgradeSettings
                {
                    EnableUpgradeSchedule = true,
                    ScheduledOn = DateTimeOffset.Parse("2022-04-26T18:25:43.511Z"),
                },
                NetworkSettings = new StorageCacheNetworkSettings
                {
                    Mtu = 1500,
                    DnsServers = { IPAddress.Parse("10.1.22.33"), IPAddress.Parse("10.1.12.33") },
                    DnsSearchDomain = "contoso.com",
                    NtpServer = "time.contoso.com",
                },
                SecurityAccessPolicies = {new NfsAccessPolicy("default", new NfsAccessRule[]
{
new NfsAccessRule(NfsAccessRuleScope.Default, NfsAccessRuleAccess.ReadWrite)
{
AllowSuid = false,
AllowSubmountAccess = true,
EnableRootSquash = false,
}
}), new NfsAccessPolicy("restrictive", new NfsAccessRule[]
{
new NfsAccessRule(NfsAccessRuleScope.Host, NfsAccessRuleAccess.ReadWrite)
{
Filter = "10.99.3.145",
AllowSuid = true,
AllowSubmountAccess = true,
EnableRootSquash = false,
},
new NfsAccessRule(NfsAccessRuleScope.Network, NfsAccessRuleAccess.ReadWrite)
{
Filter = "10.99.1.0/24",
AllowSuid = true,
AllowSubmountAccess = true,
EnableRootSquash = false,
},
new NfsAccessRule(NfsAccessRuleScope.Default, NfsAccessRuleAccess.No)
{
AllowSuid = false,
AllowSubmountAccess = true,
EnableRootSquash = true,
AnonymousUID = "65534",
AnonymousGID = "65534",
}
})},
                DirectoryServicesSettings = new StorageCacheDirectorySettings
                {
                    UsernameDownload = new StorageCacheUsernameDownloadSettings
                    {
                        EnableExtendedGroups = true,
                        UsernameSource = StorageCacheUsernameSourceType.Ldap,
                        LdapServer = "192.0.2.12",
                        LdapBaseDN = "dc=contosoad,dc=contoso,dc=local",
                        Credentials = new StorageCacheUsernameDownloadCredential
                        {
                            BindDistinguishedName = "cn=ldapadmin,dc=contosoad,dc=contoso,dc=local",
                            BindPassword = "<bindPassword>",
                        },
                    },
                },
                Tags =
{
["Dept"] = "Contoso"
},
            };
            ArmOperation<StorageCacheResource> lro = await storageCache.UpdateAsync(WaitUntil.Completed, data);
            StorageCacheResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageCacheData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task EnableDebugInfo_CachesDebugInfo()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_DebugInfo.json
            // this example is just showing the usage of "Caches_DebugInfo" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            await storageCache.EnableDebugInfoAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Flush_CachesFlush()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Flush.json
            // this example is just showing the usage of "Caches_Flush" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            await storageCache.FlushAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_CachesStart()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Start.json
            // this example is just showing the usage of "Caches_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            await storageCache.StartAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_CachesStop()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_Stop.json
            // this example is just showing the usage of "Caches_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            await storageCache.StopAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StartPrimingJob_StartPrimingJob()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StartPrimingJob.json
            // this example is just showing the usage of "Caches_StartPrimingJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            PrimingJob primingjob = new PrimingJob("contosoJob", new Uri("https://contosostorage.blob.core.windows.net/contosoblob/00000000_00000000000000000000000000000000.00000000000.FFFFFFFF.00000000?sp=r&st=2021-08-11T19:33:35Z&se=2021-08-12T03:33:35Z&spr=https&sv=2020-08-04&sr=b&sig=<secret-value-from-key>"));
            await storageCache.StartPrimingJobAsync(WaitUntil.Completed, primingjob: primingjob);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StopPrimingJob_StopPrimingJob()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StopPrimingJob.json
            // this example is just showing the usage of "Caches_StopPrimingJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            PrimingJobContent content = new PrimingJobContent("00000000000_0000000000");
            await storageCache.StopPrimingJobAsync(WaitUntil.Completed, content: content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task PausePrimingJob_PausePrimingJob()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/PausePrimingJob.json
            // this example is just showing the usage of "Caches_PausePrimingJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            PrimingJobContent content = new PrimingJobContent("00000000000_0000000000");
            await storageCache.PausePrimingJobAsync(WaitUntil.Completed, content: content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ResumePrimingJob_ResumePrimingJob()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/ResumePrimingJob.json
            // this example is just showing the usage of "Caches_ResumePrimingJob" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            PrimingJobContent content = new PrimingJobContent("00000000000_0000000000");
            await storageCache.ResumePrimingJobAsync(WaitUntil.Completed, content: content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpgradeFirmware_CachesUpgradeFirmware()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/Caches_UpgradeFirmware.json
            // this example is just showing the usage of "Caches_UpgradeFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            await storageCache.UpgradeFirmwareAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateSpaceAllocation_SpaceAllocationPost()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/SpaceAllocation_Post.json
            // this example is just showing the usage of "Caches_SpaceAllocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // invoke the operation
            IEnumerable<StorageTargetSpaceAllocation> spaceAllocation = new StorageTargetSpaceAllocation[]
            {
new StorageTargetSpaceAllocation
{
Name = "st1",
AllocationPercentage = 25,
},
new StorageTargetSpaceAllocation
{
Name = "st2",
AllocationPercentage = 50,
},
new StorageTargetSpaceAllocation
{
Name = "st3",
AllocationPercentage = 25,
}
            };
            await storageCache.UpdateSpaceAllocationAsync(WaitUntil.Completed, spaceAllocation: spaceAllocation);

            Console.WriteLine("Succeeded");
        }
    }
}
