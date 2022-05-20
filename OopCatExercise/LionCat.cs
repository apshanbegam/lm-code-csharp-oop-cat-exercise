
namespace OopCatExercise
{
	public class LionCat : Cat
	{
		public LionCat() : base(averageHeight: 30, setting: "wild")
		{
		}

		public override string Eat()
		{
			return "Roar!!!!";
		}
	}
}

