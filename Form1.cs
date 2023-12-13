using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    public Sorter()
    {
      InitializeComponent();
    }

    int maxLength = 0;
    int maxValue = 0;

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
      Strings s = new Strings();

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

      listBox1.Items.Clear();

      s.GenerateRandoms(maxLength, maxValue);
      s.ConvertToListBox(listBox1);
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void SortingProcess_ProgressBar_Click(object sender, EventArgs e)
    {

    }
  }
}
