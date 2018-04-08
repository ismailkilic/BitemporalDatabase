namespace BitemporalBasicApp
{
    partial class frm_CommitHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CommitHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CommitID = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_BranchID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_CommitName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_BranchName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 156);
            this.dataGridView1.TabIndex = 8;
            // 
            // viewer
            // 
            this.viewer.ArrowheadLength = 10D;
            this.viewer.AsyncLayout = false;
            this.viewer.AutoScroll = true;
            this.viewer.BackwardEnabled = false;
            this.viewer.BuildHitTree = true;
            this.viewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.viewer.EdgeInsertButtonVisible = true;
            this.viewer.FileName = "";
            this.viewer.ForwardEnabled = false;
            this.viewer.Graph = null;
            this.viewer.InsertingEdge = false;
            this.viewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.viewer.LayoutEditingEnabled = true;
            this.viewer.Location = new System.Drawing.Point(8, 12);
            this.viewer.LooseOffsetForRouting = 0.25D;
            this.viewer.MouseHitDistance = 0.05D;
            this.viewer.Name = "viewer";
            this.viewer.NavigationVisible = true;
            this.viewer.NeedToCalculateLayout = true;
            this.viewer.OffsetForRelaxingInRouting = 0.6D;
            this.viewer.PaddingForEdgeRouting = 8D;
            this.viewer.PanButtonPressed = false;
            this.viewer.SaveAsImageEnabled = true;
            this.viewer.SaveAsMsaglEnabled = true;
            this.viewer.SaveButtonVisible = true;
            this.viewer.SaveGraphButtonVisible = true;
            this.viewer.SaveInVectorFormatEnabled = true;
            this.viewer.Size = new System.Drawing.Size(198, 313);
            this.viewer.TabIndex = 69;
            this.viewer.TightOffsetForRouting = 0.125D;
            this.viewer.ToolBarIsVisible = true;
            this.viewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("viewer.Transform")));
            this.viewer.UndoRedoButtonsVisible = true;
            this.viewer.WindowZoomButtonPressed = false;
            this.viewer.ZoomF = 1D;
            this.viewer.ZoomWindowThreshold = 0.05D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Selected Commit ID:";
            // 
            // lbl_CommitID
            // 
            this.lbl_CommitID.AutoSize = true;
            this.lbl_CommitID.Location = new System.Drawing.Point(377, 181);
            this.lbl_CommitID.Name = "lbl_CommitID";
            this.lbl_CommitID.Size = new System.Drawing.Size(10, 13);
            this.lbl_CommitID.TabIndex = 71;
            this.lbl_CommitID.Text = "-";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(260, 223);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(478, 156);
            this.dataGridView2.TabIndex = 72;
            // 
            // lbl_BranchID
            // 
            this.lbl_BranchID.AutoSize = true;
            this.lbl_BranchID.Location = new System.Drawing.Point(586, 181);
            this.lbl_BranchID.Name = "lbl_BranchID";
            this.lbl_BranchID.Size = new System.Drawing.Size(10, 13);
            this.lbl_BranchID.TabIndex = 74;
            this.lbl_BranchID.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Selected Branch ID:";
            // 
            // lbl_CommitName
            // 
            this.lbl_CommitName.AutoSize = true;
            this.lbl_CommitName.Location = new System.Drawing.Point(377, 199);
            this.lbl_CommitName.Name = "lbl_CommitName";
            this.lbl_CommitName.Size = new System.Drawing.Size(10, 13);
            this.lbl_CommitName.TabIndex = 76;
            this.lbl_CommitName.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Selected Commit Name:";
            // 
            // lbl_BranchName
            // 
            this.lbl_BranchName.AutoSize = true;
            this.lbl_BranchName.Location = new System.Drawing.Point(586, 199);
            this.lbl_BranchName.Name = "lbl_BranchName";
            this.lbl_BranchName.Size = new System.Drawing.Size(10, 13);
            this.lbl_BranchName.TabIndex = 78;
            this.lbl_BranchName.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Selected Banch Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(5, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Green Nodes mean Node of Branches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Red Nodes mean Node of Master";
            // 
            // frm_CommitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_BranchName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_CommitName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_BranchID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl_CommitID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewer);
            this.Name = "frm_CommitHistory";
            this.Text = "frm_CommitHistory";
            this.Load += new System.EventHandler(this.frm_CommitHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CommitID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_BranchID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_CommitName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_BranchName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}