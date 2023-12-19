using System.Collections.Generic;

namespace SortingApp
{
  internal class InsertionSort : ISorting
  {
    public List<int> SortASC(List<int> list)
    {
      for (int i = 1; i < list.Count; i++)
      {
        int temporaryValue = list[i];
        int j = i - 1;

        while (j >= 0 && list[j] > temporaryValue)
        {
          list[j + 1] = list[j];
          j--;
        }

        list[j + 1] = temporaryValue;
      }

      return list;
    }

    public List<int> SortDSC(List<int> list)
    {
      for (int i = 1; i < list.Count; i++)
      {
        int temporaryValue = list[i];
        int j = i - 1;

        while (j >= 0 && list[j] < temporaryValue)
        {
          list[j + 1] = list[j];
          j--;
        }

        list[j + 1] = temporaryValue;
      }

      return list;
    }
  }
}
