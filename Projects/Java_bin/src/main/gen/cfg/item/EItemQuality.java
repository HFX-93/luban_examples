
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;

public enum EItemQuality
{
    WHITE(0),
    GREEN(1),
    BLUE(2),
    PURPLE(3),
    GOLDEN(4),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EItemQuality(int value) {
        this.value = value;
    }

    public static EItemQuality valueOf(int value) {
        if (value == 0) return WHITE;
        if (value == 1) return GREEN;
        if (value == 2) return BLUE;
        if (value == 3) return PURPLE;
        if (value == 4) return GOLDEN;
        throw new IllegalArgumentException("");
    }
}

