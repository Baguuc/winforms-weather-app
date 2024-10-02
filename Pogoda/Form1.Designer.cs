namespace Pogoda
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
            TemperatureValueLabel = new Label();
            HumidityValueLabel = new Label();
            RainValueLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TemperatureValueLabel
            // 
            TemperatureValueLabel.AutoSize = true;
            TemperatureValueLabel.Dock = DockStyle.Fill;
            TemperatureValueLabel.Location = new Point(3, 0);
            TemperatureValueLabel.Name = "TemperatureValueLabel";
            TemperatureValueLabel.Size = new Size(60, 100);
            TemperatureValueLabel.TabIndex = 0;
            TemperatureValueLabel.Text = "...";
            TemperatureValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HumidityValueLabel
            // 
            HumidityValueLabel.AutoSize = true;
            HumidityValueLabel.Dock = DockStyle.Fill;
            HumidityValueLabel.Location = new Point(69, 0);
            HumidityValueLabel.Name = "HumidityValueLabel";
            HumidityValueLabel.Size = new Size(60, 100);
            HumidityValueLabel.TabIndex = 1;
            HumidityValueLabel.Text = "...";
            HumidityValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RainValueLabel
            // 
            RainValueLabel.AutoSize = true;
            RainValueLabel.Dock = DockStyle.Fill;
            RainValueLabel.Location = new Point(135, 0);
            RainValueLabel.Name = "RainValueLabel";
            RainValueLabel.Size = new Size(62, 100);
            RainValueLabel.TabIndex = 2;
            RainValueLabel.Text = "...";
            RainValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(TemperatureValueLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(RainValueLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(HumidityValueLabel, 1, 0);
            tableLayoutPanel1.Location = new Point(251, 138);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TemperatureValueLabel;
        private Label HumidityValueLabel;
        private Label RainValueLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
