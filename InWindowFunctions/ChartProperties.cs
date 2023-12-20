using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortingApp
{
  public partial class Sorter : Form
  {
    BubbleSort bbl_Sort = new BubbleSort();
    SelectionSort slct_Sort = new SelectionSort();
    InsertionSort isrt_Sort = new InsertionSort();
    MergeSort mrg_Sort = new MergeSort();
    QuickSort q_Sort = new QuickSort();

    private void AddToChart(Chart chart, string seriesName, TimeSpan time)
    {
      Series chartValue = new Series(seriesName);

      chartValue.Points.AddY(time.TotalMilliseconds);
      chart.Series.Add(chartValue);
    }

    private void InitializeAlgorythm<T>(ISorting<T> sorting, bool ascendance,  string name, List<int> list)
    {
      Stopwatch algorythmDuration = new Stopwatch();

      algorythmDuration.Reset();

      List<int> copy = new List<int>();
      s.CopyList(copy);

      if(ascendance == true)
      {
        algorythmDuration.Start();
        sorting.SortASC(copy);
        algorythmDuration.Stop();
      }

      else
      {
        algorythmDuration.Start();
        sorting.SortDSC(copy);
        algorythmDuration.Stop();
      }

      AddToChart(Sorting_Chart, name, algorythmDuration.Elapsed);
      s.ConvertToTextBox(String_TxtBox, copy);
    }

    private void SortString_Button_Click(object sender, EventArgs e)
    {
      if (!s.IsNotEmpty())
      {
        MessageBox.Show("You might have forgotten about string of number...", "Error!", MessageBoxButtons.OK);
        return;
      }

      if (!BubbleSort_CkBox.Checked && !SelectionSort_CkBox.Checked && !InsertionSort_CkBox.Checked && !QuickSort_CkBox.Checked && !MergeSort_CkBox.Checked)
      {
        MessageBox.Show("Check at least one algorythm", "Error!", MessageBoxButtons.OK);
        return;
      }

      Sorting_Chart.Series.Clear();

      if (c.ascendingSorting == true)
      {
        if (c.bubbleSelect == true)
        {
          List<int> bubble = new List<int>();
          InitializeAlgorythm<BubbleSort>(bbl_Sort, true, "Bubble Sort", bubble);
        }

        if (c.selectionSelect == true)
        {
          List<int> selection = new List<int>();
          InitializeAlgorythm<SelectionSort>(slct_Sort, true, "Selection Sort", selection);
        }

        if (c.insertionSelect == true)
        {
          List<int> insertion = new List<int>();
          InitializeAlgorythm<InsertionSort>(isrt_Sort, true, "Insertion Sort", insertion);
        }

        if (c.mergeSelect == true)
        {
          List<int> merge = new List<int>();
          InitializeAlgorythm<MergeSort>(mrg_Sort, true, "Merge Sort", merge);
        }

        if (c.quickSelect == true)
        {
          List<int> quick = new List<int>();
          InitializeAlgorythm<QuickSort>(q_Sort, true, "Quick Sort", quick);
        }
      }

      else
      {
        if (c.bubbleSelect == true)
        {
          List<int> bubble = new List<int>();
          InitializeAlgorythm<BubbleSort>(bbl_Sort, false, "Bubble Sort", bubble);
        }

        if (c.selectionSelect == true)
        {
          List<int> selection = new List<int>();
          InitializeAlgorythm<SelectionSort>(slct_Sort, false, "Selection Sort", selection);
        }

        if (c.insertionSelect == true)
        {
          List<int> insertion = new List<int>();
          InitializeAlgorythm<InsertionSort>(isrt_Sort, false, "Insertion Sort", insertion);
        }

        if (c.mergeSelect == true)
        {
          List<int> merge = new List<int>();
          InitializeAlgorythm<MergeSort>(mrg_Sort, false, "Merge Sort", merge);
        }

        if (c.quickSelect == true)
        {
          List<int> quick = new List<int>();
          InitializeAlgorythm<QuickSort>(q_Sort, false, "Quick Sort", quick);
        }
      }

      Status_Label.Text = "Sorted!";
    }
  }
}
