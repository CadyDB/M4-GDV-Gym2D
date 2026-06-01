using System.Data;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Match : MonoBehaviour
{
    [SerializeField] Tilemap myTilemap;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("boop");
            Vector3 mousePosition = Input.mousePosition;

            //Debug.Log(mousePosition);

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            worldPosition.z = 0;
            //Debug.Log(worldPosition);

            Vector3Int cellPosition = myTilemap.WorldToCell(worldPosition);
            //Debug.Log(cellPosition);

            myTilemap.SetTileFlags(cellPosition, TileFlags.None);
            myTilemap.SetColor(cellPosition, Color.lightCyan);

            // als 2 tiles met dezelfde of nummers die 10 maken worden ingedrukt -> nummers verwijderen + 10 score, hoe?
        }

    }
}