# C# target for ANTLR 4

## Introduction

This document gives a basic overview of using the C# target for ANTLR 4
with C# projects in Visual Studio.

### Available Targets

This target provides several C# targets, numbered according to the target
framework version. When the grammars are generated by Antlr4.targets as
part of the build, the code generation target will be *automatically selected*
to match the `TargetFrameworkVersion` property in the project file.


| Target Name | Runtime Library | .NET Framework Version | C# compiler version |
| ----------- | --------------- | ---------------------- | ------------------- |
| `CSharp_v4_5` | Antlr4.Runtime.v4.5.dll | .NET 4.5 | C# 3+ (Visual Studio 2008+) |
| `CSharp_v4_0` | Antlr4.Runtime.v4.0.dll | .NET 4.0 | C# 3+  |
| `CSharp_v3_5` | Antlr4.Runtime.v3.5.dll | .NET 3.5 | C# 3+  |
| `CSharp_v3_0` | Antlr4.Runtime.v2.0.dll (same as below) | .NET 3.0 | C# 3+  |
| `CSharp_v2_0` | Antlr4.Runtime.v2.0.dll | .NET 2.0 | C# 3+  |


### Visual Studio Support for ANTLR 4 Grammars

Currently there is no Visual Studio extension specifically designed for editing
ANTLR 4 grammars. However, now that a C# target for ANTLR 4 is available an
editor should be available in the "reasonably near" future. If this feature is
particularly important to your team,
[Tunnel Vision Labs' Sponsored Development Program](http://tunnelvisionlabs.com/SponsoredDevelopment.pdf)
may be a cost effective option for reducing the release timeframe.

### Base Project Layout

    C:\dev\CoolTool\
      CoolProject\
        CoolProject.csproj
      CoolTool.sln

### Adding ANTLR to the Project Structure

1. Download the current C# release from the following location: **TODO**
2. Extract the files to `C:\dev\CoolTool\Reference\Antlr4`

After these steps, your folder should resemble the following.

    C:\dev\CoolTool\
      CoolProject\...
      Reference\
        Antlr4\
          Antlr4.targets
          Antlr4BuildTasks.dll
          antlr4-csharp-[version]-complete.jar
      CoolTool.sln

### MSBuild Support for ANTLR

Since the steps include manual modification of the Visual Studio project files,
I *very strongly* recommend you back up your project (or commit it to source control)
before attempting these steps.

1. Open the `CoolTool.sln` solution in Visual Studio
2. Unload the `CoolProject` project by right-clicking the project in Solution
   Explorer and selecting Unload Project
3. Open `CoolProject.csproj` for editing by right-clicking the unloaded project
   in Solution Explorer and selecting Edit CoolProject.csproj
4. For reference, locate the following line

        <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets"/>

   Note: the line appears as follows in some projects

        <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets"/>

5. After the line in step 4, add the following code

        <PropertyGroup>
          <!-- Folder containing Antlr4BuildTasks.dll -->
          <Antlr4BuildTaskPath>$(ProjectDir)..\Reference\Antlr4</Antlr4BuildTaskPath>
          <!-- Path to the ANTLR Tool itself. -->
          <Antlr4ToolPath>$(ProjectDir)..\Reference\Antlr4\antlr4-csharp-4.0.1-SNAPSHOT-complete.jar</Antlr4ToolPath>
        </PropertyGroup>
        <Import Project="$(ProjectDir)..\Reference\Antlr4\Antlr4.targets" /> 

6. Save and close `CoolProject.csproj`
7. Reload the CoolProject project by right-clicking the project in Solution
   Explorer and selecting Reload Project

### Adding a Reference to the C# Runtime

In the CoolProject project, add a reference to `Antlr4.Runtime.dll`,  which is
located at `C:\dev\CoolTool\Reference\Antlr4\Antlr4.Runtime.dll`.

## Grammars

*TODO*

## Custom Token Specifications (*.tokens)

*TODO*

## Generated Code

*TODO*

## Extra Features in the C# Target

*TODO*

## Example Grammars

*TODO*
