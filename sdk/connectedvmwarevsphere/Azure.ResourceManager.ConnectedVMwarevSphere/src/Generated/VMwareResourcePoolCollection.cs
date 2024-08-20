// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="VMwareResourcePoolResource"/> and their operations.
    /// Each <see cref="VMwareResourcePoolResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VMwareResourcePoolCollection"/> instance call the GetVMwareResourcePools method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VMwareResourcePoolCollection : ArmCollection, IEnumerable<VMwareResourcePoolResource>, IAsyncEnumerable<VMwareResourcePoolResource>
    {
        private readonly ClientDiagnostics _vMwareResourcePoolResourcePoolsClientDiagnostics;
        private readonly ResourcePoolsRestOperations _vMwareResourcePoolResourcePoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareResourcePoolCollection"/> class for mocking. </summary>
        protected VMwareResourcePoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareResourcePoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareResourcePoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareResourcePoolResourcePoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareResourcePoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VMwareResourcePoolResource.ResourceType, out string vMwareResourcePoolResourcePoolsApiVersion);
            _vMwareResourcePoolResourcePoolsRestClient = new ResourcePoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vMwareResourcePoolResourcePoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update resourcePool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VMwareResourcePoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourcePoolName, VMwareResourcePoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareResourcePoolResourcePoolsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareResourcePoolResource>(new VMwareResourcePoolOperationSource(Client), _vMwareResourcePoolResourcePoolsClientDiagnostics, Pipeline, _vMwareResourcePoolResourcePoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Or Update resourcePool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VMwareResourcePoolResource> CreateOrUpdate(WaitUntil waitUntil, string resourcePoolName, VMwareResourcePoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareResourcePoolResourcePoolsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareResourcePoolResource>(new VMwareResourcePoolOperationSource(Client), _vMwareResourcePoolResourcePoolsClientDiagnostics, Pipeline, _vMwareResourcePoolResourcePoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements resourcePool GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual async Task<Response<VMwareResourcePoolResource>> GetAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareResourcePoolResourcePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareResourcePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements resourcePool GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<VMwareResourcePoolResource> Get(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareResourcePoolResourcePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareResourcePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of resourcePools in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareResourcePoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareResourcePoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareResourcePoolResourcePoolsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareResourcePoolResourcePoolsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VMwareResourcePoolResource(Client, VMwareResourcePoolData.DeserializeVMwareResourcePoolData(e)), _vMwareResourcePoolResourcePoolsClientDiagnostics, Pipeline, "VMwareResourcePoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of resourcePools in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareResourcePoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareResourcePoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareResourcePoolResourcePoolsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareResourcePoolResourcePoolsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VMwareResourcePoolResource(Client, VMwareResourcePoolData.DeserializeVMwareResourcePoolData(e)), _vMwareResourcePoolResourcePoolsClientDiagnostics, Pipeline, "VMwareResourcePoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vMwareResourcePoolResourcePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _vMwareResourcePoolResourcePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<VMwareResourcePoolResource>> GetIfExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareResourcePoolResourcePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VMwareResourcePoolResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareResourcePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareResourcePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual NullableResponse<VMwareResourcePoolResource> GetIfExists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _vMwareResourcePoolResourcePoolsClientDiagnostics.CreateScope("VMwareResourcePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareResourcePoolResourcePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VMwareResourcePoolResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareResourcePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareResourcePoolResource> IEnumerable<VMwareResourcePoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareResourcePoolResource> IAsyncEnumerable<VMwareResourcePoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
