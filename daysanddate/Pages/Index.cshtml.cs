﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace daysanddate.Pages
{
    public class IndexModel : PageModel
    {
       [FromForm]

        public data data { get; set; }
        public void OnGet()
        {
            if (ModelState.IsValid)
            {
                DateTime answer = data.Date.AddDays(data.Days);

            }

        }
   




    }
}

