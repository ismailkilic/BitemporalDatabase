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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 312);
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
            this.label1.Location = new System.Drawing.Point(260, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Selected Commit ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "-";
            // 
            // frm_CommitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewer);
            this.Name = "frm_CommitHistory";
            this.Text = "frm_CommitHistory";
            this.Load += new System.EventHandler(this.frm_CommitHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}