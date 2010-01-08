// LibOpenSCL
//
// Copyright (C) 2009 Comisión Federal de Electricidad
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 3 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using IEC61850.SCL;

namespace OpenSCL
{	
	public struct IEDConnectedAP {
		int i;
		int a;
		int s;
		int c;
		public IEDConnectedAP (int i, int a, int s, int c)
		{
			this.i = i;
			this.a = a;
			this.s = s;
			this.c = c;
		}
		public int ied {
			set { i = value; }
			get { return i;}
		}
		public int ap {
			set { a = value; }
			get { return a; }
		}
		public int subnetwork {
			set { s = value; }
			get { return s; }
		}
		public int connectedap {
			set { c = value;}
			get { return c; }
		}
	}
	
	/// <summary>
	/// This class uses functions that involve an XML File.
	/// </summary>
	public class Object
	{
		// An Errors List that occurs when a serialization or deserialization is 
		// executed.
		List<ErrorsManagement> ListErrors;
		private ObjectManagement objectManagement;
		private SCL configuration;
		private string filename;
		
		// FIXME: It returns a TRUE value if the configuration is generic, 
		// if it's loaded from CID or ICD this must be set to FALSE.
		protected bool genericConfiguration;
		
		public string id 
		{
			get 
			{
				return this.configuration.Header.id;
			}
			set 
			{
				this.configuration.Header.id = value;
			}
		}
		
		public bool HaveRevisionInformation()
		{
			if (this.configuration.Header != null)
				return true;
			else
				return false;
		}
		
		public IEC61850.SCL.tHitem[] RevisionHistory 
		{
			get 
			{
				if (this.configuration.Header.History != null)
					return this.configuration.Header.History;
				else
					return null;
			}
			set 
			{
				this.configuration.Header.History = value;
			}
		}
		
		public bool AppendHistoryItem (string version, string revision, 
		                           string when, string who, 
		                           string what, string why)
		{
			if (this.RevisionHistory != null)
			{
				System.Collections.ArrayList history = 
						(System.Collections.ArrayList) this.RevisionHistory.GetEnumerator();
				tHitem item = new tHitem();
				
				item.version = version;
				item.revision = revision;
				item.when = when;
				item.what = what;
				item.who = who;
				item.why = why;
				
				history.Add(item);
				
				return true;
			}
			
			return false;
		}
		
			
		public string FileName 
		{
			get 
			{
				return this.filename;
			}
			set 
			{
				this.Deserialize (value);
				this.filename = value;
			}
		}
		
		public string Description 
		{
			get 
			{
				if(this.configuration.Header.Text != null)
					return this.configuration.Header.Text.source;
				else
					return null;
			}
			set 
			{
				if(this.configuration.Header.Text != null)
					this.configuration.Header.Text.source = value;
			}
		}

		/// <summary>
   		/// FIXME: It returns a configuration of an IED according to an XML file.
   		/// </summary>
		public tIED[] Devices 
		{
			get 
			{
				return this.configuration.IED;
			}
			set 
			{
				this.configuration.IED = value;
			}
		}
		
   		/// <summary>
   		/// It returns an SCL object.
   		/// </summary>
		public SCL Configuration 
		{
			get 
			{
				return this.configuration;
			}
			set 
			{
				this.configuration = value;
			}
		}
		
   		/// <summary>
   		/// It returns the value of the attribute "ConfigurationVersion" 
   		/// that belongs to the SCL file's Header.
   		/// </summary>
		public string Version 
		{
			get 
			{
				if (this.configuration.Header != null)
					return this.configuration.Header.version;
				else 
					return null;
			}
			set 
			{
				if (this.configuration.Header != null)
					this.configuration.Header.version = value;
				else
				{
					this.configuration.Header = new tHeader();
					this.configuration.Header.version = value;
				}
			}
		}
		
   		/// <summary>
   		/// It returns the value of the attribute "ConfigurationRevision" 
   		/// that belongs to the Header of an XML file.
   		/// </summary>
		public string Revision 
		{
			get 
			{
				if(this.configuration.Header != null)
					return this.configuration.Header.revision;
				else
					return null;
			}
			set 
			{
				if (this.configuration.Header != null)
					this.configuration.Header.revision = value;
				else
				{
					this.configuration.Header = new tHeader();
					this.configuration.Header.revision = value;
				}
			}
		}
		
