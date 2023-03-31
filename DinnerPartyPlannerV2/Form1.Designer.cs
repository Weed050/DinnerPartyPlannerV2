namespace DinnerPartyPlannerV2
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
            Imprezy = new TabControl();
            tabPage1 = new TabPage();
            healthyOption = new CheckBox();
            numberOfPepleSet1 = new NumericUpDown();
            label1 = new Label();
            tabPage2 = new TabPage();
            fancyDecorations = new CheckBox();
            label2 = new Label();
            labelCost1 = new Label();
            labelCost2 = new Label();
            label4 = new Label();
            fancyDecorations2 = new CheckBox();
            numberOfPepleSet2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            cakeWritingLabel = new TextBox();
            Imprezy.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPepleSet1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPepleSet2).BeginInit();
            SuspendLayout();
            // 
            // Imprezy
            // 
            Imprezy.Controls.Add(tabPage1);
            Imprezy.Controls.Add(tabPage2);
            Imprezy.Location = new Point(0, 0);
            Imprezy.Name = "Imprezy";
            Imprezy.SelectedIndex = 0;
            Imprezy.Size = new Size(250, 268);
            Imprezy.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelCost1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(fancyDecorations);
            tabPage1.Controls.Add(healthyOption);
            tabPage1.Controls.Add(numberOfPepleSet1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 235);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Imprezy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // healthyOption
            // 
            healthyOption.AutoSize = true;
            healthyOption.Location = new Point(28, 84);
            healthyOption.Name = "healthyOption";
            healthyOption.Size = new Size(140, 24);
            healthyOption.TabIndex = 2;
            healthyOption.Text = "zdrowe jedzenie";
            healthyOption.UseVisualStyleBackColor = true;
            // 
            // numberOfPepleSet1
            // 
            numberOfPepleSet1.Location = new Point(18, 31);
            numberOfPepleSet1.Name = "numberOfPepleSet1";
            numberOfPepleSet1.Size = new Size(150, 27);
            numberOfPepleSet1.TabIndex = 1;
            numberOfPepleSet1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Ilość ludzi:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cakeWritingLabel);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(labelCost2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(fancyDecorations2);
            tabPage2.Controls.Add(numberOfPepleSet2);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 235);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Imprezy urodzinowe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fancyDecorations
            // 
            fancyDecorations.AutoSize = true;
            fancyDecorations.Location = new Point(28, 114);
            fancyDecorations.Name = "fancyDecorations";
            fancyDecorations.Size = new Size(175, 24);
            fancyDecorations.TabIndex = 3;
            fancyDecorations.Text = "dodatkowe dekoracje";
            fancyDecorations.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 158);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Razem";
            // 
            // labelCost1
            // 
            labelCost1.AutoSize = true;
            labelCost1.Location = new Point(88, 158);
            labelCost1.Name = "labelCost1";
            labelCost1.Size = new Size(17, 20);
            labelCost1.TabIndex = 5;
            labelCost1.Text = "0";
            // 
            // labelCost2
            // 
            labelCost2.AutoSize = true;
            labelCost2.Location = new Point(104, 182);
            labelCost2.Name = "labelCost2";
            labelCost2.Size = new Size(17, 20);
            labelCost2.TabIndex = 11;
            labelCost2.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 182);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 10;
            label4.Text = "Razem";
            // 
            // fancyDecorations2
            // 
            fancyDecorations2.AutoSize = true;
            fancyDecorations2.Location = new Point(24, 71);
            fancyDecorations2.Name = "fancyDecorations2";
            fancyDecorations2.Size = new Size(175, 24);
            fancyDecorations2.TabIndex = 9;
            fancyDecorations2.Text = "dodatkowe dekoracje";
            fancyDecorations2.UseVisualStyleBackColor = true;
            // 
            // numberOfPepleSet2
            // 
            numberOfPepleSet2.Location = new Point(24, 38);
            numberOfPepleSet2.Name = "numberOfPepleSet2";
            numberOfPepleSet2.Size = new Size(150, 27);
            numberOfPepleSet2.TabIndex = 7;
            numberOfPepleSet2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 15);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 6;
            label5.Text = "Ilość ludzi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 98);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 12;
            label6.Text = "Napis na torcie:";
            // 
            // cakeWritingLabel
            // 
            cakeWritingLabel.BackColor = SystemColors.HighlightText;
            cakeWritingLabel.BorderStyle = BorderStyle.FixedSingle;
            cakeWritingLabel.Location = new Point(24, 130);
            cakeWritingLabel.Name = "cakeWritingLabel";
            cakeWritingLabel.Size = new Size(184, 27);
            cakeWritingLabel.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 296);
            Controls.Add(Imprezy);
            Name = "Form1";
            Text = "Form1";
            Imprezy.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPepleSet1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPepleSet2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Imprezy;
        private TabPage tabPage1;
        private CheckBox healthyOption;
        private NumericUpDown numberOfPepleSet1;
        private Label label1;
        private TabPage tabPage2;
        private Label labelCost1;
        private Label label2;
        private CheckBox fancyDecorations;
        private Label label6;
        private Label labelCost2;
        private Label label4;
        private CheckBox fancyDecorations2;
        private NumericUpDown numberOfPepleSet2;
        private Label label5;
        private TextBox cakeWritingLabel;
    }
}