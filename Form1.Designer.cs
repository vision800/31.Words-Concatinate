namespace _31.Words_Concatinate
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
            label1 = new Label();
            txtWord = new TextBox();
            button1 = new Button();
            cbxLeft = new ComboBox();
            cbxRigth = new ComboBox();
            btnConcatenate = new Button();
            lblResult = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rdRight = new RadioButton();
            rdLeft = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 79);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a new a word: ";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(185, 116);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(250, 31);
            txtWord.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(252, 170);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 2;
            button1.Text = "Add word";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbxLeft
            // 
            cbxLeft.FormattingEnabled = true;
            cbxLeft.Location = new Point(58, 282);
            cbxLeft.Name = "cbxLeft";
            cbxLeft.Size = new Size(182, 33);
            cbxLeft.TabIndex = 3;
            cbxLeft.Text = "--Words--";
            // 
            // cbxRigth
            // 
            cbxRigth.FormattingEnabled = true;
            cbxRigth.Location = new Point(403, 282);
            cbxRigth.Name = "cbxRigth";
            cbxRigth.Size = new Size(182, 33);
            cbxRigth.TabIndex = 4;
            cbxRigth.Text = "--Words--";
            // 
            // btnConcatenate
            // 
            btnConcatenate.Location = new Point(261, 346);
            btnConcatenate.Name = "btnConcatenate";
            btnConcatenate.Size = new Size(131, 34);
            btnConcatenate.TabIndex = 5;
            btnConcatenate.Text = "Concatenate";
            btnConcatenate.UseVisualStyleBackColor = true;
            btnConcatenate.Click += btnConcatenate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ControlLightLight;
            lblResult.Location = new Point(0, 401);
            lblResult.MaximumSize = new Size(709, 40);
            lblResult.MinimumSize = new Size(695, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(695, 40);
            lblResult.TabIndex = 6;
            lblResult.Text = " ";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 225);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 7;
            label3.Text = "OR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 254);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 8;
            label4.Text = "Select a word: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 254);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 8;
            label5.Text = "Select another word: ";
            // 
            // rdRight
            // 
            rdRight.AutoSize = true;
            rdRight.Location = new Point(416, 321);
            rdRight.Name = "rdRight";
            rdRight.Size = new Size(101, 29);
            rdRight.TabIndex = 9;
            rdRight.TabStop = true;
            rdRight.Text = "Remove";
            rdRight.UseVisualStyleBackColor = true;
            rdRight.CheckedChanged += rdRight_CheckedChanged;
            // 
            // rdLeft
            // 
            rdLeft.AutoSize = true;
            rdLeft.Location = new Point(101, 316);
            rdLeft.Name = "rdLeft";
            rdLeft.Size = new Size(101, 29);
            rdLeft.TabIndex = 10;
            rdLeft.TabStop = true;
            rdLeft.Text = "Remove";
            rdLeft.UseVisualStyleBackColor = true;
            rdLeft.CheckedChanged += rdLeft_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(rdLeft);
            Controls.Add(rdRight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblResult);
            Controls.Add(btnConcatenate);
            Controls.Add(cbxRigth);
            Controls.Add(cbxLeft);
            Controls.Add(button1);
            Controls.Add(txtWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWord;
        private Button button1;
        private ComboBox cbxLeft;
        private ComboBox cbxRigth;
        private Button btnConcatenate;
        private Label lblResult;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rdRight;
        private RadioButton rdLeft;
    }
}