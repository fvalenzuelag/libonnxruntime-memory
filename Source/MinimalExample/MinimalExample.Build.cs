// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MinimalExample : ModuleRules
{
	public MinimalExample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "Engine" });
	}
}
