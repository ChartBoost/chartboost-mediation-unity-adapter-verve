# Chartboost Mediation Unity SDK - Verve Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.verve/Editor/VerveAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.verve)

In order to add the Chartboost Mediation Unity SDK - Verve Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.verve": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.Verve)

To add the Chartboost Mediation Unity SDK - Verve Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.Verve` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.Verve` package. Choose the appropriate version and install.

# AndroidManifest.xml Permissions

The following permissions must be added in the `AndroidManifest.xml` file:

```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
```

For improved targeting and therefore higher eCPMs you can add this other permissions but keep in mind that the user needs to approve them explicitly on Android versions 6 or higher.

```xml
<uses-permission android:name="android.permission.READ_PHONE_STATE" />

<!-- For location use one of the following permissions -->
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
<!-- or -->
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
```

# Usage
The following code block exemplifies usage of the `VerveAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {VerveAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.3.0.2.0
Debug.Log($"Adapter Native Version: {VerveAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 3.0.2
Debug.Log($"Partner SDK Version: {VerveAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: verve
Debug.Log($"Partner Identifier: {VerveAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Verve
Debug.Log($"Partner Display Name: {VerveAdapter.PartnerDisplayName}");
```

## Test Mode
To enable test mode for the Verve adapter, the following property has been made available:

```csharp
VerveAdapter.TestMode = true;
```

## Verbose Logging
To enable verbose logging for the Verve adapter, the following property has been made available:

```csharp
VerveAdapter.VerboseLogging = true;
```