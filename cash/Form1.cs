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
using System;

using System.Windows.Forms;

using System.Media;
//2020 nov Ashton kunder
namespace cash
{
    public partial class Form1 : Form
    { double burgerscost = 2.75;
        double friescost = 2.00;
        double drinkscost = 1.00;
        double tax = 0.13;
        SoundPlayer player = new SoundPlayer(Properties.Resources.print);



        //double totalburgers = Convert.ToInt32(burgernumber.Text);
        // double totalfries = Convert.ToInt32(friesnumber.Text);
        // double totaldrinks = Convert.ToInt32(drinksnumber.Text);
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Button1_Click_1(object sender, EventArgs e)
        {// variables 
            double burgers = Convert.ToInt32(burgernumber.Text);
            double fries = Convert.ToInt32(friesnumber.Text);
            double drinks = Convert.ToInt32(drinksnumber.Text);
            double totalfood = (burgers * burgerscost) + (fries * friescost) + (drinks * drinkscost);
            double totaltax = tax * totalfood;
            double totalall = totaltax + totalfood;
            totaltax = totalfood * tax;
            totalall = totalfood + totaltax;
            // burgernumber.Text = $"{totalfood("$00.00")}";
           // input text
            subtotal.Text = Convert.ToString(totalfood);
            taxtotal.Text = Convert.ToString (totaltax);
             total.Text = Convert.ToString(totalall);


        }

        private void Print_Click(object sender, EventArgs e)
        {// variables 
            double burgers = Convert.ToInt32(burgernumber.Text);
            double fries = Convert.ToInt32(friesnumber.Text);
            double drinks = Convert.ToInt32(drinksnumber.Text);
            double totalfood = (burgers * burgerscost) + (fries * friescost) + (drinks * drinkscost);
            double totaltax = tax * totalfood;
            double totalall = totaltax + totalfood;
            totaltax = totalfood * tax;
            totalall = totalfood + totaltax;
            double burgerstotal = (burgers * burgerscost);
            double friestotal = (fries * friescost);
            double drinkstotal = (drinks * drinkscost);
            //text
            player.Play();
            label.Text = "big belly burger";

            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            ordernumber.Text = "order number 244";
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            date.Text = "dec 21 2020";
            player.Play();
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            burgertext.Text = "burgers " + "  " + burgers + "     $" + burgerstotal + "$";
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            friestext1.Text = "fries" + "      " + fries + "     $" + friestotal +"$";
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            drinkstext1.Text = "drinks" + "    " + drinks + "     $" + drinkstotal +"$";
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            subtext.Text = "subtotal" + "         $" + totalfood;
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            taxtext.Text = "tax" +"         $" + totaltax;
            this.Refresh();
            Thread.Sleep(500);
            player.Play();
            totaltext.Text= "total"+"         $" + totalall;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 








        }
    }
}
