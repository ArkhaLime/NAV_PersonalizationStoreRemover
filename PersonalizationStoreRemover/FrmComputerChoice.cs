using System;
using System.Windows.Forms;
using Res = PersonalizationStoreRemover.Resources.Resources;

namespace PersonalizationStoreRemover
{
    public partial class FrmComputerChoice : Form
    {
        private ComputerChoice _choice;

        public FrmComputerChoice(ComputerChoice choice)
        {
            InitializeComponent();
            Localize();

            _choice = choice;

            radLocal.Checked = _choice.UseLocalComputer;
            txtComputerName.Text = _choice.RemoteComputerName;

            //this.DialogResult = DialogResult.Cancel;
        }

        private void ActivateControls()
        {
            txtComputerName.Enabled = radRemote.Checked;
            bool isRemoteEmpty = string.IsNullOrWhiteSpace(txtComputerName.Text);

            bool useLocal = radLocal.Checked;
            bool useRemote = radRemote.Checked && !isRemoteEmpty;

            btnValidation.Enabled = useLocal || useRemote;
        }

        private void radLocal_CheckedChanged(object sender, EventArgs e)
        {
            ActivateControls();
        }

        private void txtComputerName_TextChanged(object sender, EventArgs e)
        {
            ActivateControls();
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            _choice.UseLocalComputer = radLocal.Checked;
            if (!radLocal.Checked)
            {
                _choice.RemoteComputerName = txtComputerName.Text;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Localize()
        {
            Text = Res.Title_FrmComputerChoice;
            radLocal.Text = Res.Radio_LocalComputer;
            radRemote.Text = Res.Radio_RemoteComputer;
            lblRemoteName.Text = Res.Label_Name;
            lblMessageCShare.Text = Res.Text_MessageCShare;
            btnValidation.Text = Res.Button_Validate;
        }
    }
}
