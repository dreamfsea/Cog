using UnrealBuildTool;
using System.Collections.Generic;

public class CogSampleTarget : TargetRules
{
	public CogSampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("CogSample");
        bUseUnityBuild = false;
        //bUsePCHFiles = false;
    }
}
