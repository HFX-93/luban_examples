//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.ai
{
    public static partial class EOperator
    {
        public static readonly Bright.Config.EditorEnumItemInfo IS_EQUAL_TO = new Bright.Config.EditorEnumItemInfo("IS_EQUAL_TO", "", 0, "");
        public static readonly Bright.Config.EditorEnumItemInfo IS_NOT_EQUAL_TO = new Bright.Config.EditorEnumItemInfo("IS_NOT_EQUAL_TO", "", 1, "");
        public static readonly Bright.Config.EditorEnumItemInfo IS_LESS_THAN = new Bright.Config.EditorEnumItemInfo("IS_LESS_THAN", "", 2, "");
        public static readonly Bright.Config.EditorEnumItemInfo IS_LESS_THAN_OR_EQUAL_TO = new Bright.Config.EditorEnumItemInfo("IS_LESS_THAN_OR_EQUAL_TO", "", 3, "");
        public static readonly Bright.Config.EditorEnumItemInfo IS_GREAT_THAN = new Bright.Config.EditorEnumItemInfo("IS_GREAT_THAN", "", 4, "");
        public static readonly Bright.Config.EditorEnumItemInfo IS_GREAT_THAN_OR_EQUAL_TO = new Bright.Config.EditorEnumItemInfo("IS_GREAT_THAN_OR_EQUAL_TO", "", 5, "");
        public static readonly Bright.Config.EditorEnumItemInfo CONTAINS = new Bright.Config.EditorEnumItemInfo("CONTAINS", "", 6, "");
        public static readonly Bright.Config.EditorEnumItemInfo NOT_CONTAINS = new Bright.Config.EditorEnumItemInfo("NOT_CONTAINS", "", 7, "");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            IS_EQUAL_TO,
            IS_NOT_EQUAL_TO,
            IS_LESS_THAN,
            IS_LESS_THAN_OR_EQUAL_TO,
            IS_GREAT_THAN,
            IS_GREAT_THAN_OR_EQUAL_TO,
            CONTAINS,
            NOT_CONTAINS,
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
