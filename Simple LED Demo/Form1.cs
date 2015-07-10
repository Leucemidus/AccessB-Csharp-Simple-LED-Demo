using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_LED_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccessB AccB = new AccessB(); //Declare the AccessB object first

        private void btnFindDev_Click(object sender, EventArgs e)
        {
            //VID and PID used by the USB module in the PIC, these values are declarated in the AccessB_winusbapi file
            //so isn't needed to assign that values but this is show here if you change the PID and VID from the PIC 
            //firmware you know how to change the default values.

            AccB.PID = 0x003F;//You can comment these lines and the method will find the device if is connected
            AccB.VID = 0x04d8;

            if (AccB.FindDevHID() == true)
            {
                lblStatus.Text = "Status: Connected";
                btnConfig.Enabled = true;
                btnLEDOff.Enabled = true;
                btnLEDOn.Enabled = true;
            }
            else
            {
                lblStatus.Text = "Status: Disconnected";
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AccB.TRISAbits_TRISA0 = 0; //Set pin RA0 of the PIC as output
            //AccB.TRISA = 0; //All the PORTA as output
        }

        private void btnLEDOn_Click(object sender, EventArgs e)
        {
            AccB.LATAbits_LATA0 = 1; //Set pin RA0 high, LED On
            //AccB.LATA = 0xFF; //Complete PORTA pins set to ones
            //AccB.LATA = 0xAA;
            //AccB.LATAbits_LATA3 = 1;
        }

        private void btnLEDOff_Click(object sender, EventArgs e)
        {
            AccB.LATAbits_LATA0 = 0; //Set pin RA0 low, LED Off
            //AccB.LATA = 0; //Complete PORTA pins set to zeroes
        }
    }
}
