using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary1
{
  internal static class GlobalConfig
  {
    public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

    public static void InitializeConnections(bool database, bool textFiles)
    {
      if (database == true)
      {
        // TODO - Create the SQL Connection
      }

      if (textFiles == true)
      {
        // TODO - Create the Text Connection
      }
    }
  }
}
