namespace WorkshopWindowsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstListe.Items.Add("Caner Mollao�lu");
            MessageBox.Show("Test");
            MessageBox.Show("Deneme");

            List<string> liste = new List<string>();
            liste.Add("�stanbul E�itim Akademi");


        }
    }
}
