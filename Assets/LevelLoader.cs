using UnityEngine;
using System.Collections;
using System.IO;

public class LevelLoader : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Sprite[] sprites = Resources.LoadAll<Sprite>("zelda-tiles");
		string map_txt = File.ReadAllText("Assets/overworld.map");;
		string [] rows = map_txt.Split('\n');
		for (int i=0;i<rows.Length;i++){
			string [] cols = rows[i].Split(' ');
			for (int j=0;j<cols.Length;j++){
				if (cols[j].Length>1){
					GameObject tile = Instantiate(Resources.Load("MapTile"), new Vector3(j-120, -i+82, 1), Quaternion.identity) as GameObject; 
					SpriteRenderer renderer = tile.GetComponent<SpriteRenderer>();
					renderer.sprite=sprites[System.Int32.Parse(cols[j],System.Globalization.NumberStyles.AllowHexSpecifier)];
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
