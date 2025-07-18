// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalTranscriptTextDeltaEventLogprob : IJsonModel<InternalTranscriptTextDeltaEventLogprob>
    {
        void IJsonModel<InternalTranscriptTextDeltaEventLogprob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTranscriptTextDeltaEventLogprob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalTranscriptTextDeltaEventLogprob)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Token) && _additionalBinaryDataProperties?.ContainsKey("token") != true)
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(Logprob) && _additionalBinaryDataProperties?.ContainsKey("logprob") != true)
            {
                writer.WritePropertyName("logprob"u8);
                writer.WriteNumberValue(Logprob.Value);
            }
            if (Optional.IsCollectionDefined(Bytes) && _additionalBinaryDataProperties?.ContainsKey("bytes") != true)
            {
                writer.WritePropertyName("bytes"u8);
                writer.WriteStartArray();
                foreach (int item in Bytes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
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

        InternalTranscriptTextDeltaEventLogprob IJsonModel<InternalTranscriptTextDeltaEventLogprob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalTranscriptTextDeltaEventLogprob JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTranscriptTextDeltaEventLogprob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalTranscriptTextDeltaEventLogprob)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalTranscriptTextDeltaEventLogprob(document.RootElement, options);
        }

        internal static InternalTranscriptTextDeltaEventLogprob DeserializeInternalTranscriptTextDeltaEventLogprob(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            float? logprob = default;
            IList<int> bytes = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("token"u8))
                {
                    token = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("logprob"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logprob = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("bytes"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    bytes = array;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalTranscriptTextDeltaEventLogprob(token, logprob, bytes ?? new ChangeTrackingList<int>(), additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalTranscriptTextDeltaEventLogprob>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTranscriptTextDeltaEventLogprob>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalTranscriptTextDeltaEventLogprob)} does not support writing '{options.Format}' format.");
            }
        }

        InternalTranscriptTextDeltaEventLogprob IPersistableModel<InternalTranscriptTextDeltaEventLogprob>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalTranscriptTextDeltaEventLogprob PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalTranscriptTextDeltaEventLogprob>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalTranscriptTextDeltaEventLogprob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalTranscriptTextDeltaEventLogprob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalTranscriptTextDeltaEventLogprob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
