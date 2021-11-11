using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	abstract	class Animal 
	{
	public  string Name { get; set; }

		public virtual void Eat()
		{
			Console.WriteLine(Name + " eats meat");
		}

		public abstract void Voice();

		public  void Sleep()
		{
			Console.WriteLine(this.Name + " asleep");
		}



	}
}
