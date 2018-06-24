namespace LinearBinarySort
{
    partial class LinearBinarySearchForm
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.linearButton = new System.Windows.Forms.Button();
            this.binaryButton = new System.Windows.Forms.Button();
            this.indexLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortedUnsortedLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(126, 154);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(126, 112);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(252, 152);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Add to list";
            this.submitButton.UseMnemonic = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(126, 198);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(120, 147);
            this.numberListBox.TabIndex = 3;
            // 
            // linearButton
            // 
            this.linearButton.Location = new System.Drawing.Point(252, 198);
            this.linearButton.Name = "linearButton";
            this.linearButton.Size = new System.Drawing.Size(98, 23);
            this.linearButton.TabIndex = 4;
            this.linearButton.Text = "Linear Search";
            this.linearButton.UseVisualStyleBackColor = true;
            this.linearButton.Click += new System.EventHandler(this.linearButton_Click);
            // 
            // binaryButton
            // 
            this.binaryButton.Location = new System.Drawing.Point(252, 227);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(98, 23);
            this.binaryButton.TabIndex = 5;
            this.binaryButton.Text = "Binary Search";
            this.binaryButton.UseVisualStyleBackColor = true;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(251, 115);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(36, 13);
            this.indexLabel.TabIndex = 6;
            this.indexLabel.Text = "Index:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Key:";
            // 
            // sortedUnsortedLabel
            // 
            this.sortedUnsortedLabel.AutoSize = true;
            this.sortedUnsortedLabel.Location = new System.Drawing.Point(123, 357);
            this.sortedUnsortedLabel.Name = "sortedUnsortedLabel";
            this.sortedUnsortedLabel.Size = new System.Drawing.Size(0, 13);
            this.sortedUnsortedLabel.TabIndex = 8;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(252, 322);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(73, 23);
            this.clearAllButton.TabIndex = 9;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Linear and Binary Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nancy Ngo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LinearBinarySort.Properties.Resources.dancing_star;
            this.pictureBox1.Location = new System.Drawing.Point(49, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter a number:";
            // 
            // LinearBinarySearchForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(439, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.sortedUnsortedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.linearButton);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Name = "LinearBinarySearchForm";
            this.Text = "Linear and Binary Search (Nancy Ngo)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button linearButton;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sortedUnsortedLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