		public Object()
		{
			this.ListErrors = new List<ErrorsManagement>();
			this.objectManagement = new ObjectManagement();
		}
		
		public Object(string filepath)
		{
			this.ListErrors = new List<ErrorsManagement>();
			this.objectManagement = new ObjectManagement();
			this.filename = filepath;
			this.Deserialize (filepath);
		}
		
		public bool IsSCD ()
		{
			if (this.Devices.GetLength(0) > 1)
				return true;
			else
				return false;
		}
		
		public bool Serialize()
		{
			return this.Serialize(this.filename);
		}
		
   		/// <summary>
   		/// This method creates an XML file using a serialize function.
   		/// </summary>
   		/// <param name="nameFileXML">
   		/// Name of the XML File, including directory where is located the file.
   		/// </param>
   		/// <remarks>
   		/// The directory shall exist, and the name file shouldn't exist. 		
   		///  </remarks>
		public bool Serialize(string nameFileXML)
		{         	        	
        	XmlSerializer serializer = new XmlSerializer(typeof(SCL));
        	TextWriter writer = new StreamWriter(nameFileXML);       	        	       	
        	serializer.Serialize(writer, this.configuration);
        	writer.Dispose();
			this.filename = nameFileXML;
			return true;
   		}
		
   		/// <summary>
   		/// This method gets the information of an XML file and sets to SCL objects 
   		/// using the deserialize function.
   		/// </summary>
   		/// <param name="nameFileXML">
   		/// Name of the XML File, including directory where is located the file.
   		/// </param>
   		/// <returns>
   		/// If an attribute or a node is unknown then a list of error is returned.
   		/// </returns>
   		/// <remarks>
   		/// The directory and the XML File shall exist.
   		/// </remarks>
   		//public List<ErrorsManagement> Deserialize(string nameFileXML)
   		public bool Deserialize()
		{
			this.Deserialize(this.filename);
			return true; // API Change required
		}
			
		public void Deserialize(string nameFileXML)
		{
			XmlSerializer XS = new XmlSerializer(typeof(SCL));
    	   	XS.UnknownNode+= new XmlNodeEventHandler(UnknownNode);
           	XS.UnknownAttribute+= new XmlAttributeEventHandler(UnknownAttribute);        
           	FileStream fs = File.OpenRead(nameFileXML);         	
            this.configuration =(SCL) XS.Deserialize(fs);
			this.filename = nameFileXML;
            fs.Dispose();           
		}   		 		   		
   		
		
		
		
		// IED Related functions
		
