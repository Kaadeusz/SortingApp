using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
  internal class Choice
  {
    public Choice() { }

    public bool bubbleSelect = false;
    public bool selectionSelect = false;
    public bool insertionSelect = false;
    public bool quickSelect = false;
    public bool mergeSelect = false;

    public bool ascendingSorting = true;
    public bool descendingSorting = false;

    internal void UseRandomSortingOrder()
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
