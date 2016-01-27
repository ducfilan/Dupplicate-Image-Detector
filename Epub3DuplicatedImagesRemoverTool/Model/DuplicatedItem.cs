using System.Collections.Generic;

namespace Epub3DuplicatedImagesRemoverTool.Model
{
    public class DuplicatedItem
    {
        public string BaseFileName { get; set; }
        public string XhtmlFileName { get; set; }
        public string XhtmlFileContent { get; set; }
        public string BelongFolderPath { get; set; }
        public string DuplicatedFileName { get; set; }
    }
}
