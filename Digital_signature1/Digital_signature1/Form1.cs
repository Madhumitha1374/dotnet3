using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;



namespace Digital_signature1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string folderPath;
        ArrayList arrayList = new ArrayList();
        ArrayList NoDigSignList = new ArrayList();
        private void btn_bwse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = dialog.SelectedPath;
                textBox1.Text = folderPath;
            }
        }

        //private void btnCheckSignatures_Click(object sender, EventArgs e)
        //{
        //    DirectoryInfo place = new DirectoryInfo(folderPath);
        //    arrayList.Clear(); // Clear the array list before populating with new file names

        //    // Recursively search for DLL files in the selected folder and its subfolders
        //    CheckDirectory(place);

        //    // Store the results in an Excel file
        //    storeInExcel();
        //}

        //private void CheckDirectory(DirectoryInfo place)
        //{
        //    if (place.GetDirectories() != null)
        //    {
        //        foreach (DirectoryInfo directoryInfo in place.GetDirectories())
        //        {
        //            CheckDirectory(directoryInfo);
        //        }

        //        foreach (FileInfo file in place.GetFiles("*.dll"))
        //        {
        //            arrayList.Add(file.FullName);
        //        }
        //    }
        //}
        //private void storeInExcel()
        //{
        //    Application excelApp = new Application();
        //    Workbook workbook = excelApp.Workbooks.Add();
        //    Worksheet worksheet = workbook.Sheets[1];
        //    worksheet.Cells[1, 1] = "DLL Files";
        //    worksheet.Cells[1, 2] = "Digitally Signed";

        //    int rowIndex = 2; // Start from row 2 for data

        //    foreach (string filePath in arrayList)
        //    {
        //        bool isSigned = CheckDigitalSignature(filePath);
        //        string fileName = Path.GetFileName(filePath);

        //        worksheet.Cells[rowIndex, 1] = fileName;
        //        worksheet.Cells[rowIndex, 2] = isSigned ? "YES" : "NO";

        //        rowIndex++;
        //    }

        //    excelApp.Visible = true;
        //}
        private bool CheckDigitalSignature(string filePath)
        {
            try
            {
                X509Certificate cert = X509Certificate.CreateFromSignedFile(filePath);
                return cert != null;
            }
            catch
            {
                return false; // Failed to load certificate or file is not digitally signed
            }
        }

        private void btn_gtsgntr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Please select a folder first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Cells[1, 1] = "DLL Files";
            worksheet.Cells[1, 2] = "Digitally Signed";

            int rowIndex = 2; // Start from row 2 for data

            DirectoryInfo place = new DirectoryInfo(folderPath);
            foreach (FileInfo file in place.GetFiles("*.dll", SearchOption.AllDirectories))
            {
                bool isSigned = CheckDigitalSignature(file.FullName);
                worksheet.Cells[rowIndex, 1] = file.Name;
                worksheet.Cells[rowIndex, 2] = isSigned ? "YES" : "NO";
                if(isSigned == false)
                {
                    NoDigSignList.Add(file.FullName);
                }
                rowIndex++;
            }
            excelApp.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
