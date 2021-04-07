using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Container(Layout.Tabs)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stStations", "Plc", TypeComplexityEnum.Complex)]
	public partial class stStations : Vortex.Connector.IVortexObject, IstStations, IShadowstStations, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		stStationCu1 _stationCu1;
		public stStationCu1 stationCu1
		{
			get
			{
				return _stationCu1;
			}
		}

		IstStationCu1 IstStations.stationCu1
		{
			get
			{
				return stationCu1;
			}
		}

		IShadowstStationCu1 IShadowstStations.stationCu1
		{
			get
			{
				return stationCu1;
			}
		}

		stStationCu2 _stationCu2;
		public stStationCu2 stationCu2
		{
			get
			{
				return _stationCu2;
			}
		}

		IstStationCu2 IstStations.stationCu2
		{
			get
			{
				return stationCu2;
			}
		}

		IShadowstStationCu2 IShadowstStations.stationCu2
		{
			get
			{
				return stationCu2;
			}
		}

		stStationCu3 _stationCu3;
		public stStationCu3 stationCu3
		{
			get
			{
				return _stationCu3;
			}
		}

		IstStationCu3 IstStations.stationCu3
		{
			get
			{
				return stationCu3;
			}
		}

		IShadowstStationCu3 IShadowstStations.stationCu3
		{
			get
			{
				return stationCu3;
			}
		}

		stStationCu4 _stationCu4;
		public stStationCu4 stationCu4
		{
			get
			{
				return _stationCu4;
			}
		}

		IstStationCu4 IstStations.stationCu4
		{
			get
			{
				return stationCu4;
			}
		}

		IShadowstStationCu4 IShadowstStations.stationCu4
		{
			get
			{
				return stationCu4;
			}
		}

		public void LazyOnlineToShadow()
		{
			stationCu1.LazyOnlineToShadow();
			stationCu2.LazyOnlineToShadow();
			stationCu3.LazyOnlineToShadow();
			stationCu4.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			stationCu1.LazyShadowToOnline();
			stationCu2.LazyShadowToOnline();
			stationCu3.LazyShadowToOnline();
			stationCu4.LazyShadowToOnline();
		}

		public PlainstStations CreatePlainerType()
		{
			var cloned = new PlainstStations();
			cloned.stationCu1 = stationCu1.CreatePlainerType();
			cloned.stationCu2 = stationCu2.CreatePlainerType();
			cloned.stationCu3 = stationCu3.CreatePlainerType();
			cloned.stationCu4 = stationCu4.CreatePlainerType();
			return cloned;
		}

		protected PlainstStations CreatePlainerType(PlainstStations cloned)
		{
			cloned.stationCu1 = stationCu1.CreatePlainerType();
			cloned.stationCu2 = stationCu2.CreatePlainerType();
			cloned.stationCu3 = stationCu3.CreatePlainerType();
			cloned.stationCu4 = stationCu4.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainstStations source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstStations source)
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

		public void FlushOnlineToPlain(Plc.PlainstStations source)
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

		public stStations(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_stationCu1 = new stStationCu1(this, "Station1", "stationCu1");
			_stationCu1.AttributeName = "Station1";
			_stationCu2 = new stStationCu2(this, "Station2", "stationCu2");
			_stationCu2.AttributeName = "Station2";
			_stationCu3 = new stStationCu3(this, "Station3", "stationCu3");
			_stationCu3.AttributeName = "Station3";
			_stationCu4 = new stStationCu4(this, "Station4", "stationCu4");
			_stationCu4.AttributeName = "Station4";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stStations()
		{
			PexPreConstructorParameterless();
			_stationCu1 = new stStationCu1();
			_stationCu1.AttributeName = "Station1";
			_stationCu2 = new stStationCu2();
			_stationCu2.AttributeName = "Station2";
			_stationCu3 = new stStationCu3();
			_stationCu3.AttributeName = "Station3";
			_stationCu4 = new stStationCu4();
			_stationCu4.AttributeName = "Station4";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstStations
		{
			public PlainstStationCu1 stationCu1;
			public PlainstStationCu2 stationCu2;
			public PlainstStationCu3 stationCu3;
			public PlainstStationCu4 stationCu4;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstStations()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstStations : Vortex.Connector.IVortexOnlineObject
	{
		IstStationCu1 stationCu1
		{
			get;
		}

		IstStationCu2 stationCu2
		{
			get;
		}

		IstStationCu3 stationCu3
		{
			get;
		}

		IstStationCu4 stationCu4
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstStations CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstStations source);
		void FlushOnlineToPlain(Plc.PlainstStations source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstStations : Vortex.Connector.IVortexShadowObject
	{
		IShadowstStationCu1 stationCu1
		{
			get;
		}

		IShadowstStationCu2 stationCu2
		{
			get;
		}

		IShadowstStationCu3 stationCu3
		{
			get;
		}

		IShadowstStationCu4 stationCu4
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstStations CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstStations source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstStations : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstStationCu1 _stationCu1;
		public PlainstStationCu1 stationCu1
		{
			get
			{
				return _stationCu1;
			}

			set
			{
				if (_stationCu1 != value)
				{
					_stationCu1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stationCu1)));
				}
			}
		}

		PlainstStationCu2 _stationCu2;
		public PlainstStationCu2 stationCu2
		{
			get
			{
				return _stationCu2;
			}

			set
			{
				if (_stationCu2 != value)
				{
					_stationCu2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stationCu2)));
				}
			}
		}

		PlainstStationCu3 _stationCu3;
		public PlainstStationCu3 stationCu3
		{
			get
			{
				return _stationCu3;
			}

			set
			{
				if (_stationCu3 != value)
				{
					_stationCu3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stationCu3)));
				}
			}
		}

		PlainstStationCu4 _stationCu4;
		public PlainstStationCu4 stationCu4
		{
			get
			{
				return _stationCu4;
			}

			set
			{
				if (_stationCu4 != value)
				{
					_stationCu4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stationCu4)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stStations target)
		{
			stationCu1.CopyPlainToCyclic(target.stationCu1);
			stationCu2.CopyPlainToCyclic(target.stationCu2);
			stationCu3.CopyPlainToCyclic(target.stationCu3);
			stationCu4.CopyPlainToCyclic(target.stationCu4);
		}

		public void CopyPlainToCyclic(Plc.IstStations target)
		{
			this.CopyPlainToCyclic((Plc.stStations)target);
		}

		public void CopyPlainToShadow(Plc.stStations target)
		{
			stationCu1.CopyPlainToShadow(target.stationCu1);
			stationCu2.CopyPlainToShadow(target.stationCu2);
			stationCu3.CopyPlainToShadow(target.stationCu3);
			stationCu4.CopyPlainToShadow(target.stationCu4);
		}

		public void CopyPlainToShadow(Plc.IShadowstStations target)
		{
			this.CopyPlainToShadow((Plc.stStations)target);
		}

		public void CopyCyclicToPlain(Plc.stStations source)
		{
			stationCu1.CopyCyclicToPlain(source.stationCu1);
			stationCu2.CopyCyclicToPlain(source.stationCu2);
			stationCu3.CopyCyclicToPlain(source.stationCu3);
			stationCu4.CopyCyclicToPlain(source.stationCu4);
		}

		public void CopyCyclicToPlain(Plc.IstStations source)
		{
			this.CopyCyclicToPlain((Plc.stStations)source);
		}

		public void CopyShadowToPlain(Plc.stStations source)
		{
			stationCu1.CopyShadowToPlain(source.stationCu1);
			stationCu2.CopyShadowToPlain(source.stationCu2);
			stationCu3.CopyShadowToPlain(source.stationCu3);
			stationCu4.CopyShadowToPlain(source.stationCu4);
		}

		public void CopyShadowToPlain(Plc.IShadowstStations source)
		{
			this.CopyShadowToPlain((Plc.stStations)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstStations()
		{
			_stationCu1 = new PlainstStationCu1();
			_stationCu2 = new PlainstStationCu2();
			_stationCu3 = new PlainstStationCu3();
			_stationCu4 = new PlainstStationCu4();
		}
	}
}