// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Inference
{
    // Data plane generated client.
    /// <summary> The ChatCompletions service client. </summary>
    public partial class ChatCompletionsClient
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly AzureKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private static readonly string[] AuthorizationScopes = new string[] { "https://ml.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ChatCompletionsClient for mocking. </summary>
        protected ChatCompletionsClient()
        {
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new AzureAIInferenceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new AzureAIInferenceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, TokenCredential credential, AzureAIInferenceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AzureAIInferenceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary>
        /// Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfoAsync(CancellationToken)']/*" />
        public virtual async Task<Response<ModelInfo>> GetModelInfoAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetModelInfoAsync(context).ConfigureAwait(false);
            return Response.FromValue(ModelInfo.FromResponse(response), response);
        }

        /// <summary>
        /// Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfo(CancellationToken)']/*" />
        public virtual Response<ModelInfo> GetModelInfo(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetModelInfo(context);
            return Response.FromValue(ModelInfo.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetModelInfoAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfoAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetModelInfoAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ChatCompletionsClient.GetModelInfo");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelInfoRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetModelInfo(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfo(RequestContext)']/*" />
        public virtual Response GetModelInfo(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ChatCompletionsClient.GetModelInfo");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelInfoRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCompleteRequest(RequestContent content, string extraParams, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/chat/completions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (extraParams != null)
            {
                request.Headers.Add("extra-parameters", extraParams);
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetModelInfoRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/info", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
