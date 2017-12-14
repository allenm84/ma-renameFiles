using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RenameFiles
{
  [DataContract(Name = "RenameRule", Namespace = Program.Namespace)]
  public class RenameRule : BasePropertyBag, IExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public bool Enabled
    {
      get { return GetField<bool>(); }
      set { SetField(value); }
    }

    [DataMember(Order = 1)]
    public string Contains
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    [DataMember(Order = 2)]
    public string Pattern
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    [DataMember(Order = 3)]
    public string Format
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }
  }
}
