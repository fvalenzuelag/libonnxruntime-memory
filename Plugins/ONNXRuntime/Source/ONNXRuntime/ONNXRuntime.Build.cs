// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;

public class ONNXRuntime : ModuleRules
{
	public ONNXRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.AddRange(new string[] { "Core", "Engine" });

		if (Target.Platform == UnrealTargetPlatform.IOS)
		{
			string BinariesDirectory = Path.Combine(ModuleDirectory, "ThirdParty", "Bin", "IOS");
			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "ThirdParty", "Include"));

			PublicAdditionalFrameworks.Add(new Framework("ONNXRuntime", Path.Combine(BinariesDirectory, "onnxruntime.xcframework")));
		}

		PublicDefinitions.Add("ORT_NO_EXCEPTIONS");
		PublicDefinitions.Add("ORT_API_MANUAL_INIT");
	}
}
