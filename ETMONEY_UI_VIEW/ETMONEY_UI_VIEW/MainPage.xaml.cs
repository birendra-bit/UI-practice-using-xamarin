using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ETMONEY_UI_VIEW
{
    public partial class MainPage : ContentPage
    {
        public IList<Cards> Card { get; set; }
        public IList<UnscrollListView> UnscrollList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ImgBtn.Clicked += ImgBtn_Clicked;
            //Card = new List<Cards>();
            //Card.Add(new Cards
            //{
            //    CardImg = "mutualfund.jpg"
            //});
            //Card.Add(new Cards
            //{
            //    CardImg = "health.jpg"
            //});
            //Card.Add(new Cards
            //{
            //    CardImg = "insurance.jpg"
            //});

            //Card.Add(new Cards
            //{
            //    CardImg = "mutualfund1.jpg"
            //});
            //Card.Add(new Cards
            //{
            //    CardImg = "creaditscore.jpg"
            //});
            UnscrollList = new List<UnscrollListView>();

            UnscrollList.Add(new UnscrollListView {
                Title ="Spend",
                ImageURL= "spend.jpg",
                Content="Rs 0 total spends in Dec"
            });
            UnscrollList.Add(new UnscrollListView
            {
                Title = "SmartDeposit",
                ImageURL = "pig.png",
                Content = "Earn upto 50% more than your Saving Account Earn upto 50% more than your Saving Account"
            });
           
            UnscrollList.Add(new UnscrollListView
            {
                Title = "Direct Mutual Funds",
                ImageURL = "mutuaicon.jpg",
                Content = "SIP & one-time investment"
            });
            UnscrollList.Add(new UnscrollListView
            {
                Title = "Loans",
                ImageURL = "loan.jpg",
                Content = "Quicks & hassle-free way to borrow money"
            });
            UnscrollList.Add(new UnscrollListView
            {
                Title = "Insurance",
                ImageURL = "insurance.jpg",
                Content = "Keys to security! Term Life, Car, Bike, Health & more"
            });
            UnscrollList.Add(new UnscrollListView
            {
                Title = "Gold Deposit",
                ImageURL = "gold_bar.jpg",
                Content = "Smartest way to accumulate gold"
            });
            UnscrollList.Add(new UnscrollListView
            {
                Title = "Bill Calendar",
                ImageURL = "calendarbill.jpg",
                Content = "All your bills at one place"
            });
            BindingContext = this;
        }

        private async void ImgBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MutualFund());
        }
    }
}
