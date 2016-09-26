// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelAssigns : IIfcRelAssigns
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssigns), 5)]
		IItemSet<IIfcObjectDefinition> IIfcRelAssigns.RelatedObjects 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcObjectDefinition, IIfcObjectDefinition>(RelatedObjects);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcRelAssigns), 6)]
		Ifc4.Interfaces.IfcObjectTypeEnum? IIfcRelAssigns.RelatedObjectsType 
		{ 
			get
			{
				//## Custom code to handle enumeration of RelatedObjectsType
				//##
				switch (RelatedObjectsType)
				{
					case IfcObjectTypeEnum.PRODUCT:
						return Ifc4.Interfaces.IfcObjectTypeEnum.PRODUCT;
					
					case IfcObjectTypeEnum.PROCESS:
						return Ifc4.Interfaces.IfcObjectTypeEnum.PROCESS;
					
					case IfcObjectTypeEnum.CONTROL:
						return Ifc4.Interfaces.IfcObjectTypeEnum.CONTROL;
					
					case IfcObjectTypeEnum.RESOURCE:
						return Ifc4.Interfaces.IfcObjectTypeEnum.RESOURCE;
					
					case IfcObjectTypeEnum.ACTOR:
						return Ifc4.Interfaces.IfcObjectTypeEnum.ACTOR;
					
					case IfcObjectTypeEnum.GROUP:
						return Ifc4.Interfaces.IfcObjectTypeEnum.GROUP;
					
					case IfcObjectTypeEnum.PROJECT:
						return Ifc4.Interfaces.IfcObjectTypeEnum.PROJECT;
					
					case IfcObjectTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcObjectTypeEnum.NOTDEFINED;
					
					
					default:
						return null;
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of RelatedObjectsType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcObjectTypeEnum.PRODUCT:
						RelatedObjectsType = IfcObjectTypeEnum.PRODUCT;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.PROCESS:
						RelatedObjectsType = IfcObjectTypeEnum.PROCESS;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.CONTROL:
						RelatedObjectsType = IfcObjectTypeEnum.CONTROL;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.RESOURCE:
						RelatedObjectsType = IfcObjectTypeEnum.RESOURCE;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.ACTOR:
						RelatedObjectsType = IfcObjectTypeEnum.ACTOR;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.GROUP:
						RelatedObjectsType = IfcObjectTypeEnum.GROUP;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.PROJECT:
						RelatedObjectsType = IfcObjectTypeEnum.PROJECT;
						return;
					
					case Ifc4.Interfaces.IfcObjectTypeEnum.NOTDEFINED:
						RelatedObjectsType = IfcObjectTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}