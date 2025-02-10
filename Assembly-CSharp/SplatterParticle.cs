// Decompiled with JetBrains decompiler
// Type: SplatterParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class SplatterParticle : MonoBehaviour
{
  public Splatter splatterPrefab;
  public bool canHitSource;
  private SplatterSurface source;
  [SerializeField]
  private Canvas canvas;
  [SerializeField]
  private Image image;
  [SerializeField]
  private Vector2 sizeRange = new Vector2(0.3f, 0.4f);
  public Vector3 velocity;
  public Vector3 gravity = new Vector3(0.0f, 0.0f, 1f);
  public Vector3 frictMult = new Vector3(0.99f, 0.99f, 0.99f);
  private bool isInBackground;
  [SerializeField]
  private float backgroundZThreshold = 1f;

  public Color color
  {
    get => this.image.color;
    set => this.image.color = value;
  }

  private void Awake() => this.transform.localScale = Vector3.one * this.sizeRange.PettyRandom();

  private void Update()
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

  private void OnTriggerEnter(Collider other)
  {
    SplatterSurface component = other.gameObject.GetComponent<SplatterSurface>();
    if (!((Object) component != (Object) null) || !this.canHitSource && !((Object) component != (Object) this.source))
      return;
    component.Splat(this);
    this.gameObject.Destroy();
  }
}
