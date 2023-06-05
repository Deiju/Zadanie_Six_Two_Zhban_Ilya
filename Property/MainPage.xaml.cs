using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Property
{
    public partial class MainPage :ContentPage
    {
        int counts,newcost;
        public MainPage (int cost, string sell, string crok, int count, string objectes, string client, string owner, string seller, string address, string description, string square, string room,int newcost, string floor, string date)
        {
            InitializeComponent( );
            name.Text = objectes;
            clientes.Text = client;
            owners.Text = owner;
            sellers.Text = seller;
            addreses.Text = address;
            discript.Text = description;
            squares.Text = square;
            rooms.Text = room;
            cenas.Text = Convert.ToString(cost);
            floors.Text = floor;
            oplates.Text = sell;
            dates.Text = date;
            sroks.Text = crok;
            sum.Text = Convert.ToString(newcost);
            counts = count;            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync( new Sum(Convert.ToInt32(cenas.Text), oplates.Text, sroks.Text, counts, name.Text, clientes.Text, owners.Text, sellers.Text, addreses.Text, discript.Text, squares.Text, rooms.Text,Convert.ToInt32(sum.Text), floors.Text, dates.Text) );
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync( );
        }
    }
}
