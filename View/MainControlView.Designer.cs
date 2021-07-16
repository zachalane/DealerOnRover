
namespace DealerOnRover.View
{
    partial class MainControlView
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
            this.components = new System.ComponentModel.Container();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBoundsX = new System.Windows.Forms.MaskedTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.grpBoundary = new System.Windows.Forms.GroupBox();
            this.txtBoundsY = new System.Windows.Forms.MaskedTextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCurrentHeading = new System.Windows.Forms.ComboBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtCurrentY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentX = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCommands = new System.Windows.Forms.GroupBox();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCommandString = new System.Windows.Forms.TextBox();
            this.grpBoundary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest1
            // 
            this.btnTest1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest1.Location = new System.Drawing.Point(22, 17);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.Text = "Test 1";
            this.btnTest1.UseVisualStyleBackColor = true;
            // 
            // btnTest2
            // 
            this.btnTest2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest2.Location = new System.Drawing.Point(22, 55);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 1;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(192, 414);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBoundsX
            // 
            this.txtBoundsX.Location = new System.Drawing.Point(43, 19);
            this.txtBoundsX.Mask = "00";
            this.txtBoundsX.Name = "txtBoundsX";
            this.txtBoundsX.Size = new System.Drawing.Size(24, 20);
            this.txtBoundsX.TabIndex = 5;
            this.txtBoundsX.ValidatingType = typeof(int);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(14, 22);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X : ";
            // 
            // grpBoundary
            // 
            this.grpBoundary.Controls.Add(this.txtBoundsY);
            this.grpBoundary.Controls.Add(this.lblY);
            this.grpBoundary.Controls.Add(this.txtBoundsX);
            this.grpBoundary.Controls.Add(this.lblX);
            this.grpBoundary.Location = new System.Drawing.Point(150, 17);
            this.grpBoundary.Name = "grpBoundary";
            this.grpBoundary.Size = new System.Drawing.Size(100, 81);
            this.grpBoundary.TabIndex = 7;
            this.grpBoundary.TabStop = false;
            this.grpBoundary.Text = "Bounds";
            // 
            // txtBoundsY
            // 
            this.txtBoundsY.Location = new System.Drawing.Point(43, 45);
            this.txtBoundsY.Mask = "00";
            this.txtBoundsY.Name = "txtBoundsY";
            this.txtBoundsY.Size = new System.Drawing.Size(24, 20);
            this.txtBoundsY.TabIndex = 7;
            this.txtBoundsY.ValidatingType = typeof(int);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(14, 48);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 13);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCurrentHeading);
            this.groupBox1.Controls.Add(this.lblZ);
            this.groupBox1.Controls.Add(this.txtCurrentY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCurrentX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(138, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Location";
            // 
            // cboCurrentHeading
            // 
            this.cboCurrentHeading.FormattingEnabled = true;
            this.cboCurrentHeading.Items.AddRange(new object[] {
            "NORTH",
            "EAST",
            "SOUTH",
            "WEST"});
            this.cboCurrentHeading.Location = new System.Drawing.Point(36, 71);
            this.cboCurrentHeading.Name = "cboCurrentHeading";
            this.cboCurrentHeading.Size = new System.Drawing.Size(68, 21);
            this.cboCurrentHeading.TabIndex = 15;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(10, 74);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(20, 13);
            this.lblZ.TabIndex = 14;
            this.lblZ.Text = "Z :";
            // 
            // txtCurrentY
            // 
            this.txtCurrentY.Location = new System.Drawing.Point(60, 45);
            this.txtCurrentY.Mask = "00";
            this.txtCurrentY.Name = "txtCurrentY";
            this.txtCurrentY.Size = new System.Drawing.Size(24, 20);
            this.txtCurrentY.TabIndex = 11;
            this.txtCurrentY.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Y :";
            // 
            // txtCurrentX
            // 
            this.txtCurrentX.Location = new System.Drawing.Point(60, 19);
            this.txtCurrentX.Mask = "00";
            this.txtCurrentX.Name = "txtCurrentX";
            this.txtCurrentX.Size = new System.Drawing.Size(24, 20);
            this.txtCurrentX.TabIndex = 9;
            this.txtCurrentX.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X : ";
            // 
            // grpCommands
            // 
            this.grpCommands.Controls.Add(this.txtCommandString);
            this.grpCommands.Controls.Add(this.btnDelete);
            this.grpCommands.Controls.Add(this.btnMove);
            this.grpCommands.Controls.Add(this.btnRotateRight);
            this.grpCommands.Controls.Add(this.btnRotateLeft);
            this.grpCommands.Location = new System.Drawing.Point(22, 225);
            this.grpCommands.Name = "grpCommands";
            this.grpCommands.Size = new System.Drawing.Size(245, 172);
            this.grpCommands.TabIndex = 9;
            this.grpCommands.TabStop = false;
            this.grpCommands.Text = "Commands";
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(17, 19);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(80, 29);
            this.btnRotateLeft.TabIndex = 0;
            this.btnRotateLeft.Text = "Rotate Left";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(17, 54);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(80, 29);
            this.btnRotateRight.TabIndex = 1;
            this.btnRotateRight.Text = "Rotate Right";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(17, 89);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(80, 29);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(152, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtCommandString
            // 
            this.txtCommandString.Location = new System.Drawing.Point(16, 138);
            this.txtCommandString.Name = "txtCommandString";
            this.txtCommandString.ReadOnly = true;
            this.txtCommandString.Size = new System.Drawing.Size(212, 20);
            this.txtCommandString.TabIndex = 4;
            this.txtCommandString.Text = "{{IN CODE}}";
            // 
            // MainControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCommands);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoundary);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Name = "MainControlView";
            this.Size = new System.Drawing.Size(293, 456);
            this.grpBoundary.ResumeLayout(false);
            this.grpBoundary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCommands.ResumeLayout(false);
            this.grpCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox txtBoundsX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox grpBoundary;
        private System.Windows.Forms.MaskedTextBox txtBoundsY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCurrentHeading;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.MaskedTextBox txtCurrentY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCurrentX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCommands;
        private System.Windows.Forms.TextBox txtCommandString;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotateLeft;
    }
}
