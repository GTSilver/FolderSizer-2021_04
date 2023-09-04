namespace Folders_Sizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Path_TB = new System.Windows.Forms.TextBox();
            this.Start_B = new System.Windows.Forms.Button();
            this.Open_B = new System.Windows.Forms.Button();
            this.Result_DGV = new System.Windows.Forms.DataGridView();
            this.NameF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Fiels_L = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Folders_L = new System.Windows.Forms.Label();
            this.Size_L = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Path_TB
            // 
            this.Path_TB.Location = new System.Drawing.Point(12, 41);
            this.Path_TB.Name = "Path_TB";
            this.Path_TB.Size = new System.Drawing.Size(287, 20);
            this.Path_TB.TabIndex = 0;
            // 
            // Start_B
            // 
            this.Start_B.Location = new System.Drawing.Point(305, 12);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(75, 23);
            this.Start_B.TabIndex = 1;
            this.Start_B.Text = "Start";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // Open_B
            // 
            this.Open_B.Location = new System.Drawing.Point(305, 39);
            this.Open_B.Name = "Open_B";
            this.Open_B.Size = new System.Drawing.Size(75, 23);
            this.Open_B.TabIndex = 2;
            this.Open_B.Text = "Open";
            this.Open_B.UseVisualStyleBackColor = true;
            this.Open_B.Click += new System.EventHandler(this.Open_B_Click);
            // 
            // Result_DGV
            // 
            this.Result_DGV.AllowUserToAddRows = false;
            this.Result_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameF,
            this.SizeMB,
            this.SizeB,
            this.Percent});
            this.Result_DGV.Location = new System.Drawing.Point(12, 68);
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.RowHeadersVisible = false;
            this.Result_DGV.Size = new System.Drawing.Size(368, 133);
            this.Result_DGV.TabIndex = 3;
            // 
            // NameF
            // 
            this.NameF.Frozen = true;
            this.NameF.HeaderText = "Name";
            this.NameF.Name = "NameF";
            this.NameF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SizeMB
            // 
            this.SizeMB.Frozen = true;
            this.SizeMB.HeaderText = "Size, MB";
            this.SizeMB.Name = "SizeMB";
            this.SizeMB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SizeMB.Width = 76;
            // 
            // SizeB
            // 
            this.SizeB.Frozen = true;
            this.SizeB.HeaderText = "Size, B";
            this.SizeB.Name = "SizeB";
            this.SizeB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SizeB.Width = 88;
            // 
            // Percent
            // 
            this.Percent.Frozen = true;
            this.Percent.HeaderText = "Percent, %";
            this.Percent.Name = "Percent";
            this.Percent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Percent.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fiels:";
            // 
            // Fiels_L
            // 
            this.Fiels_L.AutoSize = true;
            this.Fiels_L.Location = new System.Drawing.Point(130, 17);
            this.Fiels_L.Name = "Fiels_L";
            this.Fiels_L.Size = new System.Drawing.Size(13, 13);
            this.Fiels_L.TabIndex = 5;
            this.Fiels_L.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Folders:";
            // 
            // Folders_L
            // 
            this.Folders_L.AutoSize = true;
            this.Folders_L.Location = new System.Drawing.Point(53, 17);
            this.Folders_L.Name = "Folders_L";
            this.Folders_L.Size = new System.Drawing.Size(13, 13);
            this.Folders_L.TabIndex = 7;
            this.Folders_L.Text = "0";
            // 
            // Size_L
            // 
            this.Size_L.AutoSize = true;
            this.Size_L.Location = new System.Drawing.Point(234, 17);
            this.Size_L.Name = "Size_L";
            this.Size_L.Size = new System.Drawing.Size(13, 13);
            this.Size_L.TabIndex = 9;
            this.Size_L.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size, MB:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 213);
            this.Controls.Add(this.Size_L);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Folders_L);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fiels_L);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result_DGV);
            this.Controls.Add(this.Open_B);
            this.Controls.Add(this.Start_B);
            this.Controls.Add(this.Path_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Folder Scaler";
            ((System.ComponentModel.ISupportInitialize)(this.Result_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_TB;
        private System.Windows.Forms.Button Start_B;
        private System.Windows.Forms.Button Open_B;
        private System.Windows.Forms.DataGridView Result_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fiels_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Folders_L;
        private System.Windows.Forms.Label Size_L;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameF;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
    }
}

