using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    BubbleSort bbl_Sort = new BubbleSort();
    SelectionSort slct_Sort = new SelectionSort();
    InsertionSort isrt_Sort = new InsertionSort();

    private void AddToChart(Chart chart, string seriesName, TimeSpan time)
    {
      Series chartValue = new Series(seriesName);

      chartValue.Points.AddY(time.TotalMilliseconds);
      chart.Series.Add(chartValue);
    }

    private void SortString_Button_Click(object sender, EventArgs e)
    {
      Sorting_Chart.Series.Clear();
      Stopwatch algorythmDuration = new Stopwatch();

      if (c.ascendingSorting == true)
      {
        if (c.bubbleSelect == true)
        {
          algorythmDuration.Reset();

          List<int> BubbleCopy = new List<int>();
          s.CopyList(BubbleCopy);

          algorythmDuration.Start();
          bbl_Sort.SortASC(BubbleCopy);
          algorythmDuration.Stop();

          AddToChart(Sorting_Chart, "Bubble Sort", algorythmDuration.Elapsed);
        }

        if (c.selectionSelect == true)
        {
          algorythmDuration.Reset();

          List<int> SelectionCopy = new List<int>();
          s.CopyList(SelectionCopy);

          algorythmDuration.Start();
          slct_Sort.SortASC(SelectionCopy);
          algorythmDuration.Stop();

          AddToChart(Sorting_Chart, "Selection Sort", algorythmDuration.Elapsed);
        }

        if (c.insertionSelect == true)
        {
          algorythmDuration.Reset();

          List<int> InsertionCopy = new List<int>();
          s.CopyList(InsertionCopy);

          algorythmDuration.Start();
          isrt_Sort.SortASC(InsertionCopy);
          algorythmDuration.Stop();

          AddToChart(Sorting_Chart, "Insertion Sort", algorythmDuration.Elapsed);
        }
      }

      else
      {
        if (c.bubbleSelect == true)
        {
          algorythmDuration.Reset();

          List<int> BubbleCopy = new List<int>();
          s.CopyList(BubbleCopy);

          algorythmDuration.Start();
          bbl_Sort.SortDSC(BubbleCopy);
          algorythmDuration.Stop();

          AddToChart(Sorting_Chart, "Bubble Sort", algorythmDuration.Elapsed);
        }

        if (c.selectionSelect == true)
        {
          algorythmDuration.Reset();

          List<int> SelectionCopy = new List<int>();
          s.CopyList(SelectionCopy);

          algorythmDuration.Start();
          slct_Sort.SortDSC(SelectionCopy);
          algorythmDuration.Stop();

          AddToChart(Sorting_Chart, "Selection Sort", algorythmDuration.Elapsed);
        }

        if (c.insertionSelect == true)
        {
          algorythmDuration.Reset();

          List<int> InsertionCopy = new List<int>();
          s.CopyList(InsertionCopy);

          algorythmDuration.Start();
          isrt_Sort.SortDSC(InsertionCopy);
          algorythmDuration.Stop();

          AddToChart(Sorting_Chart, "Insertion Sort", algorythmDuration.Elapsed);
        }
      }
    }


    private void Sorting_Chart_Click(object sender, EventArgs e)
    {

    }
  }
}
