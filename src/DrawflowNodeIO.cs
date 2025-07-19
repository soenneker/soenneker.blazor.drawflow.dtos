using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Blazor.Drawflow.Dtos;

/// <summary>
/// Represents input/output connections for a node
/// </summary>
public sealed class DrawflowNodeIO
{
    /// <summary>
    /// List of connections for this input/output
    /// </summary>
    [JsonPropertyName("connections")]
    public List<DrawflowConnection>? Connections { get; set; }
} 