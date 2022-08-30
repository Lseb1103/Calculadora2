using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;

namespace Calculadora2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView textResult;
        Button buttonPlus;
        Button buttonMinus;
        Button buttonMulti;
        Button buttonDivider;
        Button buttonAC;
        Button buttonC;
        Button buttonEqual;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Button button7;
        Button button8;
        Button button9;
        Button button0;
        string type = "";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            textResult = FindViewById<TextView>(Resource.Id.textResult);
            buttonPlus = FindViewById<Button>(Resource.Id.buttonPlus);
            buttonMinus = FindViewById<Button>(Resource.Id.buttonMinus);
            buttonMulti = FindViewById<Button>(Resource.Id.buttonMulti);
            buttonDivider = FindViewById<Button>(Resource.Id.buttonDivider);
            buttonAC = FindViewById<Button>(Resource.Id.buttonAC);
            buttonC = FindViewById<Button>(Resource.Id.buttonC);
            buttonEqual = FindViewById<Button>(Resource.Id.buttonEqual);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button3 = FindViewById<Button>(Resource.Id.button3);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button5 = FindViewById<Button>(Resource.Id.button5);
            button6 = FindViewById<Button>(Resource.Id.button6);
            button7 = FindViewById<Button>(Resource.Id.button7);
            button8 = FindViewById<Button>(Resource.Id.button8);
            button9 = FindViewById<Button>(Resource.Id.button9);
            button0 = FindViewById<Button>(Resource.Id.button0);
            buttonPlus.Click += (sender, e) =>

            {
                textResult.Text += "+";
                type = "suma";
            };
            buttonMinus.Click += (sender, e) =>
            {
                textResult.Text += "-";
                type = "resta";

            };
            buttonMulti.Click += (sender, e) =>
            {
                textResult.Text += "x";
                type = "multi";

            };
            buttonDivider.Click += (sender, e) =>
            {
                textResult.Text += "/";
                type = "divider";

            };
            buttonAC.Click += (sender, e) =>
            {
                textResult.Text = "";
            };
            buttonC.Click += (sender, e) =>
            {

            };
            buttonEqual.Click += (sender, e) =>
            {
                try
                {
                    if (type == "suma")
                    {
                        string datos = textResult.Text;
                        string[] temp = datos.Split("+");
                        int num1 = System.Int32.Parse(temp[0]);
                        int num2 = System.Int32.Parse(temp[1]);
                        int result = num1 + num2;
                        textResult.Text += " = " + result.ToString();
                        System.Console.WriteLine(textResult);

                    }
                    else if (type == "resta")
                    {
                        string datos = textResult.Text;
                        string[] temp = datos.Split("-");
                        int num1 = System.Int32.Parse(temp[0]);
                        int num2 = System.Int32.Parse(temp[1]);
                        int result = num1 - num2;
                        textResult.Text += " = " + result.ToString();
                    }
                    else if (type == "multi")
                    {
                        string datos = textResult.Text;
                        string[] temp = datos.Split("x");
                        int num1 = System.Int32.Parse(temp[0]);
                        int num2 = System.Int32.Parse(temp[1]);
                        int result = num1 * num2;
                        textResult.Text += " = " + result.ToString();
                    }
                    else if (type == "divider")
                    {
                        string datos = textResult.Text;
                        string[] temp = datos.Split("/");
                        int num1 = System.Int32.Parse(temp[0]);
                        int num2 = System.Int32.Parse(temp[1]);
                        int result = num1 / num2;
                        textResult.Text += " = " + result.ToString();
                    }
                }
                catch (System.Exception ex)
                {

                }


            };
            button1.Click += (sender, e) =>
            {
                textResult.Text += "1";
            };
            button2.Click += (sender, e) =>
            {
                textResult.Text += "2";
            };
            button3.Click += (sender, e) =>
            {
                textResult.Text += "3";
            };
            button4.Click += (sender, e) =>
            {
                textResult.Text += "4";
            };
            button5.Click += (sender, e) =>
            {
                textResult.Text += "5";
            };
            button6.Click += (sender, e) =>
            {
                textResult.Text += "6";
            };
            button7.Click += (sender, e) =>
            {
                textResult.Text += "7";
            };
            button8.Click += (sender, e) =>
            {
                textResult.Text += "8";
            };
            button9.Click += (sender, e) =>
            {
                textResult.Text += "9";
            };
            button0.Click += (sender, e) =>
            {
                textResult.Text += "0";
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {

            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}