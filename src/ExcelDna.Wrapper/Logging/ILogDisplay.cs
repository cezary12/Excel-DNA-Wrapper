﻿using System;

namespace ExcelDna.Logging
{
    public interface ILogDisplay
    {
        void Show();
        void Hide();
        [Obsolete("Rather use LogDisplay.Clear() and LogDisplay.WriteLine(...)")]
        void SetText(string text);
        void WriteLine(string format, params object[] args);
        void RecordLine(string format, params object[] args);
        void Clear();
    }
}