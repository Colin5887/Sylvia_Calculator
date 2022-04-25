using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorStudy {
   public partial class Form1 : Form {
      private int _num1 = 0;
      private int _num2 = 0;
      ///public Operator _operator = Operator.Null;
      public int _operator = 0;
      public float operationResult = 0;

      public Form1() {
         InitializeComponent();
      }

      //public enum Operator {
      //   Null,
      //   Add,
      //   Subtraction,
      //   Multiple,
      //   Devision,
      //}

      //public void OperatorSelection() {
      //   switch (_operator) {
      //      case Operator.Null:
      //         break;
      //      case Operator.Add:
      //         break;
      //      case Operator.Subtraction:
      //         break;
      //      case Operator.Multiple:
      //         break;
      //      case Operator.Devision:
      //         break;
      //   }
      //}


      private void btnNumber0_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 0;
         } else {
            _num2 = 0;
         }
         lblResult.Text = "0";
      }

      private void btnNumber1_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 1;
         } else {
            _num2 = 1;
         }
         lblResult.Text = "1";
      }

      private void btnNumber2_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 2;
         } else {
            _num2 = 2;
         }
         lblResult.Text = "2";
      }

      private void btnNumber3_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 3;
         } else {
            _num2 = 3;
         }
         lblResult.Text = "3";
      }

      private void btnNumber4_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 4;
         } else {
            _num2 = 4;
         }
         lblResult.Text = "4";
      }

      private void btnNumber5_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 5;
         } else {
            _num2 = 5;
         }
         lblResult.Text = "5";
      }

      private void btnNumber6_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 6;
         } else {
            _num2 = 6;
         }
         lblResult.Text = "6";
      }

      private void btnNumber7_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 7;
         } else {
            _num2 = 7;
         }
         lblResult.Text = "7";
      }

      private void btnNumber8_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 8;
         } else {
            _num2 = 8;
         }
         lblResult.Text = "8";
      }

      private void btnNumber9_Click(object sender, EventArgs e) {
         if (_operator == 0) {
            _num1 = 9;
         } else {
            _num2 = 9;
         }
         lblResult.Text = "9";
      }

      private void btnNumberPlus_Click(object sender, EventArgs e) {
         _operator = 1;
      }

      private void btnNumberSubtraction_Click(object sender, EventArgs e) {
         _operator = 2;
      }

      private void btnNumberMultiple_Click(object sender, EventArgs e) {
         _operator = 3;
      }

      private void btnNumberSlack_Click(object sender, EventArgs e) {
         _operator = 4;
      }

      private void btnNumberEqual_Click(object sender, EventArgs e) {
         switch (_operator) {
            case 1:
               operationResult = _num1 + _num2;
               break;
            case 2:
               operationResult = _num1 - _num2;
               break;
            case 3:
               operationResult = _num1 * _num2;
               break;
            case 4:
               operationResult = ((float)_num1) / ((float)_num2);
               break;
         }
         lblResult.Text = operationResult.ToString();
      }
   }
}
