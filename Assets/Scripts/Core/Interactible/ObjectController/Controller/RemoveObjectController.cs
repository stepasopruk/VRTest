using System.Collections.Generic;
using UnityEngine;

namespace VRTest.Core.Interactable
{
    public sealed class RemoveObjectController : ObjectButtonsGroup
    {
        [SerializeField] private List<Transform> parentsTransform;

        protected override void Clicked() =>
            RemoveObjects();

        /// <summary>
        /// Удаляет все объекты у родителя
        /// </summary>
        private void RemoveObjects()
        {
            foreach (Transform parentTransform in parentsTransform)
                foreach (Transform child in parentTransform)
                    Destroy(child.gameObject);
        }
    }
}