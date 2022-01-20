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
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    internal partial class CertificateOrdersDiagnosticsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of CertificateOrdersDiagnosticsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public CertificateOrdersDiagnosticsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions options, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-02-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListAppServiceCertificateOrderDetectorResponseRequest(string subscriptionId, string resourceGroupName, string certificateOrderName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.CertificateRegistration/certificateOrders/", false);
            uri.AppendPath(certificateOrderName, true);
            uri.AppendPath("/detectors", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="certificateOrderName"/> is null. </exception>
        public async Task<Response<DetectorResponseCollection>> ListAppServiceCertificateOrderDetectorResponseAsync(string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var message = CreateListAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DetectorResponseCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DetectorResponseCollection.DeserializeDetectorResponseCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="certificateOrderName"/> is null. </exception>
        public Response<DetectorResponseCollection> ListAppServiceCertificateOrderDetectorResponse(string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var message = CreateListAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DetectorResponseCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DetectorResponseCollection.DeserializeDetectorResponseCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAppServiceCertificateOrderDetectorResponseRequest(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime, DateTimeOffset? endTime, string timeGrain)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.CertificateRegistration/certificateOrders/", false);
            uri.AppendPath(certificateOrderName, true);
            uri.AppendPath("/detectors/", false);
            uri.AppendPath(detectorName, true);
            if (startTime != null)
            {
                uri.AppendQuery("startTime", startTime.Value, "O", true);
            }
            if (endTime != null)
            {
                uri.AppendQuery("endTime", endTime.Value, "O", true);
            }
            if (timeGrain != null)
            {
                uri.AppendQuery("timeGrain", timeGrain, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Description for Microsoft.CertificateRegistration call to get a detector response from App Lens. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="certificateOrderName"/>, or <paramref name="detectorName"/> is null. </exception>
        public async Task<Response<AppServiceDetectorData>> GetAppServiceCertificateOrderDetectorResponseAsync(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var message = CreateGetAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName, detectorName, startTime, endTime, timeGrain);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppServiceDetectorData.DeserializeAppServiceDetectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppServiceDetectorData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Description for Microsoft.CertificateRegistration call to get a detector response from App Lens. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="detectorName"> The detector name which needs to be run. </param>
        /// <param name="startTime"> The start time for detector response. </param>
        /// <param name="endTime"> The end time for the detector response. </param>
        /// <param name="timeGrain"> The time grain for the detector response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="certificateOrderName"/>, or <paramref name="detectorName"/> is null. </exception>
        public Response<AppServiceDetectorData> GetAppServiceCertificateOrderDetectorResponse(string subscriptionId, string resourceGroupName, string certificateOrderName, string detectorName, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }

            using var message = CreateGetAppServiceCertificateOrderDetectorResponseRequest(subscriptionId, resourceGroupName, certificateOrderName, detectorName, startTime, endTime, timeGrain);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppServiceDetectorData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppServiceDetectorData.DeserializeAppServiceDetectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppServiceDetectorData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="certificateOrderName"/> is null. </exception>
        public async Task<Response<DetectorResponseCollection>> ListAppServiceCertificateOrderDetectorResponseNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var message = CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(nextLink, subscriptionId, resourceGroupName, certificateOrderName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DetectorResponseCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DetectorResponseCollection.DeserializeDetectorResponseCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Description for Microsoft.CertificateRegistration to get the list of detectors for this RP. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="certificateOrderName"> The certificate order name for which the response is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="certificateOrderName"/> is null. </exception>
        public Response<DetectorResponseCollection> ListAppServiceCertificateOrderDetectorResponseNextPage(string nextLink, string subscriptionId, string resourceGroupName, string certificateOrderName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (certificateOrderName == null)
            {
                throw new ArgumentNullException(nameof(certificateOrderName));
            }

            using var message = CreateListAppServiceCertificateOrderDetectorResponseNextPageRequest(nextLink, subscriptionId, resourceGroupName, certificateOrderName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DetectorResponseCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DetectorResponseCollection.DeserializeDetectorResponseCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
