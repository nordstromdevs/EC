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

namespace StreamReader_writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnLoad_Click(object sender, EventArgs e)
        {
            // open file into textbox
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadFile(dlg.FileName);
            }
        }

        private void LoadFile(string path)
        {
            _txtInputOutput.Clear();

            StreamReader reader = new StreamReader(path);

            string line;

            while((line = reader.ReadLine()) != null)
            {
                _txtInputOutput.Text += line + Environment.NewLine;
            }

            reader.Close();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(dlg.FileName);
            }
        }

        private void SaveToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);

            foreach (var line in _txtInputOutput.Lines)
                writer.WriteLine(line);

            writer.Close();
        }
    }
}
