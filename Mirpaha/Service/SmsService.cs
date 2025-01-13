using System.Diagnostics;

namespace Mirpaha.Service
{
    public class SmsService:IMsgService
    {

        public void Logout(string message)
        {
            Debug.WriteLine($"Sent from Sms Login {message}");
        }
        public void Login(string message)
        {
            Debug.WriteLine($"Sent from Sms Logout {message}");
        }

    }
}
