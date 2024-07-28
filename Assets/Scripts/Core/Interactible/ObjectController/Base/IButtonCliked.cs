using System;

namespace VRTest.Core
{
    public interface IButtonCliked
    {
        /// <summary>
        /// Событие на нажатие кнопки
        /// </summary>
        event Action Clicked;
    }
}