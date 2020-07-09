using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel2Csv
{
    public partial class MainForm : Form
    {
        List<string> fileList;

        public MainForm()
        {
            InitializeComponent();

            fileList = new List<string>();
        }

        private void SetList(string[] list, bool add = true)
        {
            if (!add) {
                fileList.Clear();
            }
            fileList.AddRange(list);

            fileListLbx.Items.Clear();
            fileListLbx.Items.AddRange(fileList.ToArray());
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            inputPanel.BackColor = Color.AntiqueWhite;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragLeave(object sender, EventArgs e)
        {
            inputPanel.BackColor = Control.DefaultBackColor;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            inputPanel.BackColor = Control.DefaultBackColor;
            messageLbl.Text = "";
            SetList((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool successful = true;
            foreach (var xl in fileList) {
                successful = Excel2CsvConvertor.SaveAsCsv(xl);
            }
            messageLbl.Text = successful
                ? "Files are saved to the same directory."
                : "Error converting files.";
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            fileListLbx.Items.Clear();
            fileList.Clear();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excel to CSV convertor.\n" +
                "\nRahmanism\n" +
                "https://github.com/Rahmanism/Excel2Csv" +
                "\n\nVersion: 1.0.1\n" +
                "July 8, 2020 - 1399/04/18");
        }

        private void outputLbl_DoubleClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = 
                    "Excel files (*.xslx;*.xls)|*.xlsx;*.xls|All files (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = true,
                Title = "Select some Excel files ..."
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                SetList(openFileDialog.FileNames);
            }
        }
    }
}
