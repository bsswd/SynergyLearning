using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricImperialConverter
{
    public partial class FormImpToMetConverter : Form
    {
        private int _maxValueLength = 10;
        private string _valueToConvert = string.Empty;
        private readonly char _comma = ',';

        private bool _mPressed = false;
        private bool _kmPressed = false;
        private bool _cmPressed = false;
        private bool _ftPressed = false;


        public FormImpToMetConverter()
        {
            InitializeComponent();
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

        private void ButtonMSelect_Click(object sender, EventArgs e)
        {
            _mPressed = true;
            _ftPressed = false;
            _cmPressed = false;
            _kmPressed = false;
        }

        private void ButtonFtSelect_Click(object sender, EventArgs e)
        {
            _mPressed = false;
            _ftPressed = true;
            _cmPressed = false;
            _kmPressed = false;
        }

        private void ButtonCmSelect_Click(object sender, EventArgs e)
        {
            _mPressed = false;
            _ftPressed = false;
            _cmPressed = true;
            _kmPressed = false;
        }

        private void ButtonKmSelect_Click(object sender, EventArgs e)
        {
            _mPressed = false;
            _ftPressed = false;
            _cmPressed = false;
            _kmPressed = true;
        }

        private void ButtonClear_Click(object sender, EventArgs e) => AssignZero();

        private void ButtonBackSpace_Click(object sender, EventArgs e)
        {
            if (_valueToConvert.Length <= 1 )
            {
                AssignZero();
                return;
            }

            _valueToConvert = _valueToConvert.Remove(_valueToConvert.Length - 1,1);
            UpdateCurrentField();
        }

        #endregion

        private void AssignNum(Button button)
        {
            while ((_kmPressed || _cmPressed || _ftPressed || _mPressed) == false)
                return;

            if (_valueToConvert.Length >= _maxValueLength)
                return;

            _valueToConvert += button.Text;
            UpdateCurrentField();
        }

        private void UpdateCurrentField()
        {

            if(_mPressed)
            {
                MetersField.Text = _valueToConvert;
                

            }
            if (_ftPressed)
                FootsField.Text = _valueToConvert;
            if (_cmPressed)
                CentimetersField.Text = _valueToConvert;
            if (_kmPressed)
                KilometersField.Text = _valueToConvert;
        }

        private void AssignZero()
        {
            _valueToConvert = string.Empty;
            MetersField.Text = "0";
            KilometersField.Text = "0";
            FootsField.Text = "0";
            CentimetersField.Text = "0";
        }
    }
}
