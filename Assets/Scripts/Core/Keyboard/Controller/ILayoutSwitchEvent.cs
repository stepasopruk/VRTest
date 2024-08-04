using KeyboardVR;
using System;

public interface ILayoutSwitchEvent
{
    event Action<KeyboardLayout> LayoutChanged;
}
