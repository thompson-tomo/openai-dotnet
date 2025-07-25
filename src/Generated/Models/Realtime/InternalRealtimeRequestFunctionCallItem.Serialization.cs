// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeRequestFunctionCallItem : IJsonModel<InternalRealtimeRequestFunctionCallItem>
    {
        internal InternalRealtimeRequestFunctionCallItem() : this(InternalRealtimeItemType.FunctionCall, null, null, null, null, null, default)
        {
        }

        void IJsonModel<InternalRealtimeRequestFunctionCallItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestFunctionCallItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeRequestFunctionCallItem)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("name") != true)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("call_id") != true)
            {
                writer.WritePropertyName("call_id"u8);
                writer.WriteStringValue(CallId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("arguments") != true)
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStringValue(Arguments);
            }
            if (Optional.IsDefined(Status) && _additionalBinaryDataProperties?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
        }

        InternalRealtimeRequestFunctionCallItem IJsonModel<InternalRealtimeRequestFunctionCallItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeRequestFunctionCallItem)JsonModelCreateCore(ref reader, options);

        protected override RealtimeItem JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestFunctionCallItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeRequestFunctionCallItem)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeRequestFunctionCallItem(document.RootElement, options);
        }

        internal static InternalRealtimeRequestFunctionCallItem DeserializeInternalRealtimeRequestFunctionCallItem(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeItemType kind = default;
            string id = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string name = default;
            string callId = default;
            string arguments = default;
            ConversationItemStatus? status = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalRealtimeItemType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("id"u8))
                {
                    id = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("call_id"u8))
                {
                    callId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("arguments"u8))
                {
                    arguments = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("status"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ConversationItemStatus(prop.Value.GetString());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeRequestFunctionCallItem(
                kind,
                id,
                additionalBinaryDataProperties,
                name,
                callId,
                arguments,
                status);
        }

        BinaryData IPersistableModel<InternalRealtimeRequestFunctionCallItem>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestFunctionCallItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeRequestFunctionCallItem)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeRequestFunctionCallItem IPersistableModel<InternalRealtimeRequestFunctionCallItem>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeRequestFunctionCallItem)PersistableModelCreateCore(data, options);

        protected override RealtimeItem PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeRequestFunctionCallItem>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeRequestFunctionCallItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeRequestFunctionCallItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeRequestFunctionCallItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
