using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WeAreDevs_API;

namespace Inset_Client
{
    public partial class Client : Form
    {
        readonly ExploitAPI api = new ExploitAPI();

        bool InsetAPI = true;
        bool TopApp = false;
        bool CustomAPI = false;

        private void Client_Toggle(bool choice)
        {
            //GUI
            Settings_Label.Visible = choice;
            InsetAPI_RadioButton.Visible = choice;
            TopApp_RadioButton.Visible = choice;
            CustomAPI_RadioButton.Visible = choice;
            CustomAPIURL.Visible = choice;

            if (choice == true)
            {
                Border_Left_Tab.Location = new Point(363, 25);
                Border_Left_Tab.Size = new Size(1, 25);

                Border_Bottom_Left.Location = new Point(0, 50);
                Border_Bottom_Left.Size = new Size(364, 1);

                Border_Top_Tab.Location = new Point(363, 24);
                Border_Top_Tab.Size = new Size(63, 1);

                Border_Right_Tab.Location = new Point(425, 25);
                Border_Right_Tab.Size = new Size(1, 25);

                Border_Bottom_Right.Location = new Point(425, 50);
                Border_Bottom_Right.Size = new Size(250, 1);
            }
        }

        private void List_Toggle(bool choice)
        {
            //Options-Extra
            RTX_Button.Visible = choice;
            Menu_Button.Visible = choice;
            AimBot_Button.Visible = choice;
            FireBalls_Button.Visible = choice;
            BTools_Button.Visible = choice;
            Sky_Button.Visible = choice;
            DexExplorer_Button.Visible = choice;

            if (choice == true)
            {
                Border_Left_Tab.Location = new Point(301, 25);
                Border_Left_Tab.Size = new Size(1, 25);

                Border_Bottom_Left.Location = new Point(0, 50);
                Border_Bottom_Left.Size = new Size(302, 1);

                Border_Top_Tab.Location = new Point(301, 24);
                Border_Top_Tab.Size = new Size(63, 1);

                Border_Right_Tab.Location = new Point(363, 25);
                Border_Right_Tab.Size = new Size(1, 25);

                Border_Bottom_Right.Location = new Point(363, 50);
                Border_Bottom_Right.Size = new Size(313, 1);
            }
        }

        private void Home_Toggle(bool choice)
        {
            ScriptBox.Visible = choice;
            Inject_Button.Visible = choice;
            OpenFile_Button.Visible = choice;
            Execute_Button.Visible = choice;
            Clear_Button.Visible = choice;

            if (choice == true)
            {
                Border_Left_Tab.Location = new Point(239, 25);
                Border_Left_Tab.Size = new Size(1, 25);
                Border_Bottom_Left.Location = new Point(0, 50);
                Border_Bottom_Left.Size = new Size(240, 1);
                Border_Top_Tab.Location = new Point(239, 24);
                Border_Top_Tab.Size = new Size(63, 1);
                Border_Right_Tab.Location = new Point(301, 25);
                Border_Right_Tab.Size = new Size(1, 25);
                Border_Bottom_Right.Location = new Point(301, 50);
                Border_Bottom_Right.Size = new Size(374, 1);
            }
        }

        public Client()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            InsetAPI = Properties.Settings.Default.InsetAPISetting;
            TopApp = Properties.Settings.Default.TopAppSetting;
            CustomAPI = Properties.Settings.Default.CustomAPIToggle;
            CustomAPIURL.Text = Properties.Settings.Default.CustomAPIurl;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.InsetAPISetting = InsetAPI;
            Properties.Settings.Default.TopAppSetting = TopApp;
            Properties.Settings.Default.CustomAPIToggle = CustomAPI;
            Properties.Settings.Default.CustomAPIurl = CustomAPIURL.Text;

            Properties.Settings.Default.Save();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            LoadSettings();

            if (InsetAPI == true)
            {
                InsetAPI_RadioButton.Checked = true;
            }
            if (InsetAPI == false)
            {
                InsetAPI_RadioButton.Checked = false;
            }

            if (TopApp == true)
            {
                TopApp_RadioButton.Checked = true;
                TopMost = true;
            }
            if (TopApp == false)
            {
                TopApp_RadioButton.Checked = false;
                TopMost = false;
            }

            if (CustomAPI == true)
            {
                CustomAPI_RadioButton.Checked = true;
            }
            if (CustomAPI == false)
            {
                CustomAPI_RadioButton.Checked = false;
            }
        }

        private void Client_Closing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Client_Button_Click(object sender, EventArgs e)
        {
            Client_Toggle(true);
            List_Toggle(false);
            Home_Toggle(false);
        }

        private void List_Button_Click(object sender, EventArgs e)
        {
            Client_Toggle(false);
            List_Toggle(true);
            Home_Toggle(false);
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            Client_Toggle(false);
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void Inject_Button_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ScriptBox.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void Execute_Button_Click(object sender, EventArgs e)
        {
            string Script = ScriptBox.Text;
            

            if (CustomAPI == true)
            {
                Script = "local MyAPI = loadstring(game:HttpGet(\"" + CustomAPIURL.Text + "\", true))()\n" + Script;
            }

            if (InsetAPI == true)
            {
                Script = "local InsetAPI = loadstring(game:HttpGet(\"https://raw.githubusercontent.com/ENDLESS-HACKER0/Scripts/main/API.lua\", true))()\n" + Script;
            }

            api.SendLuaScript(Script);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Clear();
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/ENDLESS-HACKER0/Scripts/main/Menu.lua\", true))()";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void AimBot_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/WRD Aimbot.txt\"))()\n--Right Click To Use\n\n--Settings\n_G.WRDAimbotTeamCheck = false\n_G.WRDAimbotBypass = false\n_G.WRDAimBotWallcheck = false";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void FireBalls_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/ENDLESS-HACKER0/Scripts/main/Fire%20Orb%20Pet.lua\", true))()";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void BTools_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Unlock Workspace Baseparts.txt\"))()\nwait(0.2)\nloadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/BTools.txt\"))()";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void RTX_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "InsetAPI:RTX()";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void Sky_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "InsetAPI:skybox(144931564, 144931530, 144933262, 144933244, 144933338, 144933299)";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void DexExplorer_Button_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt\", true))()";
            List_Toggle(false);
            Home_Toggle(true);
        }

        private void InsetAPI_RadioButton_Click(object sender, EventArgs e)
        {
            InsetAPI = !InsetAPI;

            if (InsetAPI == true)
            {
                InsetAPI_RadioButton.Checked = true;
            }
            if (InsetAPI == false)
            {
                InsetAPI_RadioButton.Checked = false;
            }
        }

        private void TopApp_RadioButton_Click(object sender, EventArgs e)
        {
            TopApp = !TopApp;

            if (TopApp == true)
            {
                TopApp_RadioButton.Checked = true;
                TopMost = true;
            }
            if (TopApp == false)
            {
                TopApp_RadioButton.Checked = false;
                TopMost = false;
            }
        }

        private void CustomAPI_RadioButton_Click(object sender, EventArgs e)
        {
            CustomAPI = !CustomAPI;

            if (CustomAPI == true)
            {
                CustomAPI_RadioButton.Checked = true;
            }
            if (CustomAPI == false)
            {
                CustomAPI_RadioButton.Checked = false;
            }
        }
    }
}
