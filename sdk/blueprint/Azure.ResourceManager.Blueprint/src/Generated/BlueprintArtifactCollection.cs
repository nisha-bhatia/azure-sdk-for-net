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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing a collection of <see cref="BlueprintArtifactResource" /> and their operations.
    /// Each <see cref="BlueprintArtifactResource" /> in the collection will belong to the same instance of <see cref="BlueprintResource" />.
    /// To get a <see cref="BlueprintArtifactCollection" /> instance call the GetBlueprintArtifacts method from an instance of <see cref="BlueprintResource" />.
    /// </summary>
    public partial class BlueprintArtifactCollection : ArmCollection, IEnumerable<BlueprintArtifactResource>, IAsyncEnumerable<BlueprintArtifactResource>
    {
        private readonly ClientDiagnostics _blueprintArtifactArtifactsClientDiagnostics;
        private readonly ArtifactsRestOperations _blueprintArtifactArtifactsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlueprintArtifactCollection"/> class for mocking. </summary>
        protected BlueprintArtifactCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlueprintArtifactCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BlueprintArtifactCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blueprintArtifactArtifactsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", BlueprintArtifactResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BlueprintArtifactResource.ResourceType, out string blueprintArtifactArtifactsApiVersion);
            _blueprintArtifactArtifactsRestClient = new ArtifactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, blueprintArtifactArtifactsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BlueprintResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BlueprintResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="data"> Blueprint artifact to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BlueprintArtifactResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string artifactName, ArtifactData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _blueprintArtifactArtifactsRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, artifactName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<BlueprintArtifactResource>(Response.FromValue(new BlueprintArtifactResource(Client, response), response.GetRawResponse()));
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
        /// Create or update blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="data"> Blueprint artifact to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BlueprintArtifactResource> CreateOrUpdate(WaitUntil waitUntil, string artifactName, ArtifactData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _blueprintArtifactArtifactsRestClient.CreateOrUpdate(Id.Parent, Id.Name, artifactName, data, cancellationToken);
                var operation = new BlueprintArmOperation<BlueprintArtifactResource>(Response.FromValue(new BlueprintArtifactResource(Client, response), response.GetRawResponse()));
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
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual async Task<Response<BlueprintArtifactResource>> GetAsync(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactCollection.Get");
            scope.Start();
            try
            {
                var response = await _blueprintArtifactArtifactsRestClient.GetAsync(Id.Parent, Id.Name, artifactName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual Response<BlueprintArtifactResource> Get(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactCollection.Get");
            scope.Start();
            try
            {
                var response = _blueprintArtifactArtifactsRestClient.Get(Id.Parent, Id.Name, artifactName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List artifacts for a given blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlueprintArtifactResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlueprintArtifactResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _blueprintArtifactArtifactsRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _blueprintArtifactArtifactsRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BlueprintArtifactResource(Client, ArtifactData.DeserializeArtifactData(e)), _blueprintArtifactArtifactsClientDiagnostics, Pipeline, "BlueprintArtifactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List artifacts for a given blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlueprintArtifactResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlueprintArtifactResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _blueprintArtifactArtifactsRestClient.CreateListRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _blueprintArtifactArtifactsRestClient.CreateListNextPageRequest(nextLink, Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BlueprintArtifactResource(Client, ArtifactData.DeserializeArtifactData(e)), _blueprintArtifactArtifactsClientDiagnostics, Pipeline, "BlueprintArtifactCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactCollection.Exists");
            scope.Start();
            try
            {
                var response = await _blueprintArtifactArtifactsRestClient.GetAsync(Id.Parent, Id.Name, artifactName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactName"> Name of the blueprint artifact. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactName"/> is null. </exception>
        public virtual Response<bool> Exists(string artifactName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactName, nameof(artifactName));

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactCollection.Exists");
            scope.Start();
            try
            {
                var response = _blueprintArtifactArtifactsRestClient.Get(Id.Parent, Id.Name, artifactName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BlueprintArtifactResource> IEnumerable<BlueprintArtifactResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BlueprintArtifactResource> IAsyncEnumerable<BlueprintArtifactResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
