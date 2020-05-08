using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConverterHomework
{
    public class TemperatureModel : PageModel
    {
        [BindProperty]
        public int tempType { get; set; }
        [BindProperty]
        public float value { get; set; }
        [BindProperty]
        public string conversion { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            //basic function need to add more 
            conversion = coversion(tempType, value).ToString();

        }

        private float coversion(int conversion, float value)
        {
            switch (conversion)
            {
                case 0:
                    value = value - 32;
                    value = value * 5/9;
                    break;
                case 1:
                    value = value * 9/5 + 32;
                    break;

            }
            return value;
        }
    }
}
