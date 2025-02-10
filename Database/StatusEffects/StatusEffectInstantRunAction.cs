using System;
using System.Collections;

public class StatusEffectInstantRunAction : StatusEffectInstant
{
    public Action<object> action = e =>
    {
        var entity = e as Entity;
        var go = entity.gameObject;
        LeanTween.value(go, 1f, 0f, 0.5f)
        .setOnUpdate(val => (entity.display as Card).canvasGroup.alpha = val);
    };

    public override IEnumerator Process()
    {
        action.Invoke(target);
        yield return Remove();
    }
}