using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private int totalClickCount = 0;

        private bool stopIt = false;

        public Form1()
        {
            InitializeComponent();
            btPause.Enabled = false;
            btStops.Enabled = false;
            tbSec.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tbSec.Enabled = false;
            tbTotal.Enabled = false;
            btPause.Enabled = true;
            btStops.Enabled = true;
            btStart.Enabled = false;
            tbPause.Enabled = false;
            tbStartAfter.Enabled = false;

            lbStartTime.Text = "Started at: " + DateTime.UtcNow.ToString();
            totalClickCount = 0;
            lbTotalClickCount.Text = totalClickCount.ToString();
            this.Refresh();

            if (tbSec.TextLength == 0)
            {
                MessageBox.Show("Can not be empty!");
                tbSec.Enabled = true;
                return;
            }

            int timer = int.Parse(tbSec.Text) * 1000;
            int totalClick = int.Parse(tbTotal.Text);

            System.Threading.Thread.Sleep(int.Parse(tbStartAfter.Text) * 1000);

            Task task = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < totalClick; i++)
                {
                    string currentPos = Cursor.Position.ToString();
                    System.Threading.Thread.Sleep(500);
                    bool checkMove = false;

                    while (currentPos != Cursor.Position.ToString())
                    {
                        System.Threading.Thread.Sleep(int.Parse(tbPause.Text) * 1000);
                        currentPos = Cursor.Position.ToString();
                        System.Threading.Thread.Sleep(500);
                        checkMove = true;
                    }

                    if (!checkMove)
                    {
                        if (!stopIt)
                        {
                            System.Threading.Thread.Sleep(timer);
                            DoMouseClick();
                            totalClickCount++;
                            lbTotalClickCount.Text = totalClickCount.ToString() + " / " + totalClick.ToString();
                            this.Refresh();
                        }
                        else
                        {
                            lbTotalClickCount.Text = "0";
                            this.Refresh();
                            break;
                        }
                    }
                }
            });

            stopIt = false;
            this.Refresh();
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void tbSecond_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSec.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSec.Text = tbSec.Text.Remove(tbSec.Text.Length - 1);
            }
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTotal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTotal.Text = tbTotal.Text.Remove(tbTotal.Text.Length - 1);
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
        }

        private void btStop_Click(object sender, EventArgs e)
        {
        }

        private void btStops_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "STOP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                stopIt = true;
                lbStartTime.Text = "Stoped at: " + DateTime.UtcNow.ToString() + "\nTotal clicked: " + lbTotalClickCount.Text;

                btStart.Enabled = true;
                btPause.Enabled = false;
                btStops.Enabled = false;
                tbSec.Enabled = true;
                tbTotal.Enabled = true;
                tbPause.Enabled = true;
                tbStartAfter.Enabled = true;

                tbSec.Text = tbSec.Text.Remove(tbSec.Text.Length - (tbSec.Text.Length));
                tbTotal.Text = tbTotal.Text.Remove(tbTotal.Text.Length - (tbTotal.Text.Length));
                tbPause.Text = tbPause.Text.Remove(tbTotal.Text.Length - (tbTotal.Text.Length));
                tbStartAfter.Text = tbStartAfter.Text.Remove(tbTotal.Text.Length - (tbTotal.Text.Length));

                lbTotalClickCount.Text = "0";
                this.Refresh();
            }
        }

        private void tbPause_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTotal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "OOPPP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTotal.Text = tbTotal.Text.Remove(tbTotal.Text.Length - 1);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
