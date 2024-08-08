using Chartboost.Logging;
using Chartboost.Mediation.Verve;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class VerveAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => VerveAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => VerveAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => VerveAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => VerveAdapter.PartnerDisplayName);

        [Test]
        public void TestMode()
            => TestUtilities.TestBooleanAccessor(() => VerveAdapter.TestMode, value => VerveAdapter.TestMode = value);
        
        [Test]
        public void VerboseLogging()
            => TestUtilities.TestBooleanAccessor(() => VerveAdapter.VerboseLogging, value => VerveAdapter.VerboseLogging = value);
    }
}
