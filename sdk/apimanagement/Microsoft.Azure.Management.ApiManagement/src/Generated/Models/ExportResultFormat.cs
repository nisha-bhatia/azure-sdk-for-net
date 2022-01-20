// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{

    /// <summary>
    /// Defines values for ExportResultFormat.
    /// </summary>
    public static class ExportResultFormat
    {
        /// <summary>
        /// The API Definition is exported in OpenAPI Specification 2.0 format
        /// to the Storage Blob.
        /// </summary>
        public const string Swagger = "swagger-link-json";
        /// <summary>
        /// The API Definition is exported in WSDL Schema to Storage Blob. This
        /// is only supported for APIs of Type `soap`
        /// </summary>
        public const string Wsdl = "wsdl-link+xml";
        /// <summary>
        /// Export the API Definition in WADL Schema to Storage Blob.
        /// </summary>
        public const string Wadl = "wadl-link-json";
        /// <summary>
        /// Export the API Definition in OpenAPI Specification 3.0 to Storage
        /// Blob.
        /// </summary>
        public const string OpenApi = "openapi-link";
    }
}
