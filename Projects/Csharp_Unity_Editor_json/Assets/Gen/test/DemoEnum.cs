//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.test
{
    public static partial class DemoEnum
    {
        public static readonly Bright.Config.EditorEnumItemInfo NONE = new Bright.Config.EditorEnumItemInfo("NONE", "", 0, "");
        public static readonly Bright.Config.EditorEnumItemInfo A = new Bright.Config.EditorEnumItemInfo("A", "aa", 1, "aa");
        public static readonly Bright.Config.EditorEnumItemInfo B = new Bright.Config.EditorEnumItemInfo("B", "bb", 2, "bb");
        public static readonly Bright.Config.EditorEnumItemInfo C = new Bright.Config.EditorEnumItemInfo("C", "cc", 4, "cc");
        public static readonly Bright.Config.EditorEnumItemInfo D = new Bright.Config.EditorEnumItemInfo("D", "dd", 5, "dd");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            NONE,
            A,
            B,
            C,
            D,
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
