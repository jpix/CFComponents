using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CFComponentN18.DataNascitaPicker
{
    [ToolboxBitmap(typeof(DateTimePicker))]
    public partial class DataNascitaPicker : DateTimePicker
    {
        public DataNascitaPicker()
        {
            InitializeComponent();
            this.Size = new Size(274, 22);
        }

        public DataNascitaPicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
