using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingApp
{
  public class Strings
  {
    public Strings()
    {

    }

    Random randomNumber = new Random();
    public List<int> randomString = new List<int>();

    public void GenerateRandoms(int stringLength, int maxValue)
    {
      for (int i = 0; i < stringLength; i++)
      {
        randomString.Add(randomNumber.Next(maxValue + 1));
      }
    }
  }
}
