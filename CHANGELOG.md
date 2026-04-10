# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.8 *(2026-01-26)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.6.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.7.0`

### Version 5.0.7 *(2025-10-10)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.6.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.6.0`

### Version 5.0.6 *(2025-10-10)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.3.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.6.0`

### Version 5.0.5 *(2025-06-02)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.3.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.2.0`

### Version 5.0.4 *(2025-06-02)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.2.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.2.0`

### Version 5.0.3 *(2025-02-18)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.2.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.1.0`

### Version 5.0.2 *(2025-02-18)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.1.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.1.0`

### Version 5.0.1 *(2024-10-18)*
This version of the Verve Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.1.+`
  * iOS: `ChartboostMediationAdapterVerve: ~> 5.3.0.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Verve Adapter.

#Added
- Support for the following `Verve` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-verve:5.3.0.+`
    * iOS: `ChartboostMediationAdapterVerve ~> 5.3.0.0`
    
- `VerveAdapter.cs` with Configuration Properties for `Verve`.
- The following properties have been added in `VerveAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool TestMode`
    * `bool VerboseLogging`
