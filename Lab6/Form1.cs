using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

Author: Zachary Salvaggio

Program Title: Temperature Converter

File Description: Lab 6, Final Project for CSC 317

This program takes a temperature in kelvin, celsius, or fahrenheit and converts it. It also has a temperature gauge which is automatically updated. 

*/

namespace Lab6
{
    public partial class TemperatureConverter : Form
    {

        private decimal fahrenheit_gauge = 9999999;
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberboxTempValue_ValueChanged(object sender, EventArgs e)
        {

            decimal entered = numberboxTempValue.Value;

            if (comboUnits.Text != null)
            {
                switch (comboUnits.Text)
                {
                    case "Fahrenheit":
                        //convert from farenheit to celsius and kelvin
                        if(entered <= -459.67m) { displayWarning();return; }
                        lblConversion1Value.Text = convertToCelsius('F', entered).ToString("0.00") + "°C";
                        lblConversion2Value.Text = convertToKelvin('F', entered).ToString("0.00") + "K";
                        fahrenheit_gauge = entered;
                        break;
                    case "Celsius":
                        //convert from celsius to fahrenheit and kelvin
                        if (entered <= -273.15m) { displayWarning(); return; }
                        lblConversion1Value.Text = convertToFahrenheit('C', entered).ToString("0.00") + "°F";
                        lblConversion2Value.Text = convertToKelvin('C', entered).ToString("0.00") + "K";
                        break;
                    case "Kelvin":
                        //convert from kelvin to celsius and fahrenheit
                        if (entered <= 0m) { displayWarning();return; }
                        lblConversion1Value.Text = convertToFahrenheit('K', entered).ToString("0.00") + "°F";
                        lblConversion2Value.Text = convertToCelsius('K', entered).ToString("0.00") + "°C";
                        break;
                }
            }
        }

        private decimal convertToKelvin(char startingTemp, decimal value)
        {
            decimal kelvin = 0;

            switch (startingTemp)
            {
                case 'F':
                    kelvin = (value + 459.67m) * (5m / 9m);
                    break;
                case 'C':
                    kelvin = value + 273.15m;
                    break;
            }

            return kelvin;

        }

        private decimal convertToCelsius(char startingTemp, decimal value)
        {
            decimal celsius = 0;

            switch (startingTemp)
            {
                case 'F':
                    celsius = (value - 32m) * (5m / 9m);
                    break;
                case 'K':
                    celsius = value - 273.15m;
                    break;
            }

            return celsius;
        }

        private decimal convertToFahrenheit(char startingTemp, decimal value)
        {
            decimal fahrenheit = 0;

            switch (startingTemp)
            {
                case 'C':
                    fahrenheit = (value * (9m / 5m)) + 32;
                    break;
                case 'K':
                    fahrenheit = (value - 273.15m) * (9m / 5m) + 32;
                    break;
            }

            fahrenheit_gauge = fahrenheit;
            return fahrenheit;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (fahrenheit_gauge > 95m && fahrenheit_gauge != 9999999)
            {
                imageTempGauge.Image = Properties.Resources.temperaturegauge_hot;
            }
            else if (fahrenheit_gauge <= 95m && fahrenheit_gauge > 75m)
            {
                imageTempGauge.Image = Properties.Resources.temperaturegauge_warm;
            }
            else if (fahrenheit_gauge <= 75m && fahrenheit_gauge > 55m)
            {
                imageTempGauge.Image = Properties.Resources.temperaturegauge_mild;
            }
            else if (fahrenheit_gauge <= 55m && fahrenheit_gauge > 33m)
            {
                imageTempGauge.Image = Properties.Resources.temperaturegauge_cold;
            }
            else if (fahrenheit_gauge < 33m)
            {
                imageTempGauge.Image = Properties.Resources.temperaturegauge_freezing;
            }
            else if (fahrenheit_gauge == 9999999)
            {
                imageTempGauge.Image = Properties.Resources.temperaturegauge_none;
            }

        }

        private void comboUnits_TextChanged(object sender, EventArgs e)
        {
            numberboxTempValue_ValueChanged(sender, e);
        }

        private void displayWarning()
        {
            MessageBox.Show("The value you entered is invalid. Please enter a valid temperature");
        }
    }
}
