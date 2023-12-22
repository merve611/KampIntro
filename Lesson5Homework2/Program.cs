internal class Program
{
    private static void Main(string[] args)
    {
        //IPersonManager customerManager = new CustomerManager();
       

        //IPersonManager employeeManager = new EmployeeManager();
        

        ProjectManager projectManager = new ProjectManager();
        projectManager.Add(new InternManager());




    }

    interface IPersonManager 
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müiteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncelledi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncelledi");
        }

    }
    class ProjectManager        //tüm projeyi tek noktadan yöneteceğim class
    {
        public void Add(IPersonManager personManager)       //bununla ister employee ister customer ekleyebileceğim 
        {

            personManager.Add();

        }

    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }
}