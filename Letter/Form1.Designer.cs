namespace Letter
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CharacterCountTextFlowBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChooseFileClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(93, 12);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(110, 20);
            this.PathTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CountCharacters);
            // 
            // CharacterCountTextFlowBox
            // 
            this.CharacterCountTextFlowBox.AutoScroll = true;
            this.CharacterCountTextFlowBox.Location = new System.Drawing.Point(12, 41);
            this.CharacterCountTextFlowBox.Name = "CharacterCountTextFlowBox";
            this.CharacterCountTextFlowBox.Size = new System.Drawing.Size(272, 261);
            this.CharacterCountTextFlowBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 314);
            this.Controls.Add(this.CharacterCountTextFlowBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(312, 353);
            this.MinimumSize = new System.Drawing.Size(312, 353);
            this.Name = "Form1";
            this.Text = "Letterfrequenties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel CharacterCountTextFlowBox;
    }
}

