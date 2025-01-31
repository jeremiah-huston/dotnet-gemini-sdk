using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotnetGeminiSDK.Model.Request
{
    public class Content
    {
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string? Role { get; set; }

        [JsonProperty("parts")] public List<Part> Parts { get; set; }
    }

    public class Part
    {
        [JsonProperty("text")] public string Text { get; set; }

        [JsonProperty("inlineData", NullValueHandling = NullValueHandling.Ignore)]
        public InlineData? InlineData { get; set; }
    }

    public class GeminiMessageRequest
    {
        [JsonProperty("contents")] public List<Content> Contents { get; set; }

        [JsonProperty("generationConfig", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationConfig? GenerationConfig { get; set; }

        [JsonProperty("safetySetting", NullValueHandling = NullValueHandling.Ignore)]
        public SafetySetting? SafetySetting { get; set; }
    }

    public class GenerationConfig
    {
        [JsonProperty("stopSequences", NullValueHandling = NullValueHandling.Ignore)] public List<string>? StopSequences { get; set; }

        [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)] public double ?Temperature { get; set; }

        [JsonProperty("maxOutputTokens", NullValueHandling = NullValueHandling.Ignore)] public int? MaxOutputTokens { get; set; }

        [JsonProperty("response_mime_type", NullValueHandling = NullValueHandling.Ignore)] public string? ResponseMimeType { get; set; }

        [JsonProperty("response_schema", NullValueHandling = NullValueHandling.Ignore)] public dynamic? ResponseSchema { get; set; }

        [JsonProperty("topP", NullValueHandling = NullValueHandling.Ignore)] public double? TopP { get; set; }

        [JsonProperty("topK", NullValueHandling = NullValueHandling.Ignore)] public int? TopK { get; set; }
    }

    public class SafetySetting
    {
        [JsonProperty("category")] public string Category { get; set; }

        [JsonProperty("threshold")] public string Threshold { get; set; }
    }

    public class InlineData
    {
        [JsonProperty("mime_type")] public string MimeType { get; set; }

        [JsonProperty("data")] public string Data { get; set; }
    }
}