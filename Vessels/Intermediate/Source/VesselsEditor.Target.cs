using UnrealBuildTool;

public class VesselsEditorTarget : TargetRules
{
	public VesselsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Vessels");
	}
}
