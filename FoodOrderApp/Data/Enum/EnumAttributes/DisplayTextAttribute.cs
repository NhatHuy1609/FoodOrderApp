﻿namespace FoodOrderApp.Data.Enum.EnumAttributes
{
    public class DisplayTextAttribute : Attribute
    {
        public string Text { get; }

        public DisplayTextAttribute(string text)
        {
            Text = text;
        }
    }
}
