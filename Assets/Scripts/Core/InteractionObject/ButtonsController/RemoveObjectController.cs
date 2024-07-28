using System.Collections.Generic;
using UnityEngine;

public class RemoveObjectController : OjectButtonsGroup
{
    [SerializeField] private List<Transform> parentsTransform;

    protected override void Clicked()
    {
        foreach (Transform parentTransform in parentsTransform)
            foreach (Transform child in parentTransform)
                Destroy(child.gameObject);
    }
}