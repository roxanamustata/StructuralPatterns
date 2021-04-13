namespace FacadePattern
{
    public class LeaseFacade
    {
        private Premises _premises;
        private Parties _parties;
        private Rent _rent;
        private Clauses _clauses;

      public LeaseFacade()
        {
            _premises = new Premises();
            _parties = new Parties();
            _rent = new Rent();
            _clauses = new Clauses();
        }
        
       public void SetPremises()
        {
            _premises.Set();
        }

        public void SetParties()
        {
            _parties.Set();
        }
        public void SetRent()
        {
            _rent.Set();
        }
        public void SetClauses()
        {
            _clauses.Set();
        }

        public void GenerateLease()
        {
            SetParties();
            SetPremises();
            SetRent();
        }
    }
}
