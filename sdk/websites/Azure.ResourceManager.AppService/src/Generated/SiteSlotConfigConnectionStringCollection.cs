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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of ApiKeyVaultReference and their operations over its parent. </summary>
    public partial class SiteSlotConfigConnectionStringCollection : ArmCollection, IEnumerable<SiteSlotConfigConnectionString>, IAsyncEnumerable<SiteSlotConfigConnectionString>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigConnectionStringCollection"/> class for mocking. </summary>
        protected SiteSlotConfigConnectionStringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigConnectionStringCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotConfigConnectionStringCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteSlotConfigConnectionString.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<SiteSlotConfigConnectionString> Get(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (connectionStringKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings/{connectionStringKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReferenceSlot
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public async virtual Task<Response<SiteSlotConfigConnectionString>> GetAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (connectionStringKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<SiteSlotConfigConnectionString> GetIfExists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (connectionStringKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigConnectionString>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public async virtual Task<Response<SiteSlotConfigConnectionString>> GetIfExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (connectionStringKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferenceSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotConfigConnectionString>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigConnectionString(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (connectionStringKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionStringKey, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionStringKey"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionStringKey"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string connectionStringKey, CancellationToken cancellationToken = default)
        {
            if (connectionStringKey == null)
            {
                throw new ArgumentNullException(nameof(connectionStringKey));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionStringKey, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReferencesSlot
        /// <summary> Description for Gets the config reference app settings and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotConfigConnectionString" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotConfigConnectionString> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotConfigConnectionString> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotConfigConnectionString> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/configreferences/connectionstrings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetSiteConnectionStringKeyVaultReferencesSlot
        /// <summary> Description for Gets the config reference app settings and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotConfigConnectionString" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotConfigConnectionString> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotConfigConnectionString>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotConfigConnectionString>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotConfigConnectionStringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.GetSiteConnectionStringKeyVaultReferencesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotConfigConnectionString(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotConfigConnectionString> IEnumerable<SiteSlotConfigConnectionString>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotConfigConnectionString> IAsyncEnumerable<SiteSlotConfigConnectionString>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteSlotConfigConnectionString, ApiKeyVaultReferenceData> Construct() { }
    }
}
