// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Containers
{
    [Experimental("OPENAI001")]
    public partial class ContainerResourceExpiresAfter
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ContainerResourceExpiresAfter()
        {
        }

        internal ContainerResourceExpiresAfter(string anchor, int? minutes, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Anchor = anchor;
            Minutes = minutes;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Anchor { get; }

        public int? Minutes { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
