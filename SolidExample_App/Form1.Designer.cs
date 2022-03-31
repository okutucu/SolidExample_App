namespace SolidExample_App
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nmrHour = new System.Windows.Forms.NumericUpDown();
            this.cmbAssign = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilterTaskState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilterAssign = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstTaskList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flwOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTeamMember = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.btnTaskStateChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).BeginInit();
            this.flwOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TASK CREATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hour:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assign:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(12, 107);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(263, 36);
            this.txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(12, 191);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 72);
            this.txtDescription.TabIndex = 6;
            // 
            // nmrHour
            // 
            this.nmrHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrHour.Location = new System.Drawing.Point(17, 319);
            this.nmrHour.Name = "nmrHour";
            this.nmrHour.Size = new System.Drawing.Size(263, 36);
            this.nmrHour.TabIndex = 7;
            // 
            // cmbAssign
            // 
            this.cmbAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAssign.FormattingEnabled = true;
            this.cmbAssign.Location = new System.Drawing.Point(12, 412);
            this.cmbAssign.Name = "cmbAssign";
            this.cmbAssign.Size = new System.Drawing.Size(263, 37);
            this.cmbAssign.TabIndex = 8;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNew.Location = new System.Drawing.Point(346, 395);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(171, 54);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(577, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "TaskState";
            // 
            // cmbFilterTaskState
            // 
            this.cmbFilterTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilterTaskState.FormattingEnabled = true;
            this.cmbFilterTaskState.Location = new System.Drawing.Point(582, 136);
            this.cmbFilterTaskState.Name = "cmbFilterTaskState";
            this.cmbFilterTaskState.Size = new System.Drawing.Size(229, 37);
            this.cmbFilterTaskState.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(881, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Assign";
            // 
            // cmbFilterAssign
            // 
            this.cmbFilterAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilterAssign.FormattingEnabled = true;
            this.cmbFilterAssign.Location = new System.Drawing.Point(877, 136);
            this.cmbFilterAssign.Name = "cmbFilterAssign";
            this.cmbFilterAssign.Size = new System.Drawing.Size(243, 37);
            this.cmbFilterAssign.TabIndex = 13;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.Location = new System.Drawing.Point(1189, 126);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(156, 55);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(680, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "FİLTER";
            // 
            // lstTaskList
            // 
            this.lstTaskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTaskList.HideSelection = false;
            this.lstTaskList.Location = new System.Drawing.Point(17, 477);
            this.lstTaskList.Name = "lstTaskList";
            this.lstTaskList.Size = new System.Drawing.Size(1414, 238);
            this.lstTaskList.TabIndex = 16;
            this.lstTaskList.UseCompatibleStateImageBehavior = false;
            this.lstTaskList.View = System.Windows.Forms.View.Details;
            this.lstTaskList.SelectedIndexChanged += new System.EventHandler(this.lstTaskList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 222;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "WorkHour";
            this.columnHeader2.Width = 277;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TaskState";
            this.columnHeader3.Width = 293;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Assigned";
            this.columnHeader4.Width = 222;
            // 
            // flwOperation
            // 
            this.flwOperation.Controls.Add(this.label9);
            this.flwOperation.Controls.Add(this.cmbTeamMember);
            this.flwOperation.Controls.Add(this.btnAssign);
            this.flwOperation.Controls.Add(this.label10);
            this.flwOperation.Controls.Add(this.cmbTaskState);
            this.flwOperation.Controls.Add(this.btnTaskStateChange);
            this.flwOperation.Location = new System.Drawing.Point(23, 738);
            this.flwOperation.Name = "flwOperation";
            this.flwOperation.Size = new System.Drawing.Size(1407, 167);
            this.flwOperation.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Team Member:";
            // 
            // cmbTeamMember
            // 
            this.cmbTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTeamMember.FormattingEnabled = true;
            this.cmbTeamMember.Location = new System.Drawing.Point(187, 3);
            this.cmbTeamMember.Name = "cmbTeamMember";
            this.cmbTeamMember.Size = new System.Drawing.Size(223, 37);
            this.cmbTeamMember.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssign.Location = new System.Drawing.Point(416, 3);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(132, 37);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(554, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "TaskState:";
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(687, 3);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(284, 37);
            this.cmbTaskState.TabIndex = 4;
            // 
            // btnTaskStateChange
            // 
            this.btnTaskStateChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskStateChange.Location = new System.Drawing.Point(977, 3);
            this.btnTaskStateChange.Name = "btnTaskStateChange";
            this.btnTaskStateChange.Size = new System.Drawing.Size(238, 40);
            this.btnTaskStateChange.TabIndex = 5;
            this.btnTaskStateChange.Text = "TaskState Change";
            this.btnTaskStateChange.UseVisualStyleBackColor = true;
            this.btnTaskStateChange.Click += new System.EventHandler(this.btnTaskStateChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 951);
            this.Controls.Add(this.flwOperation);
            this.Controls.Add(this.lstTaskList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilterAssign);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFilterTaskState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbAssign);
            this.Controls.Add(this.nmrHour);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).EndInit();
            this.flwOperation.ResumeLayout(false);
            this.flwOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nmrHour;
        private System.Windows.Forms.ComboBox cmbAssign;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilterTaskState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFilterAssign;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstTaskList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.FlowLayoutPanel flwOperation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTeamMember;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Button btnTaskStateChange;
    }
}

