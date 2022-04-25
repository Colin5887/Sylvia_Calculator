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
         if (_operator == 0 && _num1 == 0) {
            _num1 = 0;
         } else if (_operator == 0 && _num1 !=0){
            _num1 = _num1 * 10;
         } else if (_operator != 0 && _num2 == 0){
            _num2 = 0;
         } else if (_operator!=0 && _num2 != 0) {
            _num2 = _num2 * 10;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber1_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 1;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 1;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 1;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 1;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber2_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 2;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 2;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 2;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 2;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber3_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 3;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 3;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 3;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 3;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber4_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 4;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 4;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 4;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 4;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber5_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 5;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 5;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 5;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 5;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber6_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 6;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 6;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 6;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 6;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber7_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 7;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 7;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 7;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 7;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber8_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 8;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 8;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 8;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 8;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
      }

      private void btnNumber9_Click(object sender, EventArgs e) {
         if (_operator == 0 && _num1 == 0) {
            _num1 = 9;
         } else if (_operator == 0 && _num1 != 0) {
            _num1 = _num1 * 10 + 9;
         } else if (_operator != 0 && _num2 == 0) {
            _num2 = 9;
         } else if (_operator != 0 && _num2 != 0) {
            _num2 = _num2 * 10 + 9;
         }

         if (_operator == 0) {
            lblResult.Text = _num1.ToString();
         } else {
            lblResult.Text = _num2.ToString();
         }
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

      private void btnClear_Click(object sender, EventArgs e) {
         _num1 = 0;
         _num2 = 0;
         _operator = 0;
         lblResult.Text = " ";
      }
   }
}
