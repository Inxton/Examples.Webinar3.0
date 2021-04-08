using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stStationCu4", "Plc", TypeComplexityEnum.Complex)]
	public partial class stStationCu4 : Vortex.Connector.IVortexObject, IstStationCu4, IShadowstStationCu4, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerString _Name;
		public Vortex.Connector.ValueTypes.OnlinerString Name
		{
			get
			{
				return _Name;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstStationCu4.Name
		{
			get
			{
				return Name;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstStationCu4.Name
		{
			get
			{
				return Name;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _IsOn;
		public Vortex.Connector.ValueTypes.OnlinerBool IsOn
		{
			get
			{
				return _IsOn;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstStationCu4.IsOn
		{
			get
			{
				return IsOn;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstStationCu4.IsOn
		{
			get
			{
				return IsOn;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Cu1Enum;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (stTestEnum))]
		public Vortex.Connector.ValueTypes.OnlinerInt Cu1Enum
		{
			get
			{
				return _Cu1Enum;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (stTestEnum))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstStationCu4.Cu1Enum
		{
			get
			{
				return Cu1Enum;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (stTestEnum))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstStationCu4.Cu1Enum
		{
			get
			{
				return Cu1Enum;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTimeOfDay _TimeOfDay;
		public Vortex.Connector.ValueTypes.OnlinerTimeOfDay TimeOfDay
		{
			get
			{
				return _TimeOfDay;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay IstStationCu4.TimeOfDay
		{
			get
			{
				return TimeOfDay;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay IShadowstStationCu4.TimeOfDay
		{
			get
			{
				return TimeOfDay;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDate _TestDate;
		public Vortex.Connector.ValueTypes.OnlinerDate TestDate
		{
			get
			{
				return _TestDate;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate IstStationCu4.TestDate
		{
			get
			{
				return TestDate;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate IShadowstStationCu4.TestDate
		{
			get
			{
				return TestDate;
			}
		}

		public void LazyOnlineToShadow()
		{
			Name.Shadow = Name.LastValue;
			IsOn.Shadow = IsOn.LastValue;
			Cu1Enum.Shadow = Cu1Enum.LastValue;
			TimeOfDay.Shadow = TimeOfDay.LastValue;
			TestDate.Shadow = TestDate.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Name.Cyclic = Name.Shadow;
			IsOn.Cyclic = IsOn.Shadow;
			Cu1Enum.Cyclic = Cu1Enum.Shadow;
			TimeOfDay.Cyclic = TimeOfDay.Shadow;
			TestDate.Cyclic = TestDate.Shadow;
		}

		public PlainstStationCu4 CreatePlainerType()
		{
			var cloned = new PlainstStationCu4();
			return cloned;
		}

		protected PlainstStationCu4 CreatePlainerType(PlainstStationCu4 cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainstStationCu4 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstStationCu4 source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainstStationCu4 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public stStationCu4(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Name = @Connector.Online.Adapter.CreateSTRING(this, "Name", "Name");
			Name.AttributeName = "Name";
			_IsOn = @Connector.Online.Adapter.CreateBOOL(this, "Is On", "IsOn");
			IsOn.AttributeName = "Is On";
			_Cu1Enum = @Connector.Online.Adapter.CreateINT(this, "Station status", "Cu1Enum");
			Cu1Enum.AttributeName = "Station status";
			_TimeOfDay = @Connector.Online.Adapter.CreateTIME_OF_DAY(this, "Time", "TimeOfDay");
			TimeOfDay.AttributeName = "Time";
			_TestDate = @Connector.Online.Adapter.CreateDATE(this, "Date", "TestDate");
			TestDate.AttributeName = "Date";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stStationCu4()
		{
			PexPreConstructorParameterless();
			_Name = Vortex.Connector.IConnectorFactory.CreateSTRING();
			Name.AttributeName = "Name";
			_IsOn = Vortex.Connector.IConnectorFactory.CreateBOOL();
			IsOn.AttributeName = "Is On";
			_Cu1Enum = Vortex.Connector.IConnectorFactory.CreateINT();
			Cu1Enum.AttributeName = "Station status";
			_TimeOfDay = Vortex.Connector.IConnectorFactory.CreateTIME_OF_DAY();
			TimeOfDay.AttributeName = "Time";
			_TestDate = Vortex.Connector.IConnectorFactory.CreateDATE();
			TestDate.AttributeName = "Date";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstStationCu4
		{
			public object Name;
			public object IsOn;
			public System.Int16 Cu1Enum;
			public object TimeOfDay;
			public object TestDate;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstStationCu4()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstStationCu4 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString Name
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IsOn
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (stTestEnum))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt Cu1Enum
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay TimeOfDay
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate TestDate
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstStationCu4 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstStationCu4 source);
		void FlushOnlineToPlain(Plc.PlainstStationCu4 source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstStationCu4 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString Name
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IsOn
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (stTestEnum))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt Cu1Enum
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay TimeOfDay
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate TestDate
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstStationCu4 CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstStationCu4 source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstStationCu4 : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String _Name;
		public System.String Name
		{
			get
			{
				return _Name;
			}

			set
			{
				if (_Name != value)
				{
					_Name = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Name)));
				}
			}
		}

		System.Boolean _IsOn;
		public System.Boolean IsOn
		{
			get
			{
				return _IsOn;
			}

			set
			{
				if (_IsOn != value)
				{
					_IsOn = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(IsOn)));
				}
			}
		}

		System.Int16 _Cu1Enum;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (stTestEnum))]
		public System.Int16 Cu1Enum
		{
			get
			{
				return _Cu1Enum;
			}

			set
			{
				if (_Cu1Enum != value)
				{
					_Cu1Enum = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Cu1Enum)));
				}
			}
		}

		System.TimeSpan _TimeOfDay;
		public System.TimeSpan TimeOfDay
		{
			get
			{
				return _TimeOfDay;
			}

			set
			{
				if (_TimeOfDay != value)
				{
					_TimeOfDay = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TimeOfDay)));
				}
			}
		}

		System.DateTime _TestDate;
		public System.DateTime TestDate
		{
			get
			{
				return _TestDate;
			}

			set
			{
				if (_TestDate != value)
				{
					_TestDate = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TestDate)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stStationCu4 target)
		{
			target.Name.Cyclic = Name;
			target.IsOn.Cyclic = IsOn;
			target.Cu1Enum.Cyclic = Cu1Enum;
			target.TimeOfDay.Cyclic = TimeOfDay;
			target.TestDate.Cyclic = TestDate;
		}

		public void CopyPlainToCyclic(Plc.IstStationCu4 target)
		{
			this.CopyPlainToCyclic((Plc.stStationCu4)target);
		}

		public void CopyPlainToShadow(Plc.stStationCu4 target)
		{
			target.Name.Shadow = Name;
			target.IsOn.Shadow = IsOn;
			target.Cu1Enum.Shadow = Cu1Enum;
			target.TimeOfDay.Shadow = TimeOfDay;
			target.TestDate.Shadow = TestDate;
		}

		public void CopyPlainToShadow(Plc.IShadowstStationCu4 target)
		{
			this.CopyPlainToShadow((Plc.stStationCu4)target);
		}

		public void CopyCyclicToPlain(Plc.stStationCu4 source)
		{
			Name = source.Name.LastValue;
			IsOn = source.IsOn.LastValue;
			Cu1Enum = source.Cu1Enum.LastValue;
			TimeOfDay = source.TimeOfDay.LastValue;
			TestDate = source.TestDate.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IstStationCu4 source)
		{
			this.CopyCyclicToPlain((Plc.stStationCu4)source);
		}

		public void CopyShadowToPlain(Plc.stStationCu4 source)
		{
			Name = source.Name.Shadow;
			IsOn = source.IsOn.Shadow;
			Cu1Enum = source.Cu1Enum.Shadow;
			TimeOfDay = source.TimeOfDay.Shadow;
			TestDate = source.TestDate.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowstStationCu4 source)
		{
			this.CopyShadowToPlain((Plc.stStationCu4)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstStationCu4()
		{
		}
	}
}