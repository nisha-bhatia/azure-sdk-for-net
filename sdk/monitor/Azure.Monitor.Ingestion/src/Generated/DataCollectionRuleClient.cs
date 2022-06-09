// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Monitor.Ingestion
{
    /// <summary> The DataCollectionRule service client. </summary>
    public partial class DataCollectionRuleClient
    {
        private readonly TokenCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DataCollectionRuleClient for mocking. </summary>
        protected DataCollectionRuleClient()
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleClient. </summary>
        /// <param name="endpoint"> The Data Collection Endpoint for the Data Collection Rule, for example https://dce-name.eastus-2.ingest.monitor.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DataCollectionRuleClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new DataCollectionRuleClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DataCollectionRuleClient. </summary>
        /// <param name="endpoint"> The Data Collection Endpoint for the Data Collection Rule, for example https://dce-name.eastus-2.ingest.monitor.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DataCollectionRuleClient(Uri endpoint, TokenCredential credential, DataCollectionRuleClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new DataCollectionRuleClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            var scope = "https://monitor.azure.com//.default";
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(credential, scope) }, new ResponseClassifier());
            _endpoint = endpoint.AbsoluteUri;
            _apiVersion = options.Version;
        }

        /// <summary> See error response code and error response message for more detail. </summary>
        /// <param name="ruleId"> The immutable Id of the Data Collection Rule resource. </param>
        /// <param name="stream"> The streamDeclaration name as defined in the Data Collection Rule. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentEncoding"> gzip. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/>, <paramref name="stream"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> or <paramref name="stream"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorDetail],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> IngestAsync(string ruleId, string stream, RequestContent content, string contentEncoding = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNullOrEmpty(stream, nameof(stream));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("DataCollectionRuleClient.Ingest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIngestRequest(ruleId, stream, content, contentEncoding, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> See error response code and error response message for more detail. </summary>
        /// <param name="ruleId"> The immutable Id of the Data Collection Rule resource. </param>
        /// <param name="stream"> The streamDeclaration name as defined in the Data Collection Rule. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentEncoding"> gzip. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/>, <paramref name="stream"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="ruleId"/> or <paramref name="stream"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [ErrorDetail],
        ///     additionalInfo: [
        ///       {
        ///         type: string,
        ///         info: AnyObject
        ///       }
        ///     ]
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Ingest(string ruleId, string stream, RequestContent content, string contentEncoding = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(ruleId, nameof(ruleId));
            Argument.AssertNotNullOrEmpty(stream, nameof(stream));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("DataCollectionRuleClient.Ingest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIngestRequest(ruleId, stream, content, contentEncoding, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateIngestRequest(string ruleId, string stream, RequestContent content, string contentEncoding, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/dataCollectionRules/", false);
            uri.AppendPath(ruleId, true);
            uri.AppendPath("/streams/", false);
            uri.AppendPath(stream, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            if (contentEncoding != null)
            {
                request.Headers.Add("Content-Encoding", contentEncoding);
            }
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
