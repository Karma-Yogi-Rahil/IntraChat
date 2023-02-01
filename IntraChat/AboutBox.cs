


namespace IntraChat
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            DeveloperLabel.Text = Constants.DeveloperName;
            VersionLabel.Text = System.Windows.Forms.Application.ProductVersion;


        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
