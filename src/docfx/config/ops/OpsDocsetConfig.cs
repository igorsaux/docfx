// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

#nullable enable

namespace Microsoft.Docs.Build
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    internal class OpsDocsetConfig
    {
        public readonly string DocsetName = "";

        public readonly PathString BuildSourceFolder;

        public readonly bool OpenToPublicContributors;

        public readonly string[] XrefQueryTags = Array.Empty<string>();
    }
}