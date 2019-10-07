using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
/// <summary>
/// Sridhar Patel
/// October 2019
/// Cash Register displaying the skills that I have gathered 
/// </summary>
namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        const double BURGER_PRICE = 2.50;
        const double FRIES_PRICE = 2.00;
        const double DRINK_PRICE = 1.50;
        const double TAX = 0.13;
        double burgerNumber, friesNumber, drinksNumber;
        double subtotal;
        double tax;
        double tendered;
        double totalCost;
        double change;

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {
            //Tendered and Change Calculations
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
            }
            catch
            {
                tendered = 0;
            }
            try
            {
                change = Convert.ToDouble(changeOutput.Text);
            }
            catch
            {
                change = 0;
            }

            change = tendered - totalCost;
            changeOutput.Text = change.ToString("C");
        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            //Draw tools
            Graphics g = this.CreateGraphics();
            Font receiptFont = new Font("Consolas", 12);
            SolidBrush receiptBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush2 = new SolidBrush(Color.Black);
            Pen receiptPen = new Pen(Color.Black);
            SoundPlayer receiptSound = new SoundPlayer(Properties.Resources.Receipt);

            //Drawing the Receipt
            g.FillRectangle(receiptBrush, 258, 20, 230, 380);
            //g.DrawString("", titleFont, titleBrush, 20, 50);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTotalsButton_Click(object sender, EventArgs e)
        {
            //Finding the subtotal, tax, and total Calculations
            try
            {
                burgerNumber = Convert.ToDouble(burgerInput.Text);
            }
            catch
            {
                burgerNumber = 0;
            }
            try
            {
                friesNumber = Convert.ToDouble(friesInput.Text);
            }
            catch
            {
                friesNumber = 0;
            }
            try
            {
                drinksNumber = Convert.ToDouble(drinksInput.Text);
            }
            catch
            {
                drinksNumber = 0;
            }

            subtotal = (burgerNumber * BURGER_PRICE) + (friesNumber * FRIES_PRICE) + (drinksNumber * DRINK_PRICE);
            subTotalOutput.Text = subtotal.ToString("C");

            tax = subtotal * TAX;
            taxOutput.Text = tax.ToString("C");

            totalCost = subtotal + tax;
            totalOutput.Text = totalCost.ToString("C");
        }
    }
}
