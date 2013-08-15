using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ResevationSystem
{
    public class ItemInfo
    {
        public DateTime StartDateFunction;
        public DateTime EndDateFunction;
        public string FunctionName;
        public int A;
        public int R;
        public int G;
        public int B;
        HatchStyle pattern;
        Color patternColor;

        public ItemInfo()
        { }

        public ItemInfo(DateTime startTime, DateTime endTime, string text, Color color)
        {
            StartDateFunction = startTime;
            EndDateFunction = endTime;
            FunctionName = text;
            A = color.A;
            R = color.R;
            G = color.G;
            B = color.B;
        }
    }
}
