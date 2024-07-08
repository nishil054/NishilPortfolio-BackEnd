using NishilPort.Debugging;

namespace NishilPort
{
    public class NishilPortConsts
    {
        public const string LocalizationSourceName = "NishilPort";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6dac3ad58ce1431fa75633e5383121ab";
    }
}
