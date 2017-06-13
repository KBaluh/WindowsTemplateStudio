﻿using Microsoft.Templates.Core.Mvvm;
using Microsoft.Templates.UI.Comparison;

namespace Microsoft.Templates.UI.ViewModels.NewItem
{
    public class CodeLineViewModel : Observable
    {
        public static double DefaultFontSize = 12;

        private LineStatus _status;
        public LineStatus Status
        {
            get => _status;
            set => SetProperty(ref _status, value);
        }

        private int _number;
        public int Number
        {
            get => _number;
            set => SetProperty(ref _number, value);
        }

        private string _text;
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        private double _fontSize;
        public double FontSize
        {
            get => _fontSize;
            set => SetProperty(ref _fontSize, value);
        }

        public string NumberString
        {
            get
            {
                if (Number < 10)
                {
                    return $"  {Number}";
                }
                else if (Number < 100)
                {
                    return $" {Number}";
                }
                else
                {
                    return Number.ToString();
                }                
            }            
        }

        public CodeLineViewModel(CodeLine codeLine)
        {
            Status = codeLine.Status;
            Number = codeLine.Number;
            Text = codeLine.Text;

            FontSize = DefaultFontSize;
        }
    }
}
