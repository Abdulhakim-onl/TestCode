﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Delphin: Fish, ICanSwim
	{
		public Delphin(string name)
		{
			Name = name;
		}

		public void Swim()
		{
			Console.WriteLine(Name + " can swim");
		}

		public override void Voice()
		{
			Console.WriteLine(Name + ": *special lips");
		}

		public override void Eat()
		{
			Console.WriteLine(Name + " eat a wide variety of fishes");
		}
	}
}
