namespace Mirpaha.Entities
{
    public class FaceContext:IDataContext
    {

        public List<Doctor> Doctors { get; set; }

        public FaceContext()
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
