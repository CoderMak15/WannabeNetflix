namespace Netflix.src
{
    public class CreditCard
    {
        public CreditCard(int number, DateTime expiry, int pin)
        {
            _number = number;
            _expiry = expiry;
            _pin = pin;
        }

        protected int _number;
        protected DateTime _expiry;
        protected int _pin;
    }
}
