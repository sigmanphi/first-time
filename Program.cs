using System;

namespace JoelApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string n;
            string a;

            Console.WriteLine("Please enter name:");
            n = Console.ReadLine();
            Console.WriteLine("Please enter address:");
            a = Console.ReadLine();
            Person joel = new Person(n, a);
            Console.WriteLine(joel.Name + " is my name");
        }
    }

    public class Bankaccount
    {
        public decimal Balance { get; }
        public string Owner { get; set; }
        public string AccountNumber { get; }

        private static int accountstartnum = 1234567890;

        public Bankaccount(string name, decimal initialbalance)
        {
            Owner = name;
            Balance = initialbalance;
        }

        public void MakeWithdrawal (int amount, string note, DateTime date)
        {

        }

        public void MakeDeposite(int amount, string note, DateTime date)
        {

        }

    }

}
