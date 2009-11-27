﻿// LibOpenSCL
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
		
		// FIXME: It returns a TRUE value if the configuration is generic, 
		// if it's loaded from CID or ICD this must be set to FALSE.
		protected bool genericConfiguration;
		
		public Object()
		{
			this.ListErrors = new List<ErrorsManagement>();
			this.objectManagement = new ObjectManagement();
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
   		public void Deserialize(string nameFileXML)
		{			 
			XmlSerializer XS = new XmlSerializer(typeof(SCL));
    	   	XS.UnknownNode+= new XmlNodeEventHandler(UnknownNode);
           	XS.UnknownAttribute+= new XmlAttributeEventHandler(UnknownAttribute);        
           	FileStream fs = File.OpenRead(nameFileXML);         	
            this.configuration =(SCL) XS.Deserialize(fs);                    
            fs.Dispose();           
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
   		/// FIXME: It returns a configuration of an IED according to an XML file.
   		/// </summary>
		public tIED[] ConfiguredDevices 
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
   		/// that belongs to the Header of an XML file.
   		/// </summary>
		public string ConfigurationVersion 
		{
			get 
			{
				return this.configuration.Header.version;
			}
			set 
			{
				this.configuration.Header.version = value;
			}
		}
		
   		/// <summary>
   		/// It returns the value of the attribute "ConfigurationRevision" 
   		/// that belongs to the Header of an XML file.
   		/// </summary>
		public string ConfigurationRevision 
		{
			get 
			{
				return this.configuration.Header.revision;
			}
			set 
			{
				this.configuration.Header.revision = value;
			}
		}

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
	}
}


