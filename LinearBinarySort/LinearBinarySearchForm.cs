using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearBinarySort
{
    public partial class LinearBinarySearchForm : Form
    {
        public LinearBinarySearchForm()
        {
            InitializeComponent();
        }

        List<double> numberList = new List<double>();

        #region Event Handlers

        #region Submit Button
        private void submitButton_Click(object sender, EventArgs e)
        {
            numberList.Add(Double.Parse(numberTextBox.Text));
            numberListBox.Items.Add(numberTextBox.Text);
            numberTextBox.SelectAll();

            sortedUnsortedLabel.Text = "Unsorted";
        }
        #endregion

        #region Clear All Button
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Clear();
            numberList.Clear();
            sortedUnsortedLabel.Text = "";
            indexLabel.Text = "Index:";
            numberTextBox.Clear();
            keyTextBox.Clear();
        }
        #endregion

        #region Linear Search Button
        private void linearButton_Click(object sender, EventArgs e)
        {
            int index = LinearSearch(numberList, Double.Parse(keyTextBox.Text));
            indexLabel.Text = "Index: " + index;

            numberListBox.Items.Clear();
            foreach (double i in numberList)
            {
                numberListBox.Items.Add(i);
            }

            if (index > 0)
            {
                numberListBox.SetSelected(index, true);
            }
            else
            {
                numberListBox.ClearSelected();
            }

            sortedUnsortedLabel.Text = "Unsorted";
        }
        #endregion

        #region Binary Search Button
        private void binaryButton_Click(object sender, EventArgs e)
        {
            int index = BinarySearch(numberList, Double.Parse(keyTextBox.Text));
            indexLabel.Text = "Index: " + index;

            numberListBox.Items.Clear();
            List<double> sortedList = new List<double>(numberList);
            sortedList.Sort();

            foreach (double i in sortedList)
            {
                numberListBox.Items.Add(i);
            }

            if (index > 0)
            {
                numberListBox.SetSelected(index, true);
            }
            else
            {
                numberListBox.ClearSelected();
            }

            sortedUnsortedLabel.Text = "Sorted";
        }
        #endregion

        #endregion


        #region Procedures

        #region Linear Search
        private int LinearSearch (List<double> numberList, double key)
        {
            int index = -1;

            for (int i = 0; i < numberList.Count; i++)
            {
                if (key == numberList[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        #endregion

        #region Binary Search
        private int BinarySearch(List<double> numberList, double key)
        {
            List<double> sortedList = new List<double>(numberList);
            sortedList.Sort();

            int prevLowerBound = -1;
            int lowerBound = 0;
            int upperBound = sortedList.Count - 1;

            while (lowerBound != prevLowerBound)
            {
                if (key == sortedList[(lowerBound + upperBound) / 2])
                {
                    return (lowerBound + upperBound) / 2;
                }
                else if (key < sortedList[(lowerBound + upperBound) / 2])
                {
                    upperBound = (lowerBound + upperBound) / 2;
                }
                else
                {
                    prevLowerBound = lowerBound;
                    lowerBound = (lowerBound + upperBound) / 2;
                }
            }

            if (sortedList[sortedList.Count-1] == key)
            {
                return sortedList.Count - 1;
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #endregion

    }
}
