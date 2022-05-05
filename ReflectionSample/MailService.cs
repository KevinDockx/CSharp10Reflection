namespace ReflectionSample
{
    public class MailService
    {
        public void SendMail(string address, string subject)
        {
            Console.WriteLine($"Sending a warning mail to {address} with subject {subject}.");
        }
    }
}
