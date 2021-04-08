using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stProgressBar", "Plc", TypeComplexityEnum.Complex)]
	public partial class stProgressBar : Vortex.Connector.IVortexObject, IstProgressBar, IShadowstProgressBar, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerInt _testInteger;
		public Vortex.Connector.ValueTypes.OnlinerInt testInteger
		{
			get
			{
				return _testInteger;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IstProgressBar.testInteger
		{
			get
			{
				return testInteger;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstProgressBar.testInteger
		{
			get
			{
				return testInteger;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _testBool;
		public Vortex.Connector.ValueTypes.OnlinerBool testBool
		{
			get
			{
				return _testBool;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstProgressBar.testBool
		{
			get
			{
				return testBool;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstProgressBar.testBool
		{
			get
			{
				return testBool;
			}
		}

		public void LazyOnlineToShadow()
		{
			testInteger.Shadow = testInteger.LastValue;
			testBool.Shadow = testBool.LastValue;
		}

		public void LazyShadowToOnline()
		{
			testInteger.Cyclic = testInteger.Shadow;
			testBool.Cyclic = testBool.Shadow;
		}

		public PlainstProgressBar CreatePlainerType()
		{
			var cloned = new PlainstProgressBar();
			return cloned;
		}

		protected PlainstProgressBar CreatePlainerType(PlainstProgressBar cloned)
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

		public void FlushPlainToOnline(Plc.PlainstProgressBar source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstProgressBar source)
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

		public void FlushOnlineToPlain(Plc.PlainstProgressBar source)
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

		public stProgressBar(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_testInteger = @Connector.Online.Adapter.CreateINT(this, "<#Integer From PLC#>", "testInteger");
			testInteger.AttributeName = "<#Integer From PLC#>";
			_testBool = @Connector.Online.Adapter.CreateBOOL(this, "<#Bool From PLC#>", "testBool");
			testBool.AttributeName = "<#Bool From PLC#>";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stProgressBar()
		{
			PexPreConstructorParameterless();
			_testInteger = Vortex.Connector.IConnectorFactory.CreateINT();
			testInteger.AttributeName = "<#Integer From PLC#>";
			_testBool = Vortex.Connector.IConnectorFactory.CreateBOOL();
			testBool.AttributeName = "<#Bool From PLC#>";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstProgressBar
		{
			public object testInteger;
			public object testBool;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstProgressBar()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstProgressBar : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineInt testInteger
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool testBool
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstProgressBar CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstProgressBar source);
		void FlushOnlineToPlain(Plc.PlainstProgressBar source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstProgressBar : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowInt testInteger
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool testBool
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstProgressBar CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstProgressBar source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstProgressBar : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Int16 _testInteger;
		public System.Int16 testInteger
		{
			get
			{
				return _testInteger;
			}

			set
			{
				if (_testInteger != value)
				{
					_testInteger = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(testInteger)));
				}
			}
		}

		System.Boolean _testBool;
		public System.Boolean testBool
		{
			get
			{
				return _testBool;
			}

			set
			{
				if (_testBool != value)
				{
					_testBool = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(testBool)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stProgressBar target)
		{
			target.testInteger.Cyclic = testInteger;
			target.testBool.Cyclic = testBool;
		}

		public void CopyPlainToCyclic(Plc.IstProgressBar target)
		{
			this.CopyPlainToCyclic((Plc.stProgressBar)target);
		}

		public void CopyPlainToShadow(Plc.stProgressBar target)
		{
			target.testInteger.Shadow = testInteger;
			target.testBool.Shadow = testBool;
		}

		public void CopyPlainToShadow(Plc.IShadowstProgressBar target)
		{
			this.CopyPlainToShadow((Plc.stProgressBar)target);
		}

		public void CopyCyclicToPlain(Plc.stProgressBar source)
		{
			testInteger = source.testInteger.LastValue;
			testBool = source.testBool.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IstProgressBar source)
		{
			this.CopyCyclicToPlain((Plc.stProgressBar)source);
		}

		public void CopyShadowToPlain(Plc.stProgressBar source)
		{
			testInteger = source.testInteger.Shadow;
			testBool = source.testBool.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowstProgressBar source)
		{
			this.CopyShadowToPlain((Plc.stProgressBar)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstProgressBar()
		{
		}
	}
}