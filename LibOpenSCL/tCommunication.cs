// 
//  tCommunication.cs
//  
//  Authors:
//       Comision Federal de Electricidad
//       Daniel Espinosa <esodan@gmail.com>
//  
//  Copyright (c) 2009 Comision Federal de Electricidad
//  Copyright (c) 2010 Daniel Espinosa
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
using System.ComponentModel;

namespace IEC61850.SCL
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iec.ch/61850/2003/SCL")]
	[System.Xml.Serialization.XmlRootAttribute("Communication", Namespace="http://www.iec.ch/61850/2003/SCL", IsNullable=false)]
	public partial class tCommunication : tUnNaming
	{		
		private tSubNetwork[] subNetworkField;
		
		private int isn;
		
		public tCommunication() {
			this.isn = 0; // Points to the unused index
		}
		
		[System.Xml.Serialization.XmlElementAttribute("SubNetwork")]
		[Category("Communication"), Browsable(false)]
		public tSubNetwork[] SubNetwork 
		{
			get 
			{
				return this.subNetworkField;
			}
			set 
			{
				this.subNetworkField = value;
			}
		}
		
		/// <summary>
		/// Adds a new Subnetwork with the given name. 
		/// </summary>
		/// <param name="name">
		/// A <see cref="System.String"/> with the name of the new subnetwork to add.
		/// </param>
		/// <returns>
		/// A <see cref="System.Int32"/> with the index of the new subnetwork.
		/// </returns>
		public int AddSubNetwork(string name, string desc) {
			if (name == null) return -1;
			
			tSubNetwork sn = new tSubNetwork();
			sn.name = name;
			sn.desc = desc;
			// FIXME: Review
			if(this.subNetworkField == null) { // Init array
				this.subNetworkField = new tSubNetwork[1];
				this.subNetworkField[0] = sn;
				return 0;
			}
			// Search for existing subnetwork
			for (int i = 0; i < this.subNetworkField.Length; i++) {
				if (name.Equals(this.subNetworkField[i].name)) {
					return -1;
				}
			}
			// Add to Array
			return AddSubNetwork(sn);
		}
		
		public int AddSubNetwork (tSubNetwork sn) {
			int index = -1;
			System.Array.Resize<tSubNetwork>(ref this.subNetworkField,
			                                 this.subNetworkField.Length + 1);
			
			index = this.subNetworkField.Length - 1;
			this.subNetworkField[index] = sn;
			return index;
		}
	}

}

