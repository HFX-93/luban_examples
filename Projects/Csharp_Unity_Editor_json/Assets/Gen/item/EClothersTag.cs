//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.item
{
    public static partial class EClothersTag
    {
        public static readonly Bright.Config.EditorEnumItemInfo FANG_SHAI = new Bright.Config.EditorEnumItemInfo("FANG_SHAI", "防晒", 1, "防晒");
        public static readonly Bright.Config.EditorEnumItemInfo WU_ZHE = new Bright.Config.EditorEnumItemInfo("WU_ZHE", "舞者", 2, "舞者");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            FANG_SHAI,
            WU_ZHE,
        };

        public static System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> GetItems() => __items;

        public static Bright.Config.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Bright.Config.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Bright.Config.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }
}
