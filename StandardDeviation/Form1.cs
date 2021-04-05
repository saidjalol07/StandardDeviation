using System;
using System.Linq;
using System.Windows.Forms;

namespace standarddeviation
{
    public partial class Form1 : Form
    {
        int numFirst = 1;
        int numLast = 10;
        int countStart = 0;
        int countFinish = 10;
        double average;
        int maxStandardIndex;


        double[] averageArray = new double[10];
        double[] averageArray1 = new double[10];
        string[] showDataList = new string[10];

        Random randomNumber = null;
        int[] arrayNumber = null;

        public Form1()
        {
            InitializeComponent();

            arrayNumber = new int[10];
            randomNumber = new Random();
        }

        private void btnSart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ArrayFunction();
        }

        private void ArrayFunction()
        {
            if (countStart < countFinish)
            {
                string showRandomDataNumber = "";
                double sumOfArrayNum = 0;
                double sumPowerNumber = 0;
                string spliteStr = ",";

                // selecting random numbers
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    arrayNumber[i] = randomNumber.Next(numFirst, numLast);

                    sumOfArrayNum += arrayNumber[i];
                    average = sumOfArrayNum / 10;
                    showRandomDataNumber += arrayNumber[i] + spliteStr;
                    double sum = (arrayNumber[i] - average);
                    double powerNumber = Math.Pow(sum, 2);
                    sumPowerNumber += powerNumber;
                }

                double sd = Math.Sqrt(sumPowerNumber / 10);
                listBox.Items.Add(showRandomDataNumber + "    Average : " + average + "    SD: " + sd);
                averageArray[countStart] = average;
                showDataList[countStart] = showRandomDataNumber;

                countStart++;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("====  All Data will be Deleted ======");
            listBox.Items.Clear();
            listBoxMaxSD.Items.Clear();
            listBoxMaxSdArray.Items.Clear();

            timer.Stop();
        }

        private void btnMaxSD_Click(object sender, EventArgs e)
        {
            double sumOfArray = averageArray.Sum();
            double averageOfSumArray = sumOfArray / 10;

            for (int i = 0; i < averageArray.Length; i++)
            {
                averageArray1[i] = Math.Abs(averageArray[i] - averageOfSumArray);
            }

            double maxStandard = averageArray1.Max();
            maxStandardIndex = averageArray1.ToList().IndexOf(maxStandard);

            listBoxMaxSD.Items.Add(maxStandard);
        }

        private void btnMaxSD_Array_Click(object sender, EventArgs e)
        {
            string max_array = showDataList[maxStandardIndex];
            listBoxMaxSdArray.Items.Add(max_array);
        }

        private void ClosingAction(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("=== ARE  YOU SURE TO CLOSE THIS PAGE ===");
        }
    }
}
