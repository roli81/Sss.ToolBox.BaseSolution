using System.Collections.Generic;
using System.IO;

namespace Sss.Mutobo.Core.PoCo
{
    public class Font
    {

        public string Name { get; set; }
        public IEnumerable<FileInfo> Files { get; set; }
    }
}
