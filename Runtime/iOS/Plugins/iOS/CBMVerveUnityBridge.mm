#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <HyBid/HyBid.h>
#import <ChartboostMediationAdapterVerve/ChartboostMediationAdapterVerve-Swift.h>

extern "C" {

    const char * _CBMVerveAdapterAdapterVersion(){
        return toCStringOrNull([VerveAdapterConfiguration adapterVersion]);
    }

    const char * _CBMVerveAdapterPartnerSDKVersion(){
        return toCStringOrNull([VerveAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMVerveAdapterPartnerId(){
        return toCStringOrNull([VerveAdapterConfiguration partnerID]);
    }

    const char * _CBMVerveAdapterPartnerDisplayName(){
        return toCStringOrNull([VerveAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMVerveAdapterGetTestMode() {
        return [VerveAdapterConfiguration testMode];
    }

    void _CBMVerveAdapterSetTestMode(BOOL testMode) {
        return [VerveAdapterConfiguration setTestMode:testMode];
    }

    BOOL _CBMVerveAdapterGetVerboseLogging(){
        return [VerveAdapterConfiguration logLevel] == VerveLogLevelDebug;
    }

    void _CBMVerveAdapterSetVerboseLogging(BOOL verboseLogging){
        if (verboseLogging)
            [VerveAdapterConfiguration setLogLevel:VerveLogLevelDebug];
        else
            [VerveAdapterConfiguration setLogLevel:VerveLogLevelDisabled];
    }
}
