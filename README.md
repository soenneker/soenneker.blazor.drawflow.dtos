[![](https://img.shields.io/nuget/v/soenneker.blazor.drawflow.dtos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.drawflow.dtos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.drawflow.dtos/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.drawflow.dtos/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.drawflow.dtos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.drawflow.dtos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.drawflow.dtos/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.drawflow.dtos/actions/workflows/codeql.yml)

# Soenneker.Blazor.Drawflow.Dtos

Serializable .NET models for the JSON exported and imported by [Drawflow](https://github.com/jerosoler/Drawflow). The package can be used independently for persistence and transport; it is also referenced by `Soenneker.Blazor.Drawflow`.

## Installation

```bash
dotnet add package Soenneker.Blazor.Drawflow.Dtos
```

You do not need to install this package separately when your project already references `Soenneker.Blazor.Drawflow`.

## Model shape

```text
DrawflowExport
└── Drawflow: Dictionary<string, DrawflowModule>       // module name
    └── Data: Dictionary<string, DrawflowNode>          // node ID
        ├── Data: Dictionary<string, object>
        ├── Inputs: Dictionary<string, DrawflowNodeIO>  // input_1, input_2, ...
        └── Outputs: Dictionary<string, DrawflowNodeIO> // output_1, output_2, ...
            └── Connections: List<DrawflowConnection>
```

Property names are mapped to Drawflow's JSON contract with `System.Text.Json` attributes, including `pos_x`, `pos_y`, and `typenode`.

## Create and serialize a flow

```csharp
using System.Text.Json;
using Soenneker.Blazor.Drawflow.Dtos;

var export = new DrawflowExport
{
    Drawflow = new Dictionary<string, DrawflowModule>
    {
        ["Home"] = new()
        {
            Data = new Dictionary<string, DrawflowNode>
            {
                ["source-1"] = new()
                {
                    Id = "source-1",
                    Name = "source",
                    Class = "source-node",
                    Html = "<strong>Orders</strong>",
                    PosX = 80,
                    PosY = 120,
                    Data = new Dictionary<string, object>
                    {
                        ["endpoint"] = "/orders"
                    },
                    Inputs = new Dictionary<string, DrawflowNodeIO>(),
                    Outputs = new Dictionary<string, DrawflowNodeIO>
                    {
                        ["output_1"] = new()
                        {
                            Connections = new List<DrawflowConnection>()
                        }
                    }
                }
            }
        }
    }
};

string json = JsonSerializer.Serialize(export);
```

Deserialize the same shape with:

```csharp
DrawflowExport? export = JsonSerializer.Deserialize<DrawflowExport>(json);
```

Values inside `DrawflowNode.Data` deserialize as `JsonElement` because the dictionary value type is `object`. Convert those values explicitly when reading persisted JSON.

`DrawflowNode.Html` is rendered as HTML by Drawflow. If a flow can be supplied or edited by an untrusted user, sanitize or reject its HTML before giving it to an editor.

## Connection fields

For an output entry, `DrawflowConnection.Node` identifies the destination node and `Input` identifies its input port. For an input entry, `Node` identifies the source node and `Output` identifies its output port.
