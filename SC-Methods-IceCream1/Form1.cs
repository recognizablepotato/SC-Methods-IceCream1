using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_Methods_IceCream1
{
    public partial class Form1 : Form
    {

        //Sample code with examples on using methods
        //COP2010
        //Doug Titus

        public Form1()
        {
            InitializeComponent();
        }

        /* Methods are one of the main bulding bocks of programming
        * Included here are some basic examples of how you could use a method
        * 
        * Using our IceCream sample code there is now a 
        * simple method to calculate the order total
        * 
        * The method is called and code run by putting the 
        * method name in the event handler
        */

        /* A method can be public or private 
         * Private methods can only be accessed in the same class 
         * Public methods can be accessed by other classes and forms 
         */

        int intScoopsQty = 0;
        double dblUnitPrice = 0;
        double dblSubtotal = 0;
        double dblTotalPrice = 0;


        private void btnComputePrice_Click(object sender, EventArgs e)
        {
            //input 
            bool blnResultScoops = int.TryParse(txtScoops.Text, out intScoopsQty);
            bool blnResultPrice = double.TryParse(txtUnitPrice.Text, out dblUnitPrice);

            //calculate subtotal and display to listbox
            dblSubtotal = intScoopsQty * dblUnitPrice;
            lstOutput.Items.Add(dblSubtotal.ToString("c"));

            //method to calculate total and display to textbox
            CalculateTotal();

        }//end method

        //this method is void - that means it does not return a value
        //it jbut just executes the code in the method and ends

        //note: the variable type make a difference because of scope
        //this only works because we are using field variables and not local
        private void CalculateTotal()
        {
            //add subtotal and $1 fee to totalprice and output
            dblTotalPrice = dblSubtotal + 1;
            txtTotalPrice.Text = dblTotalPrice.ToString("c");
        }//end method


        //**************************************************************
        
        //calling a method from an event handler to clear text boxes and variables
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }//end method

        //Below is a method that can be called from any event handler
        //in the event handler you would add: clearAll();
        private void ClearAll()
        {
            intScoopsQty = 0;
            dblUnitPrice = 0;
            dblTotalPrice = 0;
            txtScoops.Clear();
            txtUnitPrice.Clear();
            lstOutput.Items.Clear();
        }//end method

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end method
    }//end class
}//end namespace
