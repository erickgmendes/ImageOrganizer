namespace ImageOrganizer
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            HabilitarBtnOrganize();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOrganize_Click(object sender, EventArgs e)
        {
            var organizer = new Organizer();
            var lista = organizer.GetFileList(TxtOrigin.Text);
            progressBar1.Maximum = lista.Count;

            foreach (var file in lista.ToList())
            {
                organizer.Do(TxtOrigin.Text, TxtTarget.Text, file, LstStatus);
                LstStatus.Update();
                LstStatus.Refresh();
                progressBar1.Increment(1);
            }

            //MessageBox.Show("Fim");
        }

        private void BtnOrigin_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                TxtOrigin.Text = folderBrowserDialog1.SelectedPath;
            }

            HabilitarBtnOrganize();
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                TxtTarget.Text = folderBrowserDialog1.SelectedPath;
            }

            HabilitarBtnOrganize();
        }

        private void HabilitarBtnOrganize()
        {
            progressBar1.Value = 0;
            BtnOrganize.Enabled = !string.IsNullOrWhiteSpace(TxtOrigin.Text) && !string.IsNullOrWhiteSpace(TxtTarget.Text);
        }
    }
}