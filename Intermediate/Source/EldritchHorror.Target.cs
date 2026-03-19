using UnrealBuildTool;

public class EldritchHorrorTarget : TargetRules
{
	public EldritchHorrorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("EldritchHorror");
	}
}
