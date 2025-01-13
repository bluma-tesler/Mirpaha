namespace Mirpaha.Entities
{
    public class DataContext:IDataContext
    {

        public List<Doctor> Doctors { get; set; }

        public DataContext()
        {
            Doctors = new List<Doctor>()
            {
                new Doctor()
                {
                    Id = 1,
                    Name = "Foo",
                }
            };
        }
    }
}
