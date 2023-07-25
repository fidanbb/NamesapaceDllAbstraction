using System;
namespace ClassWrk_DLL_Abstraction
{
	public abstract class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public abstract void Sound();
	}
}

