namespace DinnerPartyPlannerV2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthDayParty birthDayParty;
        public void DisplayBirtdayParty()
        {

            labelCost2.Text = birthDayParty.Cost.ToString();

        }
        public void DisplayDinnerParty()
        {
            labelCost1.Text = dinnerParty.Cost.ToString();
        }
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberOfPepleSet1.Value, fancyDecorations1.Checked, healthyOption.Checked);
            DisplayDinnerParty();
            birthDayParty = new BirthDayParty((int)numberOfPepleSet2.Value, fancyDecorations2.Checked, cakeWritingLabel.Text);
            DisplayBirtdayParty();
        }

        private void numberOfPepleSet2_ValueChanged(object sender, EventArgs e)
        {
            birthDayParty.NumberOfPeople = (int)numberOfPepleSet2.Value;
            DisplayBirtdayParty();
        }

        private void fancyDecorations2_CheckedChanged(object sender, EventArgs e)
        {
            birthDayParty.FancyDecorations = fancyDecorations2.Checked;
            DisplayBirtdayParty();
        }

        private void cakeWritingLabel_TextChanged(object sender, EventArgs e)
        {
            birthDayParty.CakeWriting = cakeWritingLabel.Text;
            labelWritingToLong.Visible = birthDayParty.CakeToLong();
            DisplayBirtdayParty();
        }

        private void numberOfPepleSet1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPepleSet1.Value;
            DisplayDinnerParty();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyOption.Checked;
            DisplayDinnerParty();
        }

        private void fancyDecorations1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDecorations1.Checked;
            DisplayDinnerParty();
        }
    }
}