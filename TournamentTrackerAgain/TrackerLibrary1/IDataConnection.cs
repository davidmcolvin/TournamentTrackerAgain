using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary1
{
  internal interface IDataConnection
  {
    PrizeModel CreatePrize(PrizeModel model);
  }
}
