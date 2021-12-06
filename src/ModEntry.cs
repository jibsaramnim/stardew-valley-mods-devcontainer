using StardewModdingAPI;

namespace jibsaramnim.sdv.mods.SampleProject
{
    /// <summary>The mod entry point.</summary>
    internal class ModEntry : Mod
    {

        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log("Hello, World! :-)");
        }

    }
}