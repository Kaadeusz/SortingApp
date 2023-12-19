using System;

namespace SortingApp
{
  internal class SortingChoice
  {
    public SortingChoice() { }

    public bool bubbleSelect = false;
    public bool selectionSelect = false;
    public bool insertionSelect = false;
    public bool quickSelect = false;
    public bool mergeSelect = false;

    public bool ascendingSorting = true;
    public bool descendingSorting = false;

    public void UseRandomSortingOrder()
    {
      Random randomNumber = new Random();

      if (randomNumber.Next() % 2 == 0)
      {
        ascendingSorting = true;
        descendingSorting = false;

        return;
      }

      ascendingSorting = false;
      descendingSorting = true;
    }
  }
}
