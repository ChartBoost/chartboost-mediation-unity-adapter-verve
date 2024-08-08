using System.Runtime.CompilerServices;
using Chartboost.Mediation.Verve;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.VerveAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.VerveAssemblyInfoIOS)]

namespace Chartboost.Mediation.Verve
{
    internal class AssemblyInfo
    {
        public const string VerveAssemblyInfoAndroid = "Chartboost.Mediation.Verve.Android";
        public const string VerveAssemblyInfoIOS = "Chartboost.Mediation.Verve.IOS";
    }
}