		/// <summary>
		/// This method imports an ICD or CID file to the project file.
		/// </summary>
		/// <param name="objectSCLProject">
		/// SCL object of the project file.
		/// </param>
		/// <param name="objectSCLToImport">
		/// SCL object created using the deserializer method on the ICD or CID file of the IED to import.
		/// </param>
		/// <returns>
		/// The SCL object of the IED imported.
		/// </returns>
		public SCL ImportIED(SCL objectSCLProject, SCL objectSCLToImport)
		{
			SCL objectIEDToImport;
			objectIEDToImport = objectSCLToImport;			
			if(objectIEDToImport.IED!=null)
			{
				for(int y=0; y < objectSCLProject.IED.Length; y++)
				{
					if(objectSCLToImport.IED[0].name.Equals(objectSCLProject.IED[y].name))
					{
						return null;
					}
				}
				this.objectManagement.AddArrayObjectToParentObject(objectIEDToImport.IED, objectSCLProject);						
			}				
			if(objectSCLToImport.Communication!=null)
			{
				if(objectSCLProject.Communication !=null)
				{
					this.objectManagement.AddArrayObjectToParentObject(objectIEDToImport.Communication.AnyAttr, objectSCLProject.Communication);
					this.objectManagement.AddArrayObjectToParentObject(objectIEDToImport.Communication.Any, objectSCLProject.Communication);
					this.objectManagement.AddArrayObjectToParentObject(objectIEDToImport.Communication.Private, objectSCLProject.Communication);					
					bool Subnetfound = false;
					for(int i=0; i < objectSCLProject.Communication.SubNetwork.Length; i++)
					{
						for(int j=0; j < objectIEDToImport.Communication.SubNetwork.Length; j++)
						{
							if (objectSCLProject.Communication.SubNetwork[i].name == objectSCLToImport.Communication.SubNetwork[j].name)
							{					
								this.objectManagement.AddArrayObjectToParentObject(objectIEDToImport.Communication.SubNetwork[j].ConnectedAP, objectSCLProject.Communication.SubNetwork[i]);
								Subnetfound = true;
							}							
						}
					}	
					if (!Subnetfound)
					{						
						this.objectManagement.AddArrayObjectToParentObject(objectIEDToImport.Communication.SubNetwork, objectSCLProject.Communication);						
					}
				}	
				else
				{											
					objectSCLProject.Communication = objectIEDToImport.Communication;					
				}
			}				
			if(objectIEDToImport.DataTypeTemplates!=null)
			{
				if(objectSCLProject.DataTypeTemplates !=null)
				{
					this.ValidateIDName(objectIEDToImport.DataTypeTemplates.LNodeType, objectSCLProject.DataTypeTemplates.LNodeType, objectIEDToImport.DataTypeTemplates, objectSCLProject.DataTypeTemplates);
					this.ValidateIDName(objectIEDToImport.DataTypeTemplates.DOType, objectSCLProject.DataTypeTemplates.DOType, objectIEDToImport.DataTypeTemplates, objectSCLProject.DataTypeTemplates);
					this.ValidateIDName(objectIEDToImport.DataTypeTemplates.DAType, objectSCLProject.DataTypeTemplates.DAType, objectIEDToImport.DataTypeTemplates, objectSCLProject.DataTypeTemplates);
					this.ValidateIDName(objectIEDToImport.DataTypeTemplates.EnumType, objectSCLProject.DataTypeTemplates.EnumType, objectIEDToImport.DataTypeTemplates, objectSCLProject.DataTypeTemplates);										
				}		
				else
				{
					objectSCLProject.DataTypeTemplates = objectIEDToImport.DataTypeTemplates;
				}
			}		
			return objectIEDToImport;
		}
		
		public IEC61850.SCL.tIED GetIED (int iedIndex)
		{
			if (this.Devices == null)
				return null;
			if (iedIndex < 0 || iedIndex > this.Devices.GetLength(0))
				return null;
			
			return Devices[iedIndex];
		}
		
		public IEC61850.SCL.tAccessPoint[] GetAP (string iedName)
		{
			if (this.Devices == null)
				return null;
			int ied = GetIED(iedName);
			if (ied < 0)
				return null;
			else
				return Devices[ied].AccessPoint;
		}
		
		public IEC61850.SCL.tAccessPoint[] GetAP (int iedIndex)
		{
			if (this.GetIED(iedIndex) == null)
				return null;
			return Devices[iedIndex].AccessPoint;
		}
		
		public IEC61850.SCL.tAccessPoint GetAP (string iedName, string apName)
		{
			int ied = GetIED(iedName);
			int ap = GetAP(ied, apName);
			return Devices[ied].AccessPoint[ap];
		}
		
		public IEC61850.SCL.tAccessPoint GetAP (int iedIndex, int apIndex)
		{
			if (iedIndex < 0)
				return null;
			if (apIndex < 0)
				return null;
			
			if (this.Devices == null)
				return null;
			if (iedIndex > this.Devices.GetLength(0))
				return null;
			if (apIndex > this.Devices[iedIndex].AccessPoint.GetLength(0))
				return null;
			
			return this.Devices[iedIndex].AccessPoint[apIndex];
		}
		
		// LogicalDevices Related methods
		
		public IEC61850.SCL.tLDevice[] GetLD (string iedName, string apName)
		{
			int ied = this.GetIED(iedName);
			int ap = this.GetAP(ied, apName);
			
			if (ied < 0 || ied > Devices.GetLength(0) 
			    || ap < 0 || ap > Devices.GetLength(0))
				return null;
			
			return Devices[ied].AccessPoint[ap].Server.LDevice;
		}
		
		public IEC61850.SCL.tLDevice[] GetLD (int iedIndex, int apIndex)
		{
			if (iedIndex < 0 || iedIndex > Devices.GetLength(0) 
			    || apIndex < 0 || apIndex > Devices.GetLength(0))
				return null;
			
			return Devices[iedIndex].AccessPoint[apIndex].Server.LDevice;
		}
		
