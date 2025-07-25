// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeSessionCreateRequestInputAudioTranscription : IJsonModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>
    {
        void IJsonModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioTranscription)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Model) && _additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(Language) && _additionalBinaryDataProperties?.ContainsKey("language") != true)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Prompt) && _additionalBinaryDataProperties?.ContainsKey("prompt") != true)
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
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

        InternalRealtimeSessionCreateRequestInputAudioTranscription IJsonModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRealtimeSessionCreateRequestInputAudioTranscription JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioTranscription)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeSessionCreateRequestInputAudioTranscription(document.RootElement, options);
        }

        internal static InternalRealtimeSessionCreateRequestInputAudioTranscription DeserializeInternalRealtimeSessionCreateRequestInputAudioTranscription(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string model = default;
            string language = default;
            string prompt = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("model"u8))
                {
                    model = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("language"u8))
                {
                    language = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("prompt"u8))
                {
                    prompt = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeSessionCreateRequestInputAudioTranscription(model, language, prompt, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioTranscription)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeSessionCreateRequestInputAudioTranscription IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRealtimeSessionCreateRequestInputAudioTranscription PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeSessionCreateRequestInputAudioTranscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioTranscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioTranscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
