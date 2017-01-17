using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajuMandiriGudang
{
    /**
     * Barang keluar
     * Untuk keluar barang. Perlu diketahui: barang keluar
     */
    public class BarangKeluar
    {
        /**
         * GetSerialNum
         * Returns the DO number.
         */
        public int GetSerialNum()
        {
            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                { 
                    String line = sr.ReadToEnd();
                    //TODO: Find out the numbering format.
                }
            } catch (Exception e)
            {
                Console.WriteLine("ERROR! Cannot read file");
                return -1;
            }

            return 0;
        }

        /**
         * generateOutputNumber
         * This program will generate the output Delievery Order (DO) based on the time stamp and last output
         */ 
        public string GenerateOutputNumber()
        {
            int lastNumber = GetSerialNum();                //Initialize last number
            int todayYear = DateTime.Today.Year;            //Get today's year
            int todayMonth = DateTime.Today.Month;          //Get today's 

            return "DO-yy####";
        }

        public void UpdateItemQuantity(String itemName)
        {
            //Lookup the desired item

            //If found the item, then update the stock by decrementing by 1, since this is delivery
            if (true)
            {

            }
            //If not, return an error
            else
            {
                Console.WriteLine("ERROR: Cannot locate item. Item is not registered");
            }
        }
        
    }
}
