using J2i.Net.XInputWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using br.com.pgnSoft.Games.Properties;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        XboxController Controller1;
        XboxController Controller2;
        XboxController Controller3;
        XboxController Controller4;

        public event PropertyChangedEventHandler PropertyChanged;

        public frmMain()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            Controller1 = XboxController.RetrieveController(0);
            Controller2 = XboxController.RetrieveController(1);
            Controller3 = XboxController.RetrieveController(2);
            Controller4 = XboxController.RetrieveController(3);

            XboxController.StartPolling();
            Application.DoEvents();


            Controller1.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller1_StateChanged);
            Controller2.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller2_StateChanged);
            Controller3.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller3_StateChanged);
            Controller4.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller4_StateChanged);

            Controller1.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller_StateChanged);
            Controller2.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller_StateChanged);
            Controller3.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller_StateChanged);
            Controller4.StateChanged += new EventHandler<XboxControllerStateChangedEventArgs>(Controller_StateChanged);

            chkController1.CheckedChanged += new EventHandler(chkController_CheckedChanged);
            chkController2.CheckedChanged += new EventHandler(chkController_CheckedChanged);
            chkController3.CheckedChanged += new EventHandler(chkController_CheckedChanged);
            chkController4.CheckedChanged += new EventHandler(chkController_CheckedChanged);

            chkController1.Enabled = Controller1.GetCapabilities().Flags > 0;
            chkController2.Enabled = Controller2.GetCapabilities().Flags > 0;
            chkController3.Enabled = Controller3.GetCapabilities().Flags > 0;
            chkController4.Enabled = Controller4.GetCapabilities().Flags > 0;


            LoadConfig();


        }

        private bool SystemLoading = false;
        private void LoadConfig()
        {
            SystemLoading = true;
            //Load de enabled controllers
            chkController1.Checked = Settings.Default.ListenController1;
            chkController2.Checked = Settings.Default.ListenController2;
            chkController3.Checked = Settings.Default.ListenController3;
            chkController4.Checked = Settings.Default.ListenController4;

            //Load schema buttons layout
            chkKodiStart.Checked = Settings.Default.OpenKodi;

            Kodi_Controller_Config.LoadConfigValues(Settings.Default.KodiKeys);


            chkCloseEmulators.Checked = Settings.Default.CloseEmulators;
            Emulator_Controller_Config.LoadConfigValues(Settings.Default.EmulatorKeys);


            SystemLoading = false;
        }

        void Controller_StateChanged(object sender, XboxControllerStateChangedEventArgs e)
        {

        }

        void OpenKodi_Analise(XboxController controller)
        {
            if (controller != null)
            {
                if (Settings.Default.OpenKodi)
                {
                    int DeathZone = 10000;
                    string[] keys = Settings.Default.KodiKeys.Split(';');
                    int count = 0;

                    if (controller.IsBackPressed && keys.Contains("ButtonBack")) count += 1;
                    if (controller.IsAPressed && keys.Contains("ButtonA")) count += 1;
                    if (controller.IsBPressed && keys.Contains("ButtonB")) count += 1;
                    if (controller.IsXPressed && keys.Contains("ButtonX")) count += 1;
                    if (controller.IsYPressed && keys.Contains("ButtonY")) count += 1;
                    if (controller.IsDPadDownPressed && keys.Contains("DPadDown")) count += 1;
                    if (controller.IsDPadLeftPressed && keys.Contains("DPadLeft")) count += 1;
                    if (controller.IsDPadRightPressed && keys.Contains("DPadRight")) count += 1;
                    if (controller.IsDPadUpPressed && keys.Contains("DPadUp")) count += 1;
                    if (controller.IsLeftShoulderPressed && keys.Contains("LeftShoulder")) count += 1;
                    if (controller.LeftThumbStick.Y < (DeathZone * -1) && keys.Contains("LeftThumbStickYNegative")) count += 1;
                    if (controller.LeftThumbStick.X < (DeathZone * -1) && keys.Contains("LeftThumbStickXNegative")) count += 1;
                    if (controller.LeftThumbStick.X > (DeathZone) && keys.Contains("LeftThumbStickXPositive")) count += 1;
                    if (controller.IsLeftStickPressed && keys.Contains("LeftStick")) count += 1;
                    if (controller.LeftThumbStick.Y > DeathZone && keys.Contains("LeftThumbStickYPositive")) count += 1;
                    if (controller.LeftTrigger > 1 && keys.Contains("LeftTrigger")) count += 1;
                    if (controller.IsRightShoulderPressed && keys.Contains("RightShoulder")) count += 1;
                    if (controller.RightThumbStick.Y < (DeathZone * -1) && keys.Contains("RightThumbStickYNegative")) count += 1;
                    if (controller.RightThumbStick.X < DeathZone * -1 && keys.Contains("RighThumbStickXNegative")) count += 1;
                    if (controller.RightThumbStick.X > DeathZone && keys.Contains("RightThumbStickXPositive")) count += 1;
                    if (controller.IsRightStickPressed && keys.Contains("RightStick")) count += 1;
                    if (controller.RightThumbStick.Y > DeathZone && keys.Contains("RightThumbStickYPositive")) count += 1;
                    if (controller.RightTrigger > 1 && keys.Contains("RightTrigger")) count += 1;
                    if (controller.IsStartPressed && keys.Contains("ButtonStart")) count += 1;

                    if (count == keys.Length)
                    {
                        AbreKodi();
                    }

                }
            }




            
        }

        private void AbreKodi()
        {
            Process[] processes = Process.GetProcessesByName("Kodi");
            bool encontrado = false;
            foreach (Process process in processes)
            {
                encontrado = true;
            }

            if (!encontrado)
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Kodi\Kodi.exe");
            }
        }


        void CloseEmulators_Analise(XboxController controller)
        {
            if (controller != null)
            {
                if (Settings.Default.CloseEmulators)
                {
                     int DeathZone = 10000;
                    string[] keys = Settings.Default.EmulatorKeys.Split(';');
                    int count = 0;
                    
                    if (controller.IsBackPressed && keys.Contains("ButtonBack")) count +=1;
                    if(controller.IsAPressed && keys.Contains("ButtonA")) count +=1;
                    if(controller.IsBPressed && keys.Contains("ButtonB")) count +=1;
                    if(controller.IsXPressed && keys.Contains("ButtonX")) count +=1;
                    if(controller.IsYPressed && keys.Contains("ButtonY")) count +=1;
                    if(controller.IsDPadDownPressed && keys.Contains("DPadDown")) count +=1;
                    if(controller.IsDPadLeftPressed && keys.Contains("DPadLeft")) count +=1;
                    if(controller.IsDPadRightPressed && keys.Contains("DPadRight")) count +=1;
                    if(controller.IsDPadUpPressed && keys.Contains("DPadUp")) count +=1;
                    if(controller.IsLeftShoulderPressed && keys.Contains("LeftShoulder")) count +=1;
                    if(controller.LeftThumbStick.Y < (DeathZone * -1) && keys.Contains("LeftThumbStickYNegative")) count +=1;
                    if(controller.LeftThumbStick.X < (DeathZone * -1) && keys.Contains("LeftThumbStickXNegative")) count +=1;
                    if(controller.LeftThumbStick.X > (DeathZone) && keys.Contains("LeftThumbStickXPositive")) count +=1;
                    if(controller.IsLeftStickPressed && keys.Contains("LeftStick")) count +=1;
                    if(controller.LeftThumbStick.Y > DeathZone && keys.Contains("LeftThumbStickYPositive")) count +=1;
                    if(controller.LeftTrigger > 1 && keys.Contains("LeftTrigger")) count +=1;
                    if(controller.IsRightShoulderPressed && keys.Contains("RightShoulder")) count +=1;
                    if(controller.RightThumbStick.Y < (DeathZone * -1) && keys.Contains("RightThumbStickYNegative")) count +=1;
                    if(controller.RightThumbStick.X < DeathZone * -1 && keys.Contains("RighThumbStickXNegative")) count +=1;
                    if(controller.RightThumbStick.X > DeathZone && keys.Contains("RightThumbStickXPositive")) count +=1;
                    if(controller.IsRightStickPressed && keys.Contains("RightStick")) count +=1;
                    if(controller.RightThumbStick.Y > DeathZone && keys.Contains("RightThumbStickYPositive")) count +=1;
                    if (controller.RightTrigger > 1 && keys.Contains("RightTrigger")) count += 1;
                    if(controller.IsStartPressed && keys.Contains("ButtonStart")) count +=1;

                    if (count == keys.Length)
                    {
                        FechaAplicativos(); 
                    }

                }
            }
        }

        void Controller1_StateChanged(object sender, XboxControllerStateChangedEventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                CheckBox.CheckForIllegalCrossThreadCalls = false;
                chkController1.Enabled = Controller1.GetCapabilities().Flags > 0;

                if (chkController1.Enabled && chkController1.Checked)
                {
                    if (chkKodiStart.Checked)
                        Kodi_Controller_Config.SetControllerCheckBoxesHighLight(Controller1);
                    if (chkCloseEmulators.Checked)
                        Emulator_Controller_Config.SetControllerCheckBoxesHighLight(Controller1);
                }

                CheckBox.CheckForIllegalCrossThreadCalls = true;
            }


            if (Settings.Default.ListenController1)
            {
                CloseEmulators_Analise(Controller1);
                OpenKodi_Analise(Controller1); 
            }
        }

        void Controller2_StateChanged(object sender, XboxControllerStateChangedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                CheckBox.CheckForIllegalCrossThreadCalls = false;
                chkController2.Enabled = Controller2.GetCapabilities().Flags > 0;

                if (chkController2.Enabled && chkController2.Checked)
                {
                    if (chkKodiStart.Checked)
                        Kodi_Controller_Config.SetControllerCheckBoxesHighLight(Controller2);
                    if (chkCloseEmulators.Checked)
                        Emulator_Controller_Config.SetControllerCheckBoxesHighLight(Controller3);
                }

                CheckBox.CheckForIllegalCrossThreadCalls = true;
            }

            if (Settings.Default.ListenController2)
            {
                CloseEmulators_Analise(Controller2);
                OpenKodi_Analise(Controller2); 
            }
        }

        void Controller3_StateChanged(object sender, XboxControllerStateChangedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                CheckBox.CheckForIllegalCrossThreadCalls = false;
                chkController3.Enabled = Controller3.GetCapabilities().Flags > 0;

                if (chkController3.Enabled && chkController3.Checked)
                {
                    if (chkKodiStart.Checked)
                        Kodi_Controller_Config.SetControllerCheckBoxesHighLight(Controller3);
                    if (chkCloseEmulators.Checked)
                        Emulator_Controller_Config.SetControllerCheckBoxesHighLight(Controller4);
                }

                CheckBox.CheckForIllegalCrossThreadCalls = true;
            }

            if (Settings.Default.ListenController3)
            {
                CloseEmulators_Analise(Controller3);
                OpenKodi_Analise(Controller3); 
            }
        }

        void Controller4_StateChanged(object sender, XboxControllerStateChangedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                CheckBox.CheckForIllegalCrossThreadCalls = false;
                chkController4.Enabled = Controller4.GetCapabilities().Flags > 0;

                if (chkController4.Enabled && chkController4.Checked)
                {
                    if (chkKodiStart.Checked)
                        Kodi_Controller_Config.SetControllerCheckBoxesHighLight(Controller4);
                    if (chkCloseEmulators.Checked)
                        Emulator_Controller_Config.SetControllerCheckBoxesHighLight(Controller4);
                }

                CheckBox.CheckForIllegalCrossThreadCalls = true;
            }

            if (Settings.Default.ListenController4)
            {
                CloseEmulators_Analise(Controller4);
                OpenKodi_Analise(Controller4); 
            }
        }

        private void FechaAplicativos()
        {
            //Dreamcast
            FechaAplicativos("Chankast_alpha_25");
            FechaAplicativos("demul");
            FechaAplicativos("nullDC_Win32_Release-NoTrace");

            //N64
            FechaAplicativos("Project64");

            //PS1
            FechaAplicativos("AdriILE");
            FechaAplicativos("AdriRUN");
            FechaAplicativos("ePSXe");
            FechaAplicativos("pcsx");
            FechaAplicativos("psxfin");
            FechaAplicativos("PSXeven_v0.19.exe");

            EncerraAplicativos("ePSXe");

            //PS2
            FechaAplicativos("pcsx2-r5875");


            //SNES
            FechaAplicativos("snes9x-x64");
            FechaAplicativos("snes9x-x32");

            //32x/mega/master
            FechaAplicativos("Fusion");
            FechaAplicativos("gens");
            FechaAplicativos("Regen");
            FechaAplicativos("gens+");


            //atari
            FechaAplicativos("Good2600");
            FechaAplicativos("ProSystem");
            FechaAplicativos("Stella");


            //NES
            FechaAplicativos("fceux");


           
        }

        private void FechaAplicativos(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            if (processes != null)
            {
                foreach (Process process in processes)
                {
                    try
                    {
                        process.CloseMainWindow();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void EncerraAplicativos(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            if (processes != null)
            {
                foreach (Process process in processes)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                    }
                }
            }
        }


        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                Action a = () => { PropertyChanged(this, new PropertyChangedEventArgs(name)); };


            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (forceClose)
            {
                XboxController.StopPolling();
                base.OnClosing(e);
            }
            else
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }

        private void chkController_CheckedChanged(object sender, EventArgs e)
        {
            imgGuide.Image = GetImage(chkController1.Checked, chkController2.Checked, chkController3.Checked, chkController4.Checked);
        }

        private void chkController1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {

                VibrateController(0);
            }
        }

        private void chkController2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                VibrateController(1);
            }
        }

        private void chkController3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                VibrateController(2);
            }
        }

        private void chkController4_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                VibrateController(3);
            }

        }

        private void VibrateController(int index)
        {
            if (!SystemLoading)
            {
                var controller = XboxController.RetrieveController(index);
                if (controller != null)
                {
                    controller.Vibrate(1, 1, new TimeSpan(1000000));
                }
            }

        }

        private Image GetImage(bool controller1, bool controller2, bool controller3, bool controller4)
        {
            ResourceManager rm = br.com.pgnSoft.Games.Properties.Resources.ResourceManager;
            Bitmap GuidImage = (Bitmap)rm.GetObject("GB" +
                (controller1 ? "Y" : "N") +
                (controller2 ? "Y" : "N") +
                (controller3 ? "Y" : "N") +
                (controller4 ? "Y" : "N"));
            return GuidImage;
        }

        private void chkKodiStart_CheckedChanged(object sender, EventArgs e)
        {
            grpKodi.Height = chkKodiStart.Checked ? 385 : 20;
        }

        private void chkCloseEmulators_CheckedChanged(object sender, EventArgs e)
        {
            grpCloseEmulators.Height = chkCloseEmulators.Checked ? 385 : 20;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //saving enabled controllers
            Settings.Default.ListenController1 = chkController1.Checked;
            Settings.Default.ListenController2 = chkController2.Checked;
            Settings.Default.ListenController3 = chkController3.Checked;
            Settings.Default.ListenController4 = chkController4.Checked;

            //Load schema buttons layout
            Settings.Default.OpenKodi = chkKodiStart.Checked;

            Settings.Default.KodiKeys = Kodi_Controller_Config.GetConfigValues();


            Settings.Default.CloseEmulators = chkCloseEmulators.Checked;
            Settings.Default.EmulatorKeys = Emulator_Controller_Config.GetConfigValues();

            Settings.Default.Save();



            LoadConfig();
            this.Close();

        }

        private void ntfIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Visible = true;
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        bool forceClose = false;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forceClose = true;
            this.Close();
            Application.Exit();
        }

        private void openCloseEmulatorConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadConfig();
            this.Close();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }



    }
}
