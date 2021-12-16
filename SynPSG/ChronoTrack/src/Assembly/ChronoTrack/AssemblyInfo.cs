// Copyright    © 2009 Synergex International Corporation.  All rights reserved.
//
// WARNING:     All content constituting or related to this code ("Code") is the
//              property of Synergex International Corporation ("Synergex") and
//              is protected by U.S. and international copyright laws.
//              If you were given this Code by a Synergex employee then you may
//              use and modify it freely for use within your applications.
//
//              However, you may use the Code only for your personal use.
//              Any other use, unless otherwise authorized in writing by
//              Synergex is strictly prohibited.  You may not under any
//              circumstances distribute this Code, or any modified version
//              or part of this Code, to any third party without first
//              obtaining written permission to do so from Synergex.
//              In using this Code you accept that it is provided as is,
//              and without support or warranty of any kind.
//
//              Neither Synergex nor the author accept any responsibility
//              for any losses or damages of any nature which may arise
//              from the use of this Code.  This header information must
//              remain unaltered in the Code at all times.  Possession
//              of this Code, or any modified version or part of this Code,
//              indicates your acceptance of these terms.
//
//***********************************************************************************
//
// ChronoTrack is an application written and managed by the Synergex Professional Services Group.
//
//***********************************************************************************
using System.Reflection;
using System.EnterpriseServices;
#if POOLING
[assembly: ApplicationName("ChronoTrack")]
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(false)]
#endif
[assembly: AssemblyTitle("ChronoTack - Project Mangement")]
[assembly: AssemblyDescription("Project management and task tracking system")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Synergy")]
[assembly: AssemblyProduct("ChronoTrack")]
[assembly: AssemblyCopyright("Synergex")]
[assembly: AssemblyTrademark("Synergex")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("1.0.0.11")]
