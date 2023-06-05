using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Property
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sum :ContentPage
    {
        double costs;
        double newcost;
        int newcount;
        string objects, clients, owners, sellers, adres, descript, squares, rooms, floors, dates;

        private void Button_Clicked_2 (object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(Convert.ToInt32(cena.Text), "Безналичный", "5", newcount, "Квартира", "Захаров И.А.", "Петров В.Е.", "Нарен И.У.", "Пушкинская, 74", "Целая", "48", "2",Convert.ToInt32(newcost), "3", "27.04.2023"));
        }

        public Sum (int cost,string sell,string crok,int count,string objectes,string client,string owner,string seller,string address,string description, string square,string room,int newcosts, string floor,string date)
        {
            InitializeComponent( );
            cena.Text = cost.ToString();
            oplata.Text = sell;
            srok.Text = crok;
            newcount = count;
            objects = objectes;
            clients = client;
            owners = owner;
            sellers = seller;
            adres = address;
            descript = description;
            squares = square;
            rooms = room;
            newcost = newcosts;
            floors = floor;
            dates = date;
        }

        private void Button_Clicked (object sender, EventArgs e) 
        {
            costs = Convert.ToDouble(cena.Text);
            if(oplata.Text=="Безналичный")
            {
                double ckidka = costs * 0.1;
                
                if (Convert.ToInt32(srok.Text) >= 1 && Convert.ToInt32(srok.Text) < 5)
                {
                    double dop = costs * 0.05;
                    newcost = dop + costs + ckidka;
                }
                if (Convert.ToInt32(srok.Text) >= 5 && Convert.ToInt32(srok.Text) < 11)
                {
                    double dop = costs * 0.1;
                    newcost = dop + costs + ckidka;
                }
                if (Convert.ToInt32(srok.Text) >= 11 && Convert.ToInt32(srok.Text) < 21)
                {
                    double dop = costs * 0.15;
                    newcost = dop + costs + ckidka;                    
                }               
            }
            else if (oplata.Text == "Наличный")
            {
                double ckidka = costs * 0.1;

                if (Convert.ToInt32(srok.Text) > 1 && Convert.ToInt32(srok.Text) < 5)
                {
                    double dop = costs * 0.05;
                    newcost = dop + costs - ckidka;
                }
                if (Convert.ToInt32(srok.Text) >= 5 && Convert.ToInt32(srok.Text) < 11)
                {
                    double dop = costs * 0.1;
                    newcost = dop + costs - ckidka;
                }
                if (Convert.ToInt32(srok.Text) >= 11 && Convert.ToInt32(srok.Text) < 21)
                {
                    double dop = costs * 0.15;
                    newcost = dop + costs - ckidka;
                }                
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if(newcost!=0)
            {
                Navigation.PushAsync(new OnlineProperty(newcost, newcount));
            }
            else
            {
                Navigation.PushAsync(new OnlineProperty(costs, newcount));
            }                     
        }
    }
}