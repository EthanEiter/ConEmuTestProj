using System.Runtime.CompilerServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

[assembly: AssemblyTitle("Esha.Admin.Tools")]
[assembly: AssemblyDescription("Assists with administering ESHA applications and data.")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("ESHA Research, Inc.")]
[assembly: AssemblyProduct("Esha Client Suite")]
[assembly: AssemblyCopyright("Copyright © ESHA Research, Inc. 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("63009160-e02d-4ea5-b550-b051700ee40f")]

[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: InternalsVisibleTo("Esha.Admin.Tools.Tests")]
[assembly: InternalsVisibleTo("Esha.Admin.Tools.Explorables")]

