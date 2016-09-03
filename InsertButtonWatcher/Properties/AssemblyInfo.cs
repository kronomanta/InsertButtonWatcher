using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("InsertButtonWatcher")]
[assembly: AssemblyDescription("Sends a warning when the insert button is pressed. It runs in the background and only shown in the Systray.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Tibor Kanyo")]
[assembly: AssemblyProduct("InsertButtonWatcher")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("cdb66b1b-f3b7-4bd4-b724-583db40504a3")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Log4Net.config", Watch = true)]
