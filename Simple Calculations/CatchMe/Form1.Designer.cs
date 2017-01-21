namespace CatchMe
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
            this.catchMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchMeButton
            // 
            this.catchMeButton.Location = new System.Drawing.Point(112, 153);
            this.catchMeButton.Name = "catchMeButton";
            this.catchMeButton.Size = new System.Drawing.Size(169, 126);
            this.catchMeButton.TabIndex = 0;
            this.catchMeButton.Text = "Catch me !";
            this.catchMeButton.UseVisualStyleBackColor = true;
            this.catchMeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.catchMeButton_MouseClick_1);
            this.catchMeButton.MouseEnter += new System.EventHandler(this.catchMeButton_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 436);
            this.Controls.Add(this.catchMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catchMeButton;
    }
}

