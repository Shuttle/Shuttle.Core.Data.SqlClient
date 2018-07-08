using System.Reflection;
using System.Runtime.InteropServices;

#if NETCOREAPP2_0
[assembly: AssemblyTitle(".NET Core 2.0")]
#endif

#if NETCOREAPP2_1
[assembly: AssemblyTitle(".NET Core 2.1")]
#endif

#if NETSTANDARD2_0
[assembly: AssemblyTitle(".NET Standard 2.0")]
#endif

[assembly: AssemblyVersion("10.0.6.0")]
[assembly: AssemblyCopyright("Copyright © Eben Roux 2018")]
[assembly: AssemblyProduct("Shuttle.Core.Data.SqlClient")]
[assembly: AssemblyCompany("Shuttle")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyInformationalVersion("10.0.6")]
[assembly: ComVisible(false)]
