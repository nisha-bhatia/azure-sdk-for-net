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
    /// <summary> A class representing collection of FirewallPolicy and their operations over its parent. </summary>
    public partial class FirewallPolicyCollection : ArmCollection, IEnumerable<FirewallPolicy>, IAsyncEnumerable<FirewallPolicy>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FirewallPoliciesRestOperations _firewallPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FirewallPolicyCollection"/> class for mocking. </summary>
        protected FirewallPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FirewallPolicyCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FirewallPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _firewallPoliciesRestClient = new FirewallPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
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

        /// <summary> Creates or updates the specified Firewall Policy. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Firewall Policy operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FirewallPolicyCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string firewallPolicyName, FirewallPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _firewallPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, parameters, cancellationToken);
                var operation = new FirewallPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _firewallPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, parameters).Request, response);
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

        /// <summary> Creates or updates the specified Firewall Policy. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Firewall Policy operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FirewallPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string firewallPolicyName, FirewallPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _firewallPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FirewallPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _firewallPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, parameters).Request, response);
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

        /// <summary> Gets the specified Firewall Policy. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual Response<FirewallPolicy> Get(string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _firewallPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirewallPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Firewall Policy. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> is null. </exception>
        public async virtual Task<Response<FirewallPolicy>> GetAsync(string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _firewallPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FirewallPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual Response<FirewallPolicy> GetIfExists(string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _firewallPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FirewallPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new FirewallPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> is null. </exception>
        public async virtual Task<Response<FirewallPolicy>> GetIfExistsAsync(string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _firewallPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, firewallPolicyName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FirewallPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new FirewallPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(firewallPolicyName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallPolicyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string firewallPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(firewallPolicyName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Firewall Policies in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirewallPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirewallPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FirewallPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _firewallPoliciesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _firewallPoliciesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Firewall Policies in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirewallPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirewallPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FirewallPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _firewallPoliciesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _firewallPoliciesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="FirewallPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FirewallPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="FirewallPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FirewallPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FirewallPolicy> IEnumerable<FirewallPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FirewallPolicy> IAsyncEnumerable<FirewallPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, FirewallPolicy, FirewallPolicyData> Construct() { }
    }
}
