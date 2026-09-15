// Copyright Ladder Company. All Rights Reserved.

using UnrealBuildTool;

// Build rules for the primary game module.
//
// Dependencies are intentionally kept to the engine essentials for now. Systems
// such as Enhanced Input, networking helpers, or Chaos physics helpers should be
// added here only when the gameplay prototype that needs them is actually being
// built (see CLAUDE.md: "Systems created before they are needed").
public class LadderCompany : ModuleRules
{
	public LadderCompany(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });
	}
}
