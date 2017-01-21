namespace Converter
{
    partial class ConverterForm
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
            this.BGNValue = new System.Windows.Forms.NumericUpDown();
            this.BGNLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BGNValue)).BeginInit();
            this.SuspendLayout();
            // 
            // BGNValue
            // 
            this.BGNValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BGNValue.DecimalPlaces = 2;
            this.BGNValue.Location = new System.Drawing.Point(12, 28);
            this.BGNValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BGNValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BGNValue.Name = "BGNValue";
            this.BGNValue.Size = new System.Drawing.Size(120, 20);
            this.BGNValue.TabIndex = 0;
            this.BGNValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BGNValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BGNValue.ValueChanged += new System.EventHandler(this.BGNValue_ValueChanged);
            this.BGNValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BGNValue_KeyUp);
            // 
            // BGNLabel
            // 
            this.BGNLabel.AutoSize = true;
            this.BGNLabel.Location = new System.Drawing.Point(156, 30);
            this.BGNLabel.Name = "BGNLabel";
            this.BGNLabel.Size = new System.Drawing.Size(42, 13);
            this.BGNLabel.TabIndex = 1;
            this.BGNLabel.Text = "BGN ->";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.comboBox1.Location = new System.Drawing.Point(234, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.Lime;
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResultLabel.Location = new System.Drawing.Point(27, 88);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(328, 35);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Value appears here";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 146);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BGNLabel);
            this.Controls.Add(this.BGNValue);
            this.Name = "ConverterForm";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.ConverterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BGNValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BGNValue;
        private System.Windows.Forms.Label BGNLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ResultLabel;
    }
}

