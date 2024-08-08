using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.Verve;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.verve";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.Verve";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, VerveAdapter.AdapterUnityVersion);
    }
}
