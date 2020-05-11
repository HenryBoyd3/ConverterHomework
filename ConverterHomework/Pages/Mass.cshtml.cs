using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ConverterHomework
{
    public class MassModel : PageModel
    {
        [BindProperty]
        public int massType { get; set; }

        //I tried to use a regular expression I couln't find out how to get it to work right
        // I found number with steps works well but I still want to know how to use regex correctly
        //[RegularExpression(@"^\-?\d+\.?\d*")]

        [BindProperty]
        public string value { get; set; }
        [BindProperty]
        public string conversion { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            float userinput;

            if (Single.TryParse(value, out userinput))
            {
                conversion = coversion(massType, userinput).ToString();
            }
            else
            {
                conversion = "not a valid input only use numbers";
            }
        }

        private string coversion(int conversion, float value ) 
        {
            float con;
            string massCon = string.Empty; 
            switch (conversion)
            {
                case 0:
                    con = value * 16;
                    massCon = value + " Pounds to " + con + " Ounces"; ; 
                    break;
                case 1:
                    con = value / 16;
                    massCon = value + " Ounces to " + con + " Pounds";
                    break;
                case 2:
                    con = value / 454;
                    massCon = value + " Grams to "  + con + " Pounds";
                    break;
                case 3:
                    con = value / 453592;
                    massCon = value + " Milligrams to " + con + " Pounds";
                    break;

            }
            return massCon;
        }
    }
}