// Copyright Ladder Company. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

// Build target for the editor (used when opening the project in the Unreal Editor).
public class LadderCompanyEditorTarget : TargetRules
{
	public LadderCompanyEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;

		ExtraModuleNames.Add("LadderCompany");
	}
}
