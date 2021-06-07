// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace OperationalInsightsManagementClient.Models
{
    public partial class AvailableServiceTier
    {
        internal static AvailableServiceTier DeserializeAvailableServiceTier(JsonElement element)
        {
            Optional<SkuNameEnum> serviceTier = default;
            Optional<bool> enabled = default;
            Optional<long> minimumRetention = default;
            Optional<long> maximumRetention = default;
            Optional<long> defaultRetention = default;
            Optional<long> capacityReservationLevel = default;
            Optional<string> lastSkuUpdate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceTier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serviceTier = new SkuNameEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minimumRetention"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximumRetention"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maximumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultRetention"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("capacityReservationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacityReservationLevel = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastSkuUpdate"))
                {
                    lastSkuUpdate = property.Value.GetString();
                    continue;
                }
            }
            return new AvailableServiceTier(Optional.ToNullable(serviceTier), Optional.ToNullable(enabled), Optional.ToNullable(minimumRetention), Optional.ToNullable(maximumRetention), Optional.ToNullable(defaultRetention), Optional.ToNullable(capacityReservationLevel), lastSkuUpdate.Value);
        }
    }
}
