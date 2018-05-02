using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
namespace System.Diagnostics
{
    public class ProcessObject : Component
    {
        public string ProcessName { set; get; } = "No name specified";
        public int Id { set; get; } = -1;
        public ProcessObject Instance { get => this; }
        public ListViewItem ConvertToListViewItem()
        {
            return new ListViewItem(new string[] { ProcessName, "", Id.ToString() });
        }
        public override string ToString()
        {
            return $"id({Id}) : name({ProcessName})";
        }
    }
}
