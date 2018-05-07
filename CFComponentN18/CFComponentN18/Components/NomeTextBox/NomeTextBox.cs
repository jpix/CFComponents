using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CFComponentN18.NomeTextBox
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class NomeTextBox : TextBox
    {
        public NomeTextBox()
        {
            InitializeComponent();
            this.Size = new Size(201, 22);

            this.CharacterCasing = CharacterCasing.Upper;
            this.ShortcutsEnabled = false;
        }

        public NomeTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.ShortcutsEnabled = false;
        }

        private void NomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
