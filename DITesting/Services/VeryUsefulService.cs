using System;
namespace DITesting.Services
{
	interface IVeryUsefulService1
	{
	}

	public class VeryUsefulService1 : IVeryUsefulService1
	{
		public int Number { get; set; }
		public string Name { get; set; }
		public VeryUsefulService1()
		{
			Thread.Sleep(3000); // This can be any time consuming operation, aka Database call, third-party provider API call and etc.
			Number = 1;
			Name = "VeryUsefulService1";
		}
	}
	
}

