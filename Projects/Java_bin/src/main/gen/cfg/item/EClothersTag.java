
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;

public enum EClothersTag
{
    FANG_SHAI(1),
    WU_ZHE(2),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EClothersTag(int value) {
        this.value = value;
    }

    public static EClothersTag valueOf(int value) {
        if (value == 1) return FANG_SHAI;
        if (value == 2) return WU_ZHE;
        throw new IllegalArgumentException("");
    }
}

