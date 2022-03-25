using System;
using System.Text.RegularExpressions;

namespace TestandoRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtRodar_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            string text = "lucas.silva@101_192.168.5.100";
            MatchCollection matches = rx.Matches(text);
            System.Diagnostics.Debug.WriteLine(matches[0]);
            System.Diagnostics.Debug.WriteLine("Salve salve");
           
        }
    }
}