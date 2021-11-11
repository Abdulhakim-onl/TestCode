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
			List<IAnimal> Animals = new List<IAnimal> { new DOG("Tom"), new Duck("Ducky"), new Delphin("Delfi") };

			foreach (IAnimal animal in Animals)
				if (animal is ICanWalk)
					Move(animal as ICanWalk);
			
			Console.Read();
		}

		private static void Move(ICanWalk canWalk)
		{
			canWalk.Walk();
		}
	}

}