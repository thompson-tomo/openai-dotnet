// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalRunOutputItemSample
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalEvalRunOutputItemSample(IEnumerable<InternalEvalRunOutputItemSampleInput> input, IEnumerable<InternalEvalRunOutputItemSampleOutput> output, string finishReason, string model, InternalEvalRunOutputItemSampleUsage usage, InternalEvalApiError error, float temperature, int maxCompletionTokens, float topP, int seed)
        {
            Input = input.ToList();
            Output = output.ToList();
            FinishReason = finishReason;
            Model = model;
            Usage = usage;
            Error = error;
            Temperature = temperature;
            MaxCompletionTokens = maxCompletionTokens;
            TopP = topP;
            Seed = seed;
        }

        internal InternalEvalRunOutputItemSample(IList<InternalEvalRunOutputItemSampleInput> input, IList<InternalEvalRunOutputItemSampleOutput> output, string finishReason, string model, InternalEvalRunOutputItemSampleUsage usage, InternalEvalApiError error, float temperature, int maxCompletionTokens, float topP, int seed, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Input = input ?? new ChangeTrackingList<InternalEvalRunOutputItemSampleInput>();
            Output = output ?? new ChangeTrackingList<InternalEvalRunOutputItemSampleOutput>();
            FinishReason = finishReason;
            Model = model;
            Usage = usage;
            Error = error;
            Temperature = temperature;
            MaxCompletionTokens = maxCompletionTokens;
            TopP = topP;
            Seed = seed;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IList<InternalEvalRunOutputItemSampleInput> Input { get; }

        internal IList<InternalEvalRunOutputItemSampleOutput> Output { get; }

        public string FinishReason { get; }

        public string Model { get; }

        internal InternalEvalRunOutputItemSampleUsage Usage { get; }

        internal InternalEvalApiError Error { get; }

        public float Temperature { get; }

        public int MaxCompletionTokens { get; }

        public float TopP { get; }

        public int Seed { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
