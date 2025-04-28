using System;

namespace Problem_2
{
    public abstract class Loan
    {
        public double loan_amount;
        public double interest_rate;
        public double term_in_month;

       
        public Loan(double loan_amount, double interest_rate, double term_in_month)
        {
            this.loan_amount = loan_amount;
            this.interest_rate = interest_rate;
            this.term_in_month = term_in_month;
        }

      
        public abstract double Calculate_loan();  
    }
}
