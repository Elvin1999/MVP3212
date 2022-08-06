using MVP3212.Data;
using MVP3212.Models;
using MVP3212.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP3212.Presenters
{
    public class MainPresenter
    {
        private readonly CarContext _db;
        private readonly IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;
           

            _db = new CarContext();

            _view.AddButtonClick += ViewAddButtonClick;
            _view.LoadButtonClick += ViewLoadButtonClick;
        }
        public void ViewLoadButtonClick(object sender,EventArgs e)
        {
            var list = _db.Cars.ToList();
            _view.Cars = list;
        }
        public void ViewAddButtonClick(object sender,EventArgs e)
        {
            Car car = new Car
            {
                Model = _view.ModelText,
                Vendor = _view.VendorText,
                Year = int.Parse(_view.YearText),
                Color = _view.ColorText,
                Transmission = _view.TransmissionText,
            };

            _db.Cars.Add(car);
            _db.SaveChanges();
        }
    }
}
