using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "Plc", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerString _Hello_World;
		public Vortex.Connector.ValueTypes.OnlinerString Hello_World
		{
			get
			{
				return _Hello_World;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IMAIN.Hello_World
		{
			get
			{
				return Hello_World;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowMAIN.Hello_World
		{
			get
			{
				return Hello_World;
			}
		}

		stProgressBar _progressBar;
		[RenderIgnore()]
		public stProgressBar progressBar
		{
			get
			{
				return _progressBar;
			}
		}

		[RenderIgnore()]
		IstProgressBar IMAIN.progressBar
		{
			get
			{
				return progressBar;
			}
		}

		[RenderIgnore()]
		IShadowstProgressBar IShadowMAIN.progressBar
		{
			get
			{
				return progressBar;
			}
		}

		stStations _stations;
		public stStations stations
		{
			get
			{
				return _stations;
			}
		}

		IstStations IMAIN.stations
		{
			get
			{
				return stations;
			}
		}

		IShadowstStations IShadowMAIN.stations
		{
			get
			{
				return stations;
			}
		}

		public void LazyOnlineToShadow()
		{
			Hello_World.Shadow = Hello_World.LastValue;
			progressBar.LazyOnlineToShadow();
			stations.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			Hello_World.Cyclic = Hello_World.Shadow;
			progressBar.LazyShadowToOnline();
			stations.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned.progressBar = progressBar.CreatePlainerType();
			cloned.stations = stations.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned.progressBar = progressBar.CreatePlainerType();
			cloned.stations = stations.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainMAIN source)
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

		public void FlushOnlineToPlain(Plc.PlainMAIN source)
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

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Hello_World = @Connector.Online.Adapter.CreateSTRING(this, "<#Hello#> <#World#>", "Hello_World");
			Hello_World.AttributeName = "<#Hello#> <#World#>";
			_progressBar = new stProgressBar(this, "", "progressBar");
			_stations = new stStations(this, "", "stations");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			_Hello_World = Vortex.Connector.IConnectorFactory.CreateSTRING();
			Hello_World.AttributeName = "<#Hello#> <#World#>";
			_progressBar = new stProgressBar();
			_stations = new stStations();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN
		{
			public object Hello_World;
			public PlainstProgressBar progressBar;
			public PlainstStations stations;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString Hello_World
		{
			get;
		}

		[RenderIgnore()]
		IstProgressBar progressBar
		{
			get;
		}

		IstStations stations
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainMAIN source);
		void FlushOnlineToPlain(Plc.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString Hello_World
		{
			get;
		}

		[RenderIgnore()]
		IShadowstProgressBar progressBar
		{
			get;
		}

		IShadowstStations stations
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainMAIN source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String _Hello_World;
		public System.String Hello_World
		{
			get
			{
				return _Hello_World;
			}

			set
			{
				if (_Hello_World != value)
				{
					_Hello_World = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Hello_World)));
				}
			}
		}

		PlainstProgressBar _progressBar;
		[RenderIgnore()]
		public PlainstProgressBar progressBar
		{
			get
			{
				return _progressBar;
			}

			set
			{
				if (_progressBar != value)
				{
					_progressBar = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(progressBar)));
				}
			}
		}

		PlainstStations _stations;
		public PlainstStations stations
		{
			get
			{
				return _stations;
			}

			set
			{
				if (_stations != value)
				{
					_stations = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(stations)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.MAIN target)
		{
			target.Hello_World.Cyclic = Hello_World;
			progressBar.CopyPlainToCyclic(target.progressBar);
			stations.CopyPlainToCyclic(target.stations);
		}

		public void CopyPlainToCyclic(Plc.IMAIN target)
		{
			this.CopyPlainToCyclic((Plc.MAIN)target);
		}

		public void CopyPlainToShadow(Plc.MAIN target)
		{
			target.Hello_World.Shadow = Hello_World;
			progressBar.CopyPlainToShadow(target.progressBar);
			stations.CopyPlainToShadow(target.stations);
		}

		public void CopyPlainToShadow(Plc.IShadowMAIN target)
		{
			this.CopyPlainToShadow((Plc.MAIN)target);
		}

		public void CopyCyclicToPlain(Plc.MAIN source)
		{
			Hello_World = source.Hello_World.LastValue;
			progressBar.CopyCyclicToPlain(source.progressBar);
			stations.CopyCyclicToPlain(source.stations);
		}

		public void CopyCyclicToPlain(Plc.IMAIN source)
		{
			this.CopyCyclicToPlain((Plc.MAIN)source);
		}

		public void CopyShadowToPlain(Plc.MAIN source)
		{
			Hello_World = source.Hello_World.Shadow;
			progressBar.CopyShadowToPlain(source.progressBar);
			stations.CopyShadowToPlain(source.stations);
		}

		public void CopyShadowToPlain(Plc.IShadowMAIN source)
		{
			this.CopyShadowToPlain((Plc.MAIN)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
			_progressBar = new PlainstProgressBar();
			_stations = new PlainstStations();
		}
	}
}