using UnrealBuildTool;

public class Team17ColabTarget : TargetRules
{
	public Team17ColabTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Team17Colab");
	}
}
