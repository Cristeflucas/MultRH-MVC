namespace MultRH_MVC.Models.ViewModels
{
    public class Payment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set;}
        public string CVV { get; set; }
        public double Amount { get; set; }

    }
}
