﻿using System;


namespace Problem_2
{
    public class Home_loan : Loan
    {
      
        public Home_loan(double loan_amount, double interest_rate, double term_in_month)
            : base(loan_amount, interest_rate, term_in_month) { }

       
        public override double Calculate_loan()
        {

            double rHomeLoan =interest_rate/ 12 / 100;  // Monthly interest rate
            double nHomeLoan = term_in_month * 12;  // Total number of installments (months)
            double EMIHomeLoan = (loan_amount * rHomeLoan * Math.Pow(1 + rHomeLoan, nHomeLoan)) / (Math.Pow(1 + rHomeLoan, nHomeLoan) - 1);
            return EMIHomeLoan;
        } 
    }
}
