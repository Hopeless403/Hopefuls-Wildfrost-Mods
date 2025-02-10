// Decompiled with JetBrains decompiler
// Type: AvatarPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AvatarPart : MonoBehaviour
{
  [SerializeField]
  private AvatarPart.Anchor[] anchors;
  [SerializeField]
  private AvatarPart.Part[] parts;

  public Transform GetAnchor(string name) => ((IEnumerable<AvatarPart.Anchor>) this.anchors).FirstOrDefault<AvatarPart.Anchor>((Func<AvatarPart.Anchor, bool>) (a => a.name == name)).transform;

  public AvatarPart.Part Get(string name) => ((IEnumerable<AvatarPart.Part>) this.parts).FirstOrDefault<AvatarPart.Part>((Func<AvatarPart.Part, bool>) (a => a.name == name));

  [Serializable]
  public struct Anchor
  {
    public string name;
    public Transform transform;
  }

  [Serializable]
  public struct Part
  {
    public string name;
    public Image image;

    public void Disable()
    {
      if (!((UnityEngine.Object) this.image != (UnityEngine.Object) null))
        return;
      this.image.enabled = false;
    }

    public void Set(Sprite sprite, Vector2 scale)
    {
      if (!((UnityEngine.Object) this.image != (UnityEngine.Object) null))
        return;
      this.image.enabled = true;
      this.image.sprite = sprite;
      Transform transform = this.image.transform;
      transform.localScale = (Vector3) ((Vector2) transform.localScale * scale);
    }
  }
}
