using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_brasserieTest.Endpoints
{
	public static class Endpoints
	{
		public static string BASE_URL = "https://localhost:5001/api";
		#region BREWER_REGION
		public static string NEW_BEER = BASE_URL + "/bewer/newbeer";
		#endregion
	}
}
