using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewModelTest
{
    public class Contacts
    {
        public string Name
        {
            get;
            set;
        }
        public string Num
        {
            get;
            set;
        }
        public string imgsource
        {
            get;
            set;
        }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListContainPage : ContentPage
	{
        //public ListViewModelView ViewModel
        //{
        //    get;
        //    set;
        //}
        public ListContainPage()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = new List<Contacts>() {
                new Contacts() {
                        Name = "Umair", Num = "0456445450945", imgsource = "http://bit.ly/2oDQpPT",
                },
                new Contacts() {
                    Name = "Cat", Num = "034456445905", imgsource = "http://gtty.im/2psFEos",
                },
                new Contacts() {
                    Name = "Nature", Num = "56445905", imgsource = "http://gtty.im/2psFEos",
                },
            };
            ListViewModelView lvl = new ListViewModelView("Bloomberg");
            //ViewModel = lvl;
            BindingContext = lvl;
            lvl.Title = "This is it !!!!!!!!!!!!!!!";
        }
	}
}