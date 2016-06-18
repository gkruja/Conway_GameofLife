﻿namespace Conway_GameofLife
{
    partial class RandOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.Seed_UD = new System.Windows.Forms.NumericUpDown();
            this.Rand_button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Seed_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seed";
            // 
            // Seed_UD
            // 
            this.Seed_UD.Location = new System.Drawing.Point(75, 38);
            this.Seed_UD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Seed_UD.Name = "Seed_UD";
            this.Seed_UD.Size = new System.Drawing.Size(120, 20);
            this.Seed_UD.TabIndex = 1;
            // 
            // Rand_button
            // 
            this.Rand_button.Location = new System.Drawing.Point(201, 38);
            this.Rand_button.Name = "Rand_button";
            this.Rand_button.Size = new System.Drawing.Size(75, 20);
            this.Rand_button.TabIndex = 2;
            this.Rand_button.Text = "Randomize";
            this.Rand_button.UseVisualStyleBackColor = true;
            this.Rand_button.Click += new System.EventHandler(this.Rand_button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(12, 73);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(93, 73);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // RandOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 106);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Rand_button);
            this.Controls.Add(this.Seed_UD);
            this.Controls.Add(this.label1);
            this.Name = "RandOptions";
            this.Text = "RandOptions";
            ((System.ComponentModel.ISupportInitialize)(this.Seed_UD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Seed_UD;
        private System.Windows.Forms.Button Rand_button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}