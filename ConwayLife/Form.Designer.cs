namespace ConwayLife
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CellSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.DelayTrackBar = new System.Windows.Forms.TrackBar();
            this.StopButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Desktop;
            this.Canvas.Location = new System.Drawing.Point(294, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(700, 700);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DensityUpDown);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.RandomButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CellSizeUpDown);
            this.panel1.Controls.Add(this.DelayTrackBar);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 700);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Density:";
            // 
            // DensityUpDown
            // 
            this.DensityUpDown.Enabled = false;
            this.DensityUpDown.Location = new System.Drawing.Point(147, 177);
            this.DensityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DensityUpDown.Name = "DensityUpDown";
            this.DensityUpDown.Size = new System.Drawing.Size(120, 26);
            this.DensityUpDown.TabIndex = 9;
            this.DensityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DensityUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DensityUpDown.ValueChanged += new System.EventHandler(this.DensityUpDown_ValueChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(7, 50);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 40);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(7, 3);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(126, 40);
            this.RandomButton.TabIndex = 6;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cell Size:";
            // 
            // CellSizeUpDown
            // 
            this.CellSizeUpDown.Enabled = false;
            this.CellSizeUpDown.Location = new System.Drawing.Point(147, 96);
            this.CellSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellSizeUpDown.Name = "CellSizeUpDown";
            this.CellSizeUpDown.Size = new System.Drawing.Size(120, 26);
            this.CellSizeUpDown.TabIndex = 3;
            this.CellSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CellSizeUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CellSizeUpDown.ValueChanged += new System.EventHandler(this.CellSizeUpDown_ValueChanged);
            // 
            // DelayTrackBar
            // 
            this.DelayTrackBar.Location = new System.Drawing.Point(147, 128);
            this.DelayTrackBar.Minimum = 1;
            this.DelayTrackBar.Name = "DelayTrackBar";
            this.DelayTrackBar.Size = new System.Drawing.Size(120, 69);
            this.DelayTrackBar.TabIndex = 2;
            this.DelayTrackBar.Value = 1;
            this.DelayTrackBar.ValueChanged += new System.EventHandler(this.DelayTrackBar_ValueChanged);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(147, 50);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(126, 40);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(147, 3);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(126, 40);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 730);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "Conway Life";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.TrackBar DelayTrackBar;
        private System.Windows.Forms.NumericUpDown CellSizeUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DensityUpDown;
    }
}

