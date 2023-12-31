﻿#if UNITY_IOS
using System.Runtime.InteropServices;

namespace Kakera
{
    internal class PickeriOS : IPicker
    {
        [DllImport("__Internal")]
        private static extern void Unimgpicker_show(string title, string outputFileName, int maxSize);

        public void Show(string title, string outputFileName, int maxSize)
        {
            Unimgpicker_show(title, outputFileName, maxSize);
        }
    }
}
#endif