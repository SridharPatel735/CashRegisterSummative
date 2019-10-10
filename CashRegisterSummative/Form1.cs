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
    public partial class register : Form
    {
        //Varible Declaration
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
        Random randGen = new Random();
        int dice1Value;

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
            Font receiptFont = new Font("Consolas", 10);
            SolidBrush receiptBrush = new SolidBrush(Color.White);
            SolidBrush receiptBrush2 = new SolidBrush(Color.Black);
            Pen receiptPen = new Pen(Color.Black);
            SoundPlayer receiptSound = new SoundPlayer(Properties.Resources.Receipt);

            //Drawing the Receipt and Printing the Total
            g.FillRectangle(receiptBrush, 258, 20, 230, 340);
            Thread.Sleep(250);
            g.DrawString("HAMBUGUH TOO", receiptFont, receiptBrush2, 320, 80);
            receiptSound.Play();
            Thread.Sleep(250);
            dice1Value = randGen.Next(1000, 9999);
            g.DrawString("Order Number: " + dice1Value, receiptFont, receiptBrush2, 270, 110);
            Thread.Sleep(250);
            g.DrawString("Date: ", receiptFont, receiptBrush2, 270, 125);
            g.DrawString(DateTime.Now.ToString("MM-dd-yy"), receiptFont, receiptBrush2, 310, 125);
            Thread.Sleep(250);
            g.DrawString("Burgers          x" + burgerNumber + " @ " + BURGER_PRICE.ToString("C"), receiptFont, receiptBrush2, 270, 160);
            receiptSound.Play();
            Thread.Sleep(250);
            g.DrawString("Fries            x" + friesNumber + " @ " + FRIES_PRICE.ToString("C"), receiptFont, receiptBrush2, 270, 175);
            Thread.Sleep(250);
            g.DrawString("Drinks           x" + drinksNumber + " @ " + DRINK_PRICE.ToString("C"), receiptFont, receiptBrush2, 270, 190);
            Thread.Sleep(250);
            g.DrawString("Subtotal              " + subtotal.ToString("C"), receiptFont, receiptBrush2, 270, 210);
            receiptSound.Play();
            Thread.Sleep(250);
            g.DrawString("Tax                   " + tax.ToString("C"), receiptFont, receiptBrush2, 270, 225);
            Thread.Sleep(250);
            g.DrawString("Total                 " + totalCost.ToString("C"), receiptFont, receiptBrush2, 270, 240);
            Thread.Sleep(250);
            g.DrawString("Tendered              " + tendered.ToString("C"), receiptFont, receiptBrush2, 270, 275);
            receiptSound.Play();
            Thread.Sleep(250);
            g.DrawString("Change                " + change.ToString("C"), receiptFont, receiptBrush2, 270, 290);
            Thread.Sleep(250);
            g.DrawString("Have A Great Day!!!", receiptFont, receiptBrush2, 300, 310);
            Thread.Sleep(250);
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //Draw Tools
            Graphics g = this.CreateGraphics();
            SolidBrush receiptBrush = new SolidBrush(Color.White);
            g.Clear(Color.DeepSkyBlue);

            //New Order
            burgerInput.Text = "";
            friesInput.Text = "";
            drinksInput.Text = "";
            subTotalOutput.Text = "";
            totalOutput.Text = "";
            taxOutput.Text = "";
            changeOutput.Text = "";
            tenderedInput.Text = "";
            g.FillRectangle(receiptBrush, 258, 20, 230, 340);

            //Setting everything to Zero
            burgerNumber = 0;
            friesNumber = 0;
            drinksNumber = 0;
            subtotal = 0;
            tax = 0;
            tendered = 0;
            totalCost = 0;
            change = 0;

        }

        public register()
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
            tax = subtotal * TAX;
            totalCost = subtotal + tax;

            subTotalOutput.Text = subtotal.ToString("C");
            taxOutput.Text = tax.ToString("C");          
            totalOutput.Text = totalCost.ToString("C");
        }
    }
}
