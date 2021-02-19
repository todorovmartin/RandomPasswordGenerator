using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password_Generator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RandomPasswordGeneratorService passwordGenerator;
        public string password;

        public IndexModel(ILogger<IndexModel> logger, RandomPasswordGeneratorService passwordGenerator)
        {
            _logger = logger;
            this.passwordGenerator = passwordGenerator;
        }

        public void OnGet()
        {
            this.password = passwordGenerator.Test();
        }
    }
}
