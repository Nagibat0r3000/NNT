using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _1
{
    public partial class Form : System.Windows.Forms.Form
    {
        Saves saves = new Saves();
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SC(BNEW);
            SC(BCONT);
        }

        private void NewGame(object sender, EventArgs e)
        {
            saves.NewFile();
        }

        private void ContinueGame(object sender, EventArgs e)
        {
            this.Controls.Remove((sender as Control));//временно
        }
        public void SC(object sender)//ShowControl
        {
            Control c = (sender as Control);
            c.Visible = true;
            c.Location = new Point(c.Location.X - 1000, c.Location.Y);
        }
    }
    public class Saves
    {
        public void NewFile()
        {
            string dir = @"C:\Games\NNT";
            Directory.CreateDirectory(dir);
        }
    }
}
