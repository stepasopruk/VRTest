using BNG;
using UnityEngine;

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
        _meshRenderer.materials = materialData.StandartMaterials;
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

    private void ChangeMaterial()
    {
        _meshRenderer.materials =
            IsSelect ? materialData.SelectedMaterials :
            IsHover ? materialData.HoverMaterials :
            materialData.StandartMaterials;
    }
}
