
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

public enum EFinishMode
{
    IMMEDIATE(0),
    DELAYED(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EFinishMode(int value) {
        this.value = value;
    }

    public static EFinishMode valueOf(int value) {
        if (value == 0) return IMMEDIATE;
        if (value == 1) return DELAYED;
        throw new IllegalArgumentException("");
    }
}

