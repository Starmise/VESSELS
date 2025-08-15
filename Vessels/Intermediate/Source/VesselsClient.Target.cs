using UnrealBuildTool;

public class VesselsClientTarget : TargetRules
{
	public VesselsClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Vessels");
	}
}
