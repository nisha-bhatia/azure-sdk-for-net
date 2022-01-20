// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a User along with the instance operations that can be performed on it. </summary>
    public partial class User : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="User"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier()
        {
            var resourceId = $"/providers/Microsoft.Web/publishingUsers/web";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebSiteManagementRestOperations _restClient;
        private readonly UserData _data;

        /// <summary> Initializes a new instance of the <see cref="User"/> class for mocking. </summary>
        protected User()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "User"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal User(ArmResource options, UserData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _restClient = new WebSiteManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="User"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal User(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _restClient = new WebSiteManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="User"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal User(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _restClient = new WebSiteManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/publishingUsers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual UserData Data
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

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /providers/Microsoft.Web/publishingUsers/web
        /// ContextualPath: /providers/Microsoft.Web/publishingUsers/web
        /// OperationId: GetPublishingUser
        /// <summary> Description for Gets publishing user. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<User>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("User.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetPublishingUserAsync(cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new User(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Web/publishingUsers/web
        /// ContextualPath: /providers/Microsoft.Web/publishingUsers/web
        /// OperationId: GetPublishingUser
        /// <summary> Description for Gets publishing user. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("User.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetPublishingUser(cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new User(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("User.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("User.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Web/publishingUsers/web
        /// ContextualPath: /providers/Microsoft.Web/publishingUsers/web
        /// OperationId: UpdatePublishingUser
        /// <summary> Description for Updates publishing user. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="userDetails"> Details of publishing user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDetails"/> is null. </exception>
        public async virtual Task<UserCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, UserData userDetails, CancellationToken cancellationToken = default)
        {
            if (userDetails == null)
            {
                throw new ArgumentNullException(nameof(userDetails));
            }

            using var scope = _clientDiagnostics.CreateScope("User.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.UpdatePublishingUserAsync(userDetails, cancellationToken).ConfigureAwait(false);
                var operation = new UserCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /providers/Microsoft.Web/publishingUsers/web
        /// ContextualPath: /providers/Microsoft.Web/publishingUsers/web
        /// OperationId: UpdatePublishingUser
        /// <summary> Description for Updates publishing user. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="userDetails"> Details of publishing user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userDetails"/> is null. </exception>
        public virtual UserCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, UserData userDetails, CancellationToken cancellationToken = default)
        {
            if (userDetails == null)
            {
                throw new ArgumentNullException(nameof(userDetails));
            }

            using var scope = _clientDiagnostics.CreateScope("User.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.UpdatePublishingUser(userDetails, cancellationToken);
                var operation = new UserCreateOrUpdateOperation(this, response);
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
    }
}
