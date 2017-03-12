using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRepayment{

    abstract class Loan{

        public abstract void setStartDate(int sY, int sM, int sD);
        public abstract void setEndDate(int eY, int eM, int eD);
        public abstract void setPrinciple(double p);
        public abstract void setAmount(double a);
        public abstract void setInterestRate(double iR);
         
        public abstract DateTime getStartDate();
        public abstract DateTime getEndDate();
        public abstract double getPrinciple();
        public abstract double getAmount();
        public abstract double getInterestRate();
    }

    class StudentLoan : Loan {
        private string name;
        private DateTime startDate;
        private DateTime endDate;
        private double principle;
        private double amount;
        private double interestRate;

        public override void setStartDate(int sY, int sM, int sD)
        {
            startDate = new DateTime(sY, sM, sD);
        }

        public override void setEndDate(int eY, int eM, int eD)
        {
            endDate = new DateTime(eY, eM, eD);
        }

        public override void setPrinciple(double p)
        {
            this.principle = p;
        }

        public override void setAmount(double a)
        {
            this.amount = a;
        }

        public override void setInterestRate(double iR)
        {
            this.interestRate = iR;
        }

        public override DateTime getStartDate()
        {
            return startDate;
        }

        public override DateTime getEndDate()
        {
            return endDate;
        }

        public override double getPrinciple()
        {
            return principle;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double getInterestRate()
        {
            return interestRate;
        }
    }

    class ParentLoan : Loan {
        private DateTime startDate;
        private DateTime endDate;
        private double principle;
        private double amount;
        private double interestRate;

        public override void setStartDate(int sY, int sM, int sD)
        {
            startDate = new DateTime(sY, sM, sD);
        }

        public override void setEndDate(int eY, int eM, int eD)
        {
            endDate = new DateTime(eY, eM, eD);
        }

        public override void setPrinciple(double p)
        {
            this.principle = p;
        }

        public override void setAmount(double a)
        {
            this.amount = a;
        }

        public override void setInterestRate(double iR)
        {
            this.interestRate = iR;
        }

        public override DateTime getStartDate()
        {
            return startDate;
        }

        public override DateTime getEndDate()
        {
            return endDate;
        }

        public override double getPrinciple()
        {
            return principle;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double getInterestRate()
        {
            return interestRate;
        }
    }

    class EquityLoan : Loan {
        private DateTime startDate;
        private DateTime endDate;
        private double principle;
        private double amount;
        private double interestRate;

        public override void setStartDate(int sY, int sM, int sD)
        {
            startDate = new DateTime(sY, sM, sD);
        }

        public override void setEndDate(int eY, int eM, int eD)
        {
            endDate = new DateTime(eY, eM, eD);
        }

        public override void setPrinciple(double p)
        {
            this.principle = p;
        }

        public override void setAmount(double a)
        {
            this.amount = a;
        }

        public override void setInterestRate(double iR)
        {
            this.interestRate = iR;
        }

        public override DateTime getStartDate()
        {
            return startDate;
        }

        public override DateTime getEndDate()
        {
            return endDate;
        }

        public override double getPrinciple()
        {
            return principle;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double getInterestRate()
        {
            return interestRate;
        }
    }

    class Four01KLoan : Loan {
        private DateTime startDate;
        private DateTime endDate;
        private double principle;
        private double amount;
        private double interestRate;

        public override void setStartDate(int sY, int sM, int sD) {
            startDate = new DateTime(sY, sM, sD);
        }

        public override void setEndDate(int eY, int eM, int eD) {
            endDate = new DateTime(eY, eM, eD);
        }

        public override void setPrinciple(double p)
        {
            this.principle = p;
        }

        public override void setAmount(double a)
        {
            this.amount = a;
        }

        public override void setInterestRate(double iR)
        {
            this.interestRate = iR;
        }

        public override DateTime getStartDate()
        {
            return startDate;
        }

        public override DateTime getEndDate()
        {
            return endDate;
        }

        public override double getPrinciple()
        {
            return principle;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double getInterestRate()
        {
            return interestRate;
        }
    }

    class Program {

        static void Main(string[] args){

            string cont = "y";

            while (cont != "n"){ 
                string lType, lName; 
                double lAmount, lIR;
                int startDate, endDate;

                Console.WriteLine("Enter the Loan Type: ");
                lType = Console.ReadLine();
                Console.WriteLine("Enter the Loan Name: ");
                lName = Console.ReadLine();
                Console.WriteLine("Enter the Amount: ");
                lAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Interest Rate: ");
                lIR = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Specify the start date (yyyy/mm/dd) for loan repayment: ");
                startDate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Do you have another Loan to enter? (y/n)");
                cont = Console.ReadLine();                
            }
        }
    }
}
