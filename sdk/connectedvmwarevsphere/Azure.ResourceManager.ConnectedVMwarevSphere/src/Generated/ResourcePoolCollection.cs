// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of ResourcePool and their operations over its parent. </summary>
    public partial class ResourcePoolCollection : ArmCollection, IEnumerable<ResourcePool>, IAsyncEnumerable<ResourcePool>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ResourcePoolsRestOperations _resourcePoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourcePoolCollection"/> class for mocking. </summary>
        protected ResourcePoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourcePoolCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ResourcePoolCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _resourcePoolsRestClient = new ResourcePoolsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourcePools_Create
        /// <summary> Create Or Update resourcePool. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual ResourcePoolCreateOperation CreateOrUpdate(bool waitForCompletion, string resourcePoolName, ResourcePoolData body = null, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourcePoolsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body, cancellationToken);
                var operation = new ResourcePoolCreateOperation(Parent, _clientDiagnostics, Pipeline, _resourcePoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourcePools_Create
        /// <summary> Create Or Update resourcePool. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<ResourcePoolCreateOperation> CreateOrUpdateAsync(bool waitForCompletion, string resourcePoolName, ResourcePoolData body = null, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourcePoolsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcePoolCreateOperation(Parent, _clientDiagnostics, Pipeline, _resourcePoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourcePools_Get
        /// <summary> Implements resourcePool GET method. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<ResourcePool> Get(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = _resourcePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourcePool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourcePools_Get
        /// <summary> Implements resourcePool GET method. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<Response<ResourcePool>> GetAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourcePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourcePool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<ResourcePool> GetIfExists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourcePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResourcePool>(null, response.GetRawResponse());
                return Response.FromValue(new ResourcePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<Response<ResourcePool>> GetIfExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourcePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResourcePool>(null, response.GetRawResponse());
                return Response.FromValue(new ResourcePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourcePoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            if (resourcePoolName == null)
            {
                throw new ArgumentNullException(nameof(resourcePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourcePools_ListByResourceGroup
        /// <summary> List of resourcePools in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourcePool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourcePool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResourcePool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourcePoolsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourcePool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourcePoolsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourcePools_ListByResourceGroup
        /// <summary> List of resourcePools in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourcePool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourcePool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourcePool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourcePoolsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourcePool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourcePoolsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ResourcePool" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourcePool.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ResourcePool" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourcePoolCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourcePool.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourcePool> IEnumerable<ResourcePool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourcePool> IAsyncEnumerable<ResourcePool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ResourcePool, ResourcePoolData> Construct() { }
    }
}
