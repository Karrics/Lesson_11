using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov_13_14
{
    internal class BuildingCollection
    {
        private Building[] buildings;

        public BuildingCollection()
        {
            buildings = new Building[10];
        }

        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new IndexOutOfRangeException("Building index out of range");
                }

                return buildings[index];
            }
            set
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new IndexOutOfRangeException("Building index out of range");
                }

                buildings[index] = value;
            }
        }
    }
}
