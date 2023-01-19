using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeAlarm
{
    public partial class Form1 : Form
    {
        bool bTimeToAlarm = false;
        bool bChangeSet = false;
        DateTime tSetTimeToAlarm;

        bool bTimeEndAlarm = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");

            if (bTimeToAlarm || bTimeEndAlarm)
            {
                if (DateTime.Compare(tSetTimeToAlarm, DateTime.Now) <= 0)
                {
                    lbTimeRemain.ForeColor = Color.Black;
                    tTime.Stop();
                    bTimeToAlarm = false;
                    DialogResult dReturn = MessageBox.Show("按確定，再次重複倒數計時", "Time Alarm", MessageBoxButtons.OKCancel,
                                                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (dReturn == System.Windows.Forms.DialogResult.OK)
                    {
                        if (bTimeEndAlarm)
                        {
                            char[] separators = new char[] { 'h', 'm', 's' };
                            string[] subs = tbTimeEndAlarm.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                            int iTotalSec = Convert.ToInt32(subs[0]) * 60 * 60;
                            iTotalSec += Convert.ToInt32(subs[1]) * 60;
                            iTotalSec += Convert.ToInt32(subs[2]);
                            tSetTimeToAlarm = DateTime.Now.AddSeconds(iTotalSec);

                            lbTipTimeToAlarm.Text = tSetTimeToAlarm.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
                            bTimeEndAlarm = true;
                            bChangeSet = false;

                            tTime.Start();
                        }
                        else
                        {
                            tbTimeEndAlarm.Text = "00h03m00s";
                            tTime.Stop();
                            this.Close();
                        }

                    }
                    else
                    {
                        tbTimeEndAlarm.Text = "00h03m00s";
                        tTime.Stop();
                        this.Close();
                    }
                }
                else
                {
                    lbTimeRemain.ForeColor = Color.Green;
                    TimeSpan span = tSetTimeToAlarm.Subtract(DateTime.Now);
                    lbTimeRemain.Text = ((span.Days > 0) ? span.Days + " D " : "") + span.Hours + " H " + span.Minutes + " M " + span.Seconds + " S";
                }
            }
        }

        private void tbTimeToAlarm_Click(object sender, EventArgs e)
        {
            if (bChangeSet == false)
            {
                bChangeSet = true;
                tbTimeToAlarm.Text = lbTime.Text;
            }
        }

        private void tbTimeEndAlarm_Click(object sender, EventArgs e)
        {
            if (bChangeSet == false)
            {
                bChangeSet = true;
                tbTimeEndAlarm.Text = "00h03m00s";
            }
        }

        private void btnTimeToAlarm_Click(object sender, EventArgs e)
        {
            if (tbTimeToAlarm.Text.Length <= 0)
                return;

            bChangeSet = false;
            DateTime tAlarm = DateTime.Parse(tbTimeToAlarm.Text);

            /*
            小於零	t1 早於 t2。
            零	t1 與 t2 相同。
            大於零	t1 晚於 t2。
             */
            if (DateTime.Compare(tAlarm, DateTime.Now) > 0)
            {
                tSetTimeToAlarm = tAlarm;
                bTimeToAlarm = true;
                tTime.Start();
            }
            else 
            {
                tbTimeToAlarm.Text = lbTime.Text;
            }
        }

        private void btnTimeEndAlarm_Click(object sender, EventArgs e)
        {
            if (!tbTimeEndAlarm.Text.Contains('h') || !tbTimeEndAlarm.Text.Contains('m') || !tbTimeEndAlarm.Text.Contains('s'))
            {
                tbTimeEndAlarm.Text = "00h03m00s";
                return;
            }

            char[] separators = new char[] { 'h', 'm', 's' };
            string[] subs = tbTimeEndAlarm.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            if (subs.Length != 3)
            {
                tbTimeEndAlarm.Text = "00h03m00s";
                return;
            }

            int iTotalSec = Convert.ToInt32(subs[0]) * 60 * 60;
            iTotalSec += Convert.ToInt32(subs[1]) * 60;
            iTotalSec += Convert.ToInt32(subs[2]);
            tSetTimeToAlarm = DateTime.Now.AddSeconds(iTotalSec);

            lbTipTimeToAlarm.Text = tSetTimeToAlarm.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            bTimeEndAlarm = true;
            bChangeSet = false;
        }
    }
}
