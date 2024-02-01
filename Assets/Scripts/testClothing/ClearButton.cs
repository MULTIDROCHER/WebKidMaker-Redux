using System.Collections.Generic;
using UnityEngine;

namespace WKMR
{
    public class ClearButton : MonoBehaviour
    {
        [SerializeField] private List<ClothContainer> _containers;

        public void Clear()
        {
            foreach (var container in _containers)
                container.Reset();
        }
    }
}