// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="CostManagementViewsResource" /> and their operations.
    /// Each <see cref="CostManagementViewsResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="CostManagementViewsCollection" /> instance call the GetCostManagementViews method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class CostManagementViewsCollection : ArmCollection, IEnumerable<CostManagementViewsResource>, IAsyncEnumerable<CostManagementViewsResource>
    {
        private readonly ClientDiagnostics _costManagementViewsViewsClientDiagnostics;
        private readonly ViewsRestOperations _costManagementViewsViewsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CostManagementViewsCollection"/> class for mocking. </summary>
        protected CostManagementViewsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CostManagementViewsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CostManagementViewsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _costManagementViewsViewsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CostManagement", CostManagementViewsResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CostManagementViewsResource.ResourceType, out string costManagementViewsViewsApiVersion);
            _costManagementViewsViewsRestClient = new ViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, costManagementViewsViewsApiVersion);
        }

        /// <summary>
        /// The operation to create or update a view. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdateByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> View name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CostManagementViewsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string viewName, CostManagementViewData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _costManagementViewsViewsClientDiagnostics.CreateScope("CostManagementViewsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _costManagementViewsViewsRestClient.CreateOrUpdateByScopeAsync(Id, viewName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CostManagementArmOperation<CostManagementViewsResource>(Response.FromValue(new CostManagementViewsResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update a view. Update operation requires latest eTag to be set in the request. You may obtain the latest eTag by performing a get operation. Create operation does not require eTag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_CreateOrUpdateByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> View name. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate View operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CostManagementViewsResource> CreateOrUpdate(WaitUntil waitUntil, string viewName, CostManagementViewData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _costManagementViewsViewsClientDiagnostics.CreateScope("CostManagementViewsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _costManagementViewsViewsRestClient.CreateOrUpdateByScope(Id, viewName, data, cancellationToken);
                var operation = new CostManagementArmOperation<CostManagementViewsResource>(Response.FromValue(new CostManagementViewsResource(Client, response), response.GetRawResponse()));
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
        /// Gets the view for the defined scope by view name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_GetByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<Response<CostManagementViewsResource>> GetAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _costManagementViewsViewsClientDiagnostics.CreateScope("CostManagementViewsCollection.Get");
            scope.Start();
            try
            {
                var response = await _costManagementViewsViewsRestClient.GetByScopeAsync(Id, viewName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementViewsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the view for the defined scope by view name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_GetByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual Response<CostManagementViewsResource> Get(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _costManagementViewsViewsClientDiagnostics.CreateScope("CostManagementViewsCollection.Get");
            scope.Start();
            try
            {
                var response = _costManagementViewsViewsRestClient.GetByScope(Id, viewName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CostManagementViewsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all views at the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_ListByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CostManagementViewsResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CostManagementViewsResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementViewsViewsRestClient.CreateListByScopeRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _costManagementViewsViewsRestClient.CreateListByScopeNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CostManagementViewsResource(Client, CostManagementViewData.DeserializeCostManagementViewData(e)), _costManagementViewsViewsClientDiagnostics, Pipeline, "CostManagementViewsCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all views at the given scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_ListByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CostManagementViewsResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CostManagementViewsResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _costManagementViewsViewsRestClient.CreateListByScopeRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _costManagementViewsViewsRestClient.CreateListByScopeNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CostManagementViewsResource(Client, CostManagementViewData.DeserializeCostManagementViewData(e)), _costManagementViewsViewsClientDiagnostics, Pipeline, "CostManagementViewsCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_GetByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _costManagementViewsViewsClientDiagnostics.CreateScope("CostManagementViewsCollection.Exists");
            scope.Start();
            try
            {
                var response = await _costManagementViewsViewsRestClient.GetByScopeAsync(Id, viewName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.CostManagement/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Views_GetByScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> View name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual Response<bool> Exists(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _costManagementViewsViewsClientDiagnostics.CreateScope("CostManagementViewsCollection.Exists");
            scope.Start();
            try
            {
                var response = _costManagementViewsViewsRestClient.GetByScope(Id, viewName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CostManagementViewsResource> IEnumerable<CostManagementViewsResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CostManagementViewsResource> IAsyncEnumerable<CostManagementViewsResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
