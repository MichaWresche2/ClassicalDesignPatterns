namespace ClassicalDesignPatterns{
public abstract class Computer 
{
   public abstract int Mhz { get; }

}

public abstract class ComputerFactory 
{
   public abstract Computer GetComputer();

}

public class ConcreteComputer:Computer 
{

   int mhz = 500;

   public override int Mhz { 

      get { return mhz; }

   }
}

public class ConcreteComputerFactory:ComputerFactory 
{
   public override Computer GetComputer() 
   {
      return new ConcreteComputer();
   }
}}