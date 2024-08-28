using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A1q1 ques01 = new A1q1();
            ques01.func01();


            A1q2 ques02 = new A1q2();
            ques02.func02();


            A1q3 ques03 = new A1q3();
            ques03.checkBalance();
            ques03.deposit(8000);
            ques03.withdraw(18000);
            ques03.checkBalance();


            A1q4 ques04 = new A1q4();
            ques04.func04();


            A1q5 ques05 = new A1q5();
            ques05.checkPassword();


            A1q6 ques06 = new A1q6();
            ques06.GetTotalCharge();


            A1q7 ques07 = new A1q7();
            ques07.attend();
            ques07.attend();
            ques07.attend();
            ques07.attend();
            ques07.getAttendence();
            ques07.isPerfectattence();


            A1q8 ques08 = new A1q8();
            ques08.getExpenseDetails();


            A1q9 quesQ9 = new A1q9();
            quesQ9.addItem("laptop", 60000);
            quesQ9.addItem("mobile", 19000);
            quesQ9.addItem("watch", 2000);
            quesQ9.removeItem("watch");
            quesQ9.getTotalPrice();


            A1q10 ques10 = new A1q10();
            ques10.getMonthSallery();
        }
    }
    class A1q1
    {
        public void func01()
        {
            //Question 01:  Write a C# program to calculate the total price of items in a shopping cart. The cart contains 5 items with different prices.
            //Include a 10% discount if the total price exceeds Rs. 3000.

            double[] shopcart = { 1000, 2800, 3000, 1980, 1235 };
            double totalsum = 0;
            for (int i = 0; i < shopcart.Length; i++)
            {
                totalsum += shopcart[i];
            }
            if (totalsum > 3000)
            {
                totalsum = (totalsum * 90) / 100;
            }
            Console.WriteLine("Your final sum is : " + totalsum.ToString());
        }
    }
    class A1q2
    {
        public void func02()
        {
            //Question: Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit.
            //If the input temperature is below 0°C, display a warning message about freezing temperatures.
            Console.WriteLine("Enter the temperature in Celsius : ");
            double temp = double.Parse(Console.ReadLine());
            double F = ((temp * 9) / 5) + 32;
            Console.WriteLine("Temperature in fahrenheit is : " + F.ToString());
        }
    }
    class A1q3
    {
        //Question: Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money,
        //and withdraw money. Ensure that the program checks for sufficient funds before allowing a withdrawal.
        double balance = 5000;
        public void checkBalance()
        {
            Console.WriteLine("Your current balance is : " + balance.ToString());
        }
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("After depositing " + amount.ToString() + " Your New balance is : " + balance.ToString());
        }
        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient amount ");
                return;
            }
            balance -= amount;
            Console.WriteLine("After withdrawal of " + amount.ToString() + " Your new balance is : " + balance.ToString());
        }
    }
    class A1q4
    {
        public void func04()
        {
            double[] marks = new double[5];
            double totalMarks = 0;
            Console.WriteLine("Enter the marks of five subjects ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter the marks of subject " + (i + 1) + " : ");
                marks[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < marks.Length; i++)
            {
                totalMarks += marks[i];
            }
            double average = totalMarks / 5;
            if (average > 90) Console.WriteLine("Your grade is : A");
            else if (average > 80) Console.WriteLine("Your grade is : B");
            else if (average > 70) Console.WriteLine("Your grade is : C");
            else if (average < 60) Console.WriteLine("Your grade is : D");
            else
            {
                Console.WriteLine("Your grade is : F");
            }
        }
    }
    class A1q5
    {
        //Question: Develop a C# application that asks the user to enter a password. The password should be validated based on the
        //following criteria: at least 8 characters long, contains at least one uppercase letter, one lowercase letter,
        //and one number. Display appropriate messages based on the validation result.
        public void checkPassword()
        {
            Console.Write("Enter the password : ");
            string pass = Console.ReadLine();
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            if (pass.Length > 7)
            {
                foreach (char c in pass)
                {
                    if (char.IsDigit(c))
                        isDigit = true;
                    else if (char.IsLower(c))
                        isLower = true;
                    else if (char.IsUpper(c))
                        isUpper = true;
                }
                if (isUpper && isLower && isDigit)
                    Console.WriteLine("password is valid");
                return;
            }
            Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number like qRi4n9gL");
        }

    }
    class A1q6
    {
        //Question: Write a C# program to calculate the fare of a taxi ride. The fare is calculated based on the distance traveled.
        //The first 2 kilometers are charged at a flat rate (Rs. 20), and any additional kilometers are charged at a per-kilometer rate.
        //Include a night surcharge if the ride occurs after 10 PM.
        public void GetTotalCharge()
        {
            double fixedCharge = 20;
            double chargePerKm = 5;
            double totalCharge = 0;
            Console.Write("Enter the distance travelled : ");
            double dis = double.Parse(Console.ReadLine());
            Console.Write("Enter the subcharge is applied : ");
            double subCharge = double.Parse(Console.ReadLine());
            if (dis < 3)
            {
                totalCharge = totalCharge + fixedCharge;
                Console.WriteLine("Your total charge is " + totalCharge.ToString());
                return;
            }
            totalCharge = ((dis - 2) * chargePerKm) + fixedCharge + subCharge;
            Console.WriteLine("Your total charge is " + totalCharge.ToString());
        }

    }
    class A1q7
    {
        //Question: A school tracks the attendance of students over 5 days.The system should be able to record attendance,
        //calculate the total number of days attended, and identify if a student has perfect attendance.
        int attendece = 0;
        int totalAttendence = 5;
        public void getAttendence()
        {
            Console.WriteLine("Your attendence is " + (totalAttendence - attendece).ToString());
        }
        public void attend()
        {
            attendece++;
        }
        public bool isPerfectattence()
        {
            return attendece > 2 ? true : false;
        }

    }
    class A1q8
    {
        //Question: An individual tracks their expenses for each month in a year.They want to calculate the total expenses for the
        //year and identify the month with the highest and lowest expenses.
        public void getExpenseDetails()
        {
            double[] months = new double[12];
            double totalExpense = 0;
            int maxExpenseMonth = 1;
            int minExpenseMonth = 1;
            for (int i = 0; i < months.Length; i++)
            {
                Console.Write("enter expense of " + (i + 1) + " month : ");
                months[i] = double.Parse(Console.ReadLine());
                totalExpense += months[i];
            }
            for (int i = 0; i < totalExpense; i++)
            {
                if (months[maxExpenseMonth] < months[i])
                {
                    maxExpenseMonth = i;
                }
                else if (months[minExpenseMonth] > months[i])
                {
                    minExpenseMonth = i;
                }
            }
            Console.WriteLine("Maximum expense month : " + maxExpenseMonth.ToString());
            Console.WriteLine("Minimum expense month : " + minExpenseMonth.ToString());
            Console.WriteLine("Total expense of year : " + totalExpense.ToString());


        }

    }
    class A1q9
    {
        //Question: Implement a shopping cart system where a user can add items, remove items, and view the total price.
        //Assume each item has a name and a price.
        Dictionary<string, double> cart = new Dictionary<string, double>();
        double total = 0;

        public void addItem(string name, double price)
        {
            cart.Add(name, price);
            total += price;
        }
        public void removeItem(string name)
        {
            total -= cart[name];
            cart.Remove(name);

        }
        public void getTotalPrice()
        {
            Console.WriteLine("Total price is " + total.ToString());
        }

    }
    class A1q10
    {
        //Question: Create a program that calculates the monthly salary of an employee based on their hourly wage and the number of
        //hours worked in a week.Consider that there are 4 weeks in a month.

        public void getMonthSallery()
        {
            int[] weekHours = new int[4];

            int totalHours = 0;
            Console.Write("Enter the wage per hour rate : ");
            int hourWage = int.Parse(Console.ReadLine());
            for (int i = 0; i < weekHours.Length; i++)
            {
                Console.Write("Enter the hours of " + (i + 1) + "week : ");
                weekHours[i] = int.Parse(Console.ReadLine());
                totalHours += weekHours[i];
            }
            Console.WriteLine("Your tatal sallery of months is " + (totalHours * hourWage).ToString());


        }

    }
}