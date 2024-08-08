using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.Verve.Common
{
    /// <summary>
    /// The Chartboost Mediation Verve adapter.
    /// </summary>
    internal interface IVerveAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Init flag for starting up Verve SDK in test mode.
        /// </summary>
        public bool TestMode { get; set; }

        /// <summary>
        /// Enable/disable logging for the Verve Ads SDK.
        /// </summary>
        public bool VerboseLogging { get; set; }
    }
}
