// Decompiled with JetBrains decompiler
// Type: Dice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

public class Dice : MonoBehaviour
{
  public int value = -1;
  [SerializeField]
  private Rigidbody2D rb;
  [SerializeField]
  private SpriteRenderer spriteRenderer;
  [SerializeField]
  private Vector2 throwSpeed = new Vector2(20f, 40f);
  [SerializeField]
  private Vector2 spinAmount = new Vector2(4f, 6f);
  [SerializeField]
  private Vector2 drag = new Vector2(5f, 6f);
  [Header("Faces")]
  [SerializeField]
  private Sprite[] faceSprites;
  [SerializeField]
  private int[] faceValues = new int[6]{ 1, 2, 3, 4, 5, 6 };

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
