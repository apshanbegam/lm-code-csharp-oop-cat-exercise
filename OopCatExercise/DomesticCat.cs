
using System;

namespace OopCatExercise
{
	public class DomesticCat: Cat
	{
		public DomesticCat() : base(averageHeight: 23, setting: "domestic")
		{
		}

		public override string Eat()
		{

			Random rd = new Random();
			int RandomNumber = rd.Next(1, 10);
			Console.WriteLine(RandomNumber);
			if (RandomNumber == 3)
			{
				return "It will do I suppose";
			}
			else
			{
				return "Purrrrrrr";
			}
		}
	}
}

