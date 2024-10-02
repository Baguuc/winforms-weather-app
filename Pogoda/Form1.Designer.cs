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
            RootGrid = new TableLayoutPanel();
            WeatherInfoGrid.SuspendLayout();
            LastRefreshInfoGrid.SuspendLayout();
            RootGrid.SuspendLayout();
            SuspendLayout();
            // 
            // WeatherInfoGrid
            // 
            WeatherInfoGrid.ColumnCount = 3;
            WeatherInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            WeatherInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            WeatherInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            WeatherInfoGrid.Controls.Add(TemperatureValueLabel, 0, 1);
            WeatherInfoGrid.Controls.Add(HumidityValueLabel, 1, 1);
            WeatherInfoGrid.Controls.Add(RainValueLabel, 2, 1);
            WeatherInfoGrid.Controls.Add(TemperatureLabel, 0, 0);
            WeatherInfoGrid.Controls.Add(HumidityLabel, 1, 0);
            WeatherInfoGrid.Controls.Add(RainLabel, 2, 0);
            WeatherInfoGrid.Dock = DockStyle.Fill;
            WeatherInfoGrid.Location = new Point(3, 183);
            WeatherInfoGrid.Name = "WeatherInfoGrid";
            WeatherInfoGrid.RowCount = 2;
            WeatherInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            WeatherInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            WeatherInfoGrid.Size = new Size(794, 264);
            WeatherInfoGrid.TabIndex = 3;
            // 
            // TemperatureValueLabel
            // 
            TemperatureValueLabel.AutoSize = true;
            TemperatureValueLabel.Dock = DockStyle.Fill;
            TemperatureValueLabel.Location = new Point(3, 26);
            TemperatureValueLabel.Name = "TemperatureValueLabel";
            TemperatureValueLabel.Size = new Size(258, 238);
            TemperatureValueLabel.TabIndex = 0;
            TemperatureValueLabel.Text = "...";
            TemperatureValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // HumidityValueLabel
            // 
            HumidityValueLabel.AutoSize = true;
            HumidityValueLabel.Dock = DockStyle.Fill;
            HumidityValueLabel.Location = new Point(267, 26);
            HumidityValueLabel.Name = "HumidityValueLabel";
            HumidityValueLabel.Size = new Size(258, 238);
            HumidityValueLabel.TabIndex = 1;
            HumidityValueLabel.Text = "...";
            HumidityValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // RainValueLabel
            // 
            RainValueLabel.AutoSize = true;
            RainValueLabel.Dock = DockStyle.Fill;
            RainValueLabel.Location = new Point(531, 26);
            RainValueLabel.Name = "RainValueLabel";
            RainValueLabel.Size = new Size(260, 238);
            RainValueLabel.TabIndex = 2;
            RainValueLabel.Text = "...";
            RainValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Dock = DockStyle.Fill;
            TemperatureLabel.Location = new Point(3, 0);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(258, 26);
            TemperatureLabel.TabIndex = 3;
            TemperatureLabel.Text = "Temperatura";
            TemperatureLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Dock = DockStyle.Fill;
            HumidityLabel.Location = new Point(267, 0);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(258, 26);
            HumidityLabel.TabIndex = 4;
            HumidityLabel.Text = "Wilgotność";
            HumidityLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RainLabel
            // 
            RainLabel.AutoSize = true;
            RainLabel.Dock = DockStyle.Fill;
            RainLabel.Location = new Point(531, 0);
            RainLabel.Name = "RainLabel";
            RainLabel.Size = new Size(260, 26);
            RainLabel.TabIndex = 5;
            RainLabel.Text = "Opady";
            RainLabel.TextAlign = ContentAlignment.BottomCenter;
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
            LastRefreshLabel.Size = new Size(788, 87);
            LastRefreshLabel.TabIndex = 4;
            LastRefreshLabel.Text = "Ostatnio odświeżono:";
            LastRefreshLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LastRefreshInfoGrid
            // 
            LastRefreshInfoGrid.ColumnCount = 1;
            LastRefreshInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LastRefreshInfoGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            LastRefreshInfoGrid.Controls.Add(LastRefreshLabel, 0, 0);
            LastRefreshInfoGrid.Controls.Add(LastRefreshLabelValue, 0, 1);
            LastRefreshInfoGrid.Dock = DockStyle.Fill;
            LastRefreshInfoGrid.Location = new Point(3, 3);
            LastRefreshInfoGrid.Name = "LastRefreshInfoGrid";
            LastRefreshInfoGrid.RowCount = 2;
            LastRefreshInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LastRefreshInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LastRefreshInfoGrid.Size = new Size(794, 174);
            LastRefreshInfoGrid.TabIndex = 5;
            // 
            // LastRefreshLabelValue
            // 
            LastRefreshLabelValue.AutoSize = true;
            LastRefreshLabelValue.Dock = DockStyle.Fill;
            LastRefreshLabelValue.Location = new Point(3, 87);
            LastRefreshLabelValue.Name = "LastRefreshLabelValue";
            LastRefreshLabelValue.Size = new Size(788, 87);
            LastRefreshLabelValue.TabIndex = 5;
            LastRefreshLabelValue.Text = "Teraz";
            LastRefreshLabelValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // RefreshLabelUpdateTimer
            // 
            RefreshLabelUpdateTimer.Enabled = true;
            RefreshLabelUpdateTimer.Interval = 5000;
            RefreshLabelUpdateTimer.Tick += RefreshTimerTick;
            // 
            // RootGrid
            // 
            RootGrid.ColumnCount = 1;
            RootGrid.ColumnStyles.Add(new ColumnStyle());
            RootGrid.Controls.Add(LastRefreshInfoGrid, 0, 0);
            RootGrid.Controls.Add(WeatherInfoGrid, 0, 1);
            RootGrid.Dock = DockStyle.Fill;
            RootGrid.Location = new Point(0, 0);
            RootGrid.Name = "RootGrid";
            RootGrid.RowCount = 2;
            RootGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            RootGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            RootGrid.Size = new Size(800, 450);
            RootGrid.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RootGrid);
            Name = "Form1";
            Text = "Form1";
            WeatherInfoGrid.ResumeLayout(false);
            WeatherInfoGrid.PerformLayout();
            LastRefreshInfoGrid.ResumeLayout(false);
            LastRefreshInfoGrid.PerformLayout();
            RootGrid.ResumeLayout(false);
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
        private System.Windows.Forms.Timer RefreshLabelUpdateTimer;
        private TableLayoutPanel RootGrid;
        private Label LastRefreshLabelValue;
    }
}
