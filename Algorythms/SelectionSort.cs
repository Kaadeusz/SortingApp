using System.Collections.Generic;

namespace SortingApp
{
  internal class SelectionSort : ISorting
  {
    public List<int> SortASC(List<int> list)
    {
      int temporaryValue = 0;
      int minValue = 0;
      int minValueIndex = 0;

      for (int i = 0; i < list.Count - 1; i++)
      {
        minValueIndex = i;
        minValue = list[i];

        for (int j = i + 1; j < list.Count; j++)
        {
          if (minValue > list[j])
          {
            minValue = list[j];
            minValueIndex = j;
          }
        }

        temporaryValue = list[i];
        list[i] = minValue;
        list[minValueIndex] = temporaryValue;
      }

      return list;
    }

    public List<int> SortDSC(List<int> list)
    {
      int temporaryValue = 0;
      int minValue = 0;
      int minValueIndex = 0;

      for (int i = 0; i < list.Count - 1; i++)
      {
        minValueIndex = i;
        minValue = list[i];

        for (int j = i + 1; j < list.Count; j++)
        {
          if (minValue < list[j])
          {
            minValue = list[j];
            minValueIndex = j;
          }
        }

        temporaryValue = list[i];
        list[i] = minValue;
        list[minValueIndex] = temporaryValue;
      }

      return list;
    }
  }
}
