// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Create or update an Azure Cosmos DB Cassandra keyspace. </summary>
    public partial class CassandraResourceCreateUpdateCassandraKeyspaceOperation : Operation<CassandraKeyspace>, IOperationSource<CassandraKeyspace>
    {
        private readonly OperationInternals<CassandraKeyspace> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of CassandraResourceCreateUpdateCassandraKeyspaceOperation for mocking. </summary>
        protected CassandraResourceCreateUpdateCassandraKeyspaceOperation()
        {
        }

        internal CassandraResourceCreateUpdateCassandraKeyspaceOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CassandraKeyspace>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CassandraResourceCreateUpdateCassandraKeyspaceOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CassandraKeyspace Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CassandraKeyspace>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CassandraKeyspace>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CassandraKeyspace IOperationSource<CassandraKeyspace>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CassandraKeyspaceData.DeserializeCassandraKeyspaceData(document.RootElement);
            return new CassandraKeyspace(_operationBase, data);
        }

        async ValueTask<CassandraKeyspace> IOperationSource<CassandraKeyspace>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CassandraKeyspaceData.DeserializeCassandraKeyspaceData(document.RootElement);
            return new CassandraKeyspace(_operationBase, data);
        }
    }
}
