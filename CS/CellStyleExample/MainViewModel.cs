using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace CellStyleExample {
    public class MainViewModel : ViewModelBase {


        protected ObservableCollection<Order> _Items;
        public ObservableCollection<Order> Items
        {
            get
            {
                if(this._Items == null)
                {
                    Random r = new Random();
                    this._Items = new ObservableCollection<Order>(Enumerable.Range(0, 10).Select(c => new Order() {
                        OrderId = 1000 + c,
                        CustomerName = "Customer #" + c,
                        Price = Math.Round(r.NextDouble() * 100, 2),
                        Quantity = r.Next(5) + 1
                    }));
                }

                return this._Items;
            }
        }

    }
}
