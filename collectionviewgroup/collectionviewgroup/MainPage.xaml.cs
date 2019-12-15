using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections;

namespace collectionviewgroup
{
    public class NasOptionGroups : List<MobileNasoption>
    {
        public string Name { get; private set; }

        public NasOptionGroups(string name, List<MobileNasoption> items) : base(items)
        {
            Name = name;
        }
    }

    public class MobileNasoption
    {
        public string ItemTitle { get; set; }
        public string ItemImageURL { get; set; }

    }
    public partial class MainPage : ContentPage
    {
        IEnumerable ItemsSource1;
        List<NasOptionGroups> groups = new List<NasOptionGroups>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            List<MobileNasoption> list1 = new List<MobileNasoption>() {
                new MobileNasoption{ItemTitle="Directory", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="My Profile", ItemImageURL="a2.png" },

            };
            List<MobileNasoption> list2 = new List<MobileNasoption>() {

                new MobileNasoption{ItemTitle="Change Approvel Request", ItemImageURL="a3.png" },
                new MobileNasoption{ItemTitle="Benefit Items", ItemImageURL="a4.png" },
                new MobileNasoption{ItemTitle="My Leavs", ItemImageURL="a5.png" },
            };
            List<MobileNasoption> list3 = new List<MobileNasoption>() {

                new MobileNasoption{ItemTitle="Time permisions approval ", ItemImageURL="a6.png" },
                new MobileNasoption{ItemTitle="Expense sheet", ItemImageURL="a7.png" },
                new MobileNasoption{ItemTitle="My Time permisions", ItemImageURL="a8.png" },
                new MobileNasoption{ItemTitle="Attendance Tracking ", ItemImageURL="a9.png" },

            };
            List<MobileNasoption> list4 = new List<MobileNasoption>() {

                new MobileNasoption{ItemTitle="Attendance Sign in / out", ItemImageURL="a5.png" },
                new MobileNasoption{ItemTitle="Time permisions Request", ItemImageURL="a1.png" },
                new MobileNasoption{ItemTitle="My Benefit", ItemImageURL="a2.png" },

            };
            NasOptionGroups group1 = new NasOptionGroups("benfits", list1);
            NasOptionGroups group2 = new NasOptionGroups("Change of status group", list2);
            NasOptionGroups group3 = new NasOptionGroups("leavs", list3);
            NasOptionGroups group4 = new NasOptionGroups("Time permisions Request group and Expense sheet group", list4);
            groups.Add(group2);
            groups.Add(group4);
            groups.Add(group1);
            groups.Add(group3);


        }
        protected override void OnAppearing()
        {
            CollectionView.ItemsSource = groups;
            CollectionView.IsGrouped = true;


        }

        private void ShowIndicator()
        {
        }

        private void HideIndicator()
        {
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void GridDisplay_Clicked(object sender, EventArgs e)
        {
        }
    }
}


