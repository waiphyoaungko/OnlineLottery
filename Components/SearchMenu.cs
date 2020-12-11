using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLottery.Models;
using OnlineLottery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Components
{
    public class SearchMenu : ViewComponent
    {
        private readonly ITicketRepository _ticketRepository;
        public SearchMenu(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public IViewComponentResult Invoke()
        {
            var prefixList = new List<SelectListItem>
            {
                new SelectListItem{ Text="က", Value = "က"},
                new SelectListItem{ Text="ခ", Value = "ခ" },
                new SelectListItem{ Text="ဂ", Value = "ဂ" },
                new SelectListItem{ Text="ဃ", Value = "ဃ"},
                new SelectListItem{ Text="င", Value = "င" },
                new SelectListItem{ Text="စ", Value = "စ" },
                new SelectListItem{ Text="ဆ", Value = "ဆ"},
                new SelectListItem{ Text="ဇ", Value = "ဇ" },
                new SelectListItem{ Text="ဈ", Value = "ဈ" },
                new SelectListItem{ Text="ည", Value = "ည"},
                new SelectListItem{ Text="ဋ", Value = "ဋ" },
                new SelectListItem{ Text="ဌ", Value = "ဌ" },
                 new SelectListItem{ Text="ဍ", Value = "ဍ"},
                new SelectListItem{ Text="ဎ", Value = "ဎ" },
                new SelectListItem{ Text="ဏ", Value = "ဏ" },
                new SelectListItem{ Text="တ", Value = "တ"},
                new SelectListItem{ Text="ထ", Value = "ထ" },
                new SelectListItem{ Text="ဒ", Value = "ဒ" },
                new SelectListItem{ Text="ဓ", Value = "ဓ"},
                new SelectListItem{ Text="န", Value = "န" },
                new SelectListItem{ Text="ပ", Value = "ပ" },
                new SelectListItem{ Text="ဖ", Value = "ဖ"},
                new SelectListItem{ Text="ဗ", Value = "ဗ" },
                new SelectListItem{ Text="ဘ", Value = "ဘ" },
                new SelectListItem{ Text="မ", Value = "မ"},
                new SelectListItem{ Text="ယ", Value = "ယ" },
                new SelectListItem{ Text="ရ", Value = "ရ" },
                new SelectListItem{ Text="လ", Value = "လ"},
                new SelectListItem{ Text="ဝ", Value = "ဝ" },
                new SelectListItem{ Text="သ", Value = "သ" },
                new SelectListItem{ Text="ဟ", Value = "ဟ"},
                new SelectListItem{ Text="ဠ", Value = "ဠ" },
                new SelectListItem{ Text="အ", Value = "အ" },
                new SelectListItem{ Text="ကက", Value = "ကက"},
                new SelectListItem{ Text="ကခ", Value = "ကခ" },
                new SelectListItem{ Text="ကဂ", Value = "ကဂ" },
                 new SelectListItem{ Text="ကဃ", Value = "ကဃ"},
                new SelectListItem{ Text="ကင", Value = "ကင" },
                new SelectListItem{ Text="ကစ", Value = "ကစ" },
                new SelectListItem{ Text="ကဆ", Value = "ကဆ"},
                new SelectListItem{ Text="ကဇ", Value = "ကဇ" },
                new SelectListItem{ Text="ကဈ", Value = "ကဈ" },
                new SelectListItem{ Text="ကည", Value = "ကည"},
                new SelectListItem{ Text="ကဋ", Value = "ကဋ" },
                new SelectListItem{ Text="ကဌ", Value = "ကဌ" },
                new SelectListItem{ Text="ကဍ", Value = "ကဍ"},
                new SelectListItem{ Text="ကဎ", Value = "ကဎ" },
                new SelectListItem{ Text="ကဏ", Value = "ကဏ" },
                new SelectListItem{ Text="ကတ", Value = "ကတ"},
                new SelectListItem{ Text="ကထ", Value = "ကထ" },
                new SelectListItem{ Text="ကဒ", Value = "ကဒ" },
                new SelectListItem{ Text="ကဓ", Value = "ကဓ"},
                new SelectListItem{ Text="ကန", Value = "ကန" },
                new SelectListItem{ Text="ကပ", Value = "ကပ" },
                new SelectListItem{ Text="ကဖ", Value = "ကဖ"},
                new SelectListItem{ Text="ကဗ", Value = "ကဗ" },
                new SelectListItem{ Text="ကဘ", Value = "ကဘ" },
                new SelectListItem{ Text="ကမ", Value = "ကမ"},
                new SelectListItem{ Text="ကယ", Value = "ကယ" },
                new SelectListItem{ Text="ကရ", Value = "ကရ" },
                new SelectListItem{ Text="ကလ", Value = "ကလ"},
                new SelectListItem{ Text="ကဝ", Value = "ကဝ" },
                new SelectListItem{ Text="ကသ", Value = "ကသ" },
                new SelectListItem{ Text="ကဟ", Value = "ကဟ"},
                new SelectListItem{ Text="ကဠ", Value = "ကဠ" },
                new SelectListItem{ Text="ကအ", Value = "ကအ" },
            };

            ViewBag.PrefixList = new SelectList(prefixList, "Value", "Text");

            return View();
        }
    }
}
