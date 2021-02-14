namespace uvsWinFormTask
{
    partial class Main
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
            this.Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.threadAmount = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ThreadID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.threadAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(644, 103);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // threadAmount
            // 
            this.threadAmount.Location = new System.Drawing.Point(622, 61);
            this.threadAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.threadAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.threadAmount.Name = "threadAmount";
            this.threadAmount.Size = new System.Drawing.Size(120, 20);
            this.threadAmount.TabIndex = 3;
            this.threadAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThreadID,
            this.Data});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(463, 391);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ThreadID
            // 
            this.ThreadID.Text = "ThreadID";
            this.ThreadID.Width = 120;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 338;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.threadAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Start);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threadAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown threadAmount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ThreadID;
        private System.Windows.Forms.ColumnHeader Data;
    }
}

