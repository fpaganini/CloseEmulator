using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using J2i.Net.XInputWrapper;

namespace br.com.pgnSoft.Games
{
    public partial class XBOX360_Controller : UserControl
    {
        public XBOX360_Controller()
        {
            InitializeComponent();
        }



        private static void ChangeCheckboxHighlight(bool state, CheckBox checkedControl)
        {
            if (state)
            {
                checkedControl.BackColor = Color.Red;
            }
            else
            {
                checkedControl.BackColor = Color.Transparent;
            }
        }

        public void SetControllerCheckBoxesHighLight(XboxController controller)
        {
            int DeathZone = 10000;
            ChangeCheckboxHighlight(controller.IsBackPressed, chk_ButtonBack);
            ChangeCheckboxHighlight(controller.IsAPressed, chk_ButtonA);
            ChangeCheckboxHighlight(controller.IsBPressed, chk_ButtonB);
            ChangeCheckboxHighlight(controller.IsXPressed, chk_ButtonX);
            ChangeCheckboxHighlight(controller.IsYPressed, chk_ButtonY);
            ChangeCheckboxHighlight(controller.IsDPadDownPressed, chk_DPadDown);
            ChangeCheckboxHighlight(controller.IsDPadLeftPressed, chk_DPadLeft);
            ChangeCheckboxHighlight(controller.IsDPadRightPressed, chk_DPadRight);
            ChangeCheckboxHighlight(controller.IsDPadUpPressed, chk_DPadUp);
            ChangeCheckboxHighlight(controller.IsLeftShoulderPressed, chk_LeftShoulder);
            ChangeCheckboxHighlight(controller.LeftThumbStick.Y < (DeathZone * -1), chk_LeftThumbStickYNegative);
            ChangeCheckboxHighlight(controller.LeftThumbStick.X < (DeathZone * -1), chk_LeftThumbStickXNegative);
            ChangeCheckboxHighlight(controller.LeftThumbStick.X > (DeathZone), chk_LeftThumbStickXPositive);
            ChangeCheckboxHighlight(controller.IsLeftStickPressed, chk_LeftStick);
            ChangeCheckboxHighlight(controller.LeftThumbStick.Y > DeathZone, chk_LeftThumbStickYPositive);
            ChangeCheckboxHighlight(controller.LeftTrigger > 1, chk_LeftTrigger);
            ChangeCheckboxHighlight(controller.IsRightShoulderPressed, chk_RightShoulder);
            ChangeCheckboxHighlight(controller.RightThumbStick.Y < (DeathZone * -1), chk_RightThumbStickYNegative);
            ChangeCheckboxHighlight(controller.RightThumbStick.X < DeathZone * -1, chk_RighThumbStickXNegative);
            ChangeCheckboxHighlight(controller.RightThumbStick.X > DeathZone, chk_RightThumbStickXPositive);
            ChangeCheckboxHighlight(controller.IsRightStickPressed, chk_RightStick);
            ChangeCheckboxHighlight(controller.RightThumbStick.Y > DeathZone, chk_RightThumbStickYPositive);
            ChangeCheckboxHighlight(controller.RightTrigger > 1, chk_RightTrigger);
            ChangeCheckboxHighlight(controller.IsStartPressed, chk_ButtonStart);

        }


        internal void LoadConfigValues(string ValueString)
        {
            string[] values = ValueString.Split(';');
            foreach (var item in pnlKodi_Controller.Controls )
            {
                var control = item as CheckBox;
                if (control != null)
                {
                    control.Checked = (values.Contains(control.Name.Replace("chk_", "")));
                }
            }
        }

        internal string GetConfigValues()
        {
            var values = new List<string>();
            foreach (var item in pnlKodi_Controller.Controls)
            {
                var control = item as CheckBox;
                if (control != null)
                {
                    if (control.Checked)
                    {
                        values.Add (control.Name.Replace("chk_", ""));
                    }
                }
            }
            return string.Join(";", values.ToArray());   
        }
    }
}
