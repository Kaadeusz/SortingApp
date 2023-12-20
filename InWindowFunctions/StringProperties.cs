using System;
using System.Windows.Forms;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    NumbersString s = new NumbersString();

    private int maxLength = 100;
    private int maxValue = 100;

    private void MaxStringLength_Label_ValueChanged(object sender, EventArgs e)
    {
      maxLength = (int)MaxStringLength_Label.Value;
    }
    private void MaxStringValue_Label_ValueChanged(object sender, EventArgs e)
    {
      maxValue = (int)MaxStringValue_Label.Value;
    }

    private void GenerateIncreasing_RdButton_CheckedChanged(object sender, System.EventArgs e)
    {
      if (GenerateIncreasing_RdButton.Checked)
      {
        s.sortOrder = NumbersString.Order.increasing;
      }
    }
    private void GenerateDecreasing_RdButton_CheckedChanged(object sender, System.EventArgs e)
    {
      if (GenerateDecreasing_RdButton.Checked)
      {
        s.sortOrder = NumbersString.Order.decreasing;
      }
    }
    private void GenerateRandomly_RdButton_CheckedChanged(object sender, System.EventArgs e)
    {
      if (GenerateRandomly_RdButton.Checked)
      {
        s.sortOrder = NumbersString.Order.random;
      }
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

      s.GenerateRandoms(maxLength, maxValue, s.sortOrder);
      s.ConvertToTextBox(String_TxtBox, s.stringOfRandoms);

      Status_Label.Text = "String generated; not sorted";
    }
  }
}
