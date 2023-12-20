using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SortingApp
{
  internal class NumbersString
  {
    public NumbersString() { }

    private Random randomNumber = new Random();
    public List<int> stringOfRandoms = new List<int>();
    
    public enum Order
    {
      random,
      increasing,
      decreasing
    }
    public Order sortOrder
      {
        get; set;
      }

    public void GenerateRandoms(int stringLength, int maxValue, Order order)
    {
      if(order == Order.random)
      {
        for (int i = 0; i < stringLength; i++)
        {
          stringOfRandoms.Add(randomNumber.Next(maxValue + 1));
        }
      }
      else if (order == Order.increasing)
      {
        int i = 0;
        stringOfRandoms.Add(randomNumber.Next(maxValue + 1));

        while (i < stringLength-1)
        {
          int number = randomNumber.Next(maxValue + 1);

          if (number >= stringOfRandoms[i])
          {
            stringOfRandoms.Add(number);
            i++;
          }
        }
      }
      else if (order == Order.decreasing)
      {
        int i = 0;
        stringOfRandoms.Add(randomNumber.Next(maxValue + 1));

        while (i < stringLength - 1)
        {
          int number = randomNumber.Next(maxValue + 1);

          if (number <= stringOfRandoms[i])
          {
            stringOfRandoms.Add(number);
            i++;
          }
        }
      }
    }

    public void ConvertToTextBox(TextBox box, List<int> list)
    {
      string wholeString = string.Format("{0}, ", list[0]);

      for (int i = 1; i < list.Count; i++)
      {
        string temporaryValue = string.Format("{0}, ", list[i]);
        wholeString = wholeString + temporaryValue;
      }

      box.Text = wholeString;
    }

    public List<int> CopyList(List<int> newOne)
    {
      newOne.Clear();

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
