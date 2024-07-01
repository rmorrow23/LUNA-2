using Moonbase.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FormMain : Form
    {
        // Variable to hold the user's current position
        string currentPosition;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize with default values or actions
        }

        private void UpdateUserPosition(string newPosition)
        {
            currentPosition = newPosition;
            LogUserPosition();
        }

        private void LogUserPosition()
        {
            //log file will be under MoonBase\bin\x64\Debug
            string logFilePath = "user_location_log.txt";
            string logMessage = $"{DateTime.Now}: User moved to {currentPosition}";

            try
            {
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging user position: {ex.Message}");
            }
        }

        private void TBRoomName_TextChanged(object sender, EventArgs e)
        {
            // Handle any changes to the room name textbox if necessary
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle any actions related to label2 if necessary
        }

        // Nav Buttons
        private void commandCenterBTN_Click(object sender, EventArgs e)
        {
            // Update user position
            UpdateUserPosition("Command Center");
            // Change the background image to command center
            this.BackgroundImage = Properties.Resources.command_center;
            // Change Room Title to Command Center
            TBRoomName.Text = "Lunar Operations Command Center";
            // Change room description to Command Center Description
            TXBXRoomDesc.Text = "The Lunar Operations Command Center is the heart of the moonbase, featuring walls of sleek metallic panels embedded with soft, ambient LED lights that create a futuristic glow. Large, reinforced windows offer a breathtaking view of the lunar landscape and Earth. High-tech consoles with holographic displays dominate the room, providing real-time data and interactive controls for managing base operations.";
        }

        private void labBTN_Click(object sender, EventArgs e)
        {
            // Update user position
            UpdateUserPosition("Lab");
            // Change background image to Laboratory
            this.BackgroundImage = Properties.Resources.lab;
            // Change Room Title to Laboratory
            TBRoomName.Text = "Lunar Laboratory";
            // Change room description to Laboratory Description
            TXBXRoomDesc.Text = "The Lunar Laboratory is a hub of scientific discovery, featuring sleek metallic walls illuminated by ambient LED lights. Large windows offer a view of the lunar surface, enhancing the high-tech atmosphere. Equipped with advanced scientific instruments and robotic assistants, the lab enables groundbreaking experiments and efficient research.";
        }

        private void medBayBTN_Click(object sender, EventArgs e)
        {
            // Update user position
            UpdateUserPosition("MedBay");
            // Change background image to MedBay
            this.BackgroundImage = Properties.Resources.medbay;
            // Change Room Title to MedBay
            TBRoomName.Text = "Lunar Medical Bay";
            // Change room description to MedBay Description
            TXBXRoomDesc.Text = "The Lunar Medbay is a state-of-the-art medical facility with sleek metallic walls and soft LED lighting. Large windows provide a calming view of the lunar surface. Equipped with advanced medical technology and robotic assistants, the medbay ensures top-notch care and efficient patient management.";
        }

        private void livingQtBTN_Click(object sender, EventArgs e)
        {
            // Update user position
            UpdateUserPosition("Living Quarters");
            // Change background image to Living Quarters
            this.BackgroundImage = Properties.Resources.living;
            // Change Room Title to Living Quarters
            TBRoomName.Text = "Lunar Living Quarters";
            // Change room description to Living Quarters Description
            TXBXRoomDesc.Text = "The Lunar Living Quarters offer a cozy refuge with sleek metallic walls and warm LED lighting. Large windows provide a stunning lunar landscape view. Modern furniture, including a comfortable bed, seating area, and holographic work desk, ensure comfort and functionality, while personal items add a homely touch.";
        }
    }
}
