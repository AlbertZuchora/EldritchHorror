using UnrealBuildTool;

public class EldritchHorrorServerTarget : TargetRules
{
	public EldritchHorrorServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("EldritchHorror");
	}
}
