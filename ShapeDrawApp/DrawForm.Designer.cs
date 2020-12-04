namespace ShapeDrawApp
{
    partial class DrawForm
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
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.txtProgramArea = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnPerformAction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPColor = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.btnFillIndi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplay.Location = new System.Drawing.Point(12, 12);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(465, 246);
            this.pnlDisplay.TabIndex = 0;
            // 
            // txtProgramArea
            // 
            this.txtProgramArea.Location = new System.Drawing.Point(490, 15);
            this.txtProgramArea.Multiline = true;
            this.txtProgramArea.Name = "txtProgramArea";
            this.txtProgramArea.Size = new System.Drawing.Size(169, 211);
            this.txtProgramArea.TabIndex = 2;
            this.txtProgramArea.TextChanged += new System.EventHandler(this.txtProgramArea_TextChanged);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(26, 282);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(116, 20);
            this.txtCommand.TabIndex = 3;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // btnPerformAction
            // 
            this.btnPerformAction.Location = new System.Drawing.Point(26, 308);
            this.btnPerformAction.Name = "btnPerformAction";
            this.btnPerformAction.Size = new System.Drawing.Size(99, 23);
            this.btnPerformAction.TabIndex = 4;
            this.btnPerformAction.Text = "Perform Action";
            this.btnPerformAction.UseVisualStyleBackColor = true;
            this.btnPerformAction.Click += new System.EventHandler(this.btnPerformAction_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose pen color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPColor
            // 
            this.btnPColor.Location = new System.Drawing.Point(453, 294);
            this.btnPColor.Name = "btnPColor";
            this.btnPColor.Size = new System.Drawing.Size(57, 23);
            this.btnPColor.TabIndex = 6;
            this.btnPColor.Text = "Color";
            this.btnPColor.UseVisualStyleBackColor = true;
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(293, 323);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(144, 23);
            this.Fill.TabIndex = 7;
            this.Fill.Text = "Choose Fill Color";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // btnFillIndi
            // 
            this.btnFillIndi.Location = new System.Drawing.Point(453, 324);
            this.btnFillIndi.Name = "btnFillIndi";
            this.btnFillIndi.Size = new System.Drawing.Size(57, 27);
            this.btnFillIndi.TabIndex = 8;
            this.btnFillIndi.Text = "Color";
            this.btnFillIndi.UseVisualStyleBackColor = true;
            this.btnFillIndi.Click += new System.EventHandler(this.btnFillIndi_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 363);
            this.Controls.Add(this.btnFillIndi);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.btnPColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPerformAction);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.txtProgramArea);
            this.Controls.Add(this.pnlDisplay);
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.TextBox txtProgramArea;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnPerformAction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPColor;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button btnFillIndi;
    }
}

