// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeToolChoiceFunctionObject : IJsonModel<InternalRealtimeToolChoiceFunctionObject>
    {
        internal InternalRealtimeToolChoiceFunctionObject() : this(default, null, null)
        {
        }

        void IJsonModel<InternalRealtimeToolChoiceFunctionObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeToolChoiceFunctionObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeToolChoiceFunctionObject)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("function") != true)
            {
                writer.WritePropertyName("function"u8);
                writer.WriteObjectValue(Function, options);
            }
        }

        InternalRealtimeToolChoiceFunctionObject IJsonModel<InternalRealtimeToolChoiceFunctionObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeToolChoiceFunctionObject)JsonModelCreateCore(ref reader, options);

        protected override InternalRealtimeToolChoiceObject JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeToolChoiceFunctionObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeToolChoiceFunctionObject)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeToolChoiceFunctionObject(document.RootElement, options);
        }

        internal static InternalRealtimeToolChoiceFunctionObject DeserializeInternalRealtimeToolChoiceFunctionObject(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConversationToolKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalRealtimeToolChoiceFunctionObjectFunction function = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new ConversationToolKind(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("function"u8))
                {
                    function = InternalRealtimeToolChoiceFunctionObjectFunction.DeserializeInternalRealtimeToolChoiceFunctionObjectFunction(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeToolChoiceFunctionObject(kind, additionalBinaryDataProperties, function);
        }

        BinaryData IPersistableModel<InternalRealtimeToolChoiceFunctionObject>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeToolChoiceFunctionObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeToolChoiceFunctionObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeToolChoiceFunctionObject IPersistableModel<InternalRealtimeToolChoiceFunctionObject>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeToolChoiceFunctionObject)PersistableModelCreateCore(data, options);

        protected override InternalRealtimeToolChoiceObject PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeToolChoiceFunctionObject>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeToolChoiceFunctionObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeToolChoiceFunctionObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeToolChoiceFunctionObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
