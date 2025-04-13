namespace CivilAviationSystem.Models
{
    public class Flight
    {
        public int Id { get; set; }  // معرف الرحلة
        public string FlightNumber { get; set; }  // رقم الرحلة
        public int Altitude { get; set; }  // الارتفاع (بالقدم)
        public int Speed { get; set; }  // السرعة (بالكلم/ساعة)
        public string Status { get; set; }  // الحالة (مثل Airborne، Landing، Emergency)
    }
}
