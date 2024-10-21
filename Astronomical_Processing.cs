/*Caio guilherme Ferreirada da Silva
 * 
 */

using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Astronomical_Processing
{
    public partial class Astronomical_Processing : Form
    {
        private int[] data;
        private bool sortData = false;

        public Astronomical_Processing()
        {
            InitializeComponent();
            InitializeData();
            NeutrinoList();
        }

        private void InitializeData()
        {
            Random rand = new Random();
            data = new int[24];
            for (int i = 0; i < data.Length; i++)
                data[i] = rand.Next(10, 91);
        }

        private void NeutrinoList()
        {
            neutrinoList.Items.Clear(); // Clear existing items
            foreach (var value in data)
            {
                neutrinoList.Items.Add(value); // Add current values to the ListBox
            }
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (neutrinoList.SelectedIndex >= 0)
            {
                int index = neutrinoList.SelectedIndex; // Get selected index
                if (int.TryParse(editBar.Text, out int newValue))
                {
                    data[index] = newValue; // Update the data at the selected index
                    if (newValue >= 10 && newValue <= 90)
                    {
                        UpdateNeutrinoList(); // Refresh the display
                        MessageBox.Show($"Item at index {index + 1} has been changed to {newValue}.");
                        sortData = false;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a integer between 10 and 90");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer value.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBar.Text))//Show error if it's null space
            {
                MessageBox.Show("Error: Search box cannot be empty.");
                return;
            }
            if (int.TryParse(searchBar.Text, out int searchValue))
            {
                //Check the list is sorted
                if (sortData == true)
                {
                    int index = BinarySearch(data, searchValue);
                    if (index >= 0)
                    {
                        MessageBox.Show($"Search successful: Value found at index {index + 1}.");
                    }
                    else
                    {
                        MessageBox.Show("Error: Value not found.");
                    }
                }
                //Ask to sort list
                else
                {
                    MessageBox.Show("Error: Please sort data first.");
                }
            }
            else
            {
                MessageBox.Show("Error: Please enter a valid integer.");
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort(data);
            MessageBox.Show("Data sorted successfully.");
            UpdateNeutrinoList(); // Update ListBox after sorting
            sortData = true;
        }

        private void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;
            bool sortData;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap temp and array[j]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                        sortData = true;
                    }
                }
                // If no two elements were swapped in the inner loop, then the array is already sorted
                if (!swapped)
                    break;
            }
        }

        private int BinarySearch(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if value is present at mid 
                if (array[mid] == value)
                    return mid;

                // If value greater, ignore left half 
                if (array[mid] < value)
                    left = mid + 1;

                // If value is smaller, ignore right half 
                else
                    right = mid - 1;
            }

            // Value not present 
            return -1;
        }

        private void UpdateNeutrinoList()
        {
            neutrinoList.Items.Clear();
            foreach (var value in data)
            {
                neutrinoList.Items.Add(value); // Update the ListBox with the sorted or updated data
            }
        }

        private void BtnMidExtreme_Click(object sender, EventArgs e)
        {
            int min = data.Min();
            int max = data.Max();
            double midExtreme = (min + max) / 2.0;
            toolStripStatusLabel2.Text = $"Mid-extreme is: {midExtreme.ToString("F2")}";
        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            var mode = data.GroupBy(x => x)
                           .OrderByDescending(g => g.Count())
                           .First().Key;
            toolStripStatusLabel2.Text = $"Mode is: {mode.ToString()}";
        }

        private void BtnAvg_Click(object sender, EventArgs e)
        {
            double avg = data.Average();
            toolStripStatusLabel2.Text = $"Average is: {avg.ToString("F2")}";
        }

        private void BtnRange_Click(object sender, EventArgs e)
        {
            int range = data.Max() - data.Min();
            toolStripStatusLabel2.Text = $"Range is: {range.ToString()}";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBar.Text))
            {
                MessageBox.Show("Error: Search box cannot be empty.");
                return;
            }

            if (int.TryParse(searchBar.Text, out int searchValue))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == searchValue)
                    {
                        toolStripStatusLabel2.Text = $"Search successful: Value found at index {i}.";
                        return;
                    }
                }
                toolStripStatusLabel2.Text = $"Error: Value not found.";
            }
            else
            {
                toolStripStatusLabel2.Text = $"Error: Please enter a valid integer.";
            }
        }

        private void btnSequentialSort_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] > data[i + 1])
                {
                    int temp = data[i];
                    data[i] = data[i + 1];
                    data[i + 1] = temp;
                }
            }
            UpdateNeutrinoList();
            toolStripStatusLabel2.Text = $"Data sorted sequentially.";
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            neutrinoList.Items.Clear();
            InitializeData();
            UpdateNeutrinoList();
        }
    }
}

