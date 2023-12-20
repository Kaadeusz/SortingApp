using System.Collections.Generic;

namespace SortingApp
{
  internal class QuickSort : ISorting<QuickSort>
  {
    public List<int> SortASC(List<int> list)
    {
      AscendingSort(list, 0, list.Count - 1);

      return list;
    }

    private void AscendingSort(List<int> list, int firstIndex, int lastIndex)
    {
      if (firstIndex < lastIndex)
      {
        int pivotIndex = AscendingPartition(list, firstIndex, lastIndex);

        AscendingSort(list, firstIndex, pivotIndex - 1);
        AscendingSort(list, pivotIndex + 1, lastIndex);
      }
    }

    private int AscendingPartition(List<int> list, int firstIndex, int lastIndex)
    {
      int temporaryValue = 0;
      int pivot = list[lastIndex];
      int swapMarker = firstIndex - 1;

      for (int i = firstIndex; i < lastIndex; i++)
      {
        if (list[i] <= pivot)
        {
          swapMarker++;

          temporaryValue = list[i];
          list[i] = list[swapMarker];
          list[swapMarker] = temporaryValue;
        }
      }

      swapMarker++;

      temporaryValue = list[swapMarker];
      list[swapMarker] = list[lastIndex];
      list[lastIndex] = temporaryValue;

      return swapMarker;
    }

    public List<int> SortDSC(List<int> list)
    {
      DescendingSort(list, 0, list.Count - 1);

      return list;
    }

    private void DescendingSort(List<int> list, int firstIndex, int lastIndex)
    {
      if (firstIndex < lastIndex)
      {
        int pivotIndex = DescendingPartition(list, firstIndex, lastIndex);

        DescendingSort(list, firstIndex, pivotIndex - 1);
        DescendingSort(list, pivotIndex + 1, lastIndex);
      }
    }

    private int DescendingPartition(List<int> list, int firstIndex, int lastIndex)
    {
      int temporaryValue = 0;
      int pivot = list[lastIndex];
      int swapMarker = firstIndex - 1;

      for (int i = firstIndex; i < lastIndex; i++)
      {
        if (list[i] >= pivot)
        {
          swapMarker++;

          temporaryValue = list[i];
          list[i] = list[swapMarker];
          list[swapMarker] = temporaryValue;
        }
      }

      swapMarker++;

      temporaryValue = list[swapMarker];
      list[swapMarker] = list[lastIndex];
      list[lastIndex] = temporaryValue;

      return swapMarker;
    }
  }
}
