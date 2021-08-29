﻿using UnityEngine;

namespace Utilities
{
    public static class TransformExtensions
    {
        public static Vector3 DirFromAngle(this Transform transform, float angleInDegrees, bool angleIsGlobal)
        {
            if (!angleIsGlobal)
            {
                angleInDegrees += transform.eulerAngles.y;
            }
            return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0,
                Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
        }
        
        public static void RotateTowards(this Transform transform, Vector3 targetPos, float speed)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(transform.forward, targetPos - transform.position,
                speed * Time.deltaTime, 0.0f));
        }
    }
}