// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalLogsDataSourceConfigParams : IJsonModel<InternalEvalLogsDataSourceConfigParams>
    {
        void IJsonModel<InternalEvalLogsDataSourceConfigParams>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalLogsDataSourceConfigParams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalEvalLogsDataSourceConfigParams)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Metadata) && _additionalBinaryDataProperties?.ContainsKey("metadata") != true)
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
        }

        InternalEvalLogsDataSourceConfigParams IJsonModel<InternalEvalLogsDataSourceConfigParams>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalEvalLogsDataSourceConfigParams)JsonModelCreateCore(ref reader, options);

        protected override InternalEvalDataSourceConfigParams JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalLogsDataSourceConfigParams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalEvalLogsDataSourceConfigParams)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalEvalLogsDataSourceConfigParams(document.RootElement, options);
        }

        internal static InternalEvalLogsDataSourceConfigParams DeserializeInternalEvalLogsDataSourceConfigParams(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalEvalDataSourceConfigType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            IDictionary<string, string> metadata = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalEvalDataSourceConfigType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("metadata"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, prop0.Value.GetString());
                        }
                    }
                    metadata = dictionary;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalEvalLogsDataSourceConfigParams(kind, additionalBinaryDataProperties, metadata ?? new ChangeTrackingDictionary<string, string>());
        }

        BinaryData IPersistableModel<InternalEvalLogsDataSourceConfigParams>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalLogsDataSourceConfigParams>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalEvalLogsDataSourceConfigParams)} does not support writing '{options.Format}' format.");
            }
        }

        InternalEvalLogsDataSourceConfigParams IPersistableModel<InternalEvalLogsDataSourceConfigParams>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalEvalLogsDataSourceConfigParams)PersistableModelCreateCore(data, options);

        protected override InternalEvalDataSourceConfigParams PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalEvalLogsDataSourceConfigParams>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalEvalLogsDataSourceConfigParams(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalEvalLogsDataSourceConfigParams)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalEvalLogsDataSourceConfigParams>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
