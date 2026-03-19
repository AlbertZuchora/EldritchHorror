using UnrealBuildTool;

public class EldritchHorrorClientTarget : TargetRules
{
	public EldritchHorrorClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("EldritchHorror");
	}
}
