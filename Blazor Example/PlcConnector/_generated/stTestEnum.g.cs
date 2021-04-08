using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "stTestEnum", "Plc", TypeComplexityEnum.Enumerator)]
	public enum stTestEnum
	{
		Unknown = 0,
		Available = 1,
		UnAvailable = 2
	}
}