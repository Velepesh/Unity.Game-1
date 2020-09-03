using UnityEngine;

class LevelPlatform : MonoBehaviour
{
    [SerializeField] private PlatformOrder _order;

    public PlatformOrder Order => _order;
}