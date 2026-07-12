
#nullable enable

namespace SmallestAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceCloneRequest
    {
        /// <summary>
        /// Human-readable name for the voice clone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Optional longer description for the voice clone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional accent tag (e.g. "general", "indian").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Optional comma-separated list of tags. Server splits on<br/>
        /// commas and trims whitespace (`"en, tone-test"` → `["en", "tone-test"]`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// Primary language the clone will be used for. Optional, but<br/>
        /// **strongly recommended** — set it to the language of your<br/>
        /// reference audio. The TTS request's `language` should also<br/>
        /// match this code; setting it now avoids silent language<br/>
        /// mismatches at inference time.<br/>
        /// Must be one of the languages supported by `lightning-v3.1`<br/>
        /// (e.g. `en`, `hi`). The server validates and rejects<br/>
        /// unsupported codes with a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
        /// `lightning-v2` is accepted by the schema for historical<br/>
        /// reasons but is deprecated — the server returns 400 with<br/>
        /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
        /// Default Value: lightning-v3.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SmallestAI.JsonConverters.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModelJsonConverter))]
        public global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceCloneRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Human-readable name for the voice clone.
        /// </param>
        /// <param name="file">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="filename">
        /// Audio file to clone from. Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/mpeg-3`, `audio/wav`, `audio/wave`,<br/>
        /// `audio/webm`, `video/webm`, `audio/mp4`, `video/mp4`.<br/>
        /// Maximum size: 5 MB.
        /// </param>
        /// <param name="description">
        /// Optional longer description for the voice clone.
        /// </param>
        /// <param name="accent">
        /// Optional accent tag (e.g. "general", "indian").
        /// </param>
        /// <param name="tags">
        /// Optional comma-separated list of tags. Server splits on<br/>
        /// commas and trims whitespace (`"en, tone-test"` → `["en", "tone-test"]`).
        /// </param>
        /// <param name="language">
        /// Primary language the clone will be used for. Optional, but<br/>
        /// **strongly recommended** — set it to the language of your<br/>
        /// reference audio. The TTS request's `language` should also<br/>
        /// match this code; setting it now avoids silent language<br/>
        /// mismatches at inference time.<br/>
        /// Must be one of the languages supported by `lightning-v3.1`<br/>
        /// (e.g. `en`, `hi`). The server validates and rejects<br/>
        /// unsupported codes with a 400.
        /// </param>
        /// <param name="model">
        /// Voice cloning model. Defaults to `lightning-v3.1`.<br/>
        /// `lightning-v2` is accepted by the schema for historical<br/>
        /// reasons but is deprecated — the server returns 400 with<br/>
        /// `"Voice cloning for lightning-v2 is deprecated. Please use lightning-v3.1"`.<br/>
        /// Default Value: lightning-v3.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceCloneRequest(
            string displayName,
            byte[] file,
            string filename,
            string? description,
            string? accent,
            string? tags,
            string? language,
            global::SmallestAI.WavesV1VoiceCloningPostRequestBodyContentMultipartFormDataSchemaModel? model)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Description = description;
            this.Accent = accent;
            this.Tags = tags;
            this.Language = language;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceCloneRequest" /> class.
        /// </summary>
        public CreateVoiceCloneRequest()
        {
        }

    }
}