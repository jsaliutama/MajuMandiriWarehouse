using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Form1.cs
 * This form is the main menu for the warehouse application. It has 2 main functions: input and output. Possibly
 * more functions will be added into the program. 
 * 
 * Author: Joshua Saliutama
 * Date first created: 17 January 2017
 * Date last updated: 17 January 2017
 *
 * Side note: This is still initial. Beta test predicted in one month.
 */ 

namespace MajuMandiriGudang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is to go to input
        /**
         * button1_CLick
         * This function will handle the transition from the main menu to the input menu when the input button 
         * is clicked.
         * 
         * Date last updated: 17 January 2017. 
         */ 
        private void button1_Click(object sender, EventArgs e)
        {
            //Initalize the form first
            FormInput fi = new MajuMandiriGudang.FormInput();
            //Show and close the forms
            fi.Show();
            this.Close();
        }

        /**
         * button2_Click
         * This function will handle the transition from the main menu to the output menu when the output
         * menu is clicked
         * 
         * Date last updated: 17 January 2017
         */ 
        private void button2_Click(object sender, EventArgs e)
        {
            //Initalize the form first
            FormOutput fo = new FormOutput();
            //Show and close the forms
            fo.Show();
            this.Hide();
        }
    }
}
