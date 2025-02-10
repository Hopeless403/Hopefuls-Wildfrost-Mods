using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace WildfrostHopeMod
{
    public static class RectTransformExtensions
    {
        public static Vector2 GetSize(this RectTransform source) => source.rect.size;
        public static float GetWidth(this RectTransform source) => source.rect.size.x;
        public static float GetHeight(this RectTransform source) => source.rect.size.y;

        /// <summary>
        /// Sets the sources RT size to the same as the toCopy's RT size.
        /// </summary>
        public static void SetSize(this RectTransform source, RectTransform toCopy)
        {
            source.SetSize(toCopy.GetSize());
        }

        /// <summary>
        /// Sets the sources RT size to the same as the newSize.
        /// </summary>
        public static void SetSize(this RectTransform source, Vector2 newSize)
        {
            source.SetSize(newSize.x, newSize.y);
        }

        /// <summary>
        /// Sets the sources RT size to the new width and height.
        /// </summary>
        public static void SetSize(this RectTransform source, float width, float height)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }

        public static void SetWidth(this RectTransform source, float width)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        }

        public static void SetHeight(this RectTransform source, float height)
        {
            source.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
    }

    public static class TransformExtensions
    {
        public static void Normalise(this Transform transform)
        {
            transform.localScale = Vector3.one;
            transform.localRotation = Quaternion.identity;
        }
        public static Transform InstantiateWithoutChildren(this Transform transform, string detachFrom = null)
        {
            List<Transform> detached = new();
            Transform detacher = (detachFrom != null ? transform.FindRecursive(detachFrom) : transform);
            foreach (var child in detacher.GetAllChildren())
            {
                detached.Add(child);
                child.SetParent(null);
            }
            var result = transform.InstantiateKeepName();
            detached.Update(child => child.SetParent(detacher));
            return result;
        }
        public static RectTransform ToRectTransform(this Transform transform) => transform as RectTransform;
    }
}
