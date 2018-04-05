namespace BitemporalBasicApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGrid_locationArchive = new System.Windows.Forms.DataGridView();
            this.btn_add_new_person = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh_valid = new System.Windows.Forms.Button();
            this.btn_Commit = new System.Windows.Forms.Button();
            this.btn_refresh_valid_on_branch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_locationArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location Archive";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(415, 325);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(162, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh Grid for All Data";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGrid_locationArchive
            // 
            this.dataGrid_locationArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_locationArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_locationArchive.Location = new System.Drawing.Point(12, 37);
            this.dataGrid_locationArchive.Name = "dataGrid_locationArchive";
            this.dataGrid_locationArchive.Size = new System.Drawing.Size(564, 195);
            this.dataGrid_locationArchive.TabIndex = 2;
            // 
            // btn_add_new_person
            // 
            this.btn_add_new_person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_new_person.Location = new System.Drawing.Point(12, 254);
            this.btn_add_new_person.Name = "btn_add_new_person";
            this.btn_add_new_person.Size = new System.Drawing.Size(114, 23);
            this.btn_add_new_person.TabIndex = 3;
            this.btn_add_new_person.Text = "Add New Person";
            this.btn_add_new_person.UseVisualStyleBackColor = true;
            this.btn_add_new_person.Click += new System.EventHandler(this.btn_add_new_person_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(135, 254);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit Selected Person";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(266, 254);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete Selected Person";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh_valid
            // 
            this.btn_refresh_valid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_valid.Location = new System.Drawing.Point(414, 354);
            this.btn_refresh_valid.Name = "btn_refresh_valid";
            this.btn_refresh_valid.Size = new System.Drawing.Size(162, 23);
            this.btn_refresh_valid.TabIndex = 6;
            this.btn_refresh_valid.Text = "Refresh Grid for Valid Data";
            this.btn_refresh_valid.UseVisualStyleBackColor = true;
            this.btn_refresh_valid.Click += new System.EventHandler(this.btn_refresh_valid_Click);
            // 
            // btn_Commit
            // 
            this.btn_Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Commit.Location = new System.Drawing.Point(16, 354);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(114, 23);
            this.btn_Commit.TabIndex = 7;
            this.btn_Commit.Text = "Commit";
            this.btn_Commit.UseVisualStyleBackColor = true;
            this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
            // 
            // btn_refresh_valid_on_branch
            // 
            this.btn_refresh_valid_on_branch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_valid_on_branch.Location = new System.Drawing.Point(246, 325);
            this.btn_refresh_valid_on_branch.Name = "btn_refresh_valid_on_branch";
            this.btn_refresh_valid_on_branch.Size = new System.Drawing.Size(162, 52);
            this.btn_refresh_valid_on_branch.TabIndex = 8;
            this.btn_refresh_valid_on_branch.Text = "Refresh Grid for All Data on Selected branch";
            this.btn_refresh_valid_on_branch.UseVisualStyleBackColor = true;
            this.btn_refresh_valid_on_branch.Click += new System.EventHandler(this.btn_refresh_valid_on_branch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 389);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_refresh_valid_on_branch);
            this.Controls.Add(this.btn_Commit);
            this.Controls.Add(this.btn_refresh_valid);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add_new_person);
            this.Controls.Add(this.dataGrid_locationArchive);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_locationArchive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGrid_locationArchive;
        private System.Windows.Forms.Button btn_add_new_person;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh_valid;
        private System.Windows.Forms.Button btn_Commit;
        private System.Windows.Forms.Button btn_refresh_valid_on_branch;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

