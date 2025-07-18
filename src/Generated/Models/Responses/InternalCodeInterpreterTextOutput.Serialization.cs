// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalCodeInterpreterTextOutput : IJsonModel<InternalCodeInterpreterTextOutput>
    {
        internal InternalCodeInterpreterTextOutput()
        {
        }

        void IJsonModel<InternalCodeInterpreterTextOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTextOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterTextOutput)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("logs") != true)
            {
                writer.WritePropertyName("logs"u8);
                writer.WriteStringValue(Logs);
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

        InternalCodeInterpreterTextOutput IJsonModel<InternalCodeInterpreterTextOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalCodeInterpreterTextOutput JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTextOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterTextOutput)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCodeInterpreterTextOutput(document.RootElement, options);
        }

        internal static InternalCodeInterpreterTextOutput DeserializeInternalCodeInterpreterTextOutput(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            string logs = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("logs"u8))
                {
                    logs = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalCodeInterpreterTextOutput(kind, logs, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalCodeInterpreterTextOutput>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTextOutput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterTextOutput)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCodeInterpreterTextOutput IPersistableModel<InternalCodeInterpreterTextOutput>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalCodeInterpreterTextOutput PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTextOutput>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCodeInterpreterTextOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterTextOutput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCodeInterpreterTextOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
