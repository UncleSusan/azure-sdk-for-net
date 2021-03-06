// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    internal partial class ModelInfo_internal
    {
        internal static ModelInfo_internal DeserializeModelInfo_internal(JsonElement element)
        {
            Guid modelId = default;
            CustomFormModelStatus status = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"))
                {
                    modelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToCustomFormModelStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
            }
            return new ModelInfo_internal(modelId, status, createdDateTime, lastUpdatedDateTime);
        }
    }
}
