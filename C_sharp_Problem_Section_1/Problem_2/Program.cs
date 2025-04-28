using System;
using Problem_2;



class Program
{
    static void Main()
    {


        log4net.Config.BasicConfigurator.Configure();
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));


        double loan_amount=0.00;
        double interest=0.00;
        double time = 0.00;
        try
        {
            Console.WriteLine("Enter the value of loan_amount");
            loan_amount = double.Parse(Console.ReadLine());


        }
        catch (Exception ex)
        {
            log.Error(ex.GetType().Name);
        }
        try
        {
            Console.WriteLine("Enter the value of  Interest");
            interest  = double.Parse(Console.ReadLine());


        }
        catch (Exception ex)
        {
            log.Error(ex.GetType().Name);
        }
        try
        {
            Console.WriteLine("Enter the value of  Time");
            time = double.Parse(Console.ReadLine());


        }
        catch (Exception ex)
        {
            log.Error(ex.GetType().Name);
        }

        //Home_loan h1=new Home_loan(loan_amount, interest, time);
        //Car_loan c1=new Car_loan(loan_amount, interest, time);
        //Education_loan e1=new Education_loan(loan_amount, interest, time);
        //double home_loan = h1.Calculate_loan();
        //double car_loan = c1.Calculate_loan();
        //double edu_loan = e1.Calculate_loan();

        //double total_loan=home_loan+car_loan+edu_loan;

        //if (  !Double.IsInfinity((double)total_loan))
        //{
        //    log.Info($"Total loan is {total_loan}");
        //}
        //else {
        //    log.Error("NULL Value");
        
        //}

        try
        {
            Home_loan h1 = new Home_loan(loan_amount, interest, time);
            Car_loan c1 = new Car_loan(loan_amount, interest, time);
            Education_loan e1 = new Education_loan(loan_amount, interest, time);
            double home_loan = h1.Calculate_loan();
            double car_loan = c1.Calculate_loan();
            double edu_loan = e1.Calculate_loan();

            double total_loan = home_loan+car_loan+edu_loan ;

            log.Info($"Total loan is {total_loan}");
        }

        catch(Exception ex)
        {
              log.Error(ex.GetType().Name);
        }



    }
}



