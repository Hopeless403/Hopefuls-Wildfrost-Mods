// Decompiled with JetBrains decompiler
// Type: Dice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class Dice : MonoBehaviour
{
  public int value = -1;
  [SerializeField]
  public Rigidbody2D rb;
  [SerializeField]
  public SpriteRenderer spriteRenderer;
  [SerializeField]
  public Vector2 throwSpeed = new Vector2(20f, 40f);
  [SerializeField]
  public Vector2 spinAmount = new Vector2(4f, 6f);
  [SerializeField]
  public Vector2 drag = new Vector2(5f, 6f);
  [Header("Faces")]
  [SerializeField]
  public Sprite[] faceSprites;
  [SerializeField]
  public int[] faceValues = new int[6]{ 1, 2, 3, 4, 5, 6 };

  public void Roll()
  {
    int index = Dead.Random.Range(0, this.faceValues.Length - 1);
    this.value = this.faceValues[index];
    this.spriteRenderer.sprite = this.faceSprites[index];
  }

  [Button(null, EButtonEnableMode.Always)]
  public void Throw()
  {
    foreach (Dice dice in Object.FindObjectsOfType<Dice>())
    {
      Vector3 normalized = (Vector3.zero - dice.transform.position).normalized;
      dice.Throw((Vector2) normalized);
    }
  }

  public void Throw(Vector2 direction)
  {
    this.rb.drag = this.drag.Random();
    this.rb.angularDrag = this.drag.Random();
    this.rb.velocity = direction * this.throwSpeed.Random();
    this.rb.angularVelocity = this.rb.velocity.magnitude * this.spinAmount.Random();
    this.Roll();
  }

  public void DisableCollisions() => this.rb.simulated = false;
}
