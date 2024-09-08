namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okButton = new Button();
            aboutButton = new Button();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(713, 415);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += button1_Click;
            // 
            // aboutButton
            // 
            aboutButton.Location = new Point(527, 415);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(75, 23);
            aboutButton.TabIndex = 1;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aboutButton);
            Controls.Add(okButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button okButton;
        private Button aboutButton;
    }
}
