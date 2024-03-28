namespace AP.UI
{
    partial class MainView
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
            H30SpringButton = new Button();
            SuspendLayout();
            // 
            // H30SpringButton
            // 
            H30SpringButton.Location = new Point(12, 12);
            H30SpringButton.Name = "H30SpringButton";
            H30SpringButton.Size = new Size(172, 56);
            H30SpringButton.TabIndex = 0;
            H30SpringButton.Text = "平成30年春期";
            H30SpringButton.UseVisualStyleBackColor = true;
            H30SpringButton.Click += H30SpringButton_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(H30SpringButton);
            Name = "MainView";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button H30SpringButton;
    }
}
