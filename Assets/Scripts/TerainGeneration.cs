using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerainGeneration : MonoBehaviour
{
    MeshFilter meshFilter;
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    public int depth = 20;
    public int width = 256;
    public int height = 226;
    public float scale = 20;
    public float offsetX = 100f;
    public float offsetY = 100f;
    public int resolution = 65;
    Terrain terrain;
    // Start is called before the first frame update
    private void Start()
    {
       // terrain = GetComponent<Terrain>();
        offsetX = Random.Range(0f, 9999f);
        offsetY = Random.Range(0f, 9999f);
        //terrain.terrainData.heightmapResolution = resolution;
    }

    void Update()
    {
         terrain = GetComponent<Terrain>();
        //terrain.terrainData.heightmapResolution = resolution;
        //terrain.terrainData.baseMapResolution = resolution - 1;
       // terrain.terrainData.heightmapTexture.
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
        

        offsetX += Time.deltaTime * 5f;
      //  terrain.terrainData.heightmapResolution = resolution;
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
       // terrain.terrainData.heightmapResolution = resolution;
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);
       // terrain.terrainData.heightmapResolution = resolution;
        terrainData.SetHeights(0, 0, GenerateHeights());

        return terrainData;
    }

    float[,] GenerateHeights() {
        float[,] heights = new float[width, height];
        for (int x=0; x<width; x++)
        {
            for (int y = 0; y<height; y++)
            {
                heights[x, y] = CalculateHeights(x, y);
            } 
        }

        return heights;

    }

    float CalculateHeights(int x, int y) {
        float xCord = (float)x / width * scale + offsetX;
        float yCord = (float)y / height * scale + offsetY;

        return Mathf.PerlinNoise(xCord, yCord);
    }


  

   
}
