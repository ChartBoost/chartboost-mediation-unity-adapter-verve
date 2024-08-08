using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.Verve.Common;
using UnityEngine;

namespace Chartboost.Mediation.Verve.IOS
{
    internal sealed class VerveAdapter : IVerveAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Verve.VerveAdapter.Instance = new VerveAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMVerveAdapterAdapterVersion();

        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMVerveAdapterPartnerSDKVersion();

        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMVerveAdapterPartnerId();

        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMVerveAdapterPartnerDisplayName();

        /// <inheritdoc/>
        public bool TestMode
        {
            get => _CBMVerveAdapterGetTestMode();
            set => _CBMVerveAdapterSetTestMode(value);
        }

        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get => _CBMVerveAdapterGetVerboseLogging();
            set => _CBMVerveAdapterSetVerboseLogging(value);
        }

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVerveAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVerveAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVerveAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMVerveAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMVerveAdapterGetTestMode();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMVerveAdapterSetTestMode(bool testMode);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMVerveAdapterGetVerboseLogging();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMVerveAdapterSetVerboseLogging(bool verboseLogging);
    }
}
