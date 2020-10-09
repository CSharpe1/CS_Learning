using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Getting_Numbers_From_Text_Boxes
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnAnswer_Click(object sender, EventArgs e) {
            int firstTextBoxNumber;
            int seconedTextBoxNumber;
            int anwser;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            seconedTextBoxNumber = int.Parse(tbSecondNumber.Text);

            anwser = firstTextBoxNumber + seconedTextBoxNumber;

            MessageBox.Show(anwser.ToString());
        }

        private void tbSecondNumber_TextChanged(object sender, EventArgs e) {               
        }

        private void btSub_Click(object sender, EventArgs e) {
            int firstTextBoxNumber;
            int seconedTextBoxNumber;
            int anwser;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            seconedTextBoxNumber = int.Parse(tbSecondNumber.Text);

            anwser = firstTextBoxNumber - seconedTextBoxNumber;

            MessageBox.Show(anwser.ToString());
        }

        private void btMult_Click(object sender, EventArgs e) {
            int firstTextBoxNumber;
            int seconedTextBoxNumber;
            int anwser;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            seconedTextBoxNumber = int.Parse(tbSecondNumber.Text);

            anwser = firstTextBoxNumber * seconedTextBoxNumber;

            MessageBox.Show(anwser.ToString());
        }

        private void btDiv_Click(object sender, EventArgs e) {
            int firstTextBoxNumber;
            int seconedTextBoxNumber;
            int anwser;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            seconedTextBoxNumber = int.Parse(tbSecondNumber.Text);

            anwser = firstTextBoxNumber / seconedTextBoxNumber;

            MessageBox.Show(anwser.ToString());
        }
    }
}
