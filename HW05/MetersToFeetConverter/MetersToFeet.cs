using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetersToFeetConverter
{
    public partial class MetersToFeet : Form
    {
        public MetersToFeet()
        {
            InitializeComponent();
        }

        private readonly int _maxValueLength = 10;
        private string _valueToConvert = string.Empty;
        private readonly char _comma = ',';

        private void AssignNum(Button button)
        {
            if (_valueToConvert.Length >= _maxValueLength)
                return;

            _valueToConvert += button.Text;

            UpdateMeters();
            UpdateFeet();
        }


        private void UpdateMeters()
        {
            MetersField.Text = _valueToConvert;
        }

        private void UpdateFeet()
        {
            var valueToConvert = Convert.ToDouble(_valueToConvert);
            var feet = valueToConvert * 3.280839895d;

            FeetField.Text = feet.ToString().Substring(0, _maxValueLength);
        }


        private void AssignZero()
        {
            _valueToConvert = string.Empty;
            MetersField.Text = "0";
            FeetField.Text = "0";
        }

        #region Buttons

        private void Button1_Click(object sender, EventArgs e) => AssignNum(Button1);

        private void Button2_Click(object sender, EventArgs e) => AssignNum(Button2);

        private void Button3_Click(object sender, EventArgs e) => AssignNum(Button3);

        private void Button4_Click(object sender, EventArgs e) => AssignNum(Button4);

        private void Button5_Click(object sender, EventArgs e) => AssignNum(Button5);

        private void Button6_Click(object sender, EventArgs e) => AssignNum(Button6);

        private void Button7_Click(object sender, EventArgs e) => AssignNum(Button7);

        private void Button8_Click(object sender, EventArgs e) => AssignNum(Button8);
        
        private void Button9_Click(object sender, EventArgs e) => AssignNum(Button9);

        private void Button0_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length < 1)
                return;

            AssignNum(Button0);
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Contains(_comma))
                return;

            AssignNum(ButtonComma);
        }

        private void ButtonClear_Click(object sender, EventArgs e) => AssignZero();

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length <= 1)
            {
                AssignZero();
                return;
            }

            _valueToConvert = _valueToConvert.Remove(_valueToConvert.Length - 1, 1);
            UpdateMeters();
            UpdateFeet();
        }

        #endregion

     

    }
}
