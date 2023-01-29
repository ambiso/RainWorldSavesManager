using BepInEx;
using System.Security.Permissions;

[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
namespace RainWorldSavesManager
{
	[BepInPlugin("ambiso.rwsm", "RainWorldSavesManager", "0.1.0")]
	public class RainWorldSavesManager : BaseUnityPlugin
	{
		public void OnEnable()
		{
			/* This is called when the mod is loaded. */
			// subscribe your PlayerUpdateHook to the Player.Update method from the game
			Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA Hooking");
			On.RainWorld.OnModsInit += OnModsInitHook;
		}

		void OnModsInitHook(On.RainWorld.orig_OnModsInit orig, RainWorld self)
		{
			Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

			orig(self);
		}
	}
}