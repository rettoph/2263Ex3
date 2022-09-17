using System.Text;

namespace Rettoph2263Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Task 1
        private void Task1Submit_Click(object sender, EventArgs e)
        {
            string input = this.Task1Input.Text;
            string output = Task1.NumSwap(input);

            this.Task1Input.Text = output;
        }

        private void Task1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Task1Input.Text = this.Task1ListBox.Text;
        }
        #endregion

        #region Task 2
        private void Task2Submit_Click(object sender, EventArgs e)
        {
            string inputString = this.Task2Input.Text;
            decimal input = decimal.Parse(inputString);

            string output = Task2.DigitsRightOfDecimal(input);

            this.Task2Output.Text = "Output: " + output;
        }
        #endregion

        #region Task 3
        private void Task3Submit_Click(object sender, EventArgs e)
        {
            // Split the input on comma
            string[] inputStrings = this.Task3Input.Text.Split(',');
            // Create a buffer array to hold out parsed ints
            int[] input = new int[inputStrings.Length];
            
            // Convert the input array of strings into an array of ints
            // You could also use LINQ or Array.ConvertAll
            for(var i=0; i<input.Length; i++)
            { 
                // Parse each input string to an int and add them to the int array
                input[i] = int.Parse(inputStrings[i]);
            }

            // Reverse the array
            Task3.ReverseArray(input, 0);

            string output = string.Join(',', input);

            this.Task3Output.Text = "Output: " + output;
        }
        #endregion

        #region Task 4
        private void Task4Submit_Click(object sender, EventArgs e)
        {
            int size = int.Parse(this.Task4Input.Text);

            int[] randomInts = Task4.RandomInts(size);

            string output = Task4.IntArrayToString(randomInts);

            this.Task4Output.Text = "Output: " + output;
        }
        #endregion

        private void Task5Submit_Click(object sender, EventArgs e)
        {
            string input1 = this.Task5Input1.Text;
            string input2 = this.Task5Input2.Text;

            bool output = Task5.CompareStringChars(input1, input2);

            this.Task5Output.Text = "Output: " + output;
        }

        private void Task6Submit_Click(object sender, EventArgs e)
        {
            int squareSize = int.Parse(this.Task6Input.Text);

            int[,] square = Task6.Random2DSquare(squareSize);

            int[,] flipped = Task6.Flip2DSquare(square);

            StringBuilder squareOutput = new StringBuilder();
            StringBuilder flippedOutput = new StringBuilder();

            for(int x=0; x< squareSize; x++)
            {
                for (int y = 0; y < squareSize; y++)
                {
                    squareOutput.Append(square[x, y].ToString("00") + " ");
                    flippedOutput.Append(flipped[x, y].ToString("00") + " ");
                }

                squareOutput.Append("\n");
                flippedOutput.Append("\n");
            }

            string output = "Input Square:\n" + squareOutput.ToString() + "\nFlipped Square:\n" + flippedOutput.ToString();

            MessageBox.Show(output);
        }

        private void Task8Submit_Click(object sender, EventArgs e)
        {
            int squareSize = int.Parse(this.Task8Input.Text);

            string[,] square = Task8.Random2DStringArray(squareSize, squareSize);

            int average = Task8.Average2DStringArray(square);

            StringBuilder squareOutput = new StringBuilder();

            for (int x = 0; x < squareSize; x++)
            {
                for (int y = 0; y < squareSize; y++)
                {
                    squareOutput.Append(square[x, y] + " ");
                }

                squareOutput.Append("\n");
            }

            string output = "Average: " + average + "\nChar: " + (char)average + "\n" + squareOutput.ToString();

            MessageBox.Show(output);
        }

        private void Task10Submit_Click(object sender, EventArgs e)
        {
            // Split the input on comma
            string[] inputStrings = this.Task10Input.Text.Split(',');
            // Create a buffer array to hold out parsed ints
            int[] input = new int[inputStrings.Length];

            // Convert the input array of strings into an array of ints
            // You could also use LINQ or Array.ConvertAll
            for (var i = 0; i < input.Length; i++)
            {
                // Parse each input string to an int and add them to the int array
                input[i] = int.Parse(inputStrings[i]);
            }

            int output = Task10.SumArray(input);

            this.Task10Output.Text = "Output: " + output;
        }
    }
}