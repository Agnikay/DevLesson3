using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class MagicSuperpowerAttribute : Attribute
    {
        public MagicSuperpowerAttribute(int mana, MagicRank rank)
        {
            Mana = mana;
            Rank = rank;
        }


        public int Mana { set; get; }
        public MagicRank Rank { set; get; }
    }

    public enum MagicRank
    {
        Goblin,

        Student,

        DrStrange,

        DavidBlane
    }
}
