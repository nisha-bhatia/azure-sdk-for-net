// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Management.MediaServices;

namespace Microsoft.WindowsAzure.Management.MediaServices
{
    public partial class MediaServicesManagementClient : ServiceClient<MediaServicesManagementClient>, IMediaServicesManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IAccountOperations _accounts;
        
        public virtual IAccountOperations Accounts
        {
            get { return this._accounts; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesManagementClient
        /// class.
        /// </summary>
        private MediaServicesManagementClient()
            : base()
        {
            this._accounts = new AccountOperations(this);
            this._apiVersion = "2011-10-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public MediaServicesManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public MediaServicesManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        private MediaServicesManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._accounts = new AccountOperations(this);
            this._apiVersion = "2011-10-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public MediaServicesManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public MediaServicesManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// MediaServicesManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of MediaServicesManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<MediaServicesManagementClient> client)
        {
            base.Clone(client);
            
            if (client is MediaServicesManagementClient)
            {
                MediaServicesManagementClient clonedClient = ((MediaServicesManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
