using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using CurrencyConverter.Models;
using System;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    [Activity(Label = "Currency Converter by Shaun Milby", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        public double? spinner1value { get; set; }
        public double? spinner2value { get; set; }



        

        //convertFrom changed, convertTo changed, doMath from both value changes
        private void convertFrom_changed(object sender, EventArgs e, Activity activity)
        {
                var convertFrom = activity.FindViewById<TextView>(Resource.Id.convertFrom);
                double i;
                i = float.Parse(convertFrom.Text);

        }
                private void convertTo_changed(object sender, EventArgs e, Activity activity)
        {
                var convertTo = activity.FindViewById<TextView>(Resource.Id.convertTo);
                double i;
                i = float.Parse(convertTo.Text);

        }




        //THIS IS ALL THE MATH. NOT FINISHED YET. DO NOT DE-COMMENT UNTIL READY FOR BUILD OR CHECKING FOR ERRORS
      //  private void converterMath(Activity activity)
       //  {
        //     var convertFrom = activity.FindViewById<TextView>(Resource.Id.convertFrom);
        //    double valueInUSD = spinner1value * convertFrom;
        //   double valueInTarget = valueInUSD * spinner2value;
         //         Text = valueInTarget = ToString("F2");
          //    }
     

        public List<Converter> otherValues { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // list of countries in relationships to the USD

            otherValues = new List<Converter>();
            otherValues.Add(new Converter {Country = "CAD", valueInUSD = 1.31 });
            otherValues.Add(new Converter { Country = "GBP", valueInUSD = 0.92 });
            otherValues.Add(new Converter { Country = "EUR", valueInUSD = 0.54 });

            Spinner spinner1 = FindViewById<Spinner>(Resource.Id.Spinner1);
            spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected); 

            var adapter = ArrayAdapter.CreateFromResource(
                this, Resource.Array.selectCurrency, Android.Resource.Layout.SimpleSpinnerDropDownItem);
              spinner1.Adapter = adapter;

            Spinner spinner2 = FindViewById<Spinner>(Resource.Id.Spinner2);
            spinner2.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

            var adapter2 = ArrayAdapter.CreateFromResource(
                this, Resource.Array.selectCurrency, Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner2.Adapter = adapter;
            

        }

        private void Spinner2_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner2 = (Spinner)sender;

            
            throw new NotImplementedException();
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner1 = (Spinner)sender;

           
            


            

           
        }
        //button is clicked, do math

        
        

        
        

      
        
        }
    

    }




