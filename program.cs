using System;

namespace Variables
{
    class MainClass
    {
        public static void main (string() argc)
        {
            var man = new Man ();
            var cart = new cart();
            var Alien = new Alien();
        }
    }
    
    public class GeneralObject
    {
        public GeneralObject () 
        {
            public bool moves { get; set; }
            public string color { get; set;}
        }
    }
    
    public class Man : GeneralObject
    {
        public Man () 
        {
        }
        public string name  { get; set; }
        }
    
    public class cart
    {
        public string constructor  { get; set; }
    }
    public class Alien
    {
        public string planet  { get; set; }
    }
}