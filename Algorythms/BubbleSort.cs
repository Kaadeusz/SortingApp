using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
  internal class BubbleSort : ISorting
  {
    public List<int> SortASC(List<int> list)
    {
      int temporaryValue = 0;

      for (int i = 0; i < list.Count(); i++)
      {
        for (int j = 0; j < list.Count() - 1; j++)
        {
          if (list[j] > list[j + 1])
          {
            temporaryValue = list[j + 1];
            list[j + 1] = list[j];
            list[j] = temporaryValue;
          }
        }
      }

      return list;
    }
  }
}
