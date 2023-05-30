using System;
using DITesting.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DITesting.Wrappers
{
	interface IDIWrapper {

        IVeryUsefulService1 veryUsefulService1 { get; }

		IVeryUsefulService2 veryUsefulService2 { get; }

    }
	public class DIWrapper : IDIWrapper
	{
		public DIWrapper()
		{
		}

		IVeryUsefulService1 IDIWrapper.veryUsefulService1 =>  Injector.GetService<IVeryUsefulService1>();

        IVeryUsefulService2 IDIWrapper.veryUsefulService2 => Injector.GetService<IVeryUsefulService2>();
    }
}

