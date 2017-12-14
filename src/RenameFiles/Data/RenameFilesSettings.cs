using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RenameFiles
{
  [DataContract(Name = "RenameFilesSettings", Namespace = Program.Namespace)]
  public class RenameFilesSettings : IExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public List<DirectoryInfo> Directories { get; set; }

    [DataMember(Order = 1)]
    public List<RenameRule> Rules { get; set; }

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }
  }
}
