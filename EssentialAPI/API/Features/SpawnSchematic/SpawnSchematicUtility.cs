using ProjectMER.Features;
using UnityEngine;

namespace EssentialAPI.API.SpawnSchematic
{
    public static class SpawnSchematicUtility
    {
        /// <summary>
        /// It uses Project MER to load the schematic.
        /// </summary>
        public static void LoadSchematic(string path, float x, float y, float z)
        {
            Vector3 pos = new Vector3(x, y, z);
            var schematic = ObjectSpawner.SpawnSchematic(
                path,
                pos,
                Quaternion.identity
                );
        }
    }
}