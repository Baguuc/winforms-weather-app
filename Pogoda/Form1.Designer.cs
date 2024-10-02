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
            components = new System.ComponentModel.Container();
            WeatherInfoGrid = new TableLayoutPanel();
            TemperatureValueLabel = new Label();
            HumidityValueLabel = new Label();
            RainValueLabel = new Label();
            TemperatureLabel = new Label();
            HumidityLabel = new Label();
            RainLabel = new Label();
            WeatherInfoTimer = new System.Windows.Forms.Timer(components);
            LastRefreshLabel = new Label();
            LastRefreshInfoGrid = new TableLayoutPanel();
            LastRefreshLabelValue = new Label();
            RefreshLabelUpdateTimer = new System.Windows.Forms.Timer(components);
            WeatherInfoGrid.SuspendLayout();
            LastRefreshInfoGrid.SuspendLayout();
            SuspendLayout();
            // 
            // WeatherInfoGrid
            // 
            WeatherInfoGrid.ColumnCount = 3;
            WeatherInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            WeatherInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            WeatherInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            WeatherInfoGrid.Controls.Add(TemperatureValueLabel, 0, 1);
            WeatherInfoGrid.Controls.Add(HumidityValueLabel, 1, 1);
            WeatherInfoGrid.Controls.Add(RainValueLabel, 2, 1);
            WeatherInfoGrid.Controls.Add(TemperatureLabel, 0, 0);
            WeatherInfoGrid.Controls.Add(HumidityLabel, 1, 0);
            WeatherInfoGrid.Controls.Add(RainLabel, 2, 0);
            WeatherInfoGrid.Location = new Point(175, 149);
            WeatherInfoGrid.Name = "WeatherInfoGrid";
            WeatherInfoGrid.RowCount = 2;
            WeatherInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            WeatherInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            WeatherInfoGrid.Size = new Size(446, 100);
            WeatherInfoGrid.TabIndex = 3;
            // 
            // TemperatureValueLabel
            // 
            TemperatureValueLabel.AutoSize = true;
            TemperatureValueLabel.Dock = DockStyle.Fill;
            TemperatureValueLabel.Location = new Point(3, 50);
            TemperatureValueLabel.Name = "TemperatureValueLabel";
            TemperatureValueLabel.Size = new Size(142, 50);
            TemperatureValueLabel.TabIndex = 0;
            TemperatureValueLabel.Text = "...";
            TemperatureValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HumidityValueLabel
            // 
            HumidityValueLabel.AutoSize = true;
            HumidityValueLabel.Dock = DockStyle.Fill;
            HumidityValueLabel.Location = new Point(151, 50);
            HumidityValueLabel.Name = "HumidityValueLabel";
            HumidityValueLabel.Size = new Size(142, 50);
            HumidityValueLabel.TabIndex = 1;
            HumidityValueLabel.Text = "...";
            HumidityValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RainValueLabel
            // 
            RainValueLabel.AutoSize = true;
            RainValueLabel.Dock = DockStyle.Fill;
            RainValueLabel.Location = new Point(299, 50);
            RainValueLabel.Name = "RainValueLabel";
            RainValueLabel.Size = new Size(144, 50);
            RainValueLabel.TabIndex = 2;
            RainValueLabel.Text = "...";
            RainValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Dock = DockStyle.Fill;
            TemperatureLabel.Location = new Point(3, 0);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(142, 50);
            TemperatureLabel.TabIndex = 3;
            TemperatureLabel.Text = "Temperatura";
            TemperatureLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Dock = DockStyle.Fill;
            HumidityLabel.Location = new Point(151, 0);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(142, 50);
            HumidityLabel.TabIndex = 4;
            HumidityLabel.Text = "Wilgotność";
            HumidityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RainLabel
            // 
            RainLabel.AutoSize = true;
            RainLabel.Dock = DockStyle.Fill;
            RainLabel.Location = new Point(299, 0);
            RainLabel.Name = "RainLabel";
            RainLabel.Size = new Size(144, 50);
            RainLabel.TabIndex = 5;
            RainLabel.Text = "Opady";
            RainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeatherInfoTimer
            // 
            WeatherInfoTimer.Enabled = true;
            WeatherInfoTimer.Interval = 900000;
            WeatherInfoTimer.Tick += WeatherTimerTick;
            // 
            // LastRefreshLabel
            // 
            LastRefreshLabel.AutoSize = true;
            LastRefreshLabel.Dock = DockStyle.Fill;
            LastRefreshLabel.Location = new Point(3, 0);
            LastRefreshLabel.Name = "LastRefreshLabel";
            LastRefreshLabel.Size = new Size(94, 49);
            LastRefreshLabel.TabIndex = 4;
            LastRefreshLabel.Text = "Ostatnio odświeżono:";
            LastRefreshLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LastRefreshInfoGrid
            // 
            LastRefreshInfoGrid.ColumnCount = 2;
            LastRefreshInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LastRefreshInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LastRefreshInfoGrid.Controls.Add(LastRefreshLabel, 0, 0);
            LastRefreshInfoGrid.Controls.Add(LastRefreshLabelValue, 1, 0);
            LastRefreshInfoGrid.Location = new Point(295, 80);
            LastRefreshInfoGrid.Name = "LastRefreshInfoGrid";
            LastRefreshInfoGrid.RowCount = 1;
            LastRefreshInfoGrid.RowStyles.Add(new RowStyle());
            LastRefreshInfoGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LastRefreshInfoGrid.Size = new Size(200, 49);
            LastRefreshInfoGrid.TabIndex = 5;
            // 
            // LastRefreshLabelValue
            // 
            LastRefreshLabelValue.AutoSize = true;
            LastRefreshLabelValue.Dock = DockStyle.Fill;
            LastRefreshLabelValue.Location = new Point(103, 0);
            LastRefreshLabelValue.Name = "LastRefreshLabelValue";
            LastRefreshLabelValue.Size = new Size(94, 49);
            LastRefreshLabelValue.TabIndex = 5;
            LastRefreshLabelValue.Text = "Teraz";
            LastRefreshLabelValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RefreshLabelUpdateTimer
            // 
            RefreshLabelUpdateTimer.Enabled = true;
            RefreshLabelUpdateTimer.Interval = 5000;
            RefreshLabelUpdateTimer.Tick += RefreshTimerTick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LastRefreshInfoGrid);
            Controls.Add(WeatherInfoGrid);
            Name = "Form1";
            Text = "Form1";
            WeatherInfoGrid.ResumeLayout(false);
            WeatherInfoGrid.PerformLayout();
            LastRefreshInfoGrid.ResumeLayout(false);
            LastRefreshInfoGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel WeatherInfoGrid;
        private System.Windows.Forms.Timer WeatherInfoTimer;
        private Label TemperatureValueLabel;
        private Label HumidityValueLabel;
        private Label RainValueLabel;
        private Label TemperatureLabel;
        private Label HumidityLabel;
        private Label RainLabel;
        private Label LastRefreshLabel;
        private TableLayoutPanel LastRefreshInfoGrid;
        private Label LastRefreshLabelValue;
        private System.Windows.Forms.Timer RefreshLabelUpdateTimer;
    }
}
