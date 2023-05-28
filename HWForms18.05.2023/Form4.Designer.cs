namespace HWForms18._05._2023
{
    partial class Form4
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
            button = new Button();
            buttonStart = new Button();
            labelCount = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.BackColor = Color.FromArgb(192, 0, 0);
            button.ForeColor = SystemColors.ActiveCaptionText;
            button.Location = new Point(274, 131);
            button.Name = "button";
            button.Size = new Size(159, 139);
            button.TabIndex = 0;
            button.Text = "Натисни";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Green;
            buttonStart.Location = new Point(539, 316);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Розпочати";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(323, 324);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(0, 15);
            labelCount.TabIndex = 2;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCount);
            Controls.Add(buttonStart);
            Controls.Add(button);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button;
        private Button buttonStart;
        private Label labelCount;
    }
}