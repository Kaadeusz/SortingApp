using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
  internal class InsertionSort : ISorting
  {
    public List<int> SortASC(List<int> list)
    {
      int temporaryValue = 0;

      for (int i = 0; i < list.Count() - 1; i++)
      {
        if (list[i] > list[i + 1])
        {
          for (int j = 0; j < i; j++)
          {
            if (list[i + 1] < list[j])
            {
              temporaryValue = list[j];
              list[j] = list[i + 1];
              list[i + 1] = temporaryValue;
            }
          }
        }
      }

      return list;
    }

    public List<int> SortDSC(List<int> list)
    {
      int temporaryValue = 0;

      for (int i = 0; i < list.Count() - 1; i++)
      {
        if (list[i] > list[i + 1])
        {
          for (int j = 0; j < i; j++)
          {
            if (list[i + 1] > list[j])
            {
              temporaryValue = list[j];
              list[j] = list[i + 1];
              list[i + 1] = temporaryValue;
            }
          }
        }
      }

      return list;
    }
  }
}
