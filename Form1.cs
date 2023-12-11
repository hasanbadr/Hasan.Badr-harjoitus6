namespace Hasan.Badr_harjoitus6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Hasan" && SalasanaTB.Text == "Ha@09n")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}