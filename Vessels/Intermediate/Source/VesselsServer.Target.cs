using UnrealBuildTool;

public class VesselsServerTarget : TargetRules
{
	public VesselsServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Vessels");
	}
}
