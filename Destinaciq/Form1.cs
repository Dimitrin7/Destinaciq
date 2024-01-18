using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destinaciq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            decimal budget = decimal.Parse(SumaCombo.SelectedItem.ToString());
            string season = vidDestinaciqSezonCombo.SelectedItem.ToString();

            string destination = "";
            string vacationType = "";
            decimal expenses = 0;
           



            if (budget <= 100)
            {
                destination = "България";
                vacationType = (season == "Лято") ? "Къмпинг" : "Хотел";
                expenses = (season == "Лято") ? budget * 0.3m : budget * 0.7m;
            }
            else if (budget <= 1000)
            {
                destination = "Балканите";
                vacationType = (season == "Лято") ? "Къмпинг" : "Хотел";
                expenses = (season == "Лято") ? budget * 0.4m : budget * 0.8m;
            }
            else
            {
                destination = "Европа";
                vacationType = "Хотел";
                expenses = budget * 0.9m;
            }


            if (budget <= 100)
            {
                destination = "България";
                vacationType = (season == "Лято") ? "Къмпинг" : "Хотел";
            }
            else if (budget <= 1000)
            {
                destination = "Балканите";
                vacationType = (season == "Лято") ? "Къмпинг" : "Хотел";
            }
            else
            {
                destination = "Европа";
                vacationType = "Хотел";
            }


            string season1 = vidDestinaciqSezonCombo.SelectedItem.ToString();
            string vacantionType = (season == "Лято") ? "Къмпинг" : "Хотел";

            DisplayResult(destination, vacationType, expenses);
        }

        private void DisplayResult(string destination, string vacationType, decimal expenses)
        {
            MessageBox.Show($"Някъде в {destination}\n{vacationType} - {expenses:F2}");
        }

        private void vidDestinaciqSezonCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void SumaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KumpingHotelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            vidDestinaciqSezonCombo.SelectedIndex = -1;
            SumaCombo.SelectedIndex = -1;
            
            
        }
    }

    
    }

