namespace CustomerCommLib
{
    public class CustomerComm
    {
        private IMailSender _mailSender;
        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("cust@gmail.com", "Some Message");
            return true;
        }
    }
}
