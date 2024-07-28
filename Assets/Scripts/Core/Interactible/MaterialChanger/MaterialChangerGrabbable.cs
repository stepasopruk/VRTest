using BNG;
using UnityEngine;
using VRTest.Data;

namespace VRTest.Core.Interactible
{
    [RequireComponent(typeof(MeshRenderer))]
    public sealed class MaterialChangerGrabbable : GrabbableEvents
    {
        [SerializeField] private MaterialObjectData materialData;

        private MeshRenderer _meshRenderer;

        private bool _isSelect;
        private bool IsSelect
        {
            get => _isSelect;
            set
            {
                if (IsSelect == value)
                    return;

                _isSelect = value;
                ChangeMaterial();
            }
        }

        private bool _isHover;
        private bool IsHover
        {
            get => _isHover;
            set
            {
                if (IsHover == value || IsSelect)
                    return;

                _isHover = value;
                ChangeMaterial();
            }
        }

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            SetStandartMaterial();
        }

        /// <summary>
        /// Записывает данные материала объекта для взаимодействия
        /// </summary>
        /// <param name="data">Данные материала объекта</param>
        public void SetData(MaterialObjectData data)
        {
            materialData = data;
        }

        public override void OnGrab(Grabber grabber)
            => IsSelect = true;

        public override void OnBecomesClosestGrabbable(ControllerHand touchingHand)
            => IsHover = true;

        public override void OnNoLongerClosestGrabbable(ControllerHand touchingHand)
            => IsHover = false;

        public override void OnBecomesClosestRemoteGrabbable(ControllerHand touchingHand)
            => IsHover = true;

        public override void OnNoLongerClosestRemoteGrabbable(ControllerHand touchingHand)
            => IsHover = false;

        public override void OnRelease()
            => IsSelect = false;

        /// <summary>
        /// Устанавливает стандартные материалы рендера объекту
        /// </summary>
        private void SetStandartMaterial()
        {
            if (materialData == null)
                return;

            _meshRenderer.materials = materialData.StandartMaterials;
        }

        /// <summary>
        /// Изменяет материал объекта
        /// </summary>
        private void ChangeMaterial()
        {
            if (materialData == null)
                return;

            _meshRenderer.materials =
                IsSelect ? materialData.SelectedMaterials :
                IsHover ? materialData.HoverMaterials :
                materialData.StandartMaterials;
        }
    }
}