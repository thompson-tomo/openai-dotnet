// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentTextAnnotationsFilePathObject : InternalMessageDeltaTextContentAnnotation
    {
        internal InternalMessageDeltaContentTextAnnotationsFilePathObject(int index) : base(InternalMessageContentTextAnnotationType.FilePath)
        {
            Index = index;
        }

        internal InternalMessageDeltaContentTextAnnotationsFilePathObject(InternalMessageContentTextAnnotationType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, int index, string text, InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath filePath, int? startIndex, int? endIndex) : base(kind, additionalBinaryDataProperties)
        {
            Index = index;
            Text = text;
            FilePath = filePath;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        public int Index { get; }

        public string Text { get; }

        internal InternalMessageDeltaContentTextAnnotationsFilePathObjectFilePath FilePath { get; }

        public int? StartIndex { get; }

        public int? EndIndex { get; }
    }
}
