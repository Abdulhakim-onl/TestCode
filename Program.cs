using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<IAnimal> Animals = new List<IAnimal> { new DOG("Tom"), new DOG("Bob") };

			foreach (IAnimal animal in Animals)
				animal.Voice();
			
			Console.Read();
		}

		
	}

}