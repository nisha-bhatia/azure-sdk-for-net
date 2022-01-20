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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualHub and their operations over its parent. </summary>
    public partial class VirtualHubCollection : ArmCollection, IEnumerable<VirtualHub>, IAsyncEnumerable<VirtualHub>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualHubsRestOperations _virtualHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualHubCollection"/> class for mocking. </summary>
        protected VirtualHubCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualHubCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualHub.ResourceType, out string apiVersion);
            _virtualHubsRestClient = new VirtualHubsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
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

        /// <summary> Creates a VirtualHub resource if it doesn&apos;t exist else updates the existing VirtualHub. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="virtualHubParameters"> Parameters supplied to create or update VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> or <paramref name="virtualHubParameters"/> is null. </exception>
        public virtual VirtualHubCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualHubName, VirtualHubData virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualHubsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, virtualHubParameters, cancellationToken);
                var operation = new VirtualHubCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualHubsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, virtualHubParameters).Request, response);
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

        /// <summary> Creates a VirtualHub resource if it doesn&apos;t exist else updates the existing VirtualHub. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="virtualHubParameters"> Parameters supplied to create or update VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> or <paramref name="virtualHubParameters"/> is null. </exception>
        public async virtual Task<VirtualHubCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualHubName, VirtualHubData virtualHubParameters, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (virtualHubParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualHubsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, virtualHubParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualHubCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualHubsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, virtualHubParameters).Request, response);
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

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual Response<VirtualHub> Get(string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualHubsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public async virtual Task<Response<VirtualHub>> GetAsync(string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualHubsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual Response<VirtualHub> GetIfExists(string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualHubsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualHub>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public async virtual Task<Response<VirtualHub>> GetIfExistsAsync(string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualHubsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualHub>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualHubName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualHubName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualHubName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VirtualHubs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualHub" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualHub> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualHub> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualHubsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualHub> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualHubsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VirtualHubs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualHub" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualHub> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualHub>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualHubsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualHub>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualHubsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHub(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualHub" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualHub.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualHub" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualHub.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualHub> IEnumerable<VirtualHub>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualHub> IAsyncEnumerable<VirtualHub>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualHub, VirtualHubData> Construct() { }
    }
}
