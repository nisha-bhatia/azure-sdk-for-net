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

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridComputeExtensionValueResource"/> and their operations.
    /// Each <see cref="HybridComputeExtensionValueResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="HybridComputeExtensionValueCollection"/> instance call the GetHybridComputeExtensionValues method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class HybridComputeExtensionValueCollection : ArmCollection, IEnumerable<HybridComputeExtensionValueResource>, IAsyncEnumerable<HybridComputeExtensionValueResource>
    {
        private readonly ClientDiagnostics _hybridComputeExtensionValueExtensionMetadataClientDiagnostics;
        private readonly ExtensionMetadataRestOperations _hybridComputeExtensionValueExtensionMetadataRestClient;
        private readonly AzureLocation _location;
        private readonly string _publisher;
        private readonly string _extensionType;

        /// <summary> Initializes a new instance of the <see cref="HybridComputeExtensionValueCollection"/> class for mocking. </summary>
        protected HybridComputeExtensionValueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridComputeExtensionValueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The location of the Extension being received. </param>
        /// <param name="publisher"> The publisher of the Extension being received. </param>
        /// <param name="extensionType"> The extensionType of the Extension being received. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisher"/> or <paramref name="extensionType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisher"/> or <paramref name="extensionType"/> is an empty string, and was expected to be non-empty. </exception>
        internal HybridComputeExtensionValueCollection(ArmClient client, ResourceIdentifier id, AzureLocation location, string publisher, string extensionType) : base(client, id)
        {
            _location = location;
            _publisher = publisher;
            _extensionType = extensionType;
            _hybridComputeExtensionValueExtensionMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputeExtensionValueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridComputeExtensionValueResource.ResourceType, out string hybridComputeExtensionValueExtensionMetadataApiVersion);
            _hybridComputeExtensionValueExtensionMetadataRestClient = new ExtensionMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridComputeExtensionValueExtensionMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an Extension Metadata based on location, publisher, extensionType and version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<HybridComputeExtensionValueResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _hybridComputeExtensionValueExtensionMetadataClientDiagnostics.CreateScope("HybridComputeExtensionValueCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridComputeExtensionValueExtensionMetadataRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeExtensionValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Extension Metadata based on location, publisher, extensionType and version
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<HybridComputeExtensionValueResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _hybridComputeExtensionValueExtensionMetadataClientDiagnostics.CreateScope("HybridComputeExtensionValueCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridComputeExtensionValueExtensionMetadataRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputeExtensionValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Extension versions based on location, publisher, extensionType
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputeExtensionValueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputeExtensionValueResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputeExtensionValueExtensionMetadataRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new HybridComputeExtensionValueResource(Client, HybridComputeExtensionValueData.DeserializeHybridComputeExtensionValueData(e)), _hybridComputeExtensionValueExtensionMetadataClientDiagnostics, Pipeline, "HybridComputeExtensionValueCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all Extension versions based on location, publisher, extensionType
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputeExtensionValueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputeExtensionValueResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputeExtensionValueExtensionMetadataRestClient.CreateListRequest(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new HybridComputeExtensionValueResource(Client, HybridComputeExtensionValueData.DeserializeHybridComputeExtensionValueData(e)), _hybridComputeExtensionValueExtensionMetadataClientDiagnostics, Pipeline, "HybridComputeExtensionValueCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _hybridComputeExtensionValueExtensionMetadataClientDiagnostics.CreateScope("HybridComputeExtensionValueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridComputeExtensionValueExtensionMetadataRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _hybridComputeExtensionValueExtensionMetadataClientDiagnostics.CreateScope("HybridComputeExtensionValueCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridComputeExtensionValueExtensionMetadataRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType, version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridComputeExtensionValueResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _hybridComputeExtensionValueExtensionMetadataClientDiagnostics.CreateScope("HybridComputeExtensionValueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridComputeExtensionValueExtensionMetadataRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridComputeExtensionValueResource>(response.GetRawResponse());
                return Response.FromValue(new HybridComputeExtensionValueResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridCompute/locations/{location}/publishers/{publisher}/extensionTypes/{extensionType}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExtensionMetadata_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridComputeExtensionValueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> The version of the Extension being received. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<HybridComputeExtensionValueResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _hybridComputeExtensionValueExtensionMetadataClientDiagnostics.CreateScope("HybridComputeExtensionValueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridComputeExtensionValueExtensionMetadataRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), _publisher, _extensionType, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridComputeExtensionValueResource>(response.GetRawResponse());
                return Response.FromValue(new HybridComputeExtensionValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridComputeExtensionValueResource> IEnumerable<HybridComputeExtensionValueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridComputeExtensionValueResource> IAsyncEnumerable<HybridComputeExtensionValueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
