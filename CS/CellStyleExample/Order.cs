using DevExpress.Mvvm;

namespace CellStyleExample {
    public class Order : BindableBase {


        protected int _OrderId;
        public int OrderId
        {
            get { return this._OrderId; }
            set { this.SetProperty(ref this._OrderId, value, "OrderId"); }
        }

        protected string _CustomerName;
        public string CustomerName
        {
            get { return this._CustomerName; }
            set { this.SetProperty(ref this._CustomerName, value, "CustomerName"); }
        }


        protected int _Quantity;
        public int Quantity
        {
            get { return this._Quantity; }
            set { this.SetProperty(ref this._Quantity, value, "Quantity"); }
        }


        protected double _Price;
        public double Price
        {
            get { return this._Price; }
            set { this.SetProperty(ref this._Price, value, "Price"); }
        }

    }
}
