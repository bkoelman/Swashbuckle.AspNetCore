#if NET10_0_OR_GREATER
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Swashbuckle.AspNetCore;

internal static class JsonExtensions
{
    private static readonly JsonSerializerOptions Options = new()
    {
        NewLine = "\n",
        WriteIndented = true,
    };

    public static string ToJson(this JsonNode value)
        => value.ToJsonString(Options);
}
#endif
