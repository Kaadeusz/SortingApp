using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    public Sorter()
    {
      InitializeComponent();
    }


    Strings s = new Strings();

    int maxLength = 10;
    int maxValue = 10;

    private void MaxStringLength_Label_ValueChanged(object sender, EventArgs e)
    {
      maxLength = (int)MaxStringLength_Label.Value;

    }
    private void MaxStringValue_Label_ValueChanged(object sender, EventArgs e)
    {
      maxValue = (int)MaxStringValue_Label.Value;
    }

    private void GenerateString_Button_Click(object sender, EventArgs e)
    {
      s.ClearList();

      if (maxValue == 0)
      {
        MessageBox.Show("String should not contain ony 0's (check Max Value and try again)", "Error!", MessageBoxButtons.OK);
        return;
      }

      if (maxLength < 2)
      {
        MessageBox.Show("String can't be shorter than 2 characters (check Max Length and try again)", "Error!", MessageBoxButtons.OK);
        return;
      }

      s.GenerateRandoms(maxLength, maxValue);
      s.ConvertToTextBox(String_TxtBox);
    }


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


    private void SortingProcess_ProgressBar_Click(object sender, EventArgs e)
    {

    }

    private void String_TxtBox_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
