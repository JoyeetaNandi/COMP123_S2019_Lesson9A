namespace COMP123_S2019_Lesson9A
{
    partial class CalculatorForm
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
            this.NumberButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SevenButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ZeroButton1 = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NumberButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberButtonTableLayoutPanel
            // 
            this.NumberButtonTableLayoutPanel.ColumnCount = 4;
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.Controls.Add(this.button3, 3, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.button2, 3, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.button1, 2, 4);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ResultButton, 3, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ZeroButton1, 0, 4);
            this.NumberButtonTableLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButtonTableLayoutPanel.Location = new System.Drawing.Point(2, 204);
            this.NumberButtonTableLayoutPanel.Name = "NumberButtonTableLayoutPanel";
            this.NumberButtonTableLayoutPanel.RowCount = 5;
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumberButtonTableLayoutPanel.Size = new System.Drawing.Size(303, 225);
            this.NumberButtonTableLayoutPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(228, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 39);
            this.button3.TabIndex = 14;
            this.button3.Tag = "clear";
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.BackgroundImage = global::COMP123_S2019_Lesson9A.Properties.Resources.backbutton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(228, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 39);
            this.button2.TabIndex = 13;
            this.button2.Tag = "back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberButtonTableLayoutPanel.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(297, 45);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Tag = "result";
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SevenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SevenButton.Location = new System.Drawing.Point(3, 48);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(69, 39);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FourButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FourButton.Location = new System.Drawing.Point(3, 93);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(69, 39);
            this.FourButton.TabIndex = 3;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OneButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OneButton.Location = new System.Drawing.Point(3, 138);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(69, 39);
            this.OneButton.TabIndex = 6;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TwoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TwoButton.Location = new System.Drawing.Point(78, 138);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(69, 39);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FiveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FiveButton.Location = new System.Drawing.Point(78, 93);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(69, 39);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EightButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EightButton.Location = new System.Drawing.Point(78, 48);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(69, 39);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NineButton.Location = new System.Drawing.Point(153, 48);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(69, 39);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SixButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SixButton.Location = new System.Drawing.Point(153, 93);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(69, 39);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThreeButton.Location = new System.Drawing.Point(153, 138);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(69, 39);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(153, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 39);
            this.button1.TabIndex = 12;
            this.button1.Tag = "decimal";
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultButton.BackColor = System.Drawing.Color.Green;
            this.ResultButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultButton.Location = new System.Drawing.Point(228, 138);
            this.ResultButton.Name = "ResultButton";
            this.NumberButtonTableLayoutPanel.SetRowSpan(this.ResultButton, 2);
            this.ResultButton.Size = new System.Drawing.Size(72, 84);
            this.ResultButton.TabIndex = 10;
            this.ResultButton.Tag = "done";
            this.ResultButton.Text = "Done";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ZeroButton1
            // 
            this.ZeroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NumberButtonTableLayoutPanel.SetColumnSpan(this.ZeroButton1, 2);
            this.ZeroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZeroButton1.Location = new System.Drawing.Point(3, 183);
            this.ZeroButton1.Name = "ZeroButton1";
            this.ZeroButton1.Size = new System.Drawing.Size(144, 39);
            this.ZeroButton1.TabIndex = 11;
            this.ZeroButton1.Tag = "0";
            this.ZeroButton1.Text = "0";
            this.ZeroButton1.UseVisualStyleBackColor = false;
            this.ZeroButton1.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.BackColor = System.Drawing.Color.White;
            this.HeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(173, 9);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(129, 45);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Tag = "height";
            this.HeightLabel.Text = "0";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeightLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.BackColor = System.Drawing.Color.White;
            this.WeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(173, 64);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(129, 45);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Tag = "weight";
            this.WeightLabel.Text = "0";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WeightLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeLabel.BackColor = System.Drawing.Color.White;
            this.AgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(173, 118);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(129, 45);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Tag = "age";
            this.AgeLabel.Text = "0";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgeLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.NumberButtonTableLayoutPanel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.Click += new System.EventHandler(this.CalculatorForm_Click);
            this.NumberButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NumberButtonTableLayoutPanel;
        private System.Windows.Forms.Button ZeroButton1;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label AgeLabel;
    }
}

