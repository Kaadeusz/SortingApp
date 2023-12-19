using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortingApp
{
  internal class NumbersString
  {
    public NumbersString() { }

    private Random randomNumber = new Random();
    private List<int> stringOfRandoms = new List<int>();

    public void GenerateRandoms(int stringLength, int maxValue)
    {
      for (int i = 0; i < stringLength; i++)
      {
        stringOfRandoms.Add(randomNumber.Next(maxValue + 1));
      }
    }

    public void ConvertToTextBox(TextBox box)
    {
      string wholeString = string.Format("{0}, ", stringOfRandoms[0]);

      for (int i = 1; i < stringOfRandoms.Count; i++)
      {
        string temporaryValue = string.Format("{0}, ", stringOfRandoms[i]);
        wholeString = wholeString + temporaryValue;
      }

      box.Text = wholeString;
    }

    public List<int> CopyList(List<int> newOne)
    {
      foreach (int number in stringOfRandoms)
      {
        newOne.Add(number);
      }

      return newOne;
    }

    public bool IsNotEmpty()
    {
      if (stringOfRandoms.Count > 1)
      {
        return true;
      }

      return false;
    }

    public void ClearList()
    {
      stringOfRandoms.Clear();
    }
  }
}
