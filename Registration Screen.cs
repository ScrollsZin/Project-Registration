using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Registration
{
    // Registration form class definition
    public partial class Frm_Registration_Screen : Form
    {
        // Form constructor, where the components and key events for each TextBox are initialized
        public Frm_Registration_Screen()
        {
            InitializeComponent();

            // Sets the KeyDown event for each text field
            Txt_Name.KeyDown += Txt_Name_KeyDown;
            Txt_Last_Name.KeyDown += Txt_Last_Name_KeyDown;
            Txt_Age.KeyDown += Txt_Age_KeyDown;
            Txt_Neighborhood.KeyDown += Txt_Neighborhood_KeyDown;
            Txt_Number.KeyDown += Txt_Number_KeyDown;
            Txt_Email.KeyDown += Txt_Email_KeyDown;
        }

        // "Name" button click event to display the contents of the Txt_Name text field in Lbl_Result
        private void Btn_Name_Click(object sender, EventArgs e)
        {
            Lbl_Result.Text = Txt_Name.Text;
            Lbl_Result.Visible = true;
        }

        // "Last Name" button click event to display the contents of the Txt_Last_Name text field in Lbl_Result
        private void Btn_Last_Name_Click(object sender, EventArgs e)
        {
            Lbl_Result.Text = Txt_Last_Name.Text;
            Lbl_Result.Visible = true;
        }

        // "Age" button click event to display the contents of the Txt_Age text field in Lbl_Result
        private void Btn_Age_Click(object sender, EventArgs e)
        {
            // Add the word "years" after the age
            Lbl_Result.Text = Txt_Age.Text + " years";
            Lbl_Result.Visible = true;
        }

        // "Neighborhood" button click event to display the contents of the Txt_Neighborhood text field in Lbl_Result
        private void Btn_Neighborhood_Click(object sender, EventArgs e)
        {
            Lbl_Result.Text = Txt_Neighborhood.Text;
            Lbl_Result.Visible = true;
        }

        // "Number" button click event to display the contents of the Txt_Number text field in Lbl_Result
        private void Btn_Number_Click(object sender, EventArgs e)
        {
            Lbl_Result.Text = Txt_Number.Text;
            Lbl_Result.Visible = true;
        }

        // "Email" button click event to display the contents of the Txt_Email text field in Lbl_Result
        private void Btn_Email_Click(object sender, EventArgs e)
        {
            Lbl_Result.Text = Txt_Email.Text;
            Lbl_Result.Visible = true;
        }

        // "Complete Data" button click event to display all data filled in Lbl_Result
        private void Btn_Complete_Data_Click(object sender, EventArgs e)
        {
            Lbl_Result.Text = Txt_Name.Text + " " + Txt_Last_Name.Text + "\n " + Txt_Age.Text + " years" + "\n " + Txt_Neighborhood.Text + "\n " + Txt_Number.Text + "\n " + Txt_Email.Text;
            Lbl_Result.Visible = true;
        }

        // Event to change theme to default (Rad_Standard)
        private void Rad_Standard_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the background image
            BackgroundImage = Properties.Resources.Standard;

            // Change Label colors to default when returning to "Theme Standard"
            Lbl_Personal_Data.ForeColor = Color.Magenta;
            Lbl_Name.ForeColor = Color.Crimson;
            Lbl_Last_Name.ForeColor = Color.Crimson;
            Lbl_Age.ForeColor = Color.Crimson;
            Lbl_Neighborhood.ForeColor = Color.Crimson;
            Lbl_Number.ForeColor = Color.Crimson;
            Lbl_Email.ForeColor = Color.Crimson;
            Lbl_Data_Confirmation.ForeColor = Color.Crimson;
            Lbl_Result.ForeColor = Color.Crimson;

            // Change Button Colors to Default When Returning to "Theme Standard"
            Btn_Activate.ForeColor = Color.Black;
            Btn_Disable.ForeColor = Color.Black;
            Btn_Clean.ForeColor = Color.Black;

            // Change GroupBox colors to default when returning to "Theme Standard"
            Grp_Backgrounds.ForeColor = Color.Black;

            // Change RadioButton colors to default when returning to "Theme Standard"
            Rad_Standard.ForeColor = Color.Black;
            Rad_Theme_1.ForeColor = Color.Black;
            Rad_Theme_2.ForeColor = Color.Black;
            Rad_Theme_3.ForeColor = Color.Black;
        }

        // Event to change theme to "Theme 1"
        private void Rad_Theme_1_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the background image
            BackgroundImage = Properties.Resources.Theme_1;

            // Changes Button colors to Gold when clicking "Theme 1"
            Btn_Activate.ForeColor = Color.Gold;
            Btn_Disable.ForeColor = Color.Gold;
            Btn_Clean.ForeColor = Color.Gold;

            // Changes the GroupBox colors to Gold when clicking on "Theme 1"
            Grp_Backgrounds.ForeColor = Color.Gold;

            // Changes RadioButton colors to Gold when clicking on "Theme 1"
            Rad_Standard.ForeColor = Color.Gold;
            Rad_Theme_1.ForeColor = Color.Gold;
            Rad_Theme_2.ForeColor = Color.Gold;
            Rad_Theme_3.ForeColor = Color.Gold;
        }

        // Event to change theme to "Theme 2"
        private void Rad_Theme_2_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the background image
            BackgroundImage = Properties.Resources.Theme_2;

            // Changes Button colors to white when clicking "Theme 2"
            Btn_Activate.ForeColor = Color.White;
            Btn_Disable.ForeColor = Color.White;
            Btn_Clean.ForeColor = Color.White;

            // Changes GroupBox colors to white when clicking "Theme 2"
            Grp_Backgrounds.ForeColor = Color.White;

            // Changes the RadioButton colors to white when clicking on "Theme 2"
            Rad_Standard.ForeColor = Color.White;
            Rad_Theme_1.ForeColor = Color.White;
            Rad_Theme_2.ForeColor = Color.White;
            Rad_Theme_3.ForeColor = Color.White;
        }

        // Event to change theme to "Theme 3"
        private void Rad_Theme_3_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the background image
            BackgroundImage = Properties.Resources.Theme_3;

            // Changes the Labels colors to white when clicking on "Theme 3"
            Lbl_Personal_Data.ForeColor = Color.White;
            Lbl_Name.ForeColor = Color.White;
            Lbl_Last_Name.ForeColor = Color.White;
            Lbl_Age.ForeColor = Color.White;
            Lbl_Neighborhood.ForeColor = Color.White;
            Lbl_Number.ForeColor = Color.White;
            Lbl_Email.ForeColor = Color.White;
            Lbl_Data_Confirmation.ForeColor = Color.White;
            Lbl_Result.ForeColor = Color.White;

            // Changes button colors to white when clicking "Theme 3"
            Btn_Activate.ForeColor = Color.White;
            Btn_Disable.ForeColor = Color.White;
            Btn_Clean.ForeColor = Color.White;

            // Changes GroupBox colors to white when clicking "Theme 3"
            Grp_Backgrounds.ForeColor = Color.White;

            // Changes the RadioButton colors to white when clicking on "Theme 3"
            Rad_Standard.ForeColor = Color.White;
            Rad_Theme_1.ForeColor = Color.White;
            Rad_Theme_2.ForeColor = Color.White;
            Rad_Theme_3.ForeColor = Color.White;
        }

        // Event to activate the form (enable all fields and buttons)
        private void Btn_Activate_Click(object sender, EventArgs e)
        {
            // Enables all controls on the form
            Grp_Backgrounds.Enabled = true;
            Rad_Standard.Enabled = true;
            Rad_Theme_1.Enabled = true;
            Rad_Theme_2.Enabled = true;
            Rad_Theme_3.Enabled = true;
            Lbl_Personal_Data.Enabled = true;
            Lbl_Name.Enabled = true;
            Lbl_Last_Name.Enabled = true;
            Lbl_Age.Enabled = true;
            Lbl_Neighborhood.Enabled = true;
            Lbl_Number.Enabled = true;
            Lbl_Email.Enabled = true;
            Lbl_Data_Confirmation.Enabled = true;
            Lbl_Result.Enabled = true;
            Txt_Name.Enabled = true;
            Txt_Last_Name.Enabled = true;
            Txt_Age.Enabled = true;
            Txt_Neighborhood.Enabled = true;
            Txt_Number.Enabled = true;
            Txt_Email.Enabled = true;
            Btn_Name.Enabled = true;
            Btn_Last_Name.Enabled = true;
            Btn_Age.Enabled = true;
            Btn_Neighborhood.Enabled = true;
            Btn_Number.Enabled = true;
            Btn_Email.Enabled = true;
            Btn_Complete_Data.Enabled = true;
            Btn_Activate.Enabled = false; // Disables the activation button
            Btn_Disable.Enabled = true;

            // Focus on the "Txt_Name" text field
            Txt_Name.Focus();
        }

        // Event to disable the form (disable all fields and buttons)
        private void Btn_Disable_Click(object sender, EventArgs e)
        {
            // Disables all controls on the form
            Grp_Backgrounds.Enabled = false;
            Rad_Standard.Enabled = false;
            Rad_Theme_1.Enabled = false;
            Rad_Theme_2.Enabled = false;
            Rad_Theme_3.Enabled = false;
            Lbl_Personal_Data.Enabled = false;
            Lbl_Name.Enabled = false;
            Lbl_Last_Name.Enabled = false;
            Lbl_Age.Enabled = false;
            Lbl_Neighborhood.Enabled = false;
            Lbl_Number.Enabled = false;
            Lbl_Email.Enabled = false;
            Lbl_Data_Confirmation.Enabled = false;
            Lbl_Result.Enabled = false;
            Txt_Name.Enabled = false;
            Txt_Last_Name.Enabled = false;
            Txt_Age.Enabled = false;
            Txt_Neighborhood.Enabled = false;
            Txt_Number.Enabled = false;
            Txt_Email.Enabled = false;
            Btn_Name.Enabled = false;
            Btn_Last_Name.Enabled = false;
            Btn_Age.Enabled = false;
            Btn_Neighborhood.Enabled = false;
            Btn_Number.Enabled = false;
            Btn_Email.Enabled = false;
            Btn_Complete_Data.Enabled = false;
            Btn_Activate.Enabled = true;
            Btn_Disable.Enabled = false; // Disable the disable Button
        }

        // Event to clear text fields and disable the clear button
        private void Btn_Clean_Click(object sender, EventArgs e)
        {
            Txt_Name.Clear();
            Txt_Last_Name.Clear();
            Txt_Age.Clear();
            Txt_Neighborhood.Clear();
            Txt_Number.Clear();
            Txt_Email.Clear();
            Btn_Clean.Enabled = false; // Desabilita o botão de limpar
            Lbl_Result.Visible = false; // Esconde o resultado
        }

        // Event to detect changes in "Txt_Name" field and enable/disable clear button
        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            Btn_Clean.Enabled = Txt_Name.Text != ""; // Enables the clear button when there is text
        }

        // Event to detect changes in "Txt_Last_Name" field and enable/disable clear button
        private void Txt_Last_Name_TextChanged(object sender, EventArgs e)
        {
            Btn_Clean.Enabled = Txt_Last_Name.Text != "";
        }

        // Event to detect changes in "Txt_Age" field and enable/disable clear button
        private void Txt_Age_TextChanged(object sender, EventArgs e)
        {
            Btn_Clean.Enabled = Txt_Age.Text != "";
        }

        // Event to detect changes in "Txt_Neighborhood" field and enable/disable clear button
        private void Txt_Neighborhood_TextChanged(object sender, EventArgs e)
        {
            Btn_Clean.Enabled = Txt_Neighborhood.Text != "";
        }

        // Event to detect changes in "Txt_Number" field and enable/disable clear button
        private void Txt_Number_TextChanged(object sender, EventArgs e)
        {
            Btn_Clean.Enabled = Txt_Number.Text != "";

            // Prevents infinite TextChanged calls
            if (Txt_Number.Focused)
            {
                string text = Txt_Number.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                if (text.Length > 11) // Limit to 11 characters
                {
                    text = text.Substring(0, 11);
                }

                // Format according to the number of characters
                if (text.Length >= 2)
                {
                    text = $"({text.Substring(0, 2)}) {text.Substring(2)}";
                }

                if (text.Length > 9)
                {
                    text = $"{text.Substring(0, 9)}-{text.Substring(9)}";
                }

                // Updates the field text with formatting
                Txt_Number.Text = text;

                // Move o cursor para o final
                Txt_Number.SelectionStart = Txt_Number.Text.Length;
            }

        }

        // Event to detect changes in "Txt_Name" field and enable/disable clear button
        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            Btn_Clean.Enabled = Txt_Email.Text != "";
        }

        // Event to ensure only numbers are entered into the "Txt_Age" field
        private void Txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13)
            {
                e.Handled = true; // Prevents typing of non-numeric characters
                MessageBox.Show("Only Numbers Allowed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Function to ensure only numbers in the "Txt_Number" field
        private void Txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the key pressed is ENTER, do nothing
            if (e.KeyChar == (char)13) return;

            // Allows only numbers, parentheses, hyphen and the backspace key
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-')
            {
                e.Handled = true; // Blocks input of any other character
                MessageBox.Show("Only Numbers, Parentheses and Hyphen Allowed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Message if the user enters other characters
            }
        }

        // Function to advance between text fields when the Enter key is pressed
        private void Txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_Name.Text != "")
            {
                Txt_Last_Name.Focus();
            }
        }

        // Function to advance between text fields when the Enter key is pressed
        private void Txt_Last_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_Last_Name.Text != "")
            {
                Txt_Age.Focus();
            }
        }

        // Function to advance between text fields when the Enter key is pressed
        private void Txt_Age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_Age.Text != "")
            {
                Txt_Neighborhood.Focus();
            }
        }

        // Function to advance between text fields when the Enter key is pressed
        private void Txt_Neighborhood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_Neighborhood.Text != "")
            {
                Txt_Number.Focus();
            }
        }

        // Function to advance between text fields when the Enter key is pressed
        private void Txt_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_Number.Text != "")
            {
                Txt_Email.Focus();
            }
        }

        // Function to advance between text fields when the Enter key is pressed
        private void Txt_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_Email.Text != "")
            {
                Btn_Complete_Data.Focus();
            }
        }
    }
}
