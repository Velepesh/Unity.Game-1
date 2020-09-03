using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private LevelPlatform[] _templates;
    [SerializeField] private Player _player;

    readonly private int _tileLength = 50;
    readonly private int _numberOfActivePlatforms = 2;
    private float _spawnPointX = -25f;

    private Queue<LevelPlatform> _activeLevelPlatforms = new Queue<LevelPlatform>();

    private void Start()
    {
        TryCreateTemplate(PlatformType.StartPlatform);
    }

    private void Update()
    {
        float playerPositionX = _player.transform.position.x;

        if (playerPositionX - _tileLength > _spawnPointX - (_numberOfActivePlatforms * _tileLength))
        {
            TryCreateTemplate(PlatformType.ChallengePlatform);
        }

        if (playerPositionX - _tileLength * _numberOfActivePlatforms >= _activeLevelPlatforms.Peek().transform.position.x)
        {
            DeletePlatform();
        }
    }

    private void TryCreateTemplate(PlatformType type)
    {
        var template = GetRandomTemplate(type);

        if (template == null)
            return;

        var levelPlatform = Instantiate(template, transform.right * _spawnPointX, Quaternion.identity, transform);
        _activeLevelPlatforms.Enqueue(levelPlatform);

        _spawnPointX += _tileLength;
    }

    private LevelPlatform GetRandomTemplate(PlatformType type)
    {
        var variants = _templates.Where(levelPlatform => levelPlatform.Type == type);

        if (variants.Count() == 1)
            return variants.First();

        var template = variants.ElementAt(Random.Range(0, variants.Count()));

        return template;
    }

    private void DeletePlatform()
    {
        Destroy(_activeLevelPlatforms.Dequeue().gameObject);
    }
}
