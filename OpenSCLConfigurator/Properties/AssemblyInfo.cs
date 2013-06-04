#region Using directives

using System;
using System.Reflection;
using System.Runtime.InteropServices;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("OpenSCLConfigurator")]
[assembly: AssemblyDescription("Application to Create and Edit IEC 61850-6 SCL files")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Comisión Federal de Electricidad" +
	"Daniel Espinosa <esodan@gmail.com>")]
[assembly: AssemblyProduct("OpenSCLConfigurator")]
[assembly: AssemblyCopyright("Copyright 2009 - Comision Federal de Electricidad" +
	"Copyright 2013 - Daniel Espinosa <esodan@gmail.com>")]
[assembly: AssemblyTrademark("OpenSCLConfigurator are registered trademark of Comision Federal de Electricidad")]
[assembly: AssemblyCulture("")]

// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(false)]

// The assembly version has the format "{Major}.{Minor}.{Micro}".
// Major for stable versions, will be the same Major version of OpenSCLUI
// Minor for milestone versions, will be the same Minor version of OpenSCLUI
// Micro will be increased when OpenSCLUI or OpenSCL micro version is incresed or when this application is modified
[assembly: AssemblyVersion("0.4.0")]