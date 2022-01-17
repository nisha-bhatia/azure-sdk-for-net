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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates a new database or updates an existing database. </summary>
    public partial class ManagedDatabaseCreateOrUpdateOperation : Operation<ManagedDatabase>, IOperationSource<ManagedDatabase>
    {
        private readonly OperationInternals<ManagedDatabase> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ManagedDatabaseCreateOrUpdateOperation for mocking. </summary>
        protected ManagedDatabaseCreateOrUpdateOperation()
        {
        }

        internal ManagedDatabaseCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ManagedDatabase>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ManagedDatabaseCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedDatabase Value => _operation.Value;

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
        public override ValueTask<Response<ManagedDatabase>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedDatabase>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagedDatabase IOperationSource<ManagedDatabase>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedDatabaseData.DeserializeManagedDatabaseData(document.RootElement);
            return new ManagedDatabase(_operationBase, data);
        }

        async ValueTask<ManagedDatabase> IOperationSource<ManagedDatabase>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedDatabaseData.DeserializeManagedDatabaseData(document.RootElement);
            return new ManagedDatabase(_operationBase, data);
        }
    }
}
