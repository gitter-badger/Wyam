﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using System.Threading.Tasks;

namespace Wyam.Modules.Razor.Microsoft.AspNet.Mvc.Razor
{
    public delegate Task RenderAsyncDelegate(TextWriter writer);
}