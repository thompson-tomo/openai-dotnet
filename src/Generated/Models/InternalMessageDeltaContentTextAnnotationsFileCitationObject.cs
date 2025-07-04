// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaContentTextAnnotationsFileCitationObject : InternalMessageDeltaTextContentAnnotation
    {
        internal InternalMessageDeltaContentTextAnnotationsFileCitationObject(int index) : base(InternalMessageContentTextAnnotationType.FileCitation)
        {
            Index = index;
        }

        internal InternalMessageDeltaContentTextAnnotationsFileCitationObject(InternalMessageContentTextAnnotationType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, int index, string text, InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation fileCitation, int? startIndex, int? endIndex) : base(kind, additionalBinaryDataProperties)
        {
            Index = index;
            Text = text;
            FileCitation = fileCitation;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        public int Index { get; }

        public string Text { get; }

        internal InternalMessageDeltaContentTextAnnotationsFileCitationObjectFileCitation FileCitation { get; }

        public int? StartIndex { get; }

        public int? EndIndex { get; }
    }
}
