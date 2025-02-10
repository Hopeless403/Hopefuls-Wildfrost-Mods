public class ScriptableAmountDamageBlocked : ScriptableAmount
{
    public override int Get(Entity entity)
    {
        return entity?.lastHit?.damageBlocked ?? 0;
    }
}