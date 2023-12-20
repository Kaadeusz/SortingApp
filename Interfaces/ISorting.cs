using System.Collections.Generic;

namespace SortingApp
{
  internal interface ISorting<T>
  {
    List<int> SortASC(List<int> list);

    List<int> SortDSC(List<int> list);
  }
}
