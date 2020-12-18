using System.Collections.Generic;

namespace lab_1
{
    class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Color(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Color Any = new Color(1, "Любой");
        public static readonly Color White = new Color(2, "Белый");
        public static readonly Color Black = new Color(3, "Черный");
        public static readonly Color Red = new Color(4, "Красный");
        public static readonly Color Blue = new Color(5, "Синий");
        public static readonly Color Green = new Color(6, "Зеленый");
        public static readonly Color Grey = new Color(7, "Серый");
        public static readonly Color Yellow = new Color(8, "Желтый");
        public static readonly Color Orange = new Color(9, "Оранжевый");
        public static readonly List<Color> colors = new List<Color>
            {Any, White, Black, Red, Blue, Green, Grey,Yellow, Orange};

    }
}
