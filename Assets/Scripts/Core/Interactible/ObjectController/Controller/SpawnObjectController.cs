using System.Collections.Generic;
using UnityEngine;
using VRTest.Data;

namespace VRTest.Core.Interactable
{
    public sealed class SpawnObjectController : ObjectButtonsGroup
    {
        [SerializeField] private List<MaterialObjectData> materialObjectDatas;

        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform parentTransform;
        [SerializeField] private GameObject objectPrefab;

        protected override void Clicked() =>
            SpawnObject();

        /// <summary>
        /// Создает объект на сцене
        /// </summary>
        private void SpawnObject()
        {
            GameObject gameObject = Instantiate(objectPrefab, parentTransform);
            gameObject.transform.position = spawnPoint.position;

            SetDataObject(gameObject);
        }

        /// <summary>
        /// Проверяет есть ли у объекта компонент MaterialChangerGrabbable и устанавливает рандомные данные
        /// </summary>
        /// <param name="gameObject"></param>
        private void SetDataObject(GameObject gameObject)
        {
            gameObject.TryGetComponent(out MaterialChangerGrabbable materialChangerGrabbable);

            if (materialChangerGrabbable != null)
                SetRandomData(materialChangerGrabbable);
        }

        /// <summary>
        /// Устанавливает рандомные данные материалов для объекта
        /// </summary>
        /// <param name="materialChangerGrabbable"></param>
        private void SetRandomData(MaterialChangerGrabbable materialChangerGrabbable)
        {
            int countArray = materialObjectDatas.Count;
            int randValue = Random.Range(0, countArray);
            materialChangerGrabbable.SetData(materialObjectDatas[randValue]);
        }
    }
}