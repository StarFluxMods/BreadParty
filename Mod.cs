using KitchenMods;
using Kitchen;
using KitchenData;
using UnityEngine;

namespace BreadParty
{
    public class Mod : GameSystemBase, IModSystem
    {
        public const string MOD_GUID = "com.starfluxgames.breadparty";
        public const string MOD_NAME = "Bread Party";
        public const string MOD_VERSION = "0.1.0";

        protected override void Initialise()
        {
            LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
            if (GameData.Main.TryGet(1503471951, out Item breadBoard))
            {
                breadBoard.MaxOrderSharers = 1;
            }
        }

        protected override void OnUpdate()
        {
        }
        public static void LogWarning(string _log) { Debug.LogWarning($"[{MOD_NAME}] " + _log); }
    }
}
