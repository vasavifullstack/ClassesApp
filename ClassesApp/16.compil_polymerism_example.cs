using System;
 class Addition
    {
    public int add(int first, int second) {
        return first + second;
    }
    public int add(int first, int second,int third)
    {
        return first + second + third;
    }
    
    class Progarm { }
    static void Main(string[] args)
    { 
        Addition result = new Addition();
        
        Console.WriteLine(result.add(10, 20));
        Console.WriteLine(result.add(30,50,35));
      

    }
}
