internal class Program
{
    private static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[3] { new Manager(), new Worker(), new Robot() };

        foreach (var worker in workers)
        {
            worker.Work();  //Bütün workerları gezip hepsine çalış emri veriyorum
        }

        IEat[] eats = new IEat[2] { new Worker(), new Manager() };

        foreach (var eat in eats)
        {
            eat.Eat();      //Yemek yiyen çalışanlar yemek yesin (Robot hariç)
        }
    }
    interface IWorker  //çalışan
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary 
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary    //Yönetici
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary     //Normal Çalışan
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}