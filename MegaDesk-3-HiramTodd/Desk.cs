using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HiramTodd
{
	class Desk
	{
		// Desk surface materials
		public enum Material { Laminate = 100, Oak = 200, Rosewood = 300, Veneer = 125, Pine = 50 }

		// Desk Constraints
		public const int MINWIDTH = 24;
		public const int MAXWIDTH = 96;
		public const int MINDEPTH = 12;
		public const int MAXDEPTH = 48;

		#region
		// Desk Description and dimensions
		public Material DeskMaterial { get; set; }
		public int Width { get; set; }
		public int Depth { get; set; }
		public int Drawers { get; set; }
		public int Area { get; set; }
		#endregion
	}
}
