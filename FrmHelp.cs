using System;
using System.Windows.Forms;

namespace MediaButtonsSend
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            TxtValues.Text = string.Join(Environment.NewLine, Enum.GetNames(typeof(AppCommandValues)));
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
