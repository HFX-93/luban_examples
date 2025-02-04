//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class GetOwnerPlayer extends cfg.ai.Service {
    public GetOwnerPlayer(JsonObject __json__) { 
        super(__json__);
        playerActorKey = __json__.get("player_actor_key").getAsString();
    }

    public GetOwnerPlayer(int id, String node_name, String player_actor_key ) {
        super(id, node_name);
        this.playerActorKey = player_actor_key;
    }

    public static GetOwnerPlayer deserializeGetOwnerPlayer(JsonObject __json__) {
        return new GetOwnerPlayer(__json__);
    }

    public final String playerActorKey;

    public static final int __ID__ = -999247644;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "playerActorKey:" + playerActorKey + ","
        + "}";
    }
}
