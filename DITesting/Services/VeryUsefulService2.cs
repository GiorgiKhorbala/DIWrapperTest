using System;
namespace DITesting.Services
{
    interface IVeryUsefulService2
    {
        string DoWork();
    }

    public class VeryUsefulService2 : IVeryUsefulService2
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public string DoWork()
        {
            return "I've done some work";
        }
    }
}

