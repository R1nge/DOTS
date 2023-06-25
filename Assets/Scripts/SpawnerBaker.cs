using Unity.Entities;

class SpawnerBaker : Baker<SpawnerAuthoring>
{
    public override void Bake(SpawnerAuthoring authoring)
    {
        var enitiy = GetEntity(TransformUsageFlags.None);
        AddComponent(enitiy, new SpawnerComponent
        {
            Prefab = GetEntity(authoring.prefab, TransformUsageFlags.Dynamic),
            SpawnPosition = authoring.transform.position,
            NextSpawnTime = 0.0f,
            SpawnRate = authoring.spawnRate
        });
    }
}