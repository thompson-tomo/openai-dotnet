// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class DeveloperChatMessage : ChatMessage
    {
        internal DeveloperChatMessage() : this(null, ChatMessageRole.Developer, null, null)
        {
        }

        internal DeveloperChatMessage(ChatMessageContent content, ChatMessageRole role, IDictionary<string, BinaryData> additionalBinaryDataProperties, string participantName) : base(content, role, additionalBinaryDataProperties)
        {
            ParticipantName = participantName;
        }
    }
}
