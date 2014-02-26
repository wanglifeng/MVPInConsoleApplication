using System;

namespace MVPInConsoleApplication
{
	public class DataController
	{
		public DataController ()
		{

		}

		public void ShowData(IView view)
		{
			view.ShowResult ("hello world");
		}
	}
}

