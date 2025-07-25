// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponseMCPCallArgumentsDoneEvent : IJsonModel<InternalResponseMCPCallArgumentsDoneEvent>
    {
        internal InternalResponseMCPCallArgumentsDoneEvent() : this(InternalResponseStreamEventType.ResponseMcpCallArgumentsDone, default, null, default, null, null)
        {
        }

        void IJsonModel<InternalResponseMCPCallArgumentsDoneEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseMCPCallArgumentsDoneEvent)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("arguments") != true)
            {
                writer.WritePropertyName("arguments"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(Arguments);
#else
                using (JsonDocument document = JsonDocument.Parse(Arguments))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }

        InternalResponseMCPCallArgumentsDoneEvent IJsonModel<InternalResponseMCPCallArgumentsDoneEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponseMCPCallArgumentsDoneEvent)JsonModelCreateCore(ref reader, options);

        protected override StreamingResponseUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseMCPCallArgumentsDoneEvent)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponseMCPCallArgumentsDoneEvent(document.RootElement, options);
        }

        internal static InternalResponseMCPCallArgumentsDoneEvent DeserializeInternalResponseMCPCallArgumentsDoneEvent(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponseStreamEventType kind = default;
            int sequenceNumber = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            int outputIndex = default;
            string itemId = default;
            BinaryData arguments = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalResponseStreamEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("sequence_number"u8))
                {
                    sequenceNumber = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("arguments"u8))
                {
                    arguments = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponseMCPCallArgumentsDoneEvent(
                kind,
                sequenceNumber,
                additionalBinaryDataProperties,
                outputIndex,
                itemId,
                arguments);
        }

        BinaryData IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalResponseMCPCallArgumentsDoneEvent)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponseMCPCallArgumentsDoneEvent IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponseMCPCallArgumentsDoneEvent)PersistableModelCreateCore(data, options);

        protected override StreamingResponseUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponseMCPCallArgumentsDoneEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponseMCPCallArgumentsDoneEvent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponseMCPCallArgumentsDoneEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
