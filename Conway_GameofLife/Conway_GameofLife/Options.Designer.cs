namespace Conway_GameofLife
{
    partial class Options
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Height_UD = new System.Windows.Forms.NumericUpDown();
            this.Width_UD = new System.Windows.Forms.NumericUpDown();
            this.Timer_UD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GridColorButton = new System.Windows.Forms.Button();
            this.Grid_10ColorButton = new System.Windows.Forms.Button();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.LivingCellColorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Gridx10Color = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LiveLivingCellColorButton = new System.Windows.Forms.Button();
            this.DeadLivingCellColorButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Height_UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_UD)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 226);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.Height_UD);
            this.tabPage1.Controls.Add(this.Width_UD);
            this.tabPage1.Controls.Add(this.Timer_UD);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // Height_UD
            // 
            this.Height_UD.Location = new System.Drawing.Point(214, 82);
            this.Height_UD.Name = "Height_UD";
            this.Height_UD.Size = new System.Drawing.Size(120, 20);
            this.Height_UD.TabIndex = 5;
            // 
            // Width_UD
            // 
            this.Width_UD.Location = new System.Drawing.Point(214, 56);
            this.Width_UD.Name = "Width_UD";
            this.Width_UD.Size = new System.Drawing.Size(120, 20);
            this.Width_UD.TabIndex = 4;
            // 
            // Timer_UD
            // 
            this.Timer_UD.Location = new System.Drawing.Point(214, 30);
            this.Timer_UD.Name = "Timer_UD";
            this.Timer_UD.Size = new System.Drawing.Size(120, 20);
            this.Timer_UD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height in Universe in Cells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width of Universe in Cells";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer Interval in Milliseconds";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.DeadLivingCellColorButton);
            this.tabPage2.Controls.Add(this.LiveLivingCellColorButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Gridx10Color);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.LivingCellColorButton);
            this.tabPage2.Controls.Add(this.BackgroundColorButton);
            this.tabPage2.Controls.Add(this.Grid_10ColorButton);
            this.tabPage2.Controls.Add(this.GridColorButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 200);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 232);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(93, 232);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // GridColorButton
            // 
            this.GridColorButton.Location = new System.Drawing.Point(8, 6);
            this.GridColorButton.Name = "GridColorButton";
            this.GridColorButton.Size = new System.Drawing.Size(42, 23);
            this.GridColorButton.TabIndex = 0;
            this.GridColorButton.UseVisualStyleBackColor = true;
            this.GridColorButton.Click += new System.EventHandler(this.GridColorButton_Click);
            // 
            // Grid_10ColorButton
            // 
            this.Grid_10ColorButton.Location = new System.Drawing.Point(8, 35);
            this.Grid_10ColorButton.Name = "Grid_10ColorButton";
            this.Grid_10ColorButton.Size = new System.Drawing.Size(42, 23);
            this.Grid_10ColorButton.TabIndex = 1;
            this.Grid_10ColorButton.UseVisualStyleBackColor = true;
            this.Grid_10ColorButton.Click += new System.EventHandler(this.Grid_10ColorButton_Click);
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.Location = new System.Drawing.Point(8, 64);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(42, 23);
            this.BackgroundColorButton.TabIndex = 2;
            this.BackgroundColorButton.UseVisualStyleBackColor = true;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // LivingCellColorButton
            // 
            this.LivingCellColorButton.Location = new System.Drawing.Point(8, 93);
            this.LivingCellColorButton.Name = "LivingCellColorButton";
            this.LivingCellColorButton.Size = new System.Drawing.Size(42, 23);
            this.LivingCellColorButton.TabIndex = 3;
            this.LivingCellColorButton.UseVisualStyleBackColor = true;
            this.LivingCellColorButton.Click += new System.EventHandler(this.LivingCellColorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Grid Color";
            // 
            // Gridx10Color
            // 
            this.Gridx10Color.AutoSize = true;
            this.Gridx10Color.Location = new System.Drawing.Point(56, 40);
            this.Gridx10Color.Name = "Gridx10Color";
            this.Gridx10Color.Size = new System.Drawing.Size(70, 13);
            this.Gridx10Color.TabIndex = 4;
            this.Gridx10Color.Text = "Gridx10 Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Background Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Live Cell  Color";
            // 
            // LiveLivingCellColorButton
            // 
            this.LiveLivingCellColorButton.Location = new System.Drawing.Point(8, 122);
            this.LiveLivingCellColorButton.Name = "LiveLivingCellColorButton";
            this.LiveLivingCellColorButton.Size = new System.Drawing.Size(42, 23);
            this.LiveLivingCellColorButton.TabIndex = 7;
            this.LiveLivingCellColorButton.UseVisualStyleBackColor = true;
            this.LiveLivingCellColorButton.Click += new System.EventHandler(this.LiveLivingCellColorButton_Click);
            // 
            // DeadLivingCellColorButton
            // 
            this.DeadLivingCellColorButton.Location = new System.Drawing.Point(8, 151);
            this.DeadLivingCellColorButton.Name = "DeadLivingCellColorButton";
            this.DeadLivingCellColorButton.Size = new System.Drawing.Size(42, 23);
            this.DeadLivingCellColorButton.TabIndex = 8;
            this.DeadLivingCellColorButton.UseVisualStyleBackColor = true;
            this.DeadLivingCellColorButton.Click += new System.EventHandler(this.DeadLivingCellColorButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Live  Living Cell Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Dead Living Cell Color";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(383, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Reset";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boundry Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 267);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Options";
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Height_UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_UD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown Height_UD;
        private System.Windows.Forms.NumericUpDown Width_UD;
        private System.Windows.Forms.NumericUpDown Timer_UD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeadLivingCellColorButton;
        private System.Windows.Forms.Button LiveLivingCellColorButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Gridx10Color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LivingCellColorButton;
        private System.Windows.Forms.Button BackgroundColorButton;
        private System.Windows.Forms.Button Grid_10ColorButton;
        private System.Windows.Forms.Button GridColorButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button7;
    }
}