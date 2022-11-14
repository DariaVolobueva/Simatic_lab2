using S7PROSIMLib;
namespace Lab2
{
    public partial class Form1 : Form
    {
        public S7PROSIMLib.S7ProSim ps = new S7PROSIMLib.S7ProSim();   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ps.Connect();
            label_CPU.Text = ps.GetState();
            label_ScanMode.Text = ps.GetScanMode().ToString();    
        }

        private void checkBox_Input1_CheckedChanged(object sender, EventArgs e)
        {
            object I0_0 = checkBox_Input1.Checked;
            ps.WriteInputPoint(0, 0, ref I0_0);
            if(checkBox_Input1.Checked)
            {
                picture1.Image = Properties.Resources.green_circle;
            }
            else if(!checkBox_Input1.Checked) {
                picture1.Image= Properties.Resources.red_circle;
            }
        }

        private void checkBox_Input2_CheckedChanged(object sender, EventArgs e)
        {
            object I0_0 = checkBox_Input2.Checked;
            ps.WriteInputPoint(0, 1, ref I0_0);
            if (checkBox_Input2.Checked)
            {
                picture3.Image = Properties.Resources.green_circle;
            }
            else if (!checkBox_Input2.Checked)
            {
                picture3.Image = Properties.Resources.red_circle;
            }
        }

        private void checkBox_Input3_CheckedChanged(object sender, EventArgs e)
        {
            object I0_0 = checkBox_Input3.Checked;
            ps.WriteInputPoint(0, 2, ref I0_0);
            if (checkBox_Input3.Checked)
            {
                picture2.Image = Properties.Resources.green_circle;
            }
            else if (!checkBox_Input3.Checked)
            {
                picture2.Image = Properties.Resources.red_circle;
            }
        }

        private void checkBox_Output_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Output.Checked)
            {
                picture4.Image = Properties.Resources.green_circle;
            }
            else if (!checkBox_Output.Checked)
            {
                picture4.Image = Properties.Resources.red_circle;
            }
        }

        private void comboBox_CPUState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox_CPUState.SelectedItem.ToString();
            ps.SetState(s);
            label_CPU.Text = s;
        }

        private void comboBox_ScanMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox_ScanMode.SelectedItem.ToString();
            if(s == "Single Scan")
            {
                ps.SetScanMode(ScanModeConstants.SingleScan);
            }
            else if(s == "Continious Scan")
            {
                ps.SetScanMode(ScanModeConstants.ContinuousScan);
            }
            label_ScanMode.Text = s;
        }

        private void timer_ReadOutput_Tick(object sender, EventArgs e)
        {
            object Q0_0 = true;
            ps.ReadOutputPoint(0, 0, PointDataTypeConstants.S7_Bit, ref Q0_0);
            checkBox_Output.Checked = (bool)Q0_0;
        }
    }
}