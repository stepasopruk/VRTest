using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectController : OjectButtonsGroup
{
    [SerializeField] private List<MaterialObjectData> materialObjectDatas;

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private GameObject objectPrefab;

    protected override void Clicked()
    {
        GameObject gameObject = Instantiate(objectPrefab, parentTransform);
        gameObject.transform.position = spawnPoint.position;

        gameObject.TryGetComponent(out MaterialChangerGrabbable materialChangerGrabbable);

        if (materialChangerGrabbable != null)
            SetRandomData(materialChangerGrabbable);
    }

    private void SetRandomData(MaterialChangerGrabbable materialChangerGrabbable)
    {
        int countArray = materialObjectDatas.Count;
        int randValue = Random.Range(0, countArray);
        materialChangerGrabbable.SetData(materialObjectDatas[randValue]);
    }
}
