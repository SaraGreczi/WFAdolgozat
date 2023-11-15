namespace WFAdolgozat
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
            nevTextBox = new TextBox();
            koszonjButton = new Button();
            PirosLabel = new Label();
            ZoldLabel = new Label();
            KekLabel = new Label();
            button2 = new Button();
            KilepesButton = new Button();
            AlaphelyzetButton = new Button();
            udvozlesLabel = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(88, 34);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(100, 23);
            nevTextBox.TabIndex = 1;
            // 
            // koszonjButton
            // 
            koszonjButton.Location = new Point(223, 34);
            koszonjButton.Name = "koszonjButton";
            koszonjButton.Size = new Size(75, 23);
            koszonjButton.TabIndex = 2;
            koszonjButton.Text = "Köszönj!";
            koszonjButton.UseVisualStyleBackColor = true;
            koszonjButton.Click += koszonjButton_Click;
            // 
            // PirosLabel
            // 
            PirosLabel.BackColor = Color.FromArgb(192, 0, 0);
            PirosLabel.ForeColor = SystemColors.ControlText;
            PirosLabel.Location = new Point(330, 33);
            PirosLabel.Name = "PirosLabel";
            PirosLabel.Size = new Size(56, 70);
            PirosLabel.TabIndex = 3;
            PirosLabel.Text = "Piros";
            // 
            // ZoldLabel
            // 
            ZoldLabel.BackColor = Color.FromArgb(0, 192, 0);
            ZoldLabel.Location = new Point(392, 35);
            ZoldLabel.Name = "ZoldLabel";
            ZoldLabel.Size = new Size(57, 68);
            ZoldLabel.TabIndex = 4;
            ZoldLabel.Text = "Zöld";
            // 
            // KekLabel
            // 
            KekLabel.BackColor = Color.DeepSkyBlue;
            KekLabel.Location = new Point(455, 34);
            KekLabel.Name = "KekLabel";
            KekLabel.Size = new Size(52, 69);
            KekLabel.TabIndex = 5;
            KekLabel.Text = "Kék";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(29, 261);
            button2.Name = "button2";
            button2.Size = new Size(478, 44);
            button2.TabIndex = 6;
            button2.Text = "Számolj!";
            button2.UseVisualStyleBackColor = true;
            // 
            // KilepesButton
            // 
            KilepesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KilepesButton.ForeColor = Color.FromArgb(192, 0, 0);
            KilepesButton.Location = new Point(392, 311);
            KilepesButton.Name = "KilepesButton";
            KilepesButton.Size = new Size(115, 54);
            KilepesButton.TabIndex = 7;
            KilepesButton.Text = "Kilépés";
            KilepesButton.UseVisualStyleBackColor = true;
            // 
            // AlaphelyzetButton
            // 
            AlaphelyzetButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AlaphelyzetButton.ForeColor = SystemColors.HotTrack;
            AlaphelyzetButton.Location = new Point(261, 311);
            AlaphelyzetButton.Name = "AlaphelyzetButton";
            AlaphelyzetButton.Size = new Size(115, 54);
            AlaphelyzetButton.TabIndex = 8;
            AlaphelyzetButton.Text = "Alaphelyzet";
            AlaphelyzetButton.UseVisualStyleBackColor = true;
            // 
            // udvozlesLabel
            // 
            udvozlesLabel.BackColor = Color.Yellow;
            udvozlesLabel.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            udvozlesLabel.Location = new Point(29, 91);
            udvozlesLabel.Name = "udvozlesLabel";
            udvozlesLabel.Size = new Size(269, 54);
            udvozlesLabel.TabIndex = 9;
            udvozlesLabel.Text = "###Udvozles###";
            udvozlesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 182);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 47);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 182);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(64, 47);
            textBox3.TabIndex = 11;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(125, 182);
            button5.Name = "button5";
            button5.Size = new Size(38, 31);
            button5.TabIndex = 12;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(169, 182);
            button6.Name = "button6";
            button6.Size = new Size(39, 31);
            button6.TabIndex = 13;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(125, 213);
            button7.Name = "button7";
            button7.Size = new Size(38, 30);
            button7.TabIndex = 14;
            button7.Text = "*";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(169, 213);
            button8.Name = "button8";
            button8.Size = new Size(39, 30);
            button8.TabIndex = 15;
            button8.Text = "/";
            button8.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(304, 182);
            label6.Name = "label6";
            label6.Size = new Size(68, 33);
            label6.TabIndex = 16;
            label6.Text = "=";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(342, 182);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 47);
            textBox4.TabIndex = 17;
            textBox4.Text = "#eredmeny#";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(udvozlesLabel);
            Controls.Add(AlaphelyzetButton);
            Controls.Add(KilepesButton);
            Controls.Add(button2);
            Controls.Add(KekLabel);
            Controls.Add(ZoldLabel);
            Controls.Add(PirosLabel);
            Controls.Add(koszonjButton);
            Controls.Add(nevTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nevTextBox;
        private Button koszonjButton;
        private Label PirosLabel;
        private Label ZoldLabel;
        private Label KekLabel;
        private Button button2;
        private Button KilepesButton;
        private Button AlaphelyzetButton;
        private Label udvozlesLabel;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label6;
        private TextBox textBox4;
    }
}