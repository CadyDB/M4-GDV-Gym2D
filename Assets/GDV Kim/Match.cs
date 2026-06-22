using System.Data;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;
using static UnityEngine.Color;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour
{
    [SerializeField] Tilemap myTilemap;
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    private AudioSource audioSource;
    public AudioClip clickClip;
    public AudioClip winClip;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        scoreText.text = Match.score.ToString();
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
            myTilemap.SetColor(cellPosition, Random.ColorHSV());
            score += 2;
            PlaySFX(clickClip);
            
            if(score == 100)
            {
                PlaySFX(winClip);

            }
            if (score == 500)
            {
                PlaySFX(winClip);
            }
            if (score == 1000)
            {
                PlaySFX(winClip);
            }
            
        }

    }
    public void PlaySFX(AudioClip audioClip, float volume = 1f)
    {
        audioSource.clip = audioClip;
        audioSource.volume = volume;
        audioSource.Play();
    }
}