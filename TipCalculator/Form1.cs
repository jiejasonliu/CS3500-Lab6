using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class Form1 : Form {

        // mapping of a field to its dependencies (many textboxes)
        private Dictionary<TextBox, List<TextBox>> dependencies;

        public Form1() {
            dependencies = new Dictionary<TextBox, List<TextBox>>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // add field to button dependency
            if (!dependencies.ContainsKey(TotalAmtField)) {
                dependencies.Add(TotalAmtField, new List<TextBox>());
            }

            // add field to button dependency
            if (!dependencies.ContainsKey(TotalAmtField)) {
                dependencies.Add(TotalAmtField, new List<TextBox>());
            }

            // create dependency based on TotalAmtField :: dependends on TotalBill and TipPct
            dependencies[TotalAmtField].Add(TotalBillField);
            dependencies[TotalAmtField].Add(TipPctField);
        }
        private void ComputeTipBtn_Click(object sender, EventArgs e) {
        }

        private void TotalBillField_TextChanged(object sender, EventArgs e) {
            CheckShouldChange(TotalAmtField, UpdateTotalAndTipGUI);
        }

        private void TipPctField_TextChanged(object sender, EventArgs e) {
            CheckShouldChange(TotalAmtField, UpdateTotalAndTipGUI);
        }

        /// <summary>
        /// Update Tip amt and Total amt in the GUI.
        /// </summary>
        private void UpdateTotalAndTipGUI() {
            // update GUI
            double total = double.Parse(TotalBillField.Text);
            double tipPercentage = double.Parse(TipPctField.Text);

            double tipAmt = tipPercentage * total;
            double totalAmt = total + tipAmt;

            TipField.Text = tipAmt.ToString("0.00");
            TotalAmtField.Text = totalAmt.ToString("0.00");
        }

        /// <summary>
        /// Checks whether the specified field should change based on dependencies.
        /// </summary>
        private void CheckShouldChange(TextBox field, Action action) {
            // perform on each dependency
            foreach (var otherFields in dependencies[field]) {
                if (otherFields.Text == "" || !double.TryParse(otherFields.Text, out var _)) {
                    return;
                }
            }

            action();
        }
    }
}
