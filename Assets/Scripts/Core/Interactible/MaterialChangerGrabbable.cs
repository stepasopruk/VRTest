using BNG;
using System;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public sealed class MaterialChangerGrabbable : GrabbableEvents
{
    [SerializeField] private Material standartMaterial;
    [SerializeField] private Material highlightMaterial;

    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer ??= GetComponent<MeshRenderer>();
        _meshRenderer.sharedMaterial = standartMaterial;

        SubscriptionEvents();
    }

    public override void OnGrab(Grabber grabber)
    {
        if(highlightMaterial != null)
            _meshRenderer.sharedMaterial = highlightMaterial;
    }

    public override void OnRelease()
    {
        _meshRenderer.sharedMaterial = standartMaterial;
    }

    private void SubscriptionEvents()
    {

    }

    public void ChangeMaterial(Material material)
    {

    }
}
