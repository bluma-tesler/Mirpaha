using Mirpaha.Controllers;
using Mirpaha.Entities;

namespace TestDoctors
{
    public class DoctorUnitTest

    {
        [Fact]
        public void GetDoctor_Ok()
        {
            int id = 1;
            doctorController controller = new doctorController(new FaceContext());
            var res = controller.Get(id);
            Assert.IsType<Doctor>(res);
        }
    }
}