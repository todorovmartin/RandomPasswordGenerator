using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Password_Generator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RandomPasswordGeneratorService passwordGenerator;
        public string password;

        [BindProperty]
        public int passwordLength { get; set; }
        [BindProperty]
        public bool useLowerCaseIsChecked { get; set; }
        [BindProperty]
        public bool useUpperCaseIsChecked { get; set; }
        [BindProperty]
        public bool useNumbersIsChecked { get; set; }

        public IndexModel(ILogger<IndexModel> logger, RandomPasswordGeneratorService passwordGenerator)
        {
            _logger = logger;
            this.passwordGenerator = passwordGenerator;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            this.password = passwordGenerator.GeneratePassword(useLowerCaseIsChecked,
                                                                useUpperCaseIsChecked,
                                                                useNumbersIsChecked,
                                                                passwordLength);
            return Page();
        }
    }
}
