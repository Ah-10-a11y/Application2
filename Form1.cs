using System.Diagnostics;

namespace AhmedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            run_cmd();
        }

        private void run_cmd()
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd bin");
                    sw.WriteLine("python AMS_Run.py");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
    }
}