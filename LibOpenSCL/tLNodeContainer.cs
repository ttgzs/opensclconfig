// 
//  tLNodeContainer.cs
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
	
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tConnectivityNode))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerSystemResource))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubFunction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tFunction))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tTapChanger))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubEquipment))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipment))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tGeneralEquipment))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPowerTransformer))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tAbstractConductingEquipment))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tTransformerWinding))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tConductingEquipment))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tEquipmentContainer))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBay))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tVoltageLevel))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(tSubstation))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iec.ch/61850/2003/SCL")]
	public partial class tLNodeContainer : tNaming 
	{		
		private static int index = 0;
		private tLNode[] lNodeField;
		public tLNodeContainer()
		{
			if(this.name == null )
			{
				this.name = "LNodeContainer" + ( ++index ).ToString();
			}
		}
		
		[System.Xml.Serialization.XmlElementAttribute("LNode")]
		[Category("LNodeContainer"), Browsable(false)]
		public tLNode[] LNode 
		{
			get
			{
				return this.lNodeField;
			}
			set
			{
				this.lNodeField = value;
			}
		}
	}
	

}
