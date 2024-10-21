using System.Windows.Forms;

namespace Astronomical_Processing
{
    partial class Astronomical_Processing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            searchBar = new TextBox();
            neutrinoList = new ListBox();
            btnSearch = new Button();
            btnEditData = new Button();
            btnBubbleSort = new Button();
            editBar = new TextBox();
            btnMidExtreme = new Button();
            btnMode = new Button();
            btnAvg = new Button();
            btnRange = new Button();
            toolTip1 = new ToolTip(components);
            btnSequentialSort = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            btnSequentialSearch = new Button();
            btnNewData = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // searchBar
            // 
            searchBar.Location = new Point(193, 41);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(182, 23);
            searchBar.TabIndex = 0;
            searchBar.Text = "Search here";
            // 
            // neutrinoList
            // 
            neutrinoList.FormattingEnabled = true;
            neutrinoList.ItemHeight = 15;
            neutrinoList.Location = new Point(12, 12);
            neutrinoList.Name = "neutrinoList";
            neutrinoList.Size = new Size(175, 424);
            neutrinoList.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(193, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Binary Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEditData
            // 
            btnEditData.Location = new Point(193, 128);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(88, 23);
            btnEditData.TabIndex = 3;
            btnEditData.Text = "Edit";
            toolTip1.SetToolTip(btnEditData, "Click to change the data.");
            btnEditData.UseVisualStyleBackColor = true;
            btnEditData.Click += btnEditData_Click;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(193, 12);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(88, 23);
            btnBubbleSort.TabIndex = 4;
            btnBubbleSort.Text = "Sort";
            toolTip1.SetToolTip(btnBubbleSort, "Click to sort all data.");
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // editBar
            // 
            editBar.Location = new Point(193, 99);
            editBar.Name = "editBar";
            editBar.Size = new Size(182, 23);
            editBar.TabIndex = 5;
            toolTip1.SetToolTip(editBar, "Enter a value to change.");
            // 
            // btnMidExtreme
            // 
            btnMidExtreme.Location = new Point(193, 384);
            btnMidExtreme.Name = "btnMidExtreme";
            btnMidExtreme.Size = new Size(88, 23);
            btnMidExtreme.TabIndex = 7;
            btnMidExtreme.Text = "Mid-extreme";
            toolTip1.SetToolTip(btnMidExtreme, "Click to calculate the mid-extreme (average of min and max values).");
            btnMidExtreme.UseVisualStyleBackColor = true;
            btnMidExtreme.Click += BtnMidExtreme_Click;
            // 
            // btnMode
            // 
            btnMode.Location = new Point(287, 384);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(88, 23);
            btnMode.TabIndex = 8;
            btnMode.Text = "Mode";
            btnMode.UseVisualStyleBackColor = true;
            btnMode.Click += BtnMode_Click;
            // 
            // btnAvg
            // 
            btnAvg.Location = new Point(193, 413);
            btnAvg.Name = "btnAvg";
            btnAvg.Size = new Size(88, 23);
            btnAvg.TabIndex = 9;
            btnAvg.Text = "Average";
            toolTip1.SetToolTip(btnAvg, "Click to calculate the average of all values.");
            btnAvg.UseVisualStyleBackColor = true;
            btnAvg.Click += BtnAvg_Click;
            // 
            // btnRange
            // 
            btnRange.Location = new Point(287, 413);
            btnRange.Name = "btnRange";
            btnRange.Size = new Size(88, 23);
            btnRange.TabIndex = 10;
            btnRange.Text = "Range";
            toolTip1.SetToolTip(btnRange, "Click to calculate the range (max - min) of all values.");
            btnRange.UseVisualStyleBackColor = true;
            btnRange.Click += BtnRange_Click;
            // 
            // btnSequentialSort
            // 
            btnSequentialSort.Location = new Point(287, 12);
            btnSequentialSort.Name = "btnSequentialSort";
            btnSequentialSort.Size = new Size(88, 23);
            btnSequentialSort.TabIndex = 13;
            btnSequentialSort.Text = "Sequential Sort";
            toolTip1.SetToolTip(btnSequentialSort, "Click to sort all data.");
            btnSequentialSort.UseVisualStyleBackColor = true;
            btnSequentialSort.Click += btnSequentialSort_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 446);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(388, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(138, 17);
            toolStripStatusLabel2.Text = "Astronomical Processing";
            // 
            // btnSequentialSearch
            // 
            btnSequentialSearch.Location = new Point(287, 70);
            btnSequentialSearch.Name = "btnSequentialSearch";
            btnSequentialSearch.Size = new Size(88, 23);
            btnSequentialSearch.TabIndex = 12;
            btnSequentialSearch.Text = "Sequential";
            btnSequentialSearch.UseVisualStyleBackColor = true;
            btnSequentialSearch.Click += btnSequentialSearch_Click;
            // 
            // btnNewData
            // 
            btnNewData.Location = new Point(287, 128);
            btnNewData.Name = "btnNewData";
            btnNewData.Size = new Size(88, 23);
            btnNewData.TabIndex = 14;
            btnNewData.Text = "Refresh Data";
            btnNewData.UseVisualStyleBackColor = true;
            btnNewData.Click += btnNewData_Click;
            // 
            // Astronomical_Processing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 468);
            Controls.Add(btnNewData);
            Controls.Add(btnSequentialSort);
            Controls.Add(btnSequentialSearch);
            Controls.Add(statusStrip1);
            Controls.Add(btnRange);
            Controls.Add(btnAvg);
            Controls.Add(btnMode);
            Controls.Add(btnMidExtreme);
            Controls.Add(editBar);
            Controls.Add(btnBubbleSort);
            Controls.Add(btnEditData);
            Controls.Add(btnSearch);
            Controls.Add(neutrinoList);
            Controls.Add(searchBar);
            Name = "Astronomical_Processing";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox searchBar;
        private ListBox neutrinoList;
        private Button btnSearch;
        private Button btnEditData;
        private Button btnBubbleSort;
        private TextBox editBar;
        private Button btnMidExtreme;
        private Button btnMode;
        private Button btnAvg;
        private Button btnRange;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Button btnSequentialSearch;
        private Button btnSequentialSort;
        private EventHandler editBar_TextChanged;
        private Button btnNewData;
    }
}
