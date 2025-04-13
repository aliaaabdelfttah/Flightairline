using CivilAviationSystem.Data;
using CivilAviationSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CivilAviationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void LoadFlights()
        {
            using (var db = new AppDbContext())
            {
                var flights = db.Flights.ToList();
                FlightsListBox.Items.Clear();
                foreach (var flight in flights)
                {
                    FlightsListBox.Items.Add($"Flight: {flight.FlightNumber}, Status: {flight.Status}, Altitude: {flight.Altitude}ft, Speed: {flight.Speed} km/h");
                }
            }
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            // إضافة رحلة جديدة
            var flight = new Flight
            {
                FlightNumber = FlightNumberTextBox.Text,
                Altitude = int.Parse(AltitudeTextBox.Text),
                Speed = int.Parse(SpeedTextBox.Text),
                Status = "Airborne"
            };

            using (var db = new AppDbContext())
            {
                db.Flights.Add(flight);
                db.SaveChanges();
            }

            LoadFlights();  // إعادة تحميل الرحلات
        }

        private void UpdateFlightButton_Click(object sender, EventArgs e)
        {
            // تحديث حالة الرحلة
            var selectedFlight = FlightsListBox.SelectedItem.ToString();
            var flightNumber = selectedFlight.Split(',')[0].Split(':')[1].Trim();

            using (var db = new AppDbContext())
            {
                var flight = db.Flights.FirstOrDefault(f => f.FlightNumber == flightNumber);
                if (flight != null)
                {
                    flight.Status = "Landing";  // تحديث الحالة
                    db.SaveChanges();
                }
            }

            LoadFlights();
        }
    }
}
