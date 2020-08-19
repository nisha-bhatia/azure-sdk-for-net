// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using Azure.Management.Resources;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    [RunFrequency(RunTestFrequency.Manually)]
    public abstract class CosmosDBManagementClientBase : ManagementRecordedTestBase<CosmosDBManagementTestEnvironment>
    {
        public string SubscriptionId { get; set; }

        public CosmosDBManagementClient CosmosDBManagementClient { get; set; }
        public ResourcesManagementClient ResourcesManagementClient { get; set; }

        public Operations Operations { get; set; }

        public ResourcesOperations ResourcesOperations { get; set; }
        public ResourceGroupsOperations ResourceGroupsOperations { get; set; }
        public ProvidersOperations ResourceProvidersOperations { get; private set; }
        //public DatabaseAccountsOperations DatabaseAccountsOperations { get; set; }
        public NotebookWorkspacesOperations NotebookWorkspacesOperations { get; set; }
        protected CosmosDBManagementClientBase(bool isAsync) : base(isAsync)
        {
        }

        // created InitializeClients method
        protected internal void InitializeClients()
        {
            SubscriptionId = TestEnvironment.SubscriptionId;
            ResourcesManagementClient = this.GetResourceManagementClient(); //part of class, not local
            ResourcesOperations = ResourcesManagementClient.Resources;
            ResourceProvidersOperations = ResourcesManagementClient.Providers;
            ResourceGroupsOperations = ResourcesManagementClient.ResourceGroups;
            CosmosDBManagementClient = GetCosmosDBManagementClient();
            //DatabaseAccountsOperations = CosmosDBManagementClient.DatabaseAccounts;
            NotebookWorkspacesOperations = CosmosDBManagementClient.NotebookWorkspaces;
        }

        internal CosmosDBManagementClient GetCosmosDBManagementClient() {
            return CreateClient<CosmosDBManagementClient>(this.SubscriptionId, TestEnvironment.Credential, Recording.InstrumentClientOptions(new CosmosDBManagementClientOptions())); }
    }
}
