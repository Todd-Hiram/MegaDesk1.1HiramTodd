using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HiramTodd
{
	class DeskQuote
	{
		#region
		//Quote information
		public string CustomerName;
		public DateTime QuoteDate;
		public Desk Desk = new Desk();
		public int QuoteTotal;
		public int RushDays;
		#endregion

		#region
		private const int BASE_PRICE = 200;
		private const int THRESHOLD_SIZE = 1000;	// Square Inches
		private const int THRESHOLD_RUSH = 2000;
		private const int PER_DRAWER_PRICE = 50;
		private const int PER_AREA_PRICE = 1;		// Cost per squate inches over THRESHOLD_SIZE
		private const int RUSH1 = 3;				// 3 day rush order. Less than 1000
		private const int RUSH2 = 5;				// 5 day rush order. Less than 1000 to 2000
		private const int RUSH3 = 7;				// 7 day rush order. Less greater than 2000
		#endregion

		public DeskQuote(string customterName, DateTime quoteDate, int width, int depth, int drawers, DesktopMaterial material, int rushODays)
		{
			CustomerName = customterName;
			QuoteDate = quoteDate;
			Desk.Width = width;
			Desk.Depth = depth;
			Desk.Drawers = drawers;
			Desk.DesktopMaterial = material;
			RushDays = rushODays;

			//Store and calculate area
			Desk.Area = Desk.Width * Desk.Depth;
		}
	}

}
