using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager companyA_Manager = new Manager();
            string name = companyA_Manager.GetManagerName();
            System.Console.WriteLine(name);
            
            SwipeCard companyA_Card = new SwipeCard();
            System.Console.WriteLine(companyA_Card.MakerOfSwipecard());
            
            companyA_Manager.Logon(companyA_Card);
        }
    }

    public class Manager
    {
        private string name;
        public Manager() {
            name = "Pera";
        }

        public Manager(string name)
        { }

        public string GetManagerName()
        {  
            return name;
        }

        public void Logon(SwipeCard obj)
        {
            obj.Swipe(this);
        }
    }

    public class SwipeCard
    {
        public void Swipe(Manager obj)
        {
            // manager swipes card in the morning
            System.Console.WriteLine("SwipeCard class: manager on Logon called Swipe ");
        }

        public string MakerOfSwipecard()
        {
            return "TheBestCardMakingCompany";
        }
    }

}
