using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyDraw
{
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }
        Form1 _parentForm;
        public FrmOption(Form1 parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        private void FrmSetup_Load(object sender, EventArgs e)
        {
            cbbTypeOfNumber.SelectedIndex = _parentForm.TypeOfNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _parentForm.TypeOfNumber = cbbTypeOfNumber.SelectedIndex;
            _parentForm.ExcelFile = txtFilePath.Text;
            this.Close();
        }

        private void txtFilePath_MouseDown(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
