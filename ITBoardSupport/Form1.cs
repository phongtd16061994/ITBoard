namespace ITBoardSupport
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (tb_DisplayName.Text == "")
            {
                MessageBox.Show("Recheck Display Name");
            }
            else if (tb_Username.Text == "")
            {
                MessageBox.Show("Recheck Username");
            }
            else if (tb_Password.Text == "")
            {
                MessageBox.Show("Recheck Password");
            }
            else if (dtp_OB.Value <= DateTime.Now)
            {
                MessageBox.Show("Recheck day On Board");
            }
            else if (chb_Gentlement.CheckState == CheckState.Unchecked && chb_Lady.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Recheck Gender");
            }
            else if (chb_Gentlement.CheckState == CheckState.Checked && chb_Lady.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Recheck Gender");
            }
            else if (chb_Dev.CheckState == CheckState.Unchecked && chb_AnotherRole.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Recheck Role");
            }
            else if (chb_Dev.CheckState == CheckState.Checked && chb_AnotherRole.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Recheck Role");
            }
            else
            {
                print_welcomenote();
                print_hrnotify();
            }
        }
        public void print_welcomenote()
        {
            string gender = "";
            if (chb_Gentlement.CheckState == CheckState.Checked)
            {
                gender = "Mr.";
            }
            else
            {
                gender = "Ms.";
            }
            rtb_WelcomeNote.Text = "Hi "+gender+""+tb_DisplayName.Text+ ", \n\n" +
                "By the time you read this message, you have become a DevBlocker.\n" +
                "It is great pleasure to have you with us on this journey and we hope you will have a pleasant experience.\n" +
                "This is your laptop, the default password is 123456, you must change it soon due to security problem.\n\n" +
                "Your account Office365 : \n" +
                "\tDisplay Name:   " + tb_DisplayName.Text + "\n"+
                "\tUsername      :    " + tb_Username.Text+ "@devblock.net\n" +
                "\tPassword       :    " + tb_Password.Text+ "\n\n" +
                "Now, you need to access : https://outlook.office.com/mail/ to login account. This link contains your mailbox, calendar, onedrive, etc.\n" +
                "After that, you need to login Teams using Office365 to communicate with your fellow DevBlockers.\n" +
                "For further enquires on work software, contact your Project Manager, Line Manager or team member. \n" +
                "Password Wifi : DevBlocker@2019\n" +
                "Once again welcome to DevBlock :) .\n\n" +
                "Warm Regards.\n" +
                "IT Team.";
        }
        public void print_hrnotify()
        {
            string role="";
            if (chb_Dev.CheckState == CheckState.Checked)
            {
                role = "\thttps://bitbucket.org/vinasource/\n";
            }
            tb_MailTo.Text = "DevBlockOpsTeam@devblocknet.onmicrosoft.com";
            tb_CcTo.Text = "trucpt@devblock.net;nholu@devblock.net";
            tb_ContentMail.Text = "Account "+ tb_Username.Text + " Is Ready - On Board On "+ dtp_OB.Text;
            rtb_Email.Text = "Dear all,\n \n" +
                "Account " + tb_Username.Text + " is ready now, " + tb_Username.Text + " can access:\n " +
                "\thttps://outlook.office.com/mail/\n" +
                "\thttps://devblock.atlassian.net/jira/your-work\n" +
                "" + role +
                "\thttps://www.ninety.io/\n"+
                "IT Team will send login information when " + tb_Username.Text + " comes to DevBlock." +
                "If we have missed anything please feel free to ask.\n \n" +
                "Warm Regards.\n" +
                "PhongTD.";

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com");
        }
    }

}