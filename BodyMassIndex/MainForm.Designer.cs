namespace BodyMassIndex
{
    partial class BodyMassIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyMassIndexForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LanguagesGroupBox = new System.Windows.Forms.GroupBox();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.ChineseRadioButton = new System.Windows.Forms.RadioButton();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ChestLabel = new System.Windows.Forms.Label();
            this.ChestTextBox = new System.Windows.Forms.TextBox();
            this.CMILabel = new System.Windows.Forms.Label();
            this.CMITextBox = new System.Windows.Forms.TextBox();
            this.BMIGroupBox = new System.Windows.Forms.GroupBox();
            this.ObesityLabel = new System.Windows.Forms.Label();
            this.OverweightLabel = new System.Windows.Forms.Label();
            this.NormalLabel = new System.Windows.Forms.Label();
            this.UnderwightLabel = new System.Windows.Forms.Label();
            this.CMIGroupBox = new System.Windows.Forms.GroupBox();
            this.TooBigLabel = new System.Windows.Forms.Label();
            this.PerfectLabel = new System.Windows.Forms.Label();
            this.StandardLabel = new System.Windows.Forms.Label();
            this.SamllLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.LanguagesGroupBox.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.BMIGroupBox.SuspendLayout();
            this.CMIGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::BodyMassIndex.Properties.Resources.skinnyGirl;
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(157, 217);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.ChineseRadioButton);
            this.LanguagesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguagesGroupBox.Location = new System.Drawing.Point(176, 13);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(250, 119);
            this.LanguagesGroupBox.TabIndex = 1;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Languages";
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(36, 73);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(118, 33);
            this.EnglishRadioButton.TabIndex = 2;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // ChineseRadioButton
            // 
            this.ChineseRadioButton.AutoSize = true;
            this.ChineseRadioButton.Location = new System.Drawing.Point(36, 34);
            this.ChineseRadioButton.Name = "ChineseRadioButton";
            this.ChineseRadioButton.Size = new System.Drawing.Size(86, 33);
            this.ChineseRadioButton.TabIndex = 1;
            this.ChineseRadioButton.Text = "中文";
            this.ChineseRadioButton.UseVisualStyleBackColor = true;
            this.ChineseRadioButton.CheckedChanged += new System.EventHandler(this.ChineseRadioButton_CheckedChanged);
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderGroupBox.Location = new System.Drawing.Point(176, 138);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(250, 91);
            this.GenderGroupBox.TabIndex = 2;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(126, 34);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(120, 33);
            this.FemaleRadioButton.TabIndex = 4;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            this.FemaleRadioButton.CheckedChanged += new System.EventHandler(this.FemaleRadioButton_CheckedChanged);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Checked = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(36, 34);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(91, 33);
            this.MaleRadioButton.TabIndex = 3;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(182, 247);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(215, 28);
            this.HeightTextBox.TabIndex = 5;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(34, 247);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(143, 29);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "Height (cm):";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(34, 288);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(142, 29);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight (kg):";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(182, 288);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(215, 28);
            this.WeightTextBox.TabIndex = 6;
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(34, 379);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(61, 29);
            this.BMILabel.TabIndex = 8;
            this.BMILabel.Text = "BMI:";
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITextBox.Location = new System.Drawing.Point(182, 379);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(215, 28);
            this.BMITextBox.TabIndex = 8;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(40, 643);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(129, 40);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(269, 643);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(128, 40);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ChestLabel
            // 
            this.ChestLabel.AutoSize = true;
            this.ChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChestLabel.Location = new System.Drawing.Point(34, 329);
            this.ChestLabel.Name = "ChestLabel";
            this.ChestLabel.Size = new System.Drawing.Size(135, 29);
            this.ChestLabel.TabIndex = 12;
            this.ChestLabel.Text = "Chest (cm):";
            // 
            // ChestTextBox
            // 
            this.ChestTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ChestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChestTextBox.Enabled = false;
            this.ChestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChestTextBox.Location = new System.Drawing.Point(182, 329);
            this.ChestTextBox.Name = "ChestTextBox";
            this.ChestTextBox.Size = new System.Drawing.Size(215, 28);
            this.ChestTextBox.TabIndex = 7;
            // 
            // CMILabel
            // 
            this.CMILabel.AutoSize = true;
            this.CMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMILabel.Location = new System.Drawing.Point(34, 413);
            this.CMILabel.Name = "CMILabel";
            this.CMILabel.Size = new System.Drawing.Size(62, 29);
            this.CMILabel.TabIndex = 14;
            this.CMILabel.Text = "CMI:";
            // 
            // CMITextBox
            // 
            this.CMITextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CMITextBox.Enabled = false;
            this.CMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMITextBox.Location = new System.Drawing.Point(182, 413);
            this.CMITextBox.Name = "CMITextBox";
            this.CMITextBox.Size = new System.Drawing.Size(215, 28);
            this.CMITextBox.TabIndex = 9;
            // 
            // BMIGroupBox
            // 
            this.BMIGroupBox.Controls.Add(this.ObesityLabel);
            this.BMIGroupBox.Controls.Add(this.OverweightLabel);
            this.BMIGroupBox.Controls.Add(this.NormalLabel);
            this.BMIGroupBox.Controls.Add(this.UnderwightLabel);
            this.BMIGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIGroupBox.Location = new System.Drawing.Point(16, 453);
            this.BMIGroupBox.Name = "BMIGroupBox";
            this.BMIGroupBox.Size = new System.Drawing.Size(200, 147);
            this.BMIGroupBox.TabIndex = 16;
            this.BMIGroupBox.TabStop = false;
            this.BMIGroupBox.Text = "BMI";
            // 
            // ObesityLabel
            // 
            this.ObesityLabel.AutoSize = true;
            this.ObesityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObesityLabel.Location = new System.Drawing.Point(6, 113);
            this.ObesityLabel.Name = "ObesityLabel";
            this.ObesityLabel.Size = new System.Drawing.Size(113, 22);
            this.ObesityLabel.TabIndex = 3;
            this.ObesityLabel.Text = "Obesity>=30";
            // 
            // OverweightLabel
            // 
            this.OverweightLabel.AutoSize = true;
            this.OverweightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverweightLabel.Location = new System.Drawing.Point(6, 84);
            this.OverweightLabel.Name = "OverweightLabel";
            this.OverweightLabel.Size = new System.Drawing.Size(193, 22);
            this.OverweightLabel.TabIndex = 2;
            this.OverweightLabel.Text = "Overweight = 25~29.9 ";
            // 
            // NormalLabel
            // 
            this.NormalLabel.AutoSize = true;
            this.NormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalLabel.Location = new System.Drawing.Point(6, 56);
            this.NormalLabel.Name = "NormalLabel";
            this.NormalLabel.Size = new System.Drawing.Size(174, 22);
            this.NormalLabel.TabIndex = 1;
            this.NormalLabel.Text = "Normal = 18.5~24.9 ";
            // 
            // UnderwightLabel
            // 
            this.UnderwightLabel.AutoSize = true;
            this.UnderwightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderwightLabel.Location = new System.Drawing.Point(6, 26);
            this.UnderwightLabel.Name = "UnderwightLabel";
            this.UnderwightLabel.Size = new System.Drawing.Size(178, 22);
            this.UnderwightLabel.TabIndex = 0;
            this.UnderwightLabel.Text = "Underweight = <18.5";
            // 
            // CMIGroupBox
            // 
            this.CMIGroupBox.Controls.Add(this.TooBigLabel);
            this.CMIGroupBox.Controls.Add(this.PerfectLabel);
            this.CMIGroupBox.Controls.Add(this.StandardLabel);
            this.CMIGroupBox.Controls.Add(this.SamllLabel);
            this.CMIGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMIGroupBox.Location = new System.Drawing.Point(226, 453);
            this.CMIGroupBox.Name = "CMIGroupBox";
            this.CMIGroupBox.Size = new System.Drawing.Size(200, 147);
            this.CMIGroupBox.TabIndex = 17;
            this.CMIGroupBox.TabStop = false;
            this.CMIGroupBox.Text = "CMI";
            // 
            // TooBigLabel
            // 
            this.TooBigLabel.AutoSize = true;
            this.TooBigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TooBigLabel.Location = new System.Drawing.Point(6, 113);
            this.TooBigLabel.Name = "TooBigLabel";
            this.TooBigLabel.Size = new System.Drawing.Size(119, 22);
            this.TooBigLabel.TabIndex = 3;
            this.TooBigLabel.Text = "Too Big: >0.6";
            // 
            // PerfectLabel
            // 
            this.PerfectLabel.AutoSize = true;
            this.PerfectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerfectLabel.Location = new System.Drawing.Point(6, 84);
            this.PerfectLabel.Name = "PerfectLabel";
            this.PerfectLabel.Size = new System.Drawing.Size(148, 22);
            this.PerfectLabel.TabIndex = 2;
            this.PerfectLabel.Text = "Perfect: 0.54~0.6";
            // 
            // StandardLabel
            // 
            this.StandardLabel.AutoSize = true;
            this.StandardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardLabel.Location = new System.Drawing.Point(6, 56);
            this.StandardLabel.Name = "StandardLabel";
            this.StandardLabel.Size = new System.Drawing.Size(159, 22);
            this.StandardLabel.TabIndex = 1;
            this.StandardLabel.Text = "Standard:0.5~0.53";
            // 
            // SamllLabel
            // 
            this.SamllLabel.AutoSize = true;
            this.SamllLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamllLabel.Location = new System.Drawing.Point(6, 26);
            this.SamllLabel.Name = "SamllLabel";
            this.SamllLabel.Size = new System.Drawing.Size(105, 22);
            this.SamllLabel.TabIndex = 0;
            this.SamllLabel.Text = "Small:<0.49";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 603);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(249, 20);
            this.AuthorLabel.TabIndex = 18;
            this.AuthorLabel.Text = "Author: Lester  ©All Right Recived";
            // 
            // BodyMassIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 695);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.CMIGroupBox);
            this.Controls.Add(this.BMIGroupBox);
            this.Controls.Add(this.CMILabel);
            this.Controls.Add(this.CMITextBox);
            this.Controls.Add(this.ChestLabel);
            this.Controls.Add(this.ChestTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BodyMassIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Mass Index";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.BMIGroupBox.ResumeLayout(false);
            this.BMIGroupBox.PerformLayout();
            this.CMIGroupBox.ResumeLayout(false);
            this.CMIGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.RadioButton ChineseRadioButton;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ChestLabel;
        private System.Windows.Forms.TextBox ChestTextBox;
        private System.Windows.Forms.Label CMILabel;
        private System.Windows.Forms.TextBox CMITextBox;
        private System.Windows.Forms.GroupBox BMIGroupBox;
        private System.Windows.Forms.Label UnderwightLabel;
        private System.Windows.Forms.Label NormalLabel;
        private System.Windows.Forms.Label OverweightLabel;
        private System.Windows.Forms.Label ObesityLabel;
        private System.Windows.Forms.GroupBox CMIGroupBox;
        private System.Windows.Forms.Label TooBigLabel;
        private System.Windows.Forms.Label PerfectLabel;
        private System.Windows.Forms.Label StandardLabel;
        private System.Windows.Forms.Label SamllLabel;
        private System.Windows.Forms.Label AuthorLabel;
    }
}

