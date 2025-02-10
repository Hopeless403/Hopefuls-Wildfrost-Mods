using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod.MapleFrost
{
    public interface IDataFile
    {
        string Title
        {
            get;
        }
    }

    public class CardDataBuilderBase : MapleFrostMod.DataBuilderBase
    {
        public override object GetDataBuilder()
        {
            return new CardDataBuilder(Mod)
                .SubscribeToAfterAllBuildEvent(d => AfterAllBuilt(d));
        }
        public virtual Action<CardData> AfterAllBuilt(CardData data)
        {
            return null;
        }
    }
}
