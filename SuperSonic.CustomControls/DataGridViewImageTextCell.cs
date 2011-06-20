using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperSonic.CustomControls
{
    class DataGridViewImageTextCell : DataGridViewImageCell
    {
        protected override void Paint(System.Drawing.Graphics graphics, 
            System.Drawing.Rectangle clipBounds, 
            System.Drawing.Rectangle cellBounds, 
            int rowIndex, 
            DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            )base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }
    }
}
