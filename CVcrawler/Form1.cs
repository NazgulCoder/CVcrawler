using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CVcrawler
{
    public partial class Form1 : Form
    {
        private readonly string path = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
        }
        private string checkRightFolder()
        {
            if (!Directory.Exists(path + "\\ImageMagick"))
            {
                return "ImageMagick";
            }
            if (!Directory.Exists(path + "\\Tesseract-OCR"))
            {
                return "Tesseract-OCR";
            }
            return "all good";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkRightFolder() != "all good")
            {
                MessageBox.Show("Error, Cannot find " + checkRightFolder());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultList.Items.Add("ok dio porco");
        }

        private void tutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Copy all the CVs you want to analyze into CVs (PDF Only)" + Environment.NewLine
                + "- Click Analyze Button and wait it to finish" + Environment.NewLine
                + "- Search any keyword, you can then doubleclick on the result", "TUTORIAL");
        }

        private void AnalyzeBtn_Click(object sender, EventArgs e)
        {
            
            int executed = 0;
            int failed = 0;
            foreach (string file in Directory.GetFiles(path + "\\CVs"))
            {
                try
                {
                    string[] fileonly = file.Split('\\');
                    int index = fileonly.Length - 1;
                    string toExec = path + "\\ImageMagick\\convert -density 300 "
                        + path + "\\CVs\\" + fileonly[index] + " -depth 8 -background white -alpha Off "
                        + path + "\\crawled\\" + fileonly[index] + ".tiff";

                    Interaction.Shell(toExec);
                    executed++;
                } catch
                {
                    failed++;
                }
            }
            MessageBox.Show("Analyze process completed. Successfully converted into pictures " + executed + " files. Failed " + failed + " files.");

          }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            int executed = 0;
            int failed = 0;
            foreach (string file in Directory.GetFiles(path + "\\crawled"))
            {
                try
                {
                    string[] fileonly = file.Split('\\');
                    int index = fileonly.Length - 1;
                    string toExec = path + "\\Tesseract-OCR\\tesseract "
                        + path + "\\crawled\\" + fileonly[index] + " "
                        + path + "\\CVsRead\\" + fileonly[index];

                    Interaction.Shell(toExec);
                    executed++;
                }
                catch
                {
                    failed++;
                }
            }
            MessageBox.Show("Extrapolation process completed. Successfully Extracted text from " + executed + " pictures. Failed " + failed + " files.");
        }
    }
}
