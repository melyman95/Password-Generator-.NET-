using System;

namespace My_Password_Generator_CSharp
{
    public partial class PWGenForm : Form
    {
        public PWGenForm()
        {
            InitializeComponent();
        }

        public string getLengthText
        {
            get { return enterLengthBox.Text; }
        }

        public string setPasswordBox
        {
            set {PWGenBox.Text = value; }
        }

        public bool getLower
        {
            get { return lowerCheck.Checked; }
        }

        public bool getUpper
        {
            get { return upperCheck.Checked; }
        }

        public bool getSpecial
        {
            get { return specialCharsCheck.Checked; }
        }

        public bool getNumbers
        {
            get { return numberCheck.Checked; }
        }

        static int getLength(ref string str)
        {
            return str.Length;
        }

        static string generatePassword(ref int length, string chars, Random r)
        {
            string password = "";
            for (int i = 0; i < length; i++)
            {
                int num = r.Next(0, chars.Length);
                password += chars[num];
            }
            return password;
        }

        private void PWGenerateButton_Click(object sender, EventArgs e)
        {
            string desiredLength = getLengthText;
            int num;
            bool isNumber = int.TryParse(desiredLength, out num);

            Random rand = new Random();
            string charsTotal = "";
            string charsLower = "abcdefghijklmnopqrstuvwxyz";
            string charsUpper = charsLower.ToUpper();
            string numbers = "123456789";
            string specialChars = "!@#$%^&*()";

            if (lowerCheck.Checked == true)
            {
                charsTotal += charsLower;
            }

            if (upperCheck.Checked == true)
            {
                charsTotal += charsUpper;
            }

            if (numberCheck.Checked == true)
            {
                charsTotal += numbers;
            }

            if (specialCharsCheck.Checked == true)
            {
                charsTotal += specialChars;
            }

            if (charsTotal.Length == 0)
            {
                displayError(3);
                return;
            }

            if (desiredLength != "")
            {
                int length = (int)Int64.Parse(desiredLength);
                if (isNumber == true)
                {
                    if (length >= 8 && length <= 31)
                    {
                        string pw = generatePassword(ref length, charsTotal, rand);
                        PWGenBox.Text = pw;
                    }
                    else
                    {
                        displayError(0);
                    }
                }
                else
                {
                    displayError(1);
                }
            }
            else
            {
                displayError(2);
            }
        }

        public static void displayError(int errorType)
        {
            switch (errorType)
            {
                case 0:
                    MessageBox.Show("Invalid input, password must be between 8 and 31 characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case 1:
                    MessageBox.Show("Invalid input, field must be numeric.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case 2:
                    MessageBox.Show("Invalid input, field cannot be empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Media.SystemSounds.Hand.Play();
                    break;
                case 3:
                    MessageBox.Show("You must check at least one box.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
            }
        } 
    }
}