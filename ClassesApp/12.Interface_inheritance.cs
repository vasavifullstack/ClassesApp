
////When an interface inherits another interface, it means:

////Child interface = rules of parent interface +its own new rules

////Classes that implement that child interface must implement:
////✔ Parent interface methods
////✔ Child interface methods
//using InterfaceInheticanceBasics;
//using System.ComponentModel;
//using System.Reflection;


using System;


namespace RemotingSystem
{
    interface IRemote
    {
        void PowerOn();
        void PowerOff();
        void IncreaseVolume();
        void ChangeChannel(int channelNumber);
    }

    interface IRemotePrice
    {
        string getPriceDetails();
    }

    interface IRemoteLocationDetails
    {
        string getLocation();
    }

    class SonyRemote : IRemote, IRemotePrice
    {
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Sony TV changed to channel {channelNumber}.");
        }

        public void IncreaseVolume()
        {

            Console.WriteLine("Sony TV volume increased.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Sony TV is now Off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("Sony TV is now ON.");
        }


        public void A()
        {

        }

        public void B()
        {

        }

        public void C()
        {

        }

        public string getPriceDetails()
        {
            return "500Rupees";
            //throw new NotImplementedException();
        }


        //public void asfjalsfvakjskfasfaskjd()
        //{

        //}
    }


    class LGRemote : IRemote, IRemoteLocationDetails
    {
        public void ChangeChannel(int channerlNumber)
        {
            Console.WriteLine($"LG TV changed to channel {channerlNumber}.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("LG TV volume increased.");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG TV is now Off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG TV is now On.");
        }

        public string getLocation()
        {
            return "Bengolore";
        }
    }

    class Program
    {
        static void Main()
        {
            //SonyRemote sr = new SonyRemote();
            //sr.
            // or 
            IRemote remote = new SonyRemote();
            remote.PowerOn();
            remote.PowerOff();
            remote.IncreaseVolume();
            remote.ChangeChannel(10);

            IRemotePrice priceRemote = new SonyRemote();
            string priceDetails = priceRemote.getPriceDetails();
            Console.WriteLine(priceDetails);


            IRemote lgremote = new LGRemote();
            lgremote.PowerOn();
            lgremote.PowerOff();
            lgremote.IncreaseVolume();
            lgremote.ChangeChannel(10);

            IRemoteLocationDetails remotePricedetails = new LGRemote();
            string loctionDetails = remotePricedetails.getLocation();
            Console.WriteLine(loctionDetails);







            //remote.A();


        }
    }

}
////An interface is a contract — it declares members (methods/properties) but no implementation (no method bodies).

////Any class (or struct) that says : InterfaceName must implement every member declared by that interface.

////Interface members are implicitly public — you cannot declare private/protected inside an interface.

//If a class declares class Employee : Interface3, the compiler requires the class to provide public implementations for all five members above.
//If any are missing, the class must be marked abstract or the code will not compile.


//Interfaces can inherit multiple interfaces. That’s allowed and common: Interface3: Interface1, Inteface2.

//Classes can implement many interfaces (multiple interface implementation), e.g. class X : InterfaceA, InterfaceB.

//No fields or constructors in (classic) interfaces — they describe behavior, not state. (Modern C# adds limited default/interface static members — advanced topic.)

//Implementing class must implement every inherited member (unless the class is abstract).

//You can hold an object in any interface type it implements:

//Interface1 i1 = new Employee(); → you can call only Interface1 members on i1.

//Interface3 i3 = new Employee(); → you can call all members in Interface3 (which includes those from Interface1 and Inteface2).