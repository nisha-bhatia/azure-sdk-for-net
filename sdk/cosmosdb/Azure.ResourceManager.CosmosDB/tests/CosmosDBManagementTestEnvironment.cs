// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    public class CosmosDBManagementTestEnvironment : TestEnvironment // default name changed from DocumentDB to CosmosDB
    {
        public CosmosDBManagementTestEnvironment() : base("cosmosdb") // default name changed from DocumentDB to CosmosDB
        {
        }
    }
}
