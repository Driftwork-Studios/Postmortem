// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Postmortem : ModuleRules
{
	public Postmortem(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
