using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Theme
{
    public class AppState
    {
        public event Action AfterPageRendered;
        public static IJSObjectReference ThemeModule;
        public void PageRendered(bool firstRender)
        {
            AfterPageRendered?.Invoke();
        }
    }
}
