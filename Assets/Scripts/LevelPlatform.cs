using UnityEngine;

class LevelPlatform : MonoBehaviour
{
    [SerializeField] private PlatformType _type;

    public PlatformType Type => _type;
}