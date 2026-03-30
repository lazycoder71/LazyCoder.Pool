using System;
using UnityEngine;

namespace LazyCoder.Pool
{
    public class PoolPrefabSharedAutoRelease : MonoBehaviour
    {
        private void OnDisable()
        {
            PoolPrefabShared.Release(gameObject);
        }
    }
}