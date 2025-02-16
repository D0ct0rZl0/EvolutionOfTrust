﻿

namespace EvolutionOfTrust.Characters
{
    /// <summary>
    /// Обманщик, всегда пытается обмануть оппонента
    /// </summary>
    public class Cheater : Character
    {
        public Cheater(int id) : base(id) { }
        public override Action FirstAction => Action.Cheat;

        public override Action MakeAction(int opponentId)
        {
            return Action.Cheat;
        }
    }
}
