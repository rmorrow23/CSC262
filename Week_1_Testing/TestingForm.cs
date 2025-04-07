using System.Diagnostics;
namespace Week_1_Testing
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
        }
        public void btnStart_Click(object sender, EventArgs e)
        {
            //clear list
            listArray.Items.Clear();
            
            //change button text to show that the array is being created
            btnStart.Text = "Generating";

            generateArray();

            //change button text back to original
            btnStart.Text = "Start Testing";
        }

        public void generateArray()
        {
            //check if the textbox is empty before running the code
            if (string.IsNullOrEmpty(txtInt.Text))
            {
                //prompts the user to fill in the textbox before continuing
                MessageBox.Show("Please enter an integer before clicking start!");
            }
            else
            {
                if (Convert.ToInt32(txtInt.Text) <= 10000 & Convert.ToInt32(txtInt.Text) > 0)
                {


                    //Create a timer to keep track of the amount of time the code is running
                    Stopwatch stopwatch = new Stopwatch();
                    //Start the timer
                    stopwatch.Start();
                    //the size of the array, multiplied by 10 to account for high performance computer
                    int intSize = int.Parse(txtInt.Text) * 10;

                    //create the array
                    int[] ints = new int[intSize];

                    //random numbers
                    Random rndInt = new Random();

                    //create the loop to time the amount of time needed to run the code

                    for (int i = 0; i < intSize; i++)
                    {
                        //add random integer to the array, integers will be between 0 and 1000
                        ints[i] = rndInt.Next(0, 1000);

                        //add delay to account for my high performance computer
                        Thread.Sleep(10);

                    }
                    stopwatch.Stop();


                    //display messagebox with elapsed time and calculate actual time based on number of delays used
                    MessageBox.Show("Elapsed time to generate numbers with delay: " + stopwatch.ElapsedMilliseconds + "ms"
                    + Environment.NewLine + "Elapsed time to generate numbers without delay: " + (stopwatch.ElapsedMilliseconds - (10 * intSize)) + "ms");



                    stopwatch.Restart();

                    //sort the array
                    Array.Sort(ints);
                    stopwatch.Stop();
                    int[] sortedInts = new int[ints.Length];

                    //display messagebox with elapsed time and calculate actual time based on number of delays used
                    MessageBox.Show("Elapsed time to sort Array: " + stopwatch.ElapsedMilliseconds + "ms");

                    //loop to display the sorted array
                    for (int i = 0; i < ints.Length - 1; i++)
                    {
                        sortedInts[i] = ints[i];
                        //add the array item to the listview
                        listArray.Items.Add(sortedInts[i].ToString());
                    }


                }
                else
                {
                    MessageBox.Show("Please ensure the number entered is between 1 and 10000");
                }
            }
        }
    }
}
