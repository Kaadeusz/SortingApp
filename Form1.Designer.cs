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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.MaxStringLength_Label = new System.Windows.Forms.NumericUpDown();
      this.MaxStringValue_Label = new System.Windows.Forms.NumericUpDown();
      this.SortingProcess_ProgressBar = new System.Windows.Forms.ProgressBar();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SortingProperties_Box.SuspendLayout();
      this.Algorythms_Box.SuspendLayout();
      this.StringPropertiers_Box.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringLength_Label)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringValue_Label)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      resources.ApplyResources(this.splitContainer1, "splitContainer1");
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.SortString_Button);
      this.splitContainer1.Panel1.Controls.Add(this.SortingProperties_Box);
      this.splitContainer1.Panel1.Controls.Add(this.Algorythms_Box);
      this.splitContainer1.Panel1.Controls.Add(this.StringPropertiers_Box);
      this.splitContainer1.Panel1.Controls.Add(this.SortingProcess_ProgressBar);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.textBox1);
      this.splitContainer1.Panel2.Controls.Add(this.chart1);
      // 
      // SortString_Button
      // 
      resources.ApplyResources(this.SortString_Button, "SortString_Button");
      this.SortString_Button.Name = "SortString_Button";
      this.SortString_Button.UseVisualStyleBackColor = true;
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
      this.Random_RdButton.TabStop = true;
      this.Random_RdButton.UseVisualStyleBackColor = true;
      // 
      // Descending_RdButton
      // 
      resources.ApplyResources(this.Descending_RdButton, "Descending_RdButton");
      this.Descending_RdButton.Name = "Descending_RdButton";
      this.Descending_RdButton.TabStop = true;
      this.Descending_RdButton.UseVisualStyleBackColor = true;
      // 
      // Ascending_RdButton
      // 
      resources.ApplyResources(this.Ascending_RdButton, "Ascending_RdButton");
      this.Ascending_RdButton.Name = "Ascending_RdButton";
      this.Ascending_RdButton.TabStop = true;
      this.Ascending_RdButton.UseVisualStyleBackColor = true;
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
      // 
      // MergeSort_CkBox
      // 
      resources.ApplyResources(this.MergeSort_CkBox, "MergeSort_CkBox");
      this.MergeSort_CkBox.Name = "MergeSort_CkBox";
      this.MergeSort_CkBox.UseVisualStyleBackColor = true;
      // 
      // SelectionSort_CkBox
      // 
      resources.ApplyResources(this.SelectionSort_CkBox, "SelectionSort_CkBox");
      this.SelectionSort_CkBox.Name = "SelectionSort_CkBox";
      this.SelectionSort_CkBox.UseVisualStyleBackColor = true;
      // 
      // InsertionSort_CkBox
      // 
      resources.ApplyResources(this.InsertionSort_CkBox, "InsertionSort_CkBox");
      this.InsertionSort_CkBox.Name = "InsertionSort_CkBox";
      this.InsertionSort_CkBox.UseVisualStyleBackColor = true;
      // 
      // BubbleSort_CkBox
      // 
      resources.ApplyResources(this.BubbleSort_CkBox, "BubbleSort_CkBox");
      this.BubbleSort_CkBox.Name = "BubbleSort_CkBox";
      this.BubbleSort_CkBox.UseVisualStyleBackColor = true;
      // 
      // StringPropertiers_Box
      // 
      this.StringPropertiers_Box.Controls.Add(this.GenerateString_Button);
      this.StringPropertiers_Box.Controls.Add(this.label2);
      this.StringPropertiers_Box.Controls.Add(this.label1);
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
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // MaxStringLength_Label
      // 
      resources.ApplyResources(this.MaxStringLength_Label, "MaxStringLength_Label");
      this.MaxStringLength_Label.Name = "MaxStringLength_Label";
      this.MaxStringLength_Label.ValueChanged += new System.EventHandler(this.MaxStringLength_Label_ValueChanged);
      // 
      // MaxStringValue_Label
      // 
      resources.ApplyResources(this.MaxStringValue_Label, "MaxStringValue_Label");
      this.MaxStringValue_Label.Name = "MaxStringValue_Label";
      this.MaxStringValue_Label.ValueChanged += new System.EventHandler(this.MaxStringValue_Label_ValueChanged);
      // 
      // SortingProcess_ProgressBar
      // 
      resources.ApplyResources(this.SortingProcess_ProgressBar, "SortingProcess_ProgressBar");
      this.SortingProcess_ProgressBar.Name = "SortingProcess_ProgressBar";
      this.SortingProcess_ProgressBar.Click += new System.EventHandler(this.SortingProcess_ProgressBar_Click);
      // 
      // chart1
      // 
      this.chart1.BorderlineColor = System.Drawing.Color.Black;
      this.chart1.BorderlineWidth = 2;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      resources.ApplyResources(this.chart1, "chart1");
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      // 
      // textBox1
      // 
      resources.ApplyResources(this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // Sorter
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "Sorter";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.SortingProperties_Box.ResumeLayout(false);
      this.SortingProperties_Box.PerformLayout();
      this.Algorythms_Box.ResumeLayout(false);
      this.Algorythms_Box.PerformLayout();
      this.StringPropertiers_Box.ResumeLayout(false);
      this.StringPropertiers_Box.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringLength_Label)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxStringValue_Label)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.NumericUpDown MaxStringValue_Label;
    private System.Windows.Forms.ProgressBar SortingProcess_ProgressBar;
    private System.Windows.Forms.RadioButton Descending_RdButton;
    private System.Windows.Forms.RadioButton Ascending_RdButton;
    private System.Windows.Forms.Button GenerateString_Button;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown MaxStringLength_Label;
    private System.Windows.Forms.RadioButton Random_RdButton;
    private System.Windows.Forms.Button SortString_Button;
    private System.Windows.Forms.TextBox textBox1;
  }
}

