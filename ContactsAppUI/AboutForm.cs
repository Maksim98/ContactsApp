using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailLinkLabel.Links[EmailLinkLabel.Links.IndexOf(e.Link)].Visited = true; 
            System.Diagnostics.Process.Start("www.mail.ru");
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GithubLinkLabel.Links[GithubLinkLabel.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start("www.github.com/Maksim98/ContactsApp/");
        }

        private void AboutForm_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
