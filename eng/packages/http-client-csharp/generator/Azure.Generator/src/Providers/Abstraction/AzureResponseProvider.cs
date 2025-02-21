﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.TypeSpec.Generator.ScmCodeModelPlugin.Providers;
using Microsoft.TypeSpec.Generator.Expressions;
using Microsoft.TypeSpec.Generator.Primitives;
using Microsoft.TypeSpec.Generator.Snippets;
using System;
using System.IO;

namespace Azure.Generator.Providers
{
    internal record AzureResponseProvider : HttpResponseApi
    {
        private static HttpResponseApi? _instance;
        internal static HttpResponseApi Instance => _instance ??= new AzureResponseProvider(Empty);

        public AzureResponseProvider(ValueExpression original) : base(typeof(Response), original)
        {
        }

        public override CSharpType HttpResponseType => typeof(Response);

        public override ScopedApi<BinaryData> Content()
            => Original.Property(nameof(Response.Content)).As<BinaryData>();

        public override ScopedApi<Stream> ContentStream()
            => Original.Property(nameof(Response.ContentStream)).As<Stream>();

        public override HttpResponseApi FromExpression(ValueExpression original)
            => new AzureResponseProvider(original);

        public override ScopedApi<bool> IsError()
            => Original.Property(nameof(Response.IsError)).As<bool>();

        public override HttpResponseApi ToExpression() => this;
    }
}
