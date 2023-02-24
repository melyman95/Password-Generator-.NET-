namespace My_Password_Generator_CSharp
{
    partial class PWGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PWGenForm));
            this.enterLengthBox = new System.Windows.Forms.TextBox();
            this.PWGenBox = new System.Windows.Forms.TextBox();
            this.PWGenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upperCheck = new System.Windows.Forms.CheckBox();
            this.lowerCheck = new System.Windows.Forms.CheckBox();
            this.numberCheck = new System.Windows.Forms.CheckBox();
            this.specialCharsCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // enterLengthBox
            // 
            this.enterLengthBox.BackColor = System.Drawing.SystemColors.Control;
            this.enterLengthBox.Location = new System.Drawing.Point(186, 77);
            this.enterLengthBox.Name = "enterLengthBox";
            this.enterLengthBox.Size = new System.Drawing.Size(67, 31);
            this.enterLengthBox.TabIndex = 0;
            this.enterLengthBox.Text = "8";
            this.enterLengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PWGenBox
            // 
            this.PWGenBox.BackColor = System.Drawing.SystemColors.Control;
            this.PWGenBox.Location = new System.Drawing.Point(158, 181);
            this.PWGenBox.Name = "PWGenBox";
            this.PWGenBox.ReadOnly = true;
            this.PWGenBox.Size = new System.Drawing.Size(326, 31);
            this.PWGenBox.TabIndex = 1;
            // 
            // PWGenerateButton
            // 
            this.PWGenerateButton.BackColor = System.Drawing.SystemColors.Control;
            this.PWGenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PWGenerateButton.Location = new System.Drawing.Point(162, 233);
            this.PWGenerateButton.Name = "PWGenerateButton";
            this.PWGenerateButton.Size = new System.Drawing.Size(150, 45);
            this.PWGenerateButton.TabIndex = 2;
            this.PWGenerateButton.Text = "Generate";
            this.PWGenerateButton.UseVisualStyleBackColor = false;
            this.PWGenerateButton.Click += new System.EventHandler(this.PWGenerateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // upperCheck
            // 
            this.upperCheck.AutoSize = true;
            this.upperCheck.Checked = true;
            this.upperCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upperCheck.Location = new System.Drawing.Point(162, 304);
            this.upperCheck.Name = "upperCheck";
            this.upperCheck.Size = new System.Drawing.Size(245, 36);
            this.upperCheck.TabIndex = 5;
            this.upperCheck.Text = "include uppercase?";
            this.upperCheck.UseVisualStyleBackColor = true;
            // 
            // lowerCheck
            // 
            this.lowerCheck.AutoSize = true;
            this.lowerCheck.Checked = true;
            this.lowerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lowerCheck.Location = new System.Drawing.Point(162, 364);
            this.lowerCheck.Name = "lowerCheck";
            this.lowerCheck.Size = new System.Drawing.Size(240, 36);
            this.lowerCheck.TabIndex = 6;
            this.lowerCheck.Text = "include lowercase?";
            this.lowerCheck.UseVisualStyleBackColor = true;
            // 
            // numberCheck
            // 
            this.numberCheck.AutoSize = true;
            this.numberCheck.Checked = true;
            this.numberCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numberCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberCheck.Location = new System.Drawing.Point(162, 427);
            this.numberCheck.Name = "numberCheck";
            this.numberCheck.Size = new System.Drawing.Size(230, 36);
            this.numberCheck.TabIndex = 7;
            this.numberCheck.Text = "include numbers?";
            this.numberCheck.UseVisualStyleBackColor = true;
            // 
            // specialCharsCheck
            // 
            this.specialCharsCheck.AutoSize = true;
            this.specialCharsCheck.Checked = true;
            this.specialCharsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specialCharsCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialCharsCheck.Location = new System.Drawing.Point(162, 488);
            this.specialCharsCheck.Name = "specialCharsCheck";
            this.specialCharsCheck.Size = new System.Drawing.Size(322, 36);
            this.specialCharsCheck.TabIndex = 8;
            this.specialCharsCheck.Text = "include special characters?";
            this.specialCharsCheck.UseVisualStyleBackColor = true;
            // 
            // PWGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(526, 595);
            this.Controls.Add(this.specialCharsCheck);
            this.Controls.Add(this.numberCheck);
            this.Controls.Add(this.lowerCheck);
            this.Controls.Add(this.upperCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PWGenerateButton);
            this.Controls.Add(this.PWGenBox);
            this.Controls.Add(this.enterLengthBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PWGenForm";
            this.Text = "PWGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox enterLengthBox;
        public TextBox PWGenBox;
        private Button PWGenerateButton;
        private Label label1;
        private Label label2;
        public CheckBox upperCheck;
        public CheckBox lowerCheck;
        public CheckBox numberCheck;
        public CheckBox specialCharsCheck;
    }
}