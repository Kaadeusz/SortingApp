using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
  internal interface ISorting<T>
  {
    List<int> SortASC(List<int> list);

    List<int> SortDSC(List<int> list);

  }
}
