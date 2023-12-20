using System;
using System.Windows.Forms;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    NumbersString s = new NumbersString();

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
      s.ConvertToTextBox(String_TxtBox, s.stringOfRandoms);

      Status_Label.Text = "String generated; not sorted";
    }
  }
}