		public IEC61850.SCL.tLDevice[] GetLD (int iedIndex)
		{
			if (iedIndex < 0 || iedIndex > Devices.GetLength(0))
				return null;
			
			if (Devices[iedIndex].AccessPoint.GetLength(0) == 1)
				return Devices[iedIndex].AccessPoint[0].Server.LDevice;
			else
				return null;
		}
		
		public IEC61850.SCL.tLDevice[] GetLD (string iedName)
		{
			int ied = GetIED(iedName);
			
			if (ied < 0)
				return null;
			
			if (Devices[ied].AccessPoint.GetLength(0) == 1)
				return Devices[ied].AccessPoint[0].Server.LDevice;
			else
				return null;
		}
		
		public IEC61850.SCL.tLDevice GetLD (int iedIndex, int apIndex, int ldIndex)
		{
			if (Devices == null)
				return null;
			if (iedIndex < 0 || iedIndex > Devices.GetLength(0))
				return null;
			
			if (Devices[iedIndex].AccessPoint == null)
				return null;
			if (apIndex < 0 || apIndex > Devices[iedIndex].AccessPoint.GetLength(0))
				return null;
			
			if (Devices[iedIndex].AccessPoint[apIndex].Server == null)
				return null;
			if (Devices[iedIndex].AccessPoint[apIndex].Server.LDevice == null)
				return null;
			if (ldIndex < 0 
			    || ldIndex > Devices[iedIndex].AccessPoint[apIndex].Server.LDevice.GetLength(0))
				return null;
			
			return Devices[iedIndex].AccessPoint[apIndex].Server.LDevice[ldIndex];
		}
		
		/// <summary>
		/// Gets the Index of Logical Device named "name". LD's name must be "InstanceLDName", first
		/// the LD instance and then  LD name.
		/// </summary>
		/// <param name="iedIndex">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="apIndex">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="name">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Int32"/>
		/// </returns>
		private int GetLD (int iedIndex, int apIndex, string name)
		{
			if (Devices == null)
				return -1;
			if (iedIndex < 0 || iedIndex > Devices.GetLength(0))
				return -1;
			
			if (Devices[iedIndex].AccessPoint == null)
				return -1;
			if (apIndex < 0 || apIndex > Devices[iedIndex].AccessPoint.GetLength(0))
				return -1;
			
			if (Devices[iedIndex].AccessPoint[apIndex].Server == null)
				return -1;
			if (Devices[iedIndex].AccessPoint[apIndex].Server.LDevice == null)
				return -1;
			
			int pos = -1;
			for (int i = 0; i < Devices[iedIndex].AccessPoint[apIndex].Server.LDevice.GetLength(0); i++) {
				string ldname = Devices[iedIndex].AccessPoint[apIndex].Server.LDevice[i].inst;
				ldname += Devices[iedIndex].AccessPoint[apIndex].Server.LDevice[i].ldName;
				if (ldname.Equals(name))
				{
					pos = i;
					break;
				}
			}			
			return pos;
		}
		
		private int GetAP (int iedIndex, string name)
		{
			int pos = -1;
			for (int i = 0; i < Devices[iedIndex].AccessPoint.GetLength(0); i++) {
				if (Devices[iedIndex].AccessPoint[i].name.Equals(name))
				{
					pos = i;
					break;
				}
			}			
			return pos;
		}
		
		public int GetIED (string name)
		{
			if (this.Devices == null)
				return -1;
			if (name.Equals(null))
				return -1;
			
			int pos = -1;
			for (int i = 0; i < this.Devices.GetLength(0); i++) {
				if (this.Devices[i].name.Equals(name)) {
					pos = i;
					break;
				}
			}			
			return pos;
		}
	
		// Communications
		
		public tSubNetwork[] Subnetworks
		{
			get {
				return this.configuration.Communication.SubNetwork;
			}
			
			set {
				this.configuration.Communication.SubNetwork = value;
			}
		}
		
		public int GetSubnetwork (string name)
		{
			if (this.configuration.Communication == null)
				return -1;
			if (this.configuration.Communication.SubNetwork == null)
				return -1;
			int pos = -1;
			for (int i = 0; i < this.configuration.Communication.SubNetwork.GetLength(0); i++)
			{
				if ( this.configuration.Communication.SubNetwork[i].name.Equals(name))
				{
					pos = i;
					break;
				}
			}
			
			return pos;
		}
		
