using Chartboost.Mediation.Verve.Common;

namespace Chartboost.Mediation.Verve.Default
{
    internal class VerveDefault : IVerveAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => VerveAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => VerveAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "verve";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Verve";

        /// <inheritdoc/>
        public bool TestMode { get; set; }
        
        /// <inheritdoc/>
        public bool VerboseLogging { get; set; }
    }
}
