//
//  AccessPointNode.cs
//
//  Author:
//       Daniel Espinosa <esodan@gmail.com>
//
//  Copyright (c) 2013 Daniel Espinosa
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using IEC61850.SCL;

namespace OpenSCL.UI
{
	public class AccessPointNode : GenericNode
	{
		static int n = 1;
		public AccessPointNode (tAccessPoint ap)
		{
			if (ap == null) return;

			Name = "AccessPoint: " + ap.name;
			Tag = ap;
			if (ap.Server != null) {
				if (ap.Server.LDevice != null) {
					for (int i = 0; i < ap.Server.LDevice.Length; i++) {
						var n = new LogicalDeviceNode (ap.Server.LDevice[i]);
						Nodes.Add (n);
					}
					Expand ();
				}
			}
			var cxm = new System.Windows.Forms.ContextMenuStrip ();
			var addld = new System.Windows.Forms.ToolStripMenuItem ("Add Logical Device", null, on_add_ld);
			cxm.Items.Add (addld);
			base.ContextMenuStrip = cxm;
		}

		public void on_add_ld (object sender, EventArgs args)
		{
			var ld = new tLDevice ();
			ld.inst = "TEMPLATE" + AccessPointNode.n.ToString ();
			((tAccessPoint) Tag).Server.AddLDevice (ld);
			var n = new LogicalDeviceNode (ld);
			Nodes.Add (n);
			AccessPointNode.n++;
		}
	}
}
