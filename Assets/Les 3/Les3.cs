using UnityEngine;
using UnityEngine.Tilemaps;

public class Les3 : MonoBehaviour
{
    [SerializeField] Tilemap myTilemap;
    BoundsInt bounds;

    private void Start()
    {
        bounds = myTilemap.cellBounds;
        Debug.Log(bounds);
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0;

        Vector3Int cellPosition = myTilemap.WorldToCell(worldPosition);

        for (int i = 0 + bounds.position.x; i < bounds.size.x; i++)
        {
            for(int j = 0 + bounds.position.y; j < bounds.size.y; j++)
            {
                Vector3Int pos = new Vector3Int(i, j, 0);
                myTilemap.SetTileFlags(pos, TileFlags.None);
                if(cellPosition == pos)
                {
                    myTilemap.SetColor(pos, Color.purple);
                }
                else
                {
                    myTilemap.SetColor(pos, Color.white);
                }
            }
        }
        
    }
}
