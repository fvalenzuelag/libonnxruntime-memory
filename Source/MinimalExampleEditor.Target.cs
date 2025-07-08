// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MinimalExampleEditorTarget : TargetRules
{
	public MinimalExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;

		// Force ANSI allocator for iOS builds to resolve memory allocation issues
		if (Target.Platform == UnrealTargetPlatform.IOS)
		{
			GlobalDefinitions.Add("FORCE_ANSI_ALLOCATOR=1");
		}

		ExtraModuleNames.AddRange( new string[] { "MinimalExample" } );
	}
}
