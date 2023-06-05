using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Property
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnlineProperty :ContentPage
    {
        int count;
        public OnlineProperty (double cost,int count)
        {
            InitializeComponent();
            refresh(cost,count);
        }

        public void refresh(double costs, int count)
        {        
            if(count==1)
            {
                Cost.Text = "";
                Cost.Text = Convert.ToString(costs);
            }
            if (count == 2)
            {
                Cost1.Text = "";
                Cost1.Text = Convert.ToString(costs);
            }
            if (count == 3)
            {
                Cost2.Text = "";
                Cost2.Text = Convert.ToString(costs);
            }
            if (count == 4)
            {
                Cost3.Text = "";
                Cost3.Text = Convert.ToString(costs);
            }
            if (count == 5)
            {
                Cost4.Text = "";
                Cost4.Text = Convert.ToString(costs);
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            count = 1;
            Navigation.PushAsync(new Sum(Convert.ToInt32(Cost.Text),"Безналичный","12",count,"Квартира","Захаров И.А.","Петров В.Е.","Нарен И.У.","Пушкинская, 74", "Целая","48","2",0,"3","27.04.2023"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            count = 2;
            Navigation.PushAsync(new Sum(Convert.ToInt32(Cost1.Text), "Наличный", "7", count, "Застройка", "Галкин М.М.", "Петров У.Ф.", "Непал Р.В.", "Гелен, 7", "Целая", "42", "2", 0, "7", "22.11.2022"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            count = 3;
            Navigation.PushAsync(new Sum(Convert.ToInt32(Cost2.Text), "Безналичный", "3", count, "Квартира", "Ильич А.П.", "Петров В.Е.", "Дятел О.Л.", "Крестная, 13", "Есть некоторые дефекты", "46", "1", 0, "2", "12.01.2023"));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            count = 4;
            Navigation.PushAsync(new Sum(Convert.ToInt32(Cost3.Text), "Наличный", "18",count, "Коттедж", "Петров К.Н.", "Налик Ц.С.", "Карен О.И.", "Первая, 27", "Есть некоторые дефекты", "57", "3", 0, "8", "30.01.2023"));
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            count = 5;
            Navigation.PushAsync(new Sum(Convert.ToInt32(Cost4.Text), "Наличный", "12", count, "Квартира", "Шалин Л.В.", "Ульман Н.К.", "Петькин Х.Т.", "Вторая, 13", "Целая", "57", "3", 0, "4", "12.09.2021"));
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            count = 1;
            Navigation.PushAsync(new MainPage(Convert.ToInt32(Cost.Text), "Безналичный", "12", count, "Квартира", "Захаров И.А.", "Петров В.Е.", "Нарен И.У.", "Пушкинская, 74", "Целая", "48", "2", 0, "3", "27.04.2023"));
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            count = 2;
            Navigation.PushAsync(new MainPage(Convert.ToInt32(Cost1.Text), "Наличный", "7", count, "Застройка", "Галкин М.М.", "Петров У.Ф.", "Непал Р.В.", "Гелен, 7", "Целая", "42", "2", 0, "7", "22.11.2022"));
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            count = 3;
            Navigation.PushAsync(new MainPage(Convert.ToInt32(Cost2.Text), "Безналичный", "3", count, "Квартира", "Ильич А.П.", "Петров В.Е.", "Дятел О.Л.", "Крестная, 13", "Есть некоторые дефекты", "46", "1", 0, "2", "12.01.2023"));
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            count = 4;
            Navigation.PushAsync(new MainPage(Convert.ToInt32(Cost3.Text), "Наличный", "18", count, "Коттедж", "Петров К.Н.", "Налик Ц.С.", "Карен О.И.", "Первая, 27", "Есть некоторые дефекты", "57", "3", 0, "8", "30.01.2023"));
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            count = 5;
            Navigation.PushAsync(new MainPage(Convert.ToInt32(Cost4.Text), "Наличный", "12", count, "Квартира", "Шалин Л.В.", "Ульман Н.К.", "Петькин Х.Т.", "Вторая, 13", "Целая", "57", "3", 0, "4", "12.09.2021"));
        }
    }
}