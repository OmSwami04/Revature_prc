using System;

namespace ConsoleApp1
{
    // Custom EventArgs (defined but not used in this demo)
    public class OnClickEventArgs : EventArgs
    {
        public string ButtonName { get; set; }
    }

    // =======================
    // Publisher
    // =======================
    public class Button
    {
        // Delegate
        public delegate void OnClickHandler();

        // Event
        public event OnClickHandler OnClick;

        // Informing subscribers that the button was clicked
        public void Click()
        {
            OnClick?.Invoke(); // notify all subscribers
        }



    }
}
