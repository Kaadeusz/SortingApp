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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.SortingProperties_Box = new System.Windows.Forms.GroupBox();
      this.Algorythms_Box = new System.Windows.Forms.GroupBox();
      this.StringPropertiers_Box = new System.Windows.Forms.GroupBox();
      this.BubbleSort_CkBox = new System.Windows.Forms.CheckBox();
      this.SelectionSort_CkBox = new System.Windows.Forms.CheckBox();
      this.InsertionSort_CkBox = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.Algorythms_Box.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      resources.ApplyResources(this.splitContainer1, "splitContainer1");
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.SortingProperties_Box);
      this.splitContainer1.Panel1.Controls.Add(this.Algorythms_Box);
      this.splitContainer1.Panel1.Controls.Add(this.StringPropertiers_Box);
      // 
      // SortingProperties_Box
      // 
      resources.ApplyResources(this.SortingProperties_Box, "SortingProperties_Box");
      this.SortingProperties_Box.Name = "SortingProperties_Box";
      this.SortingProperties_Box.TabStop = false;
      // 
      // Algorythms_Box
      // 
      this.Algorythms_Box.Controls.Add(this.checkBox5);
      this.Algorythms_Box.Controls.Add(this.checkBox4);
      this.Algorythms_Box.Controls.Add(this.SelectionSort_CkBox);
      this.Algorythms_Box.Controls.Add(this.InsertionSort_CkBox);
      this.Algorythms_Box.Controls.Add(this.BubbleSort_CkBox);
      resources.ApplyResources(this.Algorythms_Box, "Algorythms_Box");
      this.Algorythms_Box.Name = "Algorythms_Box";
      this.Algorythms_Box.TabStop = false;
      // 
      // StringPropertiers_Box
      // 
      resources.ApplyResources(this.StringPropertiers_Box, "StringPropertiers_Box");
      this.StringPropertiers_Box.Name = "StringPropertiers_Box";
      this.StringPropertiers_Box.TabStop = false;
      // 
      // BubbleSort_CkBox
      // 
      resources.ApplyResources(this.BubbleSort_CkBox, "BubbleSort_CkBox");
      this.BubbleSort_CkBox.Name = "BubbleSort_CkBox";
      this.BubbleSort_CkBox.UseVisualStyleBackColor = true;
      this.BubbleSort_CkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // SelectionSort_CkBox
      // 
      resources.ApplyResources(this.SelectionSort_CkBox, "SelectionSort_CkBox");
      this.SelectionSort_CkBox.Name = "SelectionSort_CkBox";
      this.SelectionSort_CkBox.UseVisualStyleBackColor = true;
      this.SelectionSort_CkBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
      // 
      // InsertionSort_CkBox
      // 
      resources.ApplyResources(this.InsertionSort_CkBox, "InsertionSort_CkBox");
      this.InsertionSort_CkBox.Name = "InsertionSort_CkBox";
      this.InsertionSort_CkBox.UseVisualStyleBackColor = true;
      this.InsertionSort_CkBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // checkBox4
      // 
      resources.ApplyResources(this.checkBox4, "checkBox4");
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox5
      // 
      resources.ApplyResources(this.checkBox5, "checkBox5");
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.UseVisualStyleBackColor = true;
      // 
      // Sorter
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "Sorter";
      this.splitContainer1.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.Algorythms_Box.ResumeLayout(false);
      this.Algorythms_Box.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox SortingProperties_Box;
    private System.Windows.Forms.GroupBox Algorythms_Box;
    private System.Windows.Forms.GroupBox StringPropertiers_Box;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox SelectionSort_CkBox;
    private System.Windows.Forms.CheckBox InsertionSort_CkBox;
    private System.Windows.Forms.CheckBox BubbleSort_CkBox;
  }
}

