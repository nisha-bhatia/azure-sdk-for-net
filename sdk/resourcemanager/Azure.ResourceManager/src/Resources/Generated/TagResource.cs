// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a TagResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TagResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTagResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetTagResource method.
    /// </summary>
    public partial class TagResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TagResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope)
        {
            var resourceId = $"{scope}/providers/Microsoft.Resources/tags/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tagResourceTagsClientDiagnostics;
        private readonly TagsRestOperations _tagResourceTagsRestClient;
        private readonly TagResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="TagResource"/> class for mocking. </summary>
        protected TagResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TagResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TagResource(ArmClient client, TagResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TagResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TagResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tagResourceTagsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tagResourceTagsApiVersion);
            _tagResourceTagsRestClient = new TagsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tagResourceTagsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/tags";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TagResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the entire set of tags on a resource or subscription.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_GetAtScope
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TagResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Get");
            scope0.Start();
            try
            {
                var response = await _tagResourceTagsRestClient.GetAtScopeAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entire set of tags on a resource or subscription.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_GetAtScope
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TagResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Get");
            scope0.Start();
            try
            {
                var response = _tagResourceTagsRestClient.GetAtScope(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the entire set of tags on a resource or subscription.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_DeleteAtScope
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Delete");
            scope0.Start();
            try
            {
                var response = await _tagResourceTagsRestClient.DeleteAtScopeAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the entire set of tags on a resource or subscription.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_DeleteAtScope
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Delete");
            scope0.Start();
            try
            {
                var response = _tagResourceTagsRestClient.DeleteAtScope(Id.Parent, cancellationToken);
                var operation = new ResourcesArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation allows replacing, merging or selectively deleting tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags at the end of the operation. The &apos;replace&apos; option replaces the entire set of existing tags with a new set. The &apos;merge&apos; option allows adding tags with new names and updating the values of tags with existing names. The &apos;delete&apos; option allows selectively deleting tags based on given names or name/value pairs.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_UpdateAtScope
        /// </summary>
        /// <param name="patch"> The TagResourcePatch to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<TagResource>> UpdateAsync(TagResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Update");
            scope0.Start();
            try
            {
                var response = await _tagResourceTagsRestClient.UpdateAtScopeAsync(Id.Parent, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation allows replacing, merging or selectively deleting tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags at the end of the operation. The &apos;replace&apos; option replaces the entire set of existing tags with a new set. The &apos;merge&apos; option allows adding tags with new names and updating the values of tags with existing names. The &apos;delete&apos; option allows selectively deleting tags based on given names or name/value pairs.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_UpdateAtScope
        /// </summary>
        /// <param name="patch"> The TagResourcePatch to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<TagResource> Update(TagResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.Update");
            scope0.Start();
            try
            {
                var response = _tagResourceTagsRestClient.UpdateAtScope(Id.Parent, patch, cancellationToken);
                return Response.FromValue(new TagResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation allows adding or replacing the entire set of tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_CreateOrUpdateAtScope
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The TagResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TagResource>> CreateOrUpdateAsync(WaitUntil waitUntil, TagResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.CreateOrUpdate");
            scope0.Start();
            try
            {
                var response = await _tagResourceTagsRestClient.CreateOrUpdateAtScopeAsync(Id.Parent, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<TagResource>(Response.FromValue(new TagResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation allows adding or replacing the entire set of tags on the specified resource or subscription. The specified entity can have a maximum of 50 tags.
        /// Request Path: /{scope}/providers/Microsoft.Resources/tags/default
        /// Operation Id: Tags_CreateOrUpdateAtScope
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The TagResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TagResource> CreateOrUpdate(WaitUntil waitUntil, TagResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope0 = _tagResourceTagsClientDiagnostics.CreateScope("TagResource.CreateOrUpdate");
            scope0.Start();
            try
            {
                var response = _tagResourceTagsRestClient.CreateOrUpdateAtScope(Id.Parent, data, cancellationToken);
                var operation = new ResourcesArmOperation<TagResource>(Response.FromValue(new TagResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
