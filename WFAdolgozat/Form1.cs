namespace WFAdolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PirosLabel.Click += SzinLabelClick;
            ZoldLabel.Click += SzinLabelClick;
            KekLabel.Click += SzinLabelClick;

            AlaphelyzetButton.Click += AlaphelyzetButton_Click;

            KilepesButton.Click += KilepesButton_Click;

        }


        private void koszonjButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nevTextBox.Text))
            {
                string koszones = $"Szia, {nevTextBox.Text} !";
                udvozlesLabel.Text = koszones;
            }
            else
            {
                MessageBox.Show("Kérlek, add meg a nevedet!");
            }
        }


        private void SzinLabelClick(object sender, EventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                this.BackColor = clickedLabel.BackColor;
            }
        }

        private void AlaphelyzetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void KilepesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}