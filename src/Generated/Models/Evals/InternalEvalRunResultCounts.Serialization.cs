// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalRunResultCounts : IJsonModel<InternalEvalRunResultCounts>
    {
        internal InternalEvalRunResultCounts()
        {
        }

        void IJsonModel<InternalEvalRunResultCounts>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunResultCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalEvalRunResultCounts)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("total") != true)
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("errored") != true)
            {
                writer.WritePropertyName("errored"u8);
                writer.WriteNumberValue(Errored);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("failed") != true)
            {
                writer.WritePropertyName("failed"u8);
                writer.WriteNumberValue(Failed);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("passed") != true)
            {
                writer.WritePropertyName("passed"u8);
                writer.WriteNumberValue(Passed);
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalEvalRunResultCounts IJsonModel<InternalEvalRunResultCounts>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalEvalRunResultCounts JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunResultCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalEvalRunResultCounts)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalEvalRunResultCounts(document.RootElement, options);
        }

        internal static InternalEvalRunResultCounts DeserializeInternalEvalRunResultCounts(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int total = default;
            int errored = default;
            int failed = default;
            int passed = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("total"u8))
                {
                    total = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("errored"u8))
                {
                    errored = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("failed"u8))
                {
                    failed = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("passed"u8))
                {
                    passed = prop.Value.GetInt32();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalEvalRunResultCounts(total, errored, failed, passed, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalEvalRunResultCounts>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunResultCounts>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalEvalRunResultCounts)} does not support writing '{options.Format}' format.");
            }
        }

        InternalEvalRunResultCounts IPersistableModel<InternalEvalRunResultCounts>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalEvalRunResultCounts PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalRunResultCounts>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalEvalRunResultCounts(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalEvalRunResultCounts)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalEvalRunResultCounts>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
