// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalStoredCompletionsDataSourceConfigResource : InternalEvalDataSourceConfigResource
    {
        internal InternalEvalStoredCompletionsDataSourceConfigResource(IDictionary<string, string> metadata, IDictionary<string, BinaryData> schema) : base(InternalEvalDataSourceConfigType.StoredCompletions)
        {
            // Plugin customization: ensure initialization of collections
            Metadata = metadata ?? new ChangeTrackingDictionary<string, string>();
            Schema = schema ?? new ChangeTrackingDictionary<string, BinaryData>();
        }

        internal InternalEvalStoredCompletionsDataSourceConfigResource(InternalEvalDataSourceConfigType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, IDictionary<string, string> metadata, IDictionary<string, BinaryData> schema) : base(kind, additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Metadata = metadata ?? new ChangeTrackingDictionary<string, string>();
            Schema = schema ?? new ChangeTrackingDictionary<string, BinaryData>();
        }

        public IDictionary<string, string> Metadata { get; }

        public IDictionary<string, BinaryData> Schema { get; }
    }
}
