namespace FileSearch
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
            this.txtMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDisk = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkSubdirs = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Слово або фраза в файлі";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(12, 35);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(200, 20);
            this.txtMask.TabIndex = 1;
            this.txtMask.Text = "*.*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диски";
            // 
            // cboDisk
            // 
            this.cboDisk.FormattingEnabled = true;
            this.cboDisk.Location = new System.Drawing.Point(220, 35);
            this.cboDisk.Name = "cboDisk";
            this.cboDisk.Size = new System.Drawing.Size(80, 21);
            this.cboDisk.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Знайти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(395, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = " Зупинити";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkSubdirs
            // 
            this.chkSubdirs.AutoSize = true;
            this.chkSubdirs.Location = new System.Drawing.Point(480, 37);
            this.chkSubdirs.Name = "chkSubdirs";
            this.chkSubdirs.Size = new System.Drawing.Size(88, 17);
            this.chkSubdirs.TabIndex = 6;
            this.chkSubdirs.Text = "Підкаталоги";
            this.chkSubdirs.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 70);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(107, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Результати пошуку:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 400);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ім\'я";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Папка";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Розмір";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата модифікації";
            this.columnHeader4.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 539);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.chkSubdirs);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboDisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Пошук файлів і папок";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDisk;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkSubdirs;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
       
        }
    }


