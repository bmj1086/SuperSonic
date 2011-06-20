using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperSonic.CustomControls
{
    public class DataGridViewImageTextColumn : DataGridViewColumn
    {
        public DataGridViewImageTextColumn()
        {
            CellTemplate = new DataGridViewCell();
        }
    }
}
