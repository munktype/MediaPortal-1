#region Copyright (C) 2005-2008 Team MediaPortal

/* 
 *	Copyright (C) 2005-2008 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */

#endregion

using System;
using MediaPortal.Support;
using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MediaPortal.Tests.Support
{
  [TestFixture]
  public class DxDiagLogTests
  {
    private class MyProcRunner : ProcessRunner
    {
      public bool hasRun = false;
      public override void Run()
      {
        base.Run();
        if (LastExitCode == 0)
          hasRun = true;
      }
    }

    [Explicit]
    [Test]
    public void CreateLog()
    {
      MyProcRunner runner = new MyProcRunner();
      DxDiagLog dxlog = new DxDiagLog(runner);
      string tempFile = Environment.GetEnvironmentVariable("SystemDrive") + "\\_dxdiag.txt";
      FileHelper.Touch(tempFile);

      dxlog.CreateLogs("Support\\TestData\\TestOutput");

      Assert.IsTrue(runner.Executable.EndsWith("dxdiag.exe"), "Wrong thing has been run!");
      Assert.IsTrue(runner.hasRun);
      Assert.IsFalse(File.Exists(tempFile));
    }
  }
}
