using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace DiscordDisco
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public bool discoDisco = false;
        public int prioCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            discoDisco = true;
            Thread thread = new Thread(runTheDisco);
            thread.Start();
        }
        public void runTheDisco()
        {
            while (discoDisco)
            {
                Process[] processes = Process.GetProcessesByName("Discord");
                foreach (Process proc in processes)
                {
                    if (proc.PriorityClass == ProcessPriorityClass.Idle)
                    {
                        proc.PriorityClass = ProcessPriorityClass.High;
                        if (proc.PriorityClass == ProcessPriorityClass.High)
                        {
                            prioCounter++;
                            Random rnd = new Random();
                            int toPlayOrNotToPlay = rnd.Next(0,2);
                            if (toPlayOrNotToPlay == 1)
                            {
                                System.IO.Stream str = Properties.Resources.fart;
                                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                                snd.Play();
                            }
                        }
                    }
                }
                updateCounter();
                Thread.Sleep(5000);
            }
        }

        public void updateCounter()
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate { updateCounter(); });
                return;
            }
            counter.Text = prioCounter.ToString();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            discoDisco = false;
        }
    }
}
