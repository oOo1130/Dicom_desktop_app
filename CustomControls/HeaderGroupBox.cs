using System;
using System.Drawing;
using System.Windows.Forms;

namespace RIS
{
    /// <inheritdoc />
    /// <summary>
    /// A custom groupbox that features a header.
    /// </summary>
    public class HeaderGroupBox : GroupBox
    {
        #region Protected Override

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"></see> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var format = new StringFormat
            {
                Trimming = StringTrimming.Character,
                Alignment = StringAlignment.Near
            };

            if (RightToLeft == RightToLeft.Yes)
                format.FormatFlags = format.FormatFlags |
                                     StringFormatFlags.DirectionRightToLeft;

            var stringSize = e.Graphics.MeasureString(Text, Font, ClientRectangle.Size, format);

            if (Enabled)
            {
                using (var brush = new SolidBrush(ForeColor))
                    e.Graphics.DrawString(Text, Font, brush, ClientRectangle, format);
            }
            else
                ControlPaint.DrawStringDisabled(e.Graphics, Text, Font, BackColor, ClientRectangle, format);

            using (var forePen = new Pen(ControlPaint.LightLight(BackColor), SystemInformation.BorderSize.Height))
            {
                using (var forePenDark = new Pen(ControlPaint.Dark(BackColor), SystemInformation.BorderSize.Height))
                {
                    var lineLeft = new Point(ClientRectangle.Left, ClientRectangle.Top + (int) (Font.Height / 2f));
                    var lineRight = new Point(ClientRectangle.Right, ClientRectangle.Top + (int) (Font.Height / 2f));

                    if (RightToLeft != RightToLeft.Yes)
                        lineLeft.X += (int) stringSize.Width;
                    else
                        lineRight.X -= (int) stringSize.Width;

                    if (FlatStyle == FlatStyle.Flat)
                        e.Graphics.DrawLine(forePenDark, lineLeft, lineRight);
                    else
                    {
                        e.Graphics.DrawLine(forePenDark, lineLeft, lineRight);
                        lineLeft.Offset(0, (int) Math.Ceiling(SystemInformation.BorderSize.Height / 2f));
                        lineRight.Offset(0, (int) Math.Ceiling(SystemInformation.BorderSize.Height / 2f));
                        e.Graphics.DrawLine(forePen, lineLeft, lineRight);
                    }
                }
            }
        }

        #endregion
    }
}
