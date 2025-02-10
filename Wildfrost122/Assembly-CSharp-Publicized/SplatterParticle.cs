// Decompiled with JetBrains decompiler
// Type: SplatterParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SplatterParticle : MonoBehaviour
{
  public Splatter splatterPrefab;
  public bool canHitSource;
  public SplatterSurface source;
  [SerializeField]
  public Canvas canvas;
  [SerializeField]
  public Image image;
  [SerializeField]
  public Vector2 sizeRange = new Vector2(0.3f, 0.4f);
  public Vector3 velocity;
  public Vector3 gravity = new Vector3(0.0f, 0.0f, 1f);
  public Vector3 frictMult = new Vector3(0.99f, 0.99f, 0.99f);
  public bool isInBackground;
  [SerializeField]
  public float backgroundZThreshold = 1f;

  public Color color
  {
    get => this.image.color;
    set => this.image.color = value;
  }

  public void Awake() => this.transform.localScale = Vector3.one * this.sizeRange.PettyRandom();

  public void Update()
  {
    this.transform.position += this.velocity * Time.deltaTime;
    this.velocity += this.gravity * Time.deltaTime;
    this.velocity = Delta.Multiply(this.velocity, this.frictMult, Time.deltaTime);
    if (!this.isInBackground)
    {
      if ((double) this.transform.position.z > (double) this.backgroundZThreshold)
      {
        this.canvas.sortingLayerName = "Background";
        this.isInBackground = true;
        this.canHitSource = true;
      }
    }
    else if ((double) this.transform.position.z < (double) this.backgroundZThreshold)
    {
      this.canvas.sortingLayerName = "Default";
      this.isInBackground = true;
    }
    if ((double) this.transform.position.z <= 10.0)
      return;
    Object.Destroy((Object) this.gameObject);
  }

  public void SetSource(SplatterSurface source) => this.source = source;

  public void OnTriggerEnter(Collider other)
  {
    SplatterSurface component = other.gameObject.GetComponent<SplatterSurface>();
    if (!((Object) component != (Object) null) || !this.canHitSource && !((Object) component != (Object) this.source))
      return;
    component.Splat(this);
    this.gameObject.Destroy();
  }
}
