﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Xunit;

namespace Microsoft.Azure.Commands.Insights.Test.ScenarioTests
{
    public class ActivityLogsTests : RMTestBase
    {
        public ActivityLogsTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            //ServiceManagemenet.Common.Models.XunitTracingInterceptor.AddToContext(new ServiceManagemenet.Common.Models.XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureCorrelationIdLog()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureCorrelationIdLog");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureResourceGroupLog()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureResourceGroupLog");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureResourceLog()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureResourceLog");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureResourceProviderLog()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureResourceProviderLog");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureSubscriptionIdLog()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureSubscriptionIdLog");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureSubscriptionIdLogMaxEvents()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureSubscriptionIdLogMaxEvents");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetAzureSubscriptionIdLogPaged()
        {
            TestsController.NewInstance.RunPsTest("Test-GetAzureSubscriptionIdLogPaged");
        }
    }
}
