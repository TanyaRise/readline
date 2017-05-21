using System;

namespace Internal.ReadLine.Abstractions
{
    internal class Console2 : IConsole
    {
        private bool IsSeenOnScreen(char c) => !(char.IsControl(c) || char.IsWhiteSpace(c));

        public int CursorLeft => Console.CursorLeft;

        public int CursorTop => Console.CursorTop;

        public int BufferWidth => Console.BufferWidth;

        public int BufferHeight => Console.BufferHeight;

        public bool PasswordMode { get; set; } = false;

        public char PasswordChar { get; set; } = '\0';

        public void SetBufferSize(int width, int height) => Console.SetBufferSize(width, height);

        public void SetCursorPosition(int left, int top) => Console.SetCursorPosition(left, top);

        public void Write(string value) => Console.Write(value);

        public void WriteLine(string value) => Console.WriteLine(value);
    }
}