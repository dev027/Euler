using System;
using System.Windows.Forms;
using Euler.Problems;

namespace Euler
{
    // ReSharper disable once InconsistentNaming
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnProblem001.Click += BtnProblem001_Click;
            btnProblem002.Click += BtnProblem002_Click;
            btnProblem003.Click += BtnProblem003_Click;
            btnProblem004.Click += BtnProblem004_Click;
            btnProblem005.Click += BtnProblem005_Click;
            btnProblem006.Click += BtnProblem006_Click;
            btnProblem007.Click += BtnProblem007_Click;
        }

        private void BtnProblem001_Click(object sender, EventArgs e)
        {
            new Problem001().Display();
        }
        private void BtnProblem002_Click(object sender, EventArgs e)
        {
            new Problem002().Display();
        }
        private void BtnProblem003_Click(object sender, EventArgs e)
        {
            new Problem003().Display();
        }
        private void BtnProblem004_Click(object sender, EventArgs e)
        {
            new Problem004().Display();
        }
        private void BtnProblem005_Click(object sender, EventArgs e)
        {
            new Problem005().Display();
        }
        private void BtnProblem006_Click(object sender, EventArgs e)
        {
            new Problem006().Display();
        }
        private void BtnProblem007_Click(object sender, EventArgs e)
        {
            new Problem007().Display();
        }
    }
}