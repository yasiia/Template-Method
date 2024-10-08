using System.Net.Security;

namespace Template_Method
{
    public abstract class TemplateMetodActivity
    {
        public void SandwichAlgoritm()
        {
            CutBread();
            AddMainIngredient();
            AddVegetables();
            AddSauce();
            Serve();
        }
        protected void CutBread()
        {
            Console.WriteLine("Sliced ​​bread");
        }
        protected abstract void AddMainIngredient();
        protected abstract void AddVegetables();
        protected abstract void AddSauce();
        protected void Serve()
        {
            Console.WriteLine("Your sandwich is ready!");
        }
    }

    public class MeatSandwich : TemplateMetodActivity
    {
        protected override void AddMainIngredient()
        {
            Console.WriteLine("Add meat and cheasse");
        }
        protected override void AddVegetables()
        {
            Console.WriteLine("Add salat and tomatos");
        }
        protected override void AddSauce()
        {
            Console.WriteLine("Add mayonnaise and mustard");
        }
    }

    public class VegetablesSandwich : TemplateMetodActivity
    {
        protected override void AddMainIngredient()
        {
            Console.WriteLine("Add cheese");
        }

        protected override void AddVegetables()
        {
            Console.WriteLine("Add salad and tomato");
        }

        protected override void AddSauce()
        {
            Console.WriteLine("Add olive oil");
        }
    }

    internal class Program {
        static void Main(string[] args)
        {
            TemplateMetodActivity meatSandwich = new MeatSandwich();
            Console.WriteLine("Start cooking");
            meatSandwich.SandwichAlgoritm();

            TemplateMetodActivity vegetablesSandwich = new VegetablesSandwich();
            Console.WriteLine("Start cooking");
            vegetablesSandwich.SandwichAlgoritm();

        }
    }
    
}
