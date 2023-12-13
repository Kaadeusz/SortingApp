using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApp
{
  public class Strings
  {
    public Strings() { }

    private Random randomNumber = new Random();
    private List<int> stringOfRandoms = new List<int>();

    public void GenerateRandoms(int stringLength, int maxValue)
    {
      for (int i = 0; i < stringLength; i++)
      {
        stringOfRandoms.Add(randomNumber.Next(maxValue + 1));
      }
    }

    public void ConvertToListBox(ListBox box)
    {
      string wholeString = string.Format("{0}, ", stringOfRandoms[0]);

      for (int i = 1; i < stringOfRandoms.Count; i++)
      {
        string temporaryValue = string.Format("{0}, ", stringOfRandoms[i]);
        wholeString = wholeString + temporaryValue;
      }

      box.Items.Add(wholeString);


    }
  }
}
