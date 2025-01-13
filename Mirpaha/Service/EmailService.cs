using System.Diagnostics;

namespace Mirpaha.Service
{
    public class EmailService:IMsgService
    {

        public void Logout(string message)
        {
            Debug.WriteLine($"Sent from Email Login {message}");
        }
        public void Login(string message)
        {
            Debug.WriteLine($"Sent from Email Logout {message}");
        }

    }
}
