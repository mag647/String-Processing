using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace chap08_stringprocessing
{
    public partial class Form1 : Form
    {
        private string dateOfHireString = "";
        private int totRecordsProcessed = 0;
        private string firstNameString = "";
        private string lastNameString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputTextFile;
            string InputRecord;
            OpenFileDialog OpenTextFileDialog = new OpenFileDialog();

            // Customize the appearance of the open file dialog box for comma-delimited (.csv)
            // or fixed-width (.txt) text files.
            if (FileTypeCheckBox.Checked == true)
            {
                OpenTextFileDialog.InitialDirectory = "c:\\";
                OpenTextFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                OpenTextFileDialog.FilterIndex = 1;
                //OpenTextFileDialog.RestoreDirectory = true;
            }
            else
            {
                OpenTextFileDialog.InitialDirectory = "c:\\";
                OpenTextFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                OpenTextFileDialog.FilterIndex = 1;
                //OpenTextFileDialog.RestoreDirectory = true;
            }

            try
            {
                // Display the common dialog box and let the user specify the desired file
                // to process.
                if (OpenTextFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open the selected file.
                    inputTextFile = File.OpenText(OpenTextFileDialog.FileName);

                    // Loop through the selected file.
                    while (!inputTextFile.EndOfStream)
                    {
                        InputRecord = inputTextFile.ReadLine();
                        if (FileTypeCheckBox.Checked == true)
                        {
                            MessageBox.Show(ProcessCommaDel(InputRecord));
                        }
                        else
                        {
                            MessageBox.Show(ProcessFixedWidth(InputRecord));
                        }
                    }
                    // Close the selected file.
                    inputTextFile.Close();

                    // output the total records counter.
                    MessageBox.Show("Total records processed: " + totRecordsProcessed.ToString());
                    totRecordsProcessed = 0;

                }
                else
                {
                    //output the total records counter.
                    MessageBox.Show("Total records processed: " + totRecordsProcessed.ToString());
                    totRecordsProcessed = 0;

                    return;
                }
            }
            catch (Exception ErrorException)
            {
                MessageBox.Show("An unexpected error occured of: " +
                    ErrorException.Message);
            }
        }

        private string ProcessCommaDel(string CommaDelString)
        {
            char[] delimitingChar = { ',' };

            string[] tokensInCommaDelString = CommaDelString.Split(delimitingChar);
            if (tokensInCommaDelString.Length == 1)
            {
                return "(Only a single string was found.)";
            }
            else
            {
                firstNameString = tokensInCommaDelString[0];
                lastNameString = tokensInCommaDelString[1];
                dateOfHireString = tokensInCommaDelString[2];

                // Trim the leading and trailing quotations marks.
                firstNameString = firstNameString.Substring(1, firstNameString.Length - 2);
                lastNameString = lastNameString.Substring(1, lastNameString.Length - 2);
                dateOfHireString = dateOfHireString.Substring(1, dateOfHireString.Length - 2);

                // Increment the totatl records counter.
                totRecordsProcessed = totRecordsProcessed + 1;

                return (lastNameString.Trim() +
                    ", " + firstNameString.Trim() +
                    " - " + dateOfHireString);

                /* old code
                 * FirstNameString = FirstNameString.Substring(1, FirstNameString.Length - 1);
                FirstNameString = FirstNameString.Substring(0, FirstNameString.Length - 1);
                LastNameString = LastNameString.Substring(1, LastNameString.Length - 1);
                LastNameString = LastNameString.Substring(0, LastNameString.Length - 1);
                DateOfHireString = DateOfHireString.Substring(1, DateOfHireString.Length - 1);
                DateOfHireString = DateOfHireString.Substring(0, DateOfHireString.Length - 1);
                return (LastNameString + ", " + FirstNameString + " - " + DateOfHireString); */
            }
           /* else
            {
                return "(No tokens found.)";
            }*/
        }

        private string ProcessFixedWidth(string FixedWidthString)
        {
            firstNameString = FixedWidthString.Substring(0, 15);
            lastNameString = FixedWidthString.Substring(15, 15);
            dateOfHireString = FixedWidthString.Substring(30, 10);

            // Increment the totatl records counter.
            totRecordsProcessed = totRecordsProcessed + 1;

            return (lastNameString.Trim() +
                ", " + firstNameString.Trim() +
                " - " + dateOfHireString);
            /*
             *Code from old version
             * string FirstNameString = "";
            string LastNameString = "";
            string DateOfHireString = "";

            FirstNameString = FixedWidthString.Substring(0, 15);
            LastNameString = FixedWidthString.Substring(15, 15);
            DateOfHireString = FixedWidthString.Substring(30, 10);
            return (LastNameString.Trim() + ", " + FirstNameString.Trim() + " - " + DateOfHireString);*/
        }
    }
}
