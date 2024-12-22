namespace Mirpaha.Entities
{
    public class DataContext
    {
        public static List<Doctor> Doctors { get; set; }

        public DataContext()
        {
            Doctors = new List<Doctor> ();
        }
    }
}
