// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeServerEventResponseFunctionCallArgumentsDelta : IJsonModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>
    {
        internal InternalRealtimeServerEventResponseFunctionCallArgumentsDelta() : this(RealtimeUpdateKind.ItemStreamingFunctionCallArgumentsDelta, null, null, null, null, default, null, null)
        {
        }

        void IJsonModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("response_id") != true)
            {
                writer.WritePropertyName("response_id"u8);
                writer.WriteStringValue(ResponseId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("call_id") != true)
            {
                writer.WritePropertyName("call_id"u8);
                writer.WriteStringValue(CallId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("delta") != true)
            {
                writer.WritePropertyName("delta"u8);
                writer.WriteStringValue(Delta);
            }
        }

        InternalRealtimeServerEventResponseFunctionCallArgumentsDelta IJsonModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)JsonModelCreateCore(ref reader, options);

        protected override RealtimeUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(document.RootElement, options);
        }

        internal static InternalRealtimeServerEventResponseFunctionCallArgumentsDelta DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RealtimeUpdateKind kind = default;
            string eventId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string responseId = default;
            string itemId = default;
            int outputIndex = default;
            string callId = default;
            string delta = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToRealtimeUpdateKind();
                    continue;
                }
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("response_id"u8))
                {
                    responseId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("call_id"u8))
                {
                    callId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("delta"u8))
                {
                    delta = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeServerEventResponseFunctionCallArgumentsDelta(
                kind,
                eventId,
                additionalBinaryDataProperties,
                responseId,
                itemId,
                outputIndex,
                callId,
                delta);
        }

        BinaryData IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeServerEventResponseFunctionCallArgumentsDelta IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)PersistableModelCreateCore(data, options);

        protected override RealtimeUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
