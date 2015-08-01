#region Copyright (C) 2005-2011 Team MediaPortal

// Copyright (C) 2005-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MediaPortal is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MediaPortal is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Mediaportal.TV.Server.Plugins.TvMovieImport.Service
{
  [ServiceContract(Namespace = "http://www.team-mediaportal.com")]
  public interface ITvMovieImportService
  {
    [OperationContract]
    void ImportNow();

    [OperationContract]
    void GetImportStatus(out DateTime dateTime, out string status, out string channelCounts, out string programCounts);

    [OperationContract]
    IList<string> GetGuideChannelNames();

    [OperationContract]
    string GetDatabaseFilePath();
  }
}