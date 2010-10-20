// 
//  tSubEquipment.cs
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
namespace IEC61850.SCL
{
	
	/*
	 * The symbol @ was added to the name of virtual variable to avoid problems 
	 * with the compiler.
	*/
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.iec.ch/61850/2003/SCL")]
	public partial class tSubEquipment : tPowerSystemResource 
	{		
		private tPhaseEnum phaseField;		
		private bool virtualField;
		
		public tSubEquipment() 
		{
			this.phaseField = tPhaseEnum.none;
			this.virtualField = false;
		}
		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[Category("SubEquipment"), Description("The phase to which the subdevice belongs.")]
		public tPhaseEnum phase 
		{
			get 
			{
				return this.phaseField;
			}
			set 
			{
				this.phaseField = value;
			}
		}
		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[Category("SubEquipment"), Description("A virtual equipment")]
		public bool @virtual 
		{
			get 
			{
				return this.virtualField;
			}
			set
			{
				this.virtualField = value;
			}
		}
	}
}

