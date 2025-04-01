namespace RARpassword
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
            this.fileDestination = new System.Windows.Forms.Button();
            this.extractDestination = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.fileTxt = new System.Windows.Forms.TextBox();
            this.extractTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tryPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxLengthText = new System.Windows.Forms.TextBox();
            this.simpleLetterCheck = new System.Windows.Forms.CheckBox();
            this.numberCheck = new System.Windows.Forms.CheckBox();
            this.spacialCharCheck = new System.Windows.Forms.CheckBox();
            this.capitalLetterCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minLengthText = new System.Windows.Forms.TextBox();
            this.stopbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileDestination
            // 
            this.fileDestination.Location = new System.Drawing.Point(17, 90);
            this.fileDestination.Margin = new System.Windows.Forms.Padding(4);
            this.fileDestination.Name = "fileDestination";
            this.fileDestination.Size = new System.Drawing.Size(153, 28);
            this.fileDestination.TabIndex = 0;
            this.fileDestination.Text = "File Destination";
            this.fileDestination.UseVisualStyleBackColor = true;
            this.fileDestination.Click += new System.EventHandler(this.fileDestination_Click);
            // 
            // extractDestination
            // 
            this.extractDestination.Location = new System.Drawing.Point(17, 175);
            this.extractDestination.Margin = new System.Windows.Forms.Padding(4);
            this.extractDestination.Name = "extractDestination";
            this.extractDestination.Size = new System.Drawing.Size(153, 28);
            this.extractDestination.TabIndex = 1;
            this.extractDestination.Text = "Extract Destination";
            this.extractDestination.UseVisualStyleBackColor = true;
            this.extractDestination.Click += new System.EventHandler(this.extractDestination_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(16, 529);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 28);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // fileTxt
            // 
            this.fileTxt.Location = new System.Drawing.Point(17, 126);
            this.fileTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fileTxt.Name = "fileTxt";
            this.fileTxt.Size = new System.Drawing.Size(373, 22);
            this.fileTxt.TabIndex = 3;
            // 
            // extractTxt
            // 
            this.extractTxt.Location = new System.Drawing.Point(17, 212);
            this.extractTxt.Margin = new System.Windows.Forms.Padding(4);
            this.extractTxt.Name = "extractTxt";
            this.extractTxt.Size = new System.Drawing.Size(373, 22);
            this.extractTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "(if extraction is possible)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 490);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tring Password :";
            // 
            // tryPass
            // 
            this.tryPass.AutoSize = true;
            this.tryPass.Location = new System.Drawing.Point(128, 490);
            this.tryPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tryPass.Name = "tryPass";
            this.tryPass.Size = new System.Drawing.Size(16, 16);
            this.tryPass.TabIndex = 7;
            this.tryPass.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Password Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Higher length take more time)";
            // 
            // maxLengthText
            // 
            this.maxLengthText.Location = new System.Drawing.Point(195, 274);
            this.maxLengthText.Name = "maxLengthText";
            this.maxLengthText.Size = new System.Drawing.Size(61, 22);
            this.maxLengthText.TabIndex = 10;
            this.maxLengthText.Text = "5";
            this.maxLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxLengthText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // simpleLetterCheck
            // 
            this.simpleLetterCheck.AutoSize = true;
            this.simpleLetterCheck.Location = new System.Drawing.Point(17, 366);
            this.simpleLetterCheck.Name = "simpleLetterCheck";
            this.simpleLetterCheck.Size = new System.Drawing.Size(44, 20);
            this.simpleLetterCheck.TabIndex = 11;
            this.simpleLetterCheck.Text = "a-z";
            this.simpleLetterCheck.UseVisualStyleBackColor = true;
            // 
            // numberCheck
            // 
            this.numberCheck.AutoSize = true;
            this.numberCheck.Location = new System.Drawing.Point(17, 418);
            this.numberCheck.Name = "numberCheck";
            this.numberCheck.Size = new System.Drawing.Size(44, 20);
            this.numberCheck.TabIndex = 12;
            this.numberCheck.Text = "0-9";
            this.numberCheck.UseVisualStyleBackColor = true;
            // 
            // spacialCharCheck
            // 
            this.spacialCharCheck.AutoSize = true;
            this.spacialCharCheck.Location = new System.Drawing.Point(17, 444);
            this.spacialCharCheck.Name = "spacialCharCheck";
            this.spacialCharCheck.Size = new System.Drawing.Size(59, 20);
            this.spacialCharCheck.TabIndex = 13;
            this.spacialCharCheck.Text = "!@#...";
            this.spacialCharCheck.UseVisualStyleBackColor = true;
            // 
            // capitalLetterCheck
            // 
            this.capitalLetterCheck.AutoSize = true;
            this.capitalLetterCheck.Location = new System.Drawing.Point(17, 392);
            this.capitalLetterCheck.Name = "capitalLetterCheck";
            this.capitalLetterCheck.Size = new System.Drawing.Size(47, 20);
            this.capitalLetterCheck.TabIndex = 14;
            this.capitalLetterCheck.Text = "A-Z";
            this.capitalLetterCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Minimum Password Length";
            // 
            // minLengthText
            // 
            this.minLengthText.Location = new System.Drawing.Point(195, 323);
            this.minLengthText.Name = "minLengthText";
            this.minLengthText.Size = new System.Drawing.Size(61, 22);
            this.minLengthText.TabIndex = 16;
            this.minLengthText.Text = "1";
            this.minLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(131, 529);
            this.stopbtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(100, 28);
            this.stopbtn.TabIndex = 17;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "RAR Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.minLengthText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.capitalLetterCheck);
            this.Controls.Add(this.spacialCharCheck);
            this.Controls.Add(this.numberCheck);
            this.Controls.Add(this.simpleLetterCheck);
            this.Controls.Add(this.maxLengthText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tryPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extractTxt);
            this.Controls.Add(this.fileTxt);
            this.Controls.Add(this.start);
            this.Controls.Add(this.extractDestination);
            this.Controls.Add(this.fileDestination);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "RAR Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileDestination;
        private System.Windows.Forms.Button extractDestination;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox fileTxt;
        private System.Windows.Forms.TextBox extractTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tryPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxLengthText;
        private System.Windows.Forms.CheckBox simpleLetterCheck;
        private System.Windows.Forms.CheckBox numberCheck;
        private System.Windows.Forms.CheckBox spacialCharCheck;
        private System.Windows.Forms.CheckBox capitalLetterCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minLengthText;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Label label6;
    }
}

