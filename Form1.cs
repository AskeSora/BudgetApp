namespace BudgetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double husleje = 0;
        private string strHusleje = "";
        private double internet = 0;
        private string strinternet = "";
        private double ekstraF�lles1 = 0;
        private string strEkstraF�lles1 = "";
        private double ekstraF�lles2 = 0;
        private string strEkstraF�lles2 = "";
        private double f�llesUdgiftBetalere = 1;
        private string strF�llesUdgiftBetalere = "";
        private double f�llesTotal = 0;
        private string strF�llesTotal = "";
        private double individuelTotal = 0;
        private string strIndividuelTotal = "";

        private double personligtBudget = 0;
        private string strPersonligtBudget = "";
        private double forsikringer = 0;
        private string strForsikringer = "";
        private double abonnementer = 0;
        private string strAbonnementer = "";
        private double benzin = 0;
        private string strBenzin = "";
        private double opsparing = 0;
        private string strOpsparing = "";
        private double ekstraUdgift1 = 0;
        private string strEkstraUdgift1 = "";
        private double ekstraUdgift2 = 0;
        private string strEkstraUdgift2 = "";
        private double antalUger = 0;
        private string strAntalUger = "";
        private double madbudget = 0;
        private string strMadbudget = "";
        private double ugentligtMadbudget = 0;
        private string strUgentligMadbudget = "";
        private double buffer = 0;
        private string strBuffer = "";


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strHusleje = ValHusleje.Text;
            if (double.TryParse(strHusleje, out husleje))
            {
                husleje = Convert.ToDouble(strHusleje);
            }
            else
            {
                husleje = 0;
            }
            CalculatePersonalBudget();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ValInternet_TextChanged(object sender, EventArgs e)
        {
            string strInternet = ValInternet.Text;
            if (double.TryParse(strInternet, out internet))
            {
                internet = Convert.ToDouble(strInternet);
            }
            else
            {
                internet = 0;
            }
            CalculatePersonalBudget();
        }

        private void ValL�n_TextChanged(object sender, EventArgs e)
        {
            string strPersonligtBudget = ValL�n.Text;
            if (double.TryParse(strPersonligtBudget, out personligtBudget))
            {
                personligtBudget = Convert.ToDouble(strPersonligtBudget);
            }
            else
            {
                personligtBudget = 0;
            }
            CalculatePersonalBudget();
        }

        private void ValF�llesUdgift1_TextChanged(object sender, EventArgs e)
        {
            string strEkstraF�lles1 = ValF�llesUdgift1.Text;
            if (double.TryParse(strEkstraF�lles1, out ekstraF�lles1))
            {
                ekstraF�lles1 = Convert.ToDouble(strEkstraF�lles1);
            }
            else
            {
                ekstraF�lles1 = 0;
            }
            CalculatePersonalBudget();
        }

        private void ValF�llesUdgift2_TextChanged(object sender, EventArgs e)
        {
            string strEkstraF�lles2 = ValF�llesUdgift2.Text;
            if (double.TryParse(strEkstraF�lles2, out ekstraF�lles2))
            {
                ekstraF�lles2 = Convert.ToDouble(strEkstraF�lles2);
            }
            else
            {
                ekstraF�lles2 = 0;
            }
            CalculatePersonalBudget();
        }

        private void ValDelF�lles_TextChanged(object sender, EventArgs e)
        {
            string strF�llesUdgiftBetalere = ValDelF�lles.Text;
            if (double.TryParse(strF�llesUdgiftBetalere, out f�llesUdgiftBetalere))
            {
                f�llesUdgiftBetalere = Convert.ToDouble(strF�llesUdgiftBetalere);
            }
            else
            {
                f�llesUdgiftBetalere = 1;
            }
            CalculatePersonalBudget();
        }

        /*private void btnUdregn_Click(object sender, EventArgs e)
        {
            double f�llesTotal = (husleje + internet + ekstraF�lles1 + ekstraF�lles2);
            string strF�llesTotal = f�llesTotal.ToString();
            ValTotalF�lles.Text = strF�llesTotal;

            double individuelTotal = (f�llesTotal / f�llesUdgiftBetalere);
            string strIndividuelTotal = individuelTotal.ToString();
            ValF�llesPrPerson.Text = strIndividuelTotal;
            ValMineF�lles.Text = strIndividuelTotal;
        }*/
        
        private void CalculatePersonalBudget()
        {
            double f�llesTotal = (husleje + internet + ekstraF�lles1 + ekstraF�lles2);
            string strF�llesTotal = f�llesTotal.ToString();
            ValTotalF�lles.Text = strF�llesTotal;

            double individuelTotal = (f�llesTotal / f�llesUdgiftBetalere);
            string strIndividuelTotal = individuelTotal.ToString();
            ValF�llesPrPerson.Text = strIndividuelTotal;
            ValMineF�lles.Text = strIndividuelTotal;

            buffer = (personligtBudget - individuelTotal - forsikringer - abonnementer - benzin - opsparing - madbudget - ekstraUdgift1 - ekstraUdgift2);
            strBuffer = buffer.ToString();
            ValBuffer.Text = strBuffer;
        }

        private void ValForsikringer_TextChanged(object sender, EventArgs e)
        {
            string strForsikringer = ValForsikringer.Text;
            if (double.TryParse(strForsikringer, out forsikringer))
            {
                forsikringer = Convert.ToDouble(strForsikringer);
            }
            else
            { forsikringer = 0; }
            CalculatePersonalBudget();
        }

        private void ValAbonnementer_TextChanged(object sender, EventArgs e)
        {
            string strAbonnementer = ValAbonnementer.Text;
            if (double.TryParse(strAbonnementer, out abonnementer))
            {
                abonnementer = Convert.ToDouble(strAbonnementer);
            }
            else { abonnementer = 0; }
            CalculatePersonalBudget();
        }

        private void ValBenzin_TextChanged(object sender, EventArgs e)
        {
            string strBenzin = ValBenzin.Text;
            if (double.TryParse(strBenzin, out benzin))
            {
                benzin = Convert.ToDouble(strBenzin);
            }
            else { benzin = 0; }
            CalculatePersonalBudget();
        }

        private void OpsparingVal_TextChanged(object sender, EventArgs e)
        {
            string strOpsparing = ValOpsparing.Text;
            if (double.TryParse(strOpsparing, out opsparing))
            {
                opsparing = Convert.ToDouble(strOpsparing);
            }
            else { opsparing = 0; }
            CalculatePersonalBudget();
        }

        private void ValEkstraUdgift1_TextChanged(object sender, EventArgs e)
        {
            string strEkstraUdgift1 = ValEkstraUdgift1.Text;
            if (double.TryParse(strEkstraUdgift1, out ekstraUdgift1))
            {
                ekstraUdgift1 = Convert.ToDouble(strEkstraUdgift1);
            }
            else { ekstraUdgift1 = 0; }
            CalculatePersonalBudget();
        }

        private void ValEkstraUdgift2_TextChanged(object sender, EventArgs e)
        {
            string strEkstraUdgift2 = ValEkstraUdgift2.Text;
            if (double.TryParse(strEkstraUdgift2, out ekstraUdgift2))
            {
                ekstraUdgift2 = Convert.ToDouble(strEkstraUdgift2);
            }
            else { ekstraUdgift2 = 0; }
            CalculatePersonalBudget();
        }

        private void ValAntalUger_TextChanged(object sender, EventArgs e)
        {
            string strAntalUger = ValAntalUger.Text;
            if (double.TryParse(strAntalUger, out antalUger))
            {
                antalUger = Convert.ToDouble(strAntalUger);
            }
            else
            {
                antalUger = 1;
            }
            ugentligtMadbudget = (madbudget / antalUger);
            strUgentligMadbudget = ugentligtMadbudget.ToString();
            ValUgentligtMadbudget.Text = strUgentligMadbudget;
        }

        private void ValMadbudget_TextChanged(object sender, EventArgs e)
        {
            string strMadbudget = ValMadbudget.Text;
            if (double.TryParse(strMadbudget, out madbudget))
            {
                madbudget = Convert.ToDouble(strMadbudget);
            }
            else { madbudget = 0; }
            CalculatePersonalBudget();
        }
    }
}
