namespace WindowsFormsApplication1
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
            this.btnSort = new System.Windows.Forms.Button();
            this.CheckMonth = new System.Windows.Forms.RadioButton();
            this.CheckDate = new System.Windows.Forms.RadioButton();
            this.lblFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(153, 162);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(106, 33);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // CheckMonth
            // 
            this.CheckMonth.AutoSize = true;
            this.CheckMonth.Location = new System.Drawing.Point(125, 51);
            this.CheckMonth.Name = "CheckMonth";
            this.CheckMonth.Size = new System.Drawing.Size(151, 21);
            this.CheckMonth.TabIndex = 2;
            this.CheckMonth.TabStop = true;
            this.CheckMonth.Text = "Sort Files By Month";
            this.CheckMonth.UseVisualStyleBackColor = true;
            // 
            // CheckDate
            // 
            this.CheckDate.AutoSize = true;
            this.CheckDate.Location = new System.Drawing.Point(125, 78);
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.Size = new System.Drawing.Size(168, 21);
            this.CheckDate.TabIndex = 3;
            this.CheckDate.TabStop = true;
            this.CheckDate.Text = "Sort Files By Full Date\r\n";
            this.CheckDate.UseVisualStyleBackColor = true;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(122, 123);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(0, 17);
            this.lblFinish.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 253);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.CheckDate);
            this.Controls.Add(this.CheckMonth);
            this.Controls.Add(this.btnSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIle Sorter 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton CheckMonth;
        private System.Windows.Forms.RadioButton CheckDate;
        private System.Windows.Forms.Label lblFinish;
    }
}

