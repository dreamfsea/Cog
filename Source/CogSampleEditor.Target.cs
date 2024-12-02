using UnrealBuildTool;
using System.Collections.Generic;

public class CogSampleEditorTarget : TargetRules
{
	public CogSampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("CogSample");
	}
}