		public tConnectedAP GetIEDConnectedAP (int subnetIndex, int connectedapIndex)
		{
			if(subnetIndex < 0)
				return null;
			if (connectedapIndex < 0)
				return null;		
			if(this.Subnetworks == null)
				return null;
			if(subnetIndex > this.Subnetworks.GetLength(0))
				return null;
			if(this.Subnetworks[subnetIndex].ConnectedAP == null)
				return null;
			if(connectedapIndex > this.Subnetworks[subnetIndex].ConnectedAP.GetLength(0))
				return null;
			
			return this.Subnetworks[subnetIndex].ConnectedAP[connectedapIndex];
			
		}
			
		public  System.Collections.ArrayList
			GetIEDConnectedAP (string iedName)
		{
			if (iedName.Equals(null))
				return null;
			
			return this.GetIEDConnectedAP (iedName);
		}
		
		public System.Collections.ArrayList 
			GetIEDConnectedAP (int iedIndex)
		{
			if (this.configuration.Communication == null)
			    return null;
			if (this.configuration.Communication.SubNetwork == null)
				return null;
			
			tIED ied = this.GetIED (iedIndex);
			if (ied == null)
				return null;
			
			if (ied.AccessPoint == null)
				return null;
			
			System.Collections.ArrayList
					res = new System.Collections.ArrayList ();
			
			for (int nap = 0; nap < ied.AccessPoint.GetLength(0); nap++) {
				tAccessPoint ap = this.GetAP(iedIndex, nap);			                                      
				
				
				for (int i = 0; i < this.configuration.Communication.SubNetwork.GetLength(0); i++)
				{
					for (int j=0; 
					     j < this.configuration.Communication.SubNetwork[i].ConnectedAP.GetLength(0); 
					     j++)
					{
						
						if (this.configuration.Communication
						    .SubNetwork[i].ConnectedAP[i].iedName.Equals(ied.name) 
						    &&
						    this.configuration.Communication
						    .SubNetwork[i].ConnectedAP[i].apName.Equals(ap.name))
						{
							IEDConnectedAP c = new IEDConnectedAP();
							c.subnetwork = i;
							c.connectedap = j;
							c.ied = iedIndex;
							c.ap = nap;
							res.Add (c);
						}
					}
				}	
			}
			
			return res;
		}
		
		// Substation
		
		public tSubstation[] Substation
		{
			get {
				return this.configuration.Substation;
			}
			
			set {
				this.configuration.Substation = value;
			}
		}
		
		/// <summary>
		/// This method is executed when XmlSerializer finds an unknown XML node during the 
		/// deserialize method.
		/// </summary>
		/// <param name="sender">
		/// Event's source.</param>
		/// <param name="e">
		/// An XmlNodeEventArgs that contains the event's data.
		/// </param>
		/// <remarks>
		/// This method occurs only when the Deserialize method is used.
		/// </remarks>
		private void UnknownNode(object sender, XmlNodeEventArgs e)
    	{	        
			ListErrors.Add(new ErrorsManagement("Unknown node:"+ e.Name + "\t" + e.Text));
	    }
		
		/// <summary>
		/// This method is executed when XmlSerializer finds an unknown XML attribute 
		/// during the deserialize method.
		/// </summary>
		/// <param name="sender">
		/// Event's source.</param>
		/// <param name="e">
		/// An XmlAttributeEventArgs that contains the event data.
		/// </param>
		/// <remarks>
		/// This method occurs only when the Deserialize method is used.
		/// </remarks>
   		private void UnknownAttribute(object sender, XmlAttributeEventArgs e)
    	{
        	System.Xml.XmlAttribute attr = e.Attr;        	
        	ListErrors.Add(new ErrorsManagement("Unknown attribute:"+ attr.Name + "='" + attr.Value + "'"));
    	}	  		
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="arrayToImport">
		/// 
		/// </param>
		/// <param name="arraySCLProject">
		/// 
		/// </param>
		/// <param name="ParentToImport">
		/// 
		/// </param>
		/// <param name="ParenSCLProyect">
		/// 
		/// </param>
		private void ValidateIDName(object[] arrayToImport, object[] arraySCLProject, object ParentToImport, object ParenSCLProyect)
		{			
			bool bandAddObject=true;
			for(int x = 0, i=0; arrayToImport != null && x < arrayToImport.Length;x++)
			{
				for(int y = 0; arraySCLProject!=null && y < arraySCLProject.Length; y++)
				{
					if((arrayToImport[x] as tIDNaming).id.Equals((arraySCLProject[y] as tIDNaming).id))
					{						
						this.objectManagement.RemoveObjectOfArrayObjectOfParentObject(arrayToImport[x], i, ParentToImport);
						bandAddObject=false;						
						break;
					}
				}
				if(bandAddObject)
				{
					this.objectManagement.AddObjectToArrayObjectOfParentObject(arrayToImport[x], ParenSCLProyect);
					i++;					
				}
				bandAddObject=true;
			}
		}
		
