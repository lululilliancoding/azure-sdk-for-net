// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class TriggerRunsQueryResponse
    {
        internal static TriggerRunsQueryResponse DeserializeTriggerRunsQueryResponse(JsonElement element)
        {
            IReadOnlyList<TriggerRun> value = default;
            string continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TriggerRun> array = new List<TriggerRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TriggerRun.DeserializeTriggerRun(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerRunsQueryResponse(value, continuationToken);
        }
    }
}
