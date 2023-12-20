namespace SortingApp
{
  partial class Sorter
  {
    /// <summary>
    /// Wymagana zmienna projektanta.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Wyczyść wszystkie używane zasoby.
    /// </summary>
    /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Kod generowany przez Projektanta formularzy systemu Windows

    /// <summary>
    /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
    /// jej zawartości w edytorze kodu.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorter));
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.Status_Box = new System.Windows.Forms.GroupBox();
      this.Status_Label = new System.Windows.Forms.Label();
      this.SortString_Button = new System.Windows.Forms.Button();
      this.SortingProperties_Box = new System.Windows.Forms.GroupBox();
      this.Random_RdButton = new System.Windows.Forms.RadioButton();
      this.Descending_RdButton = new System.Windows.Forms.RadioButton();
      this.Ascending_RdButton = new System.Windows.Forms.RadioButton();
      this.Algorythms_Box = new System.Windows.Forms.GroupBox();
      this.QuickSort_CkBox = new System.Windows.Forms.CheckBox();
      this.MergeSort_CkBox = new System.Windows.Forms.CheckBox();
      this.SelectionSort_CkBox = new System.Windows.Forms.CheckBox();
      this.InsertionSort_CkBox = new System.Windows.Forms.CheckBox();
      this.BubbleSort_CkBox = new System.Windows.Forms.CheckBox();
      this.StringPropertiers_Box = new System.Windows.Forms.GroupBox();
      this.GenerateString_Button = new System.Windows.Forms.Button();
      this.MaxLength_Label = new System.Windows.Forms.Label();
      this.MaxValue_Label = new System.Windows.Forms.Label();
      this.MaxStringLength_Label = new System.Windows.Forms.NumericUpDown();
      this.MaxStringValue_Label = new System.Windows.Forms.NumericUpDown();
      this.String_TxtBox = new System.Windows.Forms.TextBox();
      this.Sorting_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.Status_Box.SuspendLayout();
      this.SortingProperties_Box.SuspendLayout();
      this.Algorythms_Box.SuspendLayout();
      this.StringPropertiers_Box.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringLength_Label)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringValue_Label)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Sorting_Chart)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      resources.ApplyResources(this.splitContainer1, "splitContainer1");
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.Status_Box);
      this.splitContainer1.Panel1.Controls.Add(this.SortString_Button);
      this.splitContainer1.Panel1.Controls.Add(this.SortingProperties_Box);
      this.splitContainer1.Panel1.Controls.Add(this.Algorythms_Box);
      this.splitContainer1.Panel1.Controls.Add(this.StringPropertiers_Box);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.String_TxtBox);
      this.splitContainer1.Panel2.Controls.Add(this.Sorting_Chart);
      // 
      // Status_Box
      // 
      this.Status_Box.Controls.Add(this.Status_Label);
      resources.ApplyResources(this.Status_Box, "Status_Box");
      this.Status_Box.Name = "Status_Box";
      this.Status_Box.TabStop = false;
      // 
      // Status_Label
      // 
      resources.ApplyResources(this.Status_Label, "Status_Label");
      this.Status_Label.Name = "Status_Label";
      // 
      // SortString_Button
      // 
      resources.ApplyResources(this.SortString_Button, "SortString_Button");
      this.SortString_Button.Name = "SortString_Button";
      this.SortString_Button.UseVisualStyleBackColor = true;
      this.SortString_Button.Click += new System.EventHandler(this.SortString_Button_Click);
      // 
      // SortingProperties_Box
      // 
      this.SortingProperties_Box.Controls.Add(this.Random_RdButton);
      this.SortingProperties_Box.Controls.Add(this.Descending_RdButton);
      this.SortingProperties_Box.Controls.Add(this.Ascending_RdButton);
      resources.ApplyResources(this.SortingProperties_Box, "SortingProperties_Box");
      this.SortingProperties_Box.Name = "SortingProperties_Box";
      this.SortingProperties_Box.TabStop = false;
      // 
      // Random_RdButton
      // 
      resources.ApplyResources(this.Random_RdButton, "Random_RdButton");
      this.Random_RdButton.Name = "Random_RdButton";
      this.Random_RdButton.UseVisualStyleBackColor = true;
      this.Random_RdButton.CheckedChanged += new System.EventHandler(this.Random_RdButton_CheckedChanged);
      // 
      // Descending_RdButton
      // 
      resources.ApplyResources(this.Descending_RdButton, "Descending_RdButton");
      this.Descending_RdButton.Name = "Descending_RdButton";
      this.Descending_RdButton.UseVisualStyleBackColor = true;
      this.Descending_RdButton.CheckedChanged += new System.EventHandler(this.Descending_RdButton_CheckedChanged);
      // 
      // Ascending_RdButton
      // 
      resources.ApplyResources(this.Ascending_RdButton, "Ascending_RdButton");
      this.Ascending_RdButton.Checked = true;
      this.Ascending_RdButton.Name = "Ascending_RdButton";
      this.Ascending_RdButton.TabStop = true;
      this.Ascending_RdButton.UseVisualStyleBackColor = true;
      this.Ascending_RdButton.CheckedChanged += new System.EventHandler(this.Ascending_RdButton_CheckedChanged);
      // 
      // Algorythms_Box
      // 
      this.Algorythms_Box.Controls.Add(this.QuickSort_CkBox);
      this.Algorythms_Box.Controls.Add(this.MergeSort_CkBox);
      this.Algorythms_Box.Controls.Add(this.SelectionSort_CkBox);
      this.Algorythms_Box.Controls.Add(this.InsertionSort_CkBox);
      this.Algorythms_Box.Controls.Add(this.BubbleSort_CkBox);
      resources.ApplyResources(this.Algorythms_Box, "Algorythms_Box");
      this.Algorythms_Box.Name = "Algorythms_Box";
      this.Algorythms_Box.TabStop = false;
      // 
      // QuickSort_CkBox
      // 
      resources.ApplyResources(this.QuickSort_CkBox, "QuickSort_CkBox");
      this.QuickSort_CkBox.Name = "QuickSort_CkBox";
      this.QuickSort_CkBox.UseVisualStyleBackColor = true;
      this.QuickSort_CkBox.CheckedChanged += new System.EventHandler(this.QuickSort_CkBox_CheckedChanged);
      // 
      // MergeSort_CkBox
      // 
      resources.ApplyResources(this.MergeSort_CkBox, "MergeSort_CkBox");
      this.MergeSort_CkBox.Name = "MergeSort_CkBox";
      this.MergeSort_CkBox.UseVisualStyleBackColor = true;
      this.MergeSort_CkBox.CheckedChanged += new System.EventHandler(this.MergeSort_CkBox_CheckedChanged);
      // 
      // SelectionSort_CkBox
      // 
      resources.ApplyResources(this.SelectionSort_CkBox, "SelectionSort_CkBox");
      this.SelectionSort_CkBox.Name = "SelectionSort_CkBox";
      this.SelectionSort_CkBox.UseVisualStyleBackColor = true;
      this.SelectionSort_CkBox.CheckedChanged += new System.EventHandler(this.SelectionSort_CkBox_CheckedChanged);
      // 
      // InsertionSort_CkBox
      // 
      resources.ApplyResources(this.InsertionSort_CkBox, "InsertionSort_CkBox");
      this.InsertionSort_CkBox.Name = "InsertionSort_CkBox";
      this.InsertionSort_CkBox.UseVisualStyleBackColor = true;
      this.InsertionSort_CkBox.CheckedChanged += new System.EventHandler(this.InsertionSort_CkBox_CheckedChanged);
      // 
      // BubbleSort_CkBox
      // 
      resources.ApplyResources(this.BubbleSort_CkBox, "BubbleSort_CkBox");
      this.BubbleSort_CkBox.Name = "BubbleSort_CkBox";
      this.BubbleSort_CkBox.UseVisualStyleBackColor = true;
      this.BubbleSort_CkBox.CheckedChanged += new System.EventHandler(this.BubbleSort_CkBox_CheckedChanged);
      // 
      // StringPropertiers_Box
      // 
      this.StringPropertiers_Box.Controls.Add(this.GenerateString_Button);
      this.StringPropertiers_Box.Controls.Add(this.MaxLength_Label);
      this.StringPropertiers_Box.Controls.Add(this.MaxValue_Label);
      this.StringPropertiers_Box.Controls.Add(this.MaxStringLength_Label);
      this.StringPropertiers_Box.Controls.Add(this.MaxStringValue_Label);
      resources.ApplyResources(this.StringPropertiers_Box, "StringPropertiers_Box");
      this.StringPropertiers_Box.Name = "StringPropertiers_Box";
      this.StringPropertiers_Box.TabStop = false;
      // 
      // GenerateString_Button
      // 
      resources.ApplyResources(this.GenerateString_Button, "GenerateString_Button");
      this.GenerateString_Button.Name = "GenerateString_Button";
      this.GenerateString_Button.UseVisualStyleBackColor = true;
      this.GenerateString_Button.Click += new System.EventHandler(this.GenerateString_Button_Click);
      // 
      // MaxLength_Label
      // 
      resources.ApplyResources(this.MaxLength_Label, "MaxLength_Label");
      this.MaxLength_Label.Name = "MaxLength_Label";
      // 
      // MaxValue_Label
      // 
      resources.ApplyResources(this.MaxValue_Label, "MaxValue_Label");
      this.MaxValue_Label.Name = "MaxValue_Label";
      // 
      // MaxStringLength_Label
      // 
      resources.ApplyResources(this.MaxStringLength_Label, "MaxStringLength_Label");
      this.MaxStringLength_Label.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
      this.MaxStringLength_Label.Name = "MaxStringLength_Label";
      this.MaxStringLength_Label.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.MaxStringLength_Label.ValueChanged += new System.EventHandler(this.MaxStringLength_Label_ValueChanged);
      // 
      // MaxStringValue_Label
      // 
      resources.ApplyResources(this.MaxStringValue_Label, "MaxStringValue_Label");
      this.MaxStringValue_Label.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
      this.MaxStringValue_Label.Name = "MaxStringValue_Label";
      this.MaxStringValue_Label.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.MaxStringValue_Label.ValueChanged += new System.EventHandler(this.MaxStringValue_Label_ValueChanged);
      // 
      // String_TxtBox
      // 
      resources.ApplyResources(this.String_TxtBox, "String_TxtBox");
      this.String_TxtBox.Name = "String_TxtBox";
      this.String_TxtBox.ReadOnly = true;
      // 
      // Sorting_Chart
      // 
      this.Sorting_Chart.BorderlineColor = System.Drawing.Color.Black;
      this.Sorting_Chart.BorderlineWidth = 2;
      chartArea1.Name = "ChartArea1";
      this.Sorting_Chart.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.Sorting_Chart.Legends.Add(legend1);
      resources.ApplyResources(this.Sorting_Chart, "Sorting_Chart");
      this.Sorting_Chart.Name = "Sorting_Chart";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.Sorting_Chart.Series.Add(series1);
      // 
      // Sorter
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.MaximizeBox = false;
      this.Name = "Sorter";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.Status_Box.ResumeLayout(false);
      this.Status_Box.PerformLayout();
      this.SortingProperties_Box.ResumeLayout(false);
      this.SortingProperties_Box.PerformLayout();
      this.Algorythms_Box.ResumeLayout(false);
      this.Algorythms_Box.PerformLayout();
      this.StringPropertiers_Box.ResumeLayout(false);
      this.StringPropertiers_Box.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringLength_Label)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringValue_Label)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Sorting_Chart)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox SortingProperties_Box;
    private System.Windows.Forms.GroupBox Algorythms_Box;
    private System.Windows.Forms.GroupBox StringPropertiers_Box;
    private System.Windows.Forms.CheckBox QuickSort_CkBox;
    private System.Windows.Forms.CheckBox MergeSort_CkBox;
    private System.Windows.Forms.CheckBox SelectionSort_CkBox;
    private System.Windows.Forms.CheckBox InsertionSort_CkBox;
    private System.Windows.Forms.CheckBox BubbleSort_CkBox;
    private System.Windows.Forms.DataVisualization.Charting.Chart Sorting_Chart;
    private System.Windows.Forms.NumericUpDown MaxStringValue_Label;
    private System.Windows.Forms.RadioButton Descending_RdButton;
    private System.Windows.Forms.RadioButton Ascending_RdButton;
    private System.Windows.Forms.Button GenerateString_Button;
    private System.Windows.Forms.Label MaxLength_Label;
    private System.Windows.Forms.Label MaxValue_Label;
    private System.Windows.Forms.NumericUpDown MaxStringLength_Label;
    private System.Windows.Forms.RadioButton Random_RdButton;
    private System.Windows.Forms.Button SortString_Button;
    private System.Windows.Forms.TextBox String_TxtBox;
    private System.Windows.Forms.GroupBox Status_Box;
    private System.Windows.Forms.Label Status_Label;
  }
}
