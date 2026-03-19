using UnrealBuildTool;

public class EldritchHorrorEditorTarget : TargetRules
{
	public EldritchHorrorEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("EldritchHorror");
	}
}
