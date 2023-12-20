using System.Collections.Generic;

namespace SortingApp
{
  internal class MergeSort : ISorting<MergeSort>
  {
    public List<int> SortASC(List<int> list)
    {
      if (list.Count <= 1)
      {
        return list;
      }

      int middleIndex = list.Count / 2;

      List<int> leftOne = new List<int>(list.GetRange(0, middleIndex));
      List<int> rightOne = new List<int>(list.GetRange(middleIndex, list.Count - middleIndex));

      leftOne = SortASC(leftOne);
      rightOne = SortASC(rightOne);

      return AscendingMerge(leftOne, rightOne);
    }

    private List<int> AscendingMerge(List<int> leftOne, List<int> rightOne)
    {
      List<int> temporaryList = new List<int>();
      int leftIndex = 0;
      int rightIndex = 0;

      while (leftIndex < leftOne.Count && rightIndex < rightOne.Count)
      {
        if (leftOne[leftIndex] >= rightOne[rightIndex])
        {
          temporaryList.Add(leftOne[leftIndex]);
          leftIndex++;
        }
        else
        {
          temporaryList.Add(rightOne[rightIndex]);
          rightIndex++;
        }
      }

      while (leftIndex < leftOne.Count)
      {
        temporaryList.Add(leftOne[leftIndex]);
        leftIndex++;
      }

      while (rightIndex < rightOne.Count)
      {
        temporaryList.Add(rightOne[rightIndex]);
        rightIndex++;
      }

      return temporaryList;
    }


    public List<int> SortDSC(List<int> list)
    {
      if (list.Count <= 1)
      {
        return list;
      }

      int middleIndex = list.Count / 2;

      List<int> leftOne = new List<int>(list.GetRange(0, middleIndex));
      List<int> rightOne = new List<int>(list.GetRange(middleIndex, list.Count - middleIndex));

      leftOne = SortASC(leftOne);
      rightOne = SortASC(rightOne);

      return DescendingMerge(leftOne, rightOne);
    }

    private List<int> DescendingMerge(List<int> leftOne, List<int> rightOne)
    {
      List<int> temporaryList = new List<int>();
      int leftIndex = leftOne.Count - 1; ;
      int rightIndex = rightOne.Count - 1;

      while (leftIndex >= 0 && rightIndex >= 0)
      {
        if (leftOne[leftIndex] >= rightOne[rightIndex])
        {
          temporaryList.Add(leftOne[leftIndex]);
          leftIndex--;
        }
        else
        {
          temporaryList.Add(rightOne[rightIndex]);
          rightIndex--;
        }
      }

      while (leftIndex >= 0)
      {
        temporaryList.Add(leftOne[leftIndex]);
        leftIndex--;
      }

      while (rightIndex >= 0)
      {
        temporaryList.Add(rightOne[rightIndex]);
        rightIndex--;
      }

      return temporaryList;
    }
  }
}
