using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConverterHomework
{
    public class MassModel : PageModel
    {
        [BindProperty]
        public int massType { get; set; }
        [BindProperty]
        public float value { get; set; }
        [BindProperty]
        public string conversion { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {

            conversion = coversion(massType, value).ToString();

        }

        private float coversion(int conversion, float value ) 
        {
            switch (conversion)
            {
                case 0:
                    value = value * 16;
                    break;
                case 1:
                    value = value / 16;
                    break;
                case 2:
                    value = value / 454;
                    break;
                case 3:
                    value = value / 453592;
                    break;

            }
            return value;
        }
    }
}