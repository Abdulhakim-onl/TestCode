using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Duck: Birds, ICanSwim, ICanWalk, ICanFly
	{
		public Duck(string name)
		{
			Name = name;
		}

		public void Fly()
		{
			Console.WriteLine(Name + " can fly");
		}

		public void Swim()
		{
			Console.WriteLine(Name + " can swim");
		}
		public void Walk()
		{
			Console.WriteLine(Name + " can Walk");
		}

		public override void Voice()
		{
			Console.WriteLine(Name + ": cry-cry");
		}

		public override void Eat()
		{
			Console.WriteLine(Name + " eat a insects");
		}
	}
}
