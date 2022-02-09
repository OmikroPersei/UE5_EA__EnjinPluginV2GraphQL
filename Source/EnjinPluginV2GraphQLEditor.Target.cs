// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class EnjinPluginV2GraphQLEditorTarget : TargetRules
{
	public EnjinPluginV2GraphQLEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "EnjinPluginV2GraphQL" } );
	}
}
