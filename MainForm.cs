
using System;
using System.Windows.Forms;
using System.IO;

namespace AdvancedDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateUI();
        }

        private void CreateUI()
        {
            this.Text = "Advanced C# Desktop App";
            this.Size = new System.Drawing.Size(500, 400);

            // Welcome Label
            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to the Advanced C# App!";
            welcomeLabel.Location = new System.Drawing.Point(100, 50);
            welcomeLabel.AutoSize = true;
            this.Controls.Add(welcomeLabel);

            // Buttons for features
            Button dbButton = new Button();
            dbButton.Text = "Database CRUD";
            dbButton.Location = new System.Drawing.Point(100, 100);
            dbButton.Click += PerformDatabaseOperations;
            this.Controls.Add(dbButton);

            Button logButton = new Button();
            logButton.Text = "Write Log";
            logButton.Location = new System.Drawing.Point(100, 150);
            logButton.Click += WriteLog;
            this.Controls.Add(logButton);

            Button apiButton = new Button();
            apiButton.Text = "Get Weather Data";
            apiButton.Location = new System.Drawing.Point(100, 200);
            apiButton.Click += FetchWeatherData;
            this.Controls.Add(apiButton);

            Button fileButton = new Button();
            fileButton.Text = "Read File";
            fileButton.Location = new System.Drawing.Point(100, 250);
            fileButton.Click += ReadFileContent;
            this.Controls.Add(fileButton);
        }

        private void PerformDatabaseOperations(object sender, EventArgs e)
        {
            DatabaseHelper.PerformCRUD();
        }

        private void WriteLog(object sender, EventArgs e)
        {
            Logger.Log("User clicked Write Log button.");
            MessageBox.Show("Log written.");
        }

        private void FetchWeatherData(object sender, EventArgs e)
        {
            string weather = WeatherAPI.GetWeather();
            MessageBox.Show(weather, "Weather Data");
        }

        private void ReadFileContent(object sender, EventArgs e)
        {
            string content = FileOperations.ReadFile("example.txt");
            MessageBox.Show(content, "File Content");
        }
    }
}
