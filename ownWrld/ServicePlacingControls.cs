﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ownWrld
{
    public class ServicePlacingControls
    {

        public static int initialPlaceholder = 10;
        public static int placeholder = initialPlaceholder;
        public static int spacebetween = 30;

        internal static void CalculateNewPlaceForControls(Button btn, TextBox txt, List<TextBox> textBoxes, List<Button> buttons, Panel panel1,Label lbl)
        {
            bool marker;
            int placeholder = 10;
            while (placeholder <= textBoxes.Count * spacebetween + initialPlaceholder)
            {
                marker = true;
                foreach (Control text in panel1.Controls)
                {
                    if (text is TextBox)
                    {
                        if (text.Location.Y == placeholder)
                        {
                            marker = false;
                        }
                    }

                }

                if (marker)
                {
                    txt.Location = new Point(10, placeholder);
                    btn.Location = new Point(150, placeholder);
                    lbl.Location = new Point(10, placeholder);
                    break;

                }
                placeholder += spacebetween;
            }
            placeholder = initialPlaceholder;

        }
    }
}
