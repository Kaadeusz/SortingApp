using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    Choice c = new Choice();

    private void BubbleSort_CkBox_CheckedChanged(object sender, EventArgs e)
    {
      if (BubbleSort_CkBox.Checked)
      {
        c.bubbleSelect = true;
        return;
      }

      c.bubbleSelect = false;
    }

    private void SelectionSort_CkBox_CheckedChanged(object sender, EventArgs e)
    {
      if (SelectionSort_CkBox.Checked)
      {
        c.selectionSelect = true;
        return;
      }

      c.selectionSelect = false;
    }

    private void InsertionSort_CkBox_CheckedChanged(object sender, EventArgs e)
    {
      if (InsertionSort_CkBox.Checked)
      {
        c.insertionSelect = true;
        return;
      }

      c.insertionSelect = false;
    }

    private void MergeSort_CkBox_CheckedChanged(object sender, EventArgs e)
    {
      if (MergeSort_CkBox.Checked)
      {
        c.mergeSelect = true;
        return;
      }

      c.mergeSelect = false;
    }

    private void QuickSort_CkBox_CheckedChanged(object sender, EventArgs e)
    {
      if (QuickSort_CkBox.Checked)
      {
        c.quickSelect = true;
        return;
      }

      c.quickSelect = false;
    }

    private void Ascending_RdButton_CheckedChanged(object sender, EventArgs e)
    {
      c.ascendingSorting = true;
      c.descendingSorting = false;
    }

    private void Descending_RdButton_CheckedChanged(object sender, EventArgs e)
    {
      c.ascendingSorting = false;
      c.descendingSorting = true;
    }

    private void Random_RdButton_CheckedChanged(object sender, EventArgs e)
    {
      c.UseRandomSortingOrder();
    }
  }
}
