using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Far_full
{
    class Dir
    {
        public DirectoryInfo dir;
        public string path;
        public int index;
        public List<FileSystemInfo> elements;

        public Dir(string path, int index)
        {
            this.path = path;
            this.index = index;
            this.dir = new DirectoryInfo(path);

            elements = new List<FileSystemInfo>();
            elements.AddRange(dir.GetDirectories());
            elements.AddRange(dir.GetFiles());

        }

        public void Action(int v)
        {
            this.index += v;
            if (this.index < 0)
            {
                this.index = elements.Count - 1;
            }
            if (this.index >= elements.Count)
            {
                this.index = 0;
            }
        }

        public string GetSelectedElementInfo()
        {
            return elements[index].FullName;
        }
    }
}