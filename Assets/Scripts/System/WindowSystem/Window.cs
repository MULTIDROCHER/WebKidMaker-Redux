using System;
using UnityEngine;

namespace WKMR.System
{
    public class Window : MonoBehaviour
    {
        public event Action Closed;

        private void OnDisable() => Closed?.Invoke();
    }
}