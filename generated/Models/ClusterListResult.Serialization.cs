// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace OperationalInsightsManagementClient.Models
{
    internal partial class ClusterListResult
    {
        internal static ClusterListResult DeserializeClusterListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<Cluster>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Cluster> array = new List<Cluster>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Cluster.DeserializeCluster(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ClusterListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
