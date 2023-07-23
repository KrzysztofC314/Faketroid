using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

namespace UnityStandardAssets._2D
{
    public class Goalpost : MonoBehaviour
    {
        public TilemapRenderer sprite;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                sprite.enabled = true; 
            }
        }
    }
}
