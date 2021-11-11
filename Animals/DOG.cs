using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class DOG : Zveri , ICanRun, ICanSwim
	{

		public DOG(string name)
		{
			Name = name;
		}

		public void Run()
		{
			Console.WriteLine(Name + " can run");
		}

		public void Swim()
		{
			Console.WriteLine(Name + " can swim");
		}

		public override void Voice()
		{
			Console.WriteLine(Name + ": gav-gav ");
		}

		public override void Eat()
		{
			Console.WriteLine(Name + " eats dog food");
		}
	}
}