		public string GetPDescription (int type)
		{
			string text = "";
			switch (type)
			{
			case (int) tPTypeEnum.IP:
				text = "TCP/IP Address";
				break;
			case (int) tPTypeEnum.IP_SUBNET:
				text = "Subnetwork Mask for TCP/IP profiles";
				break;
			case (int) tPTypeEnum.IP_GATEWAY:
				text = "First Hop IP gateway address for TCP/IP profiles";
				break;
			case (int) tPTypeEnum.OSI_NSAP:
				text = "OSI Network Address";
				break;
			case (int) tPTypeEnum.OSI_TSEL:
				text = "OSI Transport Selector";
				break;
			case (int) tPTypeEnum.OSI_SSEL:
				text = "OSI Session Selector";
				break;
			case (int) tPTypeEnum.OSI_PSEL:
				text = "OSI Presentation Selector";
				break;
			case (int) tPTypeEnum.OSI_AP_Title:
				text = "OSI ACSE AP Title value";
				break;
			case (int) tPTypeEnum.OSI_AP_Invoke:
				text = "OSI ACSE AP Invoke ID";
				break;
			case (int) tPTypeEnum.OSI_AE_Qualifier:
				text = "OSI ACSE AE Qualifier";
				break;
			case (int) tPTypeEnum.OSI_AE_Invoke:
				text = "OSI ACSE AE Invoke ID";
				break;
			case (int) tPTypeEnum.MAC_Address:
				text = "Media Access Address value";
				break;
			case (int) tPTypeEnum.APPID:
				text = "Application Identifier";
				break;
			case (int) tPTypeEnum.VLAN_PRIORITY:
				text = "VLAN User Priority";
				break;
			case (int) tPTypeEnum.VLAN_ID:
				text = "VLAN ID";
				break;
			default:
				text = "No description or type not sopported";
				break;
			}
			return text;
		}
		
		public string GetPName (int type)
		{
			string text = "";
			switch (type)
			{
			case (int) tPTypeEnum.IP:
				text = "IP";
				break;
			case (int) tPTypeEnum.IP_SUBNET:
				text = "IP-SUBNET";
				break;
			case (int) tPTypeEnum.IP_GATEWAY:
				text = "IP-GATEWAY";
				break;
			case (int) tPTypeEnum.OSI_NSAP:
				text = "OSI-NSAP";
				break;
			case (int) tPTypeEnum.OSI_TSEL:
				text = "OSI-TSEL";
				break;
			case (int) tPTypeEnum.OSI_SSEL:
				text = "OSI-SSEL";
				break;
			case (int) tPTypeEnum.OSI_PSEL:
				text = "OSI-PSEL";
				break;
			case (int) tPTypeEnum.OSI_AP_Title:
				text = "OSI-AP-Title";
				break;
			case (int) tPTypeEnum.OSI_AP_Invoke:
				text = "OSI-AP-Invoke";
				break;
			case (int) tPTypeEnum.OSI_AE_Qualifier:
				text = "OSI-AE-Qualifier";
				break;
			case (int) tPTypeEnum.OSI_AE_Invoke:
				text = "OSI-SE-Invoke";
				break;
			case (int) tPTypeEnum.MAC_Address:
				text = "MAC-Addressx";
				break;
			case (int) tPTypeEnum.APPID:
				text = "APPID";
				break;
			case (int) tPTypeEnum.VLAN_PRIORITY:
				text = "VLAN-PRIORITY";
				break;
			case (int) tPTypeEnum.VLAN_ID:
				text = "VLAN ID";
				break;
			default:
				text = "No name or type not sopported";
				break;
			}
			return text;
		}

	}
}
