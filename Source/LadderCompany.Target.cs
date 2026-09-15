// Copyright Ladder Company. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

// Build target for the packaged game (standalone client/server builds).
public class LadderCompanyTarget : TargetRules
{
	public LadderCompanyTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;

		ExtraModuleNames.Add("LadderCompany");
	}
}
