﻿using System;
using System.Windows;
using System.Windows.Media;

namespace kalkulator_bmi
{
    public partial class MainWindow : Window
    {
        float wysokosc;
        int waga;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            string wagastr = Waga.Text;
            string wysokoscstr = Wysokość.Text;

            if (string.IsNullOrEmpty(wagastr) || string.IsNullOrEmpty(wysokoscstr))
            {
                ShowWarning("Nie podałeś wagi i wysokości", Brushes.Red);
            }
            else if (!float.TryParse(wysokoscstr, out wysokosc) || !int.TryParse(wagastr, out waga))
            {
                ShowWarning("Wysokość i waga muszą być liczbami", Brushes.Red);
            }
            else if (waga < 0.01 || waga > 500 || wysokosc < 1 || wysokosc > 500)
            {
                ShowWarning("Podano niepoprawne wartości wagi lub wysokości", Brushes.Red);
            }
            else
            {
                double wysokosckw = Math.Round((wysokosc / 100.0) * (wysokosc / 100), 2);
                double bmi = Math.Round(waga / wysokosckw, 2);

                string category = GetBMICategory(bmi);
                ShowWarning($"{category} BMI: {bmi}", Brushes.Green);
            }
        }

        private void ShowWarning(string text, Brush color)
        {
            Warning.Text = text;
            Warning.Visibility = Visibility.Visible;
            Warning.FontSize = 15;
            Warning.Foreground = color;
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < 16f) return "Wygłodzenie";
            if (bmi <= 16.99f) return "Wychudzenie";
            if (bmi <= 18.49f) return "Niedowaga";
            if (bmi <= 24.99f) return "Waga prawidłowa";
            if (bmi <= 29.99f) return "Nadwaga";
            if (bmi <= 34.99f) return "1 stopień otyłości";
            if (bmi <= 39.99f) return "2 stopień otyłości";
            return "Otyłość skrajna";
        }
    }
}