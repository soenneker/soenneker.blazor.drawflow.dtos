[![](https://img.shields.io/nuget/v/soenneker.blazor.drawflow.dtos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.drawflow.dtos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.drawflow.dtos/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.drawflow.dtos/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.drawflow.dtos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.drawflow.dtos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.drawflow.dtos/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.drawflow.dtos/actions/workflows/codeql.yml)

# Soenneker.Blazor.Drawflow.Dtos

Represents a connection between nodes.

## Install

```bash
dotnet add package Soenneker.Blazor.Drawflow.Dtos
```

## What you get

- `DrawflowConnection` — Represents a connection between nodes.
- `DrawflowExport` — Represents the complete drawflow export structure containing all modules and their data.
- `DrawflowModule` — Represents a module within the drawflow graph containing nodes.
- `DrawflowNode` — Represents a node within a drawflow module with all its properties and connections.
- `DrawflowNodeIO` — Represents input/output connections for a node.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DrawflowConnection.Node` | The node ID this connection is connected to. | The node ID this connection is connected to. |
| `DrawflowConnection.Input` | The input identifier (used for output connections). | The input identifier (used for output connections). |
| `DrawflowConnection.Output` | The output identifier (used for input connections). | The output identifier (used for input connections). |
| `DrawflowExport.Drawflow` | Dictionary of modules, where each module contains nodes and their data. | Dictionary of modules, where each module contains nodes and their data. |
| `DrawflowModule.Data` | Dictionary of nodes within this module, keyed by node ID. | Dictionary of nodes within this module, keyed by node ID. |
| `DrawflowNode.Id` | Unique identifier for the node. | Unique identifier for the node. |
| `DrawflowNode.Name` | Name of the node. | Name of the node. |
| `DrawflowNode.Data` | Custom data associated with the node. | Custom data associated with the node. |
| `DrawflowNode.Class` | CSS class name for styling the node. | CSS class name for styling the node. |
| `DrawflowNode.Html` | HTML content for the node display. | HTML content for the node display. |
| `DrawflowNode.TypeNode` | Whether this is a type node (template node). | Whether this is a type node (template node). |
| `DrawflowNode.Inputs` | Input connections for the node, keyed by input name. | Input connections for the node, keyed by input name. |
| `DrawflowNode.Outputs` | Output connections for the node, keyed by output name. | Output connections for the node, keyed by output name. |
| `DrawflowNode.PosX` | X position of the node on the canvas. | X position of the node on the canvas. |
| `DrawflowNode.PosY` | Y position of the node on the canvas. | Y position of the node on the canvas. |
| `DrawflowNode.AltPosX` | Alternative X position (used for some positioning calculations). | Alternative X position (used for some positioning calculations). |
| `DrawflowNode.AltPosY` | Alternative Y position (used for some positioning calculations). | Alternative Y position (used for some positioning calculations). |
| `DrawflowNodeIO.Connections` | List of connections for this input/output. | List of connections for this input/output. |
