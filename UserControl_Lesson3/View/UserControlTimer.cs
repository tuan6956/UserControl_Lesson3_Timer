using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_Lesson3.View
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 1000;
            //timer.Enabled = true;

            GlobalVariables._isStop = false;
            GlobalVariables._isPause = false;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            updateStartController(GlobalVariables._isStop);

            if (GlobalVariables._isStop == false)
            {
                GlobalVariables._cntTimer = 0;
                GlobalVariables._isStop = true;
                GlobalVariables._isPause = false;
                timer.Start();
            }
            else
            {
                GlobalVariables._isStop = false;
                timer.Stop();
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            updatePauseController(GlobalVariables._isPause);

            if (GlobalVariables._isPause == false)
            {
                GlobalVariables._isPause = true;
                timer.Stop();
            }
            else
            {
                GlobalVariables._isPause = false;
                timer.Start();
            }
        }

        private void updateImgController()
        {
            try
            {
                long m = GlobalVariables._cntTimer / 60;
                long s = GlobalVariables._cntTimer % 60;
                base.Invoke(new MethodInvoker(delegate
                {
                    imgMinuteFr.Image = GlobalVariables._imgTimer[m / 10];
                    imgMinuteSc.Image = GlobalVariables._imgTimer[m % 10];
                    imgSecondFr.Image = GlobalVariables._imgTimer[s / 10];
                    imgSecondSc.Image = GlobalVariables._imgTimer[s % 10];
                }));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void updateStartController(bool status)
        {
            base.Invoke(new MethodInvoker(delegate
            {
                if (status)
                {
                    btnStart.Text = "Start";
                    btnPause.Text = "Pause";
                    btnPause.Enabled = false;
                }
                else
                {
                    btnStart.Text = "Stop";
                    btnPause.Enabled = true;
                }
            }));
        }
        private void updatePauseController(bool status)
        {
            base.Invoke(new MethodInvoker(delegate
            {
                if (status)
                    btnPause.Text = "Pause";
                else
                    btnPause.Text = "Resume";
            }));
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            GlobalVariables._cntTimer++;
            updateImgController();
        }

    }
}
