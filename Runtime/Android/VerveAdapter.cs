using Chartboost.Constants;
using Chartboost.Mediation.Verve.Common;
using UnityEngine;

namespace Chartboost.Mediation.Verve.Android
{
    internal sealed class VerveAdapter : IVerveAdapter
    {
        private const string VerveAdapterConfiguration = "com.chartboost.mediation.verveadapter.VerveAdapterConfiguration";
        private const string FunctionGetTestModeEnabled = "getTestModeEnabled";
        private const string FunctionSetTestModeEnabled = "setTestModeEnabled";
        
        private const string VerveLoggerLevel = "net.pubnative.lite.sdk.utils.Logger$Level";
        private const string EnumVerveLogLevelVerbose = "verbose";
        private const string EnumVerveLogLevelNone = "none";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Verve.VerveAdapter.Instance = new VerveAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool TestMode
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetTestModeEnabled);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetTestModeEnabled, value);
            }
        }

        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                using var nativeLogLevel = adapterConfiguration.Call<AndroidJavaObject>(SharedAndroidConstants.FunctionGetLogLevel);

                var logLevelAsString = nativeLogLevel.Call<string>(SharedAndroidConstants.FunctionToString);
                return logLevelAsString switch
                {
                    EnumVerveLogLevelVerbose => true,
                    _ => false
                };
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(VerveAdapterConfiguration);
                using var loggerLevelClass = new AndroidJavaClass(VerveLoggerLevel);
                using var enumValue = loggerLevelClass.GetStatic<AndroidJavaObject>(value ? EnumVerveLogLevelVerbose : EnumVerveLogLevelNone);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetLogLevel, enumValue);
            }
        }
    }
}
