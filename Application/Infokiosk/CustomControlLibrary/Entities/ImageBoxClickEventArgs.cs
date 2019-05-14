using System;

namespace CustomControlLibrary.Entities
{
    public class CustomClickEventArgs : EventArgs
    {
        public ImageBox ImageBox { get; set; }
        public CustomClickEventArgs(ImageBox imageBox)
        {
            ImageBox = imageBox;
        }
    }
}
