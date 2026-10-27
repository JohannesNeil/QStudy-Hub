using System;
using System.Collections.Generic;
using System.ComponentModel; // 1. ADD THIS NEW LINE HERE
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace QStudy_Hub
{
    // Inheritance: We are inheriting all features of a standard Button
    public class RoundedButton : Button
    {
        // 2. ADD THIS TAG DIRECTLY ABOVE THE PROPERTY
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius { get; set; } = 15;

        public RoundedButton()
        {
            // Makes the button look flat and modern so the curves look clean
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.DodgerBlue;
            this.ForeColor = Color.White;
        }

        // Polymorphism: Overriding the built-in paint method to draw curves
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            GraphicsPath path = new GraphicsPath();
            int radius = BorderRadius;

            // Draw the 4 rounded corners
            path.AddArc(0, 0, radius, radius, 180, 90); // Top Left
            path.AddArc(Width - radius, 0, radius, radius, 270, 90); // Top Right
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90); // Bottom Right
            path.AddArc(0, Height - radius, radius, radius, 90, 90); // Bottom Left
            path.CloseFigure();

            // Apply the rounded path to the button's shape
            this.Region = new Region(path);
        }
    }
}