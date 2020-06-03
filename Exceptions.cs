//Built and written with Treehouse

namespace BattleDefense
{
	class BattleDefenseException : System.Exception
	{	
		public BattleDefenseException()
		{

		}

		public BattleDefenseException(string message) : base(message)
		{

		}
	}

	class OutOfBoundsException : BattleDefenseException
	{
		public OutOfBoundsException()
		{

		}

		public OutOfBoundsException(string message) : base(message)
		{

		}
	}
}