namespace Pogoda
{
    partial class MainForm
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
            MainGrid = new TableLayoutPanel();
            RootGrid = new TableLayoutPanel();
            WeatherInfoGrid.SuspendLayout();
            LastRefreshInfoGrid.SuspendLayout();
            MainGrid.SuspendLayout();
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
            WeatherInfoGrid.Location = new Point(3, 214);
            WeatherInfoGrid.Name = "WeatherInfoGrid";
            WeatherInfoGrid.RowCount = 2;
            WeatherInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            WeatherInfoGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            WeatherInfoGrid.Size = new Size(941, 312);
            WeatherInfoGrid.TabIndex = 3;
            // 
            // TemperatureValueLabel
            // 
            TemperatureValueLabel.AutoSize = true;
            TemperatureValueLabel.Dock = DockStyle.Fill;
            TemperatureValueLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            TemperatureValueLabel.ForeColor = Color.Black;
            TemperatureValueLabel.Image = Properties.Resources.thermometer__1_;
            TemperatureValueLabel.Location = new Point(3, 31);
            TemperatureValueLabel.Name = "TemperatureValueLabel";
            TemperatureValueLabel.Size = new Size(307, 281);
            TemperatureValueLabel.TabIndex = 0;
            TemperatureValueLabel.Text = "...";
            TemperatureValueLabel.TextAlign = ContentAlignment.TopRight;
            TemperatureValueLabel.Click += TemperatureValueLabel_Click;
            // 
            // HumidityValueLabel
            // 
            HumidityValueLabel.AutoSize = true;
            HumidityValueLabel.Dock = DockStyle.Fill;
            HumidityValueLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            HumidityValueLabel.ForeColor = SystemColors.ControlText;
            HumidityValueLabel.Image = Properties.Resources.autumn_forest__1_;
            HumidityValueLabel.ImageAlign = ContentAlignment.TopCenter;
            HumidityValueLabel.Location = new Point(316, 31);
            HumidityValueLabel.Name = "HumidityValueLabel";
            HumidityValueLabel.Size = new Size(307, 281);
            HumidityValueLabel.TabIndex = 1;
            HumidityValueLabel.Text = "...";
            HumidityValueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // RainValueLabel
            // 
            RainValueLabel.AutoSize = true;
            RainValueLabel.Dock = DockStyle.Fill;
            RainValueLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            RainValueLabel.Image = Properties.Resources.rainforest;
            RainValueLabel.Location = new Point(629, 31);
            RainValueLabel.Name = "RainValueLabel";
            RainValueLabel.Size = new Size(309, 281);
            RainValueLabel.TabIndex = 2;
            RainValueLabel.Text = "...";
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Dock = DockStyle.Fill;
            TemperatureLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TemperatureLabel.ForeColor = Color.Black;
            TemperatureLabel.Location = new Point(3, 0);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(307, 31);
            TemperatureLabel.TabIndex = 3;
            TemperatureLabel.Text = "Temperatura";
            TemperatureLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Dock = DockStyle.Fill;
            HumidityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HumidityLabel.ForeColor = SystemColors.ControlText;
            HumidityLabel.Location = new Point(316, 0);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(307, 31);
            HumidityLabel.TabIndex = 4;
            HumidityLabel.Text = "Wilgotność";
            HumidityLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // RainLabel
            // 
            RainLabel.AutoSize = true;
            RainLabel.Dock = DockStyle.Fill;
            RainLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RainLabel.Location = new Point(629, 0);
            RainLabel.Name = "RainLabel";
            RainLabel.Size = new Size(309, 31);
            RainLabel.TabIndex = 5;
            RainLabel.Text = "Opady";
            RainLabel.TextAlign = ContentAlignment.BottomLeft;
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
            LastRefreshLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LastRefreshLabel.Location = new Point(3, 0);
            LastRefreshLabel.Name = "LastRefreshLabel";
            LastRefreshLabel.Size = new Size(935, 102);
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
            LastRefreshInfoGrid.Size = new Size(941, 205);
            LastRefreshInfoGrid.TabIndex = 5;
            // 
            // LastRefreshLabelValue
            // 
            LastRefreshLabelValue.AutoSize = true;
            LastRefreshLabelValue.Dock = DockStyle.Fill;
            LastRefreshLabelValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LastRefreshLabelValue.Location = new Point(3, 102);
            LastRefreshLabelValue.Name = "LastRefreshLabelValue";
            LastRefreshLabelValue.Size = new Size(935, 103);
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
            // MainGrid
            // 
            MainGrid.BackColor = Color.FromArgb(208, 224, 251);
            MainGrid.ColumnCount = 1;
            MainGrid.ColumnStyles.Add(new ColumnStyle());
            MainGrid.Controls.Add(LastRefreshInfoGrid, 0, 0);
            MainGrid.Controls.Add(WeatherInfoGrid, 0, 1);
            MainGrid.Dock = DockStyle.Fill;
            MainGrid.Location = new Point(20, 20);
            MainGrid.Margin = new Padding(0);
            MainGrid.Name = "MainGrid";
            MainGrid.RowCount = 2;
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            MainGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            MainGrid.Size = new Size(947, 529);
            MainGrid.TabIndex = 6;
            // 
            // RootGrid
            // 
            RootGrid.AutoSize = true;
            RootGrid.BackgroundImage = Properties.Resources.clouds;
            RootGrid.ColumnCount = 1;
            RootGrid.ColumnStyles.Add(new ColumnStyle());
            RootGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RootGrid.Controls.Add(MainGrid, 0, 0);
            RootGrid.Dock = DockStyle.Fill;
            RootGrid.Location = new Point(0, 0);
            RootGrid.Margin = new Padding(0);
            RootGrid.Name = "RootGrid";
            RootGrid.Padding = new Padding(20);
            RootGrid.RowCount = 1;
            RootGrid.RowStyles.Add(new RowStyle());
            RootGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RootGrid.Size = new Size(987, 569);
            RootGrid.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.clouds;
            ClientSize = new Size(987, 569);
            Controls.Add(RootGrid);
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            Text = "Weather app";
            Resize += MainFormResize;
            WeatherInfoGrid.ResumeLayout(false);
            WeatherInfoGrid.PerformLayout();
            LastRefreshInfoGrid.ResumeLayout(false);
            LastRefreshInfoGrid.PerformLayout();
            MainGrid.ResumeLayout(false);
            RootGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private TableLayoutPanel MainGrid;
        private Label LastRefreshLabelValue;
        private TableLayoutPanel RootGrid;
    }
}
