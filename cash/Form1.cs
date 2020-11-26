using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2020 nov Ashton kunder
namespace cash
{
    public partial class Form1 : Form
    { double burgerscost = 2.75;
        double friescost = 2.00;
        double drinkscost = 1.00;
        double tax = 0.13;

        
      

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
            label.Text = "big belly burger";
            

            ordernumber.Text = "order number 244";
            date.Text = "dec 21 2020";
            burgertext.Text = "burgers " + "  " + burgers + "     $" + burgerstotal + "$";
             friestext1.Text = "fries" + "      " + fries + "     $" + friestotal +"$";
            drinkstext1.Text = "drinks" + "    " + drinks + "     $" + drinkstotal +"$";
            subtext.Text = "subtotal" + "         $" + totalfood;
            taxtext.Text = "tax" +"         $" + totaltax;
            totaltext.Text= "total"+"         $" + totalall;









        }
    }
}
