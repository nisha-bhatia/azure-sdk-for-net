﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class SiteSourceControlOperationsTests : AppServiceTestBase
    {
        public SiteSourceControlOperationsTests(bool isAsync)
    : base(isAsync, RecordedTestMode.Record)
        {
        }
    }
}
