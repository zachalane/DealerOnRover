
namespace DealerOnRover.View
{
    partial class ResultsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLocationX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocationHeading = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLocationX
            // 
            this.txtLocationX.Location = new System.Drawing.Point(81, 61);
            this.txtLocationX.Name = "txtLocationX";
            this.txtLocationX.ReadOnly = true;
            this.txtLocationX.Size = new System.Drawing.Size(101, 20);
            this.txtLocationX.TabIndex = 0;
            this.txtLocationX.Text = "{{IN CODE}}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y :";
            // 
            // txtLocationY
            // 
            this.txtLocationY.Location = new System.Drawing.Point(81, 87);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.ReadOnly = true;
            this.txtLocationY.Size = new System.Drawing.Size(101, 20);
            this.txtLocationY.TabIndex = 2;
            this.txtLocationY.Text = "{{IN CODE}}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z :";
            // 
            // txtLocationHeading
            // 
            this.txtLocationHeading.Location = new System.Drawing.Point(81, 113);
            this.txtLocationHeading.Name = "txtLocationHeading";
            this.txtLocationHeading.ReadOnly = true;
            this.txtLocationHeading.Size = new System.Drawing.Size(101, 20);
            this.txtLocationHeading.TabIndex = 4;
            this.txtLocationHeading.Text = "{{IN CODE}}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Results :";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(41, 159);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(184, 20);
            this.txtResults.TabIndex = 6;
            this.txtResults.Text = "{{IN CODE}}";
            // 
            // ResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocationHeading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocationY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocationX);
            this.Name = "ResultsView";
            this.Size = new System.Drawing.Size(255, 266);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocationX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocationHeading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResults;
    }
}
