using MVP3212.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP3212.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClick { get; set; }
        EventHandler<EventArgs> LoadButtonClick { get; set; }
        List<Car> Cars { set;}
        string ModelText { get; set; }
        string VendorText { get; set; }
        string ColorText { get; set; }
        string TransmissionText { get; set; }
        string YearText { get; set; }
    }
}
