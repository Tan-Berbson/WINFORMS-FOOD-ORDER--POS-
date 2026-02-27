using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORMS_FOOD_ORDER__POS_
{
    public partial class frm_reciept : Form
    {
        private readonly List<string[]> _orders;
        private readonly string _manager;
        private readonly string _cashier;
        private readonly string _customer;
        private readonly string _paymentMethod;
        private readonly string _dineType;

        public frm_reciept(List<string[]> orders,
            string manager,
            string cashier,
            string customer,
            string paymentMethod,
            string dineType,
            string total)
        {
            InitializeComponent();
            _orders = orders;
            _manager = manager;
            _cashier = cashier;
            _customer = customer;
            _paymentMethod = paymentMethod;
            _dineType = dineType;

            GenerateReceipt();
        }
        private void GenerateReceipt()
        {
            listBox1.Items.Clear();

            StringBuilder receipt = new StringBuilder();

            receipt.AppendLine("========================================");
            receipt.AppendLine("           Tan_food restaurant          ");
            receipt.AppendLine("              FOOD  POS                 ");
            receipt.AppendLine("========================================");
            receipt.AppendLine($"Date : {DateTime.Now:MM/dd/yyyy hh:mm tt}");
            receipt.AppendLine("-----------------------------------------");
            receipt.AppendLine($"Manager  : {_manager}");
            receipt.AppendLine($"Cashier  : {_cashier}");
            receipt.AppendLine($"Customer : {_customer}");
            receipt.AppendLine($"Dine Type: {_dineType}");
            receipt.AppendLine("----------------------------------------");
            receipt.AppendLine("ITEMS");
            receipt.AppendLine("----------------------------------------");

            decimal grandTotal = 0;

            foreach (var order in _orders)
            {
                string itemName = order[0];
                string addOn = order[1];
                decimal price = decimal.Parse(order[2]);

                grandTotal += price;

                receipt.AppendLine(itemName);

                if (!string.IsNullOrWhiteSpace(addOn))
                {
                    receipt.AppendLine("   + " + addOn);
                }

                receipt.AppendLine($"   ₱ {price:N2}");
                receipt.AppendLine("");
            }

            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine($"TOTAL        : ₱ {grandTotal:N2}");
            receipt.AppendLine($"Payment      : {_paymentMethod}");
            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine("       Thank you for your order!");
            receipt.AppendLine("======================================");

            DisplayReceipt(receipt.ToString());
        }
        private void DisplayReceipt(string receiptText)
        {
            string[] lines = receiptText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None);

            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }

    }
}
