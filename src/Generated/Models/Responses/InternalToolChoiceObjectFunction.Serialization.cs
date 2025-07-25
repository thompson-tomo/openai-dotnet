// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalToolChoiceObjectFunction : IJsonModel<InternalToolChoiceObjectFunction>
    {
        internal InternalToolChoiceObjectFunction() : this(InternalToolChoiceObjectType.Function, null, null)
        {
        }

        void IJsonModel<InternalToolChoiceObjectFunction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalToolChoiceObjectFunction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalToolChoiceObjectFunction)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("name") != true)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
        }

        InternalToolChoiceObjectFunction IJsonModel<InternalToolChoiceObjectFunction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalToolChoiceObjectFunction)JsonModelCreateCore(ref reader, options);

        protected override InternalToolChoiceObject JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalToolChoiceObjectFunction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalToolChoiceObjectFunction)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalToolChoiceObjectFunction(document.RootElement, options);
        }

        internal static InternalToolChoiceObjectFunction DeserializeInternalToolChoiceObjectFunction(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalToolChoiceObjectType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string name = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalToolChoiceObjectType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalToolChoiceObjectFunction(kind, additionalBinaryDataProperties, name);
        }

        BinaryData IPersistableModel<InternalToolChoiceObjectFunction>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalToolChoiceObjectFunction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalToolChoiceObjectFunction)} does not support writing '{options.Format}' format.");
            }
        }

        InternalToolChoiceObjectFunction IPersistableModel<InternalToolChoiceObjectFunction>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalToolChoiceObjectFunction)PersistableModelCreateCore(data, options);

        protected override InternalToolChoiceObject PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalToolChoiceObjectFunction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalToolChoiceObjectFunction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalToolChoiceObjectFunction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalToolChoiceObjectFunction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
