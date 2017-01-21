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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BGNLabel = new System.Windows.Forms.Label();
            this.TOlabel = new System.Windows.Forms.Label();
            this.EUROLabel = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.UseWaitCursor = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // BGNLabel
            // 
            this.BGNLabel.AutoSize = true;
            this.BGNLabel.Location = new System.Drawing.Point(151, 47);
            this.BGNLabel.Name = "BGNLabel";
            this.BGNLabel.Size = new System.Drawing.Size(30, 13);
            this.BGNLabel.TabIndex = 1;
            this.BGNLabel.Text = "BGN";
            this.BGNLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TOlabel
            // 
            this.TOlabel.AutoSize = true;
            this.TOlabel.Location = new System.Drawing.Point(197, 47);
            this.TOlabel.Name = "TOlabel";
            this.TOlabel.Size = new System.Drawing.Size(25, 13);
            this.TOlabel.TabIndex = 2;
            this.TOlabel.Text = "<=>";
            // 
            // EUROLabel
            // 
            this.EUROLabel.AutoSize = true;
            this.EUROLabel.Location = new System.Drawing.Point(301, 47);
            this.EUROLabel.Name = "EUROLabel";
            this.EUROLabel.Size = new System.Drawing.Size(38, 13);
            this.EUROLabel.TabIndex = 3;
            this.EUROLabel.Text = "EURO";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(237, 47);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(58, 13);
            this.LabelResult.TabIndex = 5;
            this.LabelResult.Text = "Enter BGN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 119);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.EUROLabel);
            this.Controls.Add(this.TOlabel);
            this.Controls.Add(this.BGNLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "BGN to EUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BGNLabel;
        private System.Windows.Forms.Label TOlabel;
        private System.Windows.Forms.Label EUROLabel;
        private System.Windows.Forms.Label LabelResult;
    }
}

