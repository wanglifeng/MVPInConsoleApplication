using System;

namespace MVPInConsoleApplication
{
	class MainClass:IView	{

		public MainClass()
		{
			DataController c = new DataController ();
			c.ShowData (this);
		}

		public static void Main (string[] args)
		{
			MainClass p = new MainClass ();
		}


		#region IView implementation
		public void ShowResult (String model)
		{
			Console.WriteLine (model);
		}
		#endregion
	}
}
