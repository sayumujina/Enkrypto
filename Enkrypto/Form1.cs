
using System.Windows.Forms.VisualStyles;
using System;
using System.Xml;
namespace Enkrypto
{
    public partial class Enkrypto : Form
    {
        public Enkrypto()
        {
            InitializeComponent();
        }

        // Initialize variables 
        private string inputString; // Input string
        public string InputString
        {
            get => inputString;
            set => inputString = value;
        }
        private int shiftingValue; // How much the value will be shifted
        public int ShiftingValue
        {
            get => shiftingValue;
            set => shiftingValue = value;
        }

        //Set a flag to check if the input is valid
        public static bool IsInputValid = true;

        //
        public static string[] Output = new string[3];
        // String processing class
        class StringProcessing
        {

            // Check if the string is not empty, contains 40 characters or less and only has capital letters
            // Check if the number is between -25 and 25 or not
            public static (string, string) CheckInput(string InputString, int ShiftingValue)
            {
                // Initialize the error messages
                string StringErrorMessage = "";
                string IntegerErrorMessage = "";

                if (InputString.Length <= 40
                    && InputString != ""
                    && InputString.All(char.IsUpper) == true
                    // Counts 51 numbers from -25, which is the range from -25 to 25
                    && Enumerable.Range(-25, 51).Contains(ShiftingValue))
                {
                    IsInputValid = true;
                    return (StringErrorMessage, IntegerErrorMessage);
                }
                else
                {
                    if (InputString == "")
                    {
                        StringErrorMessage = "Please enter a string.";
                    }
                    if (InputString.Length > 40)
                    {
                        StringErrorMessage = "The input string must contain 40 characters or less.";
                    }
                    if (InputString.All(char.IsUpper) == false)
                    {
                        StringErrorMessage = "The input string must contain only capital letters.";
                    }
                    if (Enumerable.Range(-25, 51).Contains(ShiftingValue) == false)
                    {
                        IntegerErrorMessage = "The shifting value must be between -25 and 25.";
                    }
                    IsInputValid = false;
                }
                return (StringErrorMessage, IntegerErrorMessage);
            }

            // Encode the input string
            private static string Encode(string InputString, int ShiftingValue)
            {
                // Empty the output string first (in case the function is called multiple times)
                string OutputString = "";
                // Loop through each value in the input string
                foreach (char c in InputString)
                {
                    // Convert the input string into ASCII values
                    int InputAsciiValue = (int)c;
                    int OutputAsciiValue = InputAsciiValue + ShiftingValue;
                    // Shift the ASCII value based on the input shifting value
                    // If the value exceeds the range of capital letters (65 - 90), loop back to the beginning
                    if (OutputAsciiValue < 65)
                    {
                        OutputAsciiValue += 26; // Alphabet has 26 letters
                    }
                    else if (OutputAsciiValue > 90)
                    {
                        OutputAsciiValue -= 26;
                    }
                    // Convert the output ASCII value back to a character value and add it to the output string
                    char OutputChar = (char)OutputAsciiValue;
                    OutputString += OutputChar;
                }
                // Set the label text to output string
                return OutputString;
            }

            // Print the output string
            public static string Print(string InputString, int ShiftingValue)
            {
                return Encode(InputString, ShiftingValue);
            }
            // Return an array containing the integer of each character of the input string
            public static int[] InputCode(string InputString)
            {
                int[] ConvertedInputCode = new int[InputString.Length];
                // Loop through each character in the input string and convert it to an integer
                for (int i = 0; i < InputString.Length; i++)
                {
                    ConvertedInputCode[i] = (int)InputString[i];
                }
                return ConvertedInputCode;
            }

            // Return an array containing the integer of each character of the output string
            public static int[] OutputCode(string OutputString)
            {
                int[] ConvertedOutputCode = new int[OutputString.Length];
                // Loop through each character in the output string and convert it to an integer
                for (int i = 0; i < OutputString.Length; i++)
                {
                    ConvertedOutputCode[i] = (int)OutputString[i];
                }
                return ConvertedOutputCode;
            }
            // Sort the input string in alphabetical order
            public static string Sort(string InputString)
            {
                // Convert the input string to a character array
                char[] InputArray = InputString.ToCharArray();
                // Sort the character array
                Array.Sort(InputArray);
                // Convert the sorted character array back to a string
                string SortedString = new string(InputArray);
                return SortedString;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Starts listen to the SubmitButton button being clicked
            // Initialize the labels text
            if (SubmitButton != null && StringContainer != null)
            {
                SubmitButton.Click += (sender, e) => SubmitButton_Click(sender, e);
                this.KeyPreview = true; // Ensure the form captures key events
                this.KeyDown += (sender, e) => IsEnterKeyDown(sender, e);
            }
            InputString = "";
            SubmitLabel.Text = "";
            OutputTextBox.Text = "";
            StringErrorLabel.Text = "";
            IntegerErrorLabel.Text = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
            DisplayOutputs(sender, e);
        }

        private void IsEnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutputTextBox.Text = "";
                DisplayOutputs(sender, e);
            }
        }
        private void DisplayOutputs(object? sender, EventArgs e)
        {

            // Assign the values to the variables
            InputString = StringContainer.Text;
            if (int.TryParse(IntegerContainer.Text, out int shiftingValue))
            {
                ShiftingValue = shiftingValue;
            }
            else
            {
                IntegerErrorLabel.Text = "Please enter a valid integer. ";
                IsInputValid = false;
            }

            // Call the checkString function
            StringProcessing.CheckInput(InputString, ShiftingValue);

            // Reset the error messages
            StringErrorLabel.Text = "";
            IntegerErrorLabel.Text = "";

            // If the input is invalid, return to avoid further processing
            if (IsInputValid == false)
            {
                // Reset the flag
                IsInputValid = true;
                SubmitLabel.Text = "Cannot process the input. Please re-enter the input.";
                // Display the error messages if it exists
                if (StringProcessing.CheckInput(InputString, ShiftingValue).Item1 != "")
                {
                    StringErrorLabel.Text = StringProcessing.CheckInput(InputString, ShiftingValue).Item1;
                }
                if (StringProcessing.CheckInput(InputString, ShiftingValue).Item2 != "")
                {
                    IntegerErrorLabel.Text = StringProcessing.CheckInput(InputString, ShiftingValue).Item2;
                }
                SubmitLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                SubmitLabel.Text = "The input is valid.";
                SubmitLabel.ForeColor = System.Drawing.Color.Green;
            }

            // Call the encode function and set the output label to the output string
            OutputTextBox.Text += "The ASCII value of the input code is: ";
            foreach (int i in StringProcessing.InputCode(InputString))
            {
                OutputTextBox.Text += i.ToString() + " ";
            }
            OutputTextBox.Text += "\r\n" + "The output code is: " + StringProcessing.Print(InputString, ShiftingValue);
            OutputTextBox.Text += "\r\n" + "The ASCII value of the output code is: ";
            foreach (int i in StringProcessing.OutputCode(StringProcessing.Print(InputString, ShiftingValue)))
            {
                OutputTextBox.Text += i.ToString() + " ";
            }
            // Call the sortString function 
            OutputTextBox.Text += "\r\n" + "The sorted string is: " + StringProcessing.Sort(InputString);
        }

    }
}
