﻿using System;
namespace SupportControls
{
    public class Captcha
    {


        public string FontFamily
        {
            get { return fontFamily; }
            set
            {
                if (value != string.Empty && value != null)
                    this.fontFamily = value;
                else
                    this.fontFamily = "Arial";
            }
        }

        public double FontSize
        {
            get { return fontSize; }
            set
            {
                try
                {
                    if (value <= 10 || value >= 24)
                        this.fontSize = 16;
                    else
                        this.fontSize = value;
                }
                catch (Exception ex)
                {
                    this.fontSize = 16;
                }
            }
        }

        public string TextColor
        {
            get { return textColor; }
            set
            {
                if (value == string.Empty || value == null)
                    this.textColor = "Black";
                else
                    this.textColor = value;
            }
        }

        public string BackgroundImagePath
        {
            get { return backgroundImagePath; }
            set
            {
                this.backgroundImagePath = value;
            }
        }

        public System.Drawing.Font GetFont()
        {
            return new System.Drawing.Font(FontFamily, (float)FontSize);
        }


        private double fontSize;
        private string fontFamily;
        private string backgroundImagePath;
        private string textColor;
    }
}