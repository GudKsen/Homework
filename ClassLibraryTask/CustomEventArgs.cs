using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    public class CustomEventArgs : EventArgs
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
