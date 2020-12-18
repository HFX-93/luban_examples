
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.error;

public enum EErrorCode
{
    OK(0),
    SERVER_NOT_EXISTS(1),
    HAS_BIND_SERVER(2),
    AUTH_FAIL(3),
    NOT_BIND_SERVER(4),
    SERVER_ACCESS_FAIL(5),
    EXAMPLE_FLASH(6),
    EXAMPLE_MSGBOX(7),
    EXAMPLE_DLG_OK(8),
    EXAMPLE_DLG_OK_CANCEL(9),
    ROLE_CREATE_NAME_INVALID_CHAR(100),
    ROLE_CREATE_NAME_EMPTY(101),
    ROLE_CREATE_NAME_EXCEED_MAX_LENGTH(102),
    ROLE_CREATE_ROLE_LIST_FULL(103),
    ROLE_CREATE_INVALID_PROFESSION(104),
    ROLE_CREATE_INVALID_GENDER(105),
    ROLE_NOT_OWNED_BY_USER(106),
    ROLE_LEVEL_NOT_ARRIVE(107),
    PARAM_ILLEGAL(200),
    TEMP_BAG_NOT_EMPTY(201),
    ITEM_CAN_NOT_USE(202),
    CURRENCY_NOT_ENOUGH(203),
    BAG_IS_FULL(204),
    ITEM_NOT_ENOUGH(205),
    ITEM_IN_BAG(206),
    GENDER_NOT_MATCH(300),
    LEVEL_TOO_LOW(301),
    LEVEL_TOO_HIGH(302),
    EXCEED_LIMIT(303),
    OVER_TIME(304),
    SERVER_ERROR(305),
    SKILL_NOT_IN_LIST(400),
    SKILL_NOT_COOLDOWN(401),
    SKILL_TARGET_NOT_EXIST(402),
    SKILL_ANOTHER_CASTING(403),
    SKILL_OUT_OF_DISTANCE(404),
    SKILL_TARGET_CAMP_NOT_MATCH(405),
    SKILL_INVALID_DIRECTION(406),
    SKILL_NOT_IN_SELECT_SHAPE(407),
    SKILL_ENERGY_NOT_ENOUGH(408),
    DIALOG_NODE_NOT_CHOOSEN(500),
    DIALOG_NOT_FINISH(501),
    DIALOG_HAS_FINISH(502),
    QUEST_STAGE_NOT_FINISHED(503),
    QUEST_NOT_DOING(504),
    QUEST_STAGE_NOT_DOING(505),
    QUEST_HAS_ACCEPTED(506),
    MAP_OBJECT_NOT_EXIST(600),
    INTERACTION_OBJECT_NOT_SUPPORT_OPERATION(601),
    HAS_NOT_EQUIP(602),
    HANDHELD_EQUIP_ID_NOT_MATCH(603),
    NOT_AVAILABLE_SUIT_ID(604),
    NO_INTERACTION_COMPONENT(605),
    HAS_INTERACTED(606),
    VIALITY_NOT_ENOUGH(607),
    PLAYER_SESSION_NOT_EXIST(608),
    PLAYER_SESSION_WORLD_PLAYER_NOT_INIT(609),
    MAP_NOT_EXIST(610),
    MAIL_TYPE_ERROR(700),
    MAIL_NOT_EXITST(701),
    MAIL_HAVE_DELETED(702),
    MAIL_AWARD_HAVE_RECEIVED(703),
    MAIL_OPERATE_TYPE_ERROR(704),
    MAIL_CONDITION_NOT_MEET(705),
    MAIL_STATE_ERROR(706),
    MAIL_NO_AWARD(707),
    MAIL_BOX_IS_FULL(708),
    PROP_SCORE_NOT_BIGGER_THAN(800),
    NOT_WEAR_CLOTHES(801),
    NOT_WEAR_SUIT(802),
    SUIT_NOT_UNLOCK(900),
    SUIT_COMPONENT_NOT_UNLOCK(901),
    SUIT_STATE_ERROR(902),
    SUIT_COMPONENT_STATE_ERROR(903),
    SUIT_COMPONENT_NO_NEED_LEARN(904),
    STORE_NOT_ENABLED(1000),
    SHELF_NOT_ENABLED(1001),
    GOODS_NOT_ENABLED(1002),
    GOODS_NOT_IN_CUR_REFRESH(1003),
    RETRY(1100),
    NOT_COOLDOWN(1101),
    SELFIE_UNLOCK(1200),
    SELFIE_ALREADY_UNLOCK(1201),
    SELFIE_LACK_STARTS(1202),
    SELFIE_HAD_REWARD(1203),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EErrorCode(int value) {
        this.value = value;
    }

    public static EErrorCode valueOf(int value) {
        if (value == 0) return OK;
        if (value == 1) return SERVER_NOT_EXISTS;
        if (value == 2) return HAS_BIND_SERVER;
        if (value == 3) return AUTH_FAIL;
        if (value == 4) return NOT_BIND_SERVER;
        if (value == 5) return SERVER_ACCESS_FAIL;
        if (value == 6) return EXAMPLE_FLASH;
        if (value == 7) return EXAMPLE_MSGBOX;
        if (value == 8) return EXAMPLE_DLG_OK;
        if (value == 9) return EXAMPLE_DLG_OK_CANCEL;
        if (value == 100) return ROLE_CREATE_NAME_INVALID_CHAR;
        if (value == 101) return ROLE_CREATE_NAME_EMPTY;
        if (value == 102) return ROLE_CREATE_NAME_EXCEED_MAX_LENGTH;
        if (value == 103) return ROLE_CREATE_ROLE_LIST_FULL;
        if (value == 104) return ROLE_CREATE_INVALID_PROFESSION;
        if (value == 105) return ROLE_CREATE_INVALID_GENDER;
        if (value == 106) return ROLE_NOT_OWNED_BY_USER;
        if (value == 107) return ROLE_LEVEL_NOT_ARRIVE;
        if (value == 200) return PARAM_ILLEGAL;
        if (value == 201) return TEMP_BAG_NOT_EMPTY;
        if (value == 202) return ITEM_CAN_NOT_USE;
        if (value == 203) return CURRENCY_NOT_ENOUGH;
        if (value == 204) return BAG_IS_FULL;
        if (value == 205) return ITEM_NOT_ENOUGH;
        if (value == 206) return ITEM_IN_BAG;
        if (value == 300) return GENDER_NOT_MATCH;
        if (value == 301) return LEVEL_TOO_LOW;
        if (value == 302) return LEVEL_TOO_HIGH;
        if (value == 303) return EXCEED_LIMIT;
        if (value == 304) return OVER_TIME;
        if (value == 305) return SERVER_ERROR;
        if (value == 400) return SKILL_NOT_IN_LIST;
        if (value == 401) return SKILL_NOT_COOLDOWN;
        if (value == 402) return SKILL_TARGET_NOT_EXIST;
        if (value == 403) return SKILL_ANOTHER_CASTING;
        if (value == 404) return SKILL_OUT_OF_DISTANCE;
        if (value == 405) return SKILL_TARGET_CAMP_NOT_MATCH;
        if (value == 406) return SKILL_INVALID_DIRECTION;
        if (value == 407) return SKILL_NOT_IN_SELECT_SHAPE;
        if (value == 408) return SKILL_ENERGY_NOT_ENOUGH;
        if (value == 500) return DIALOG_NODE_NOT_CHOOSEN;
        if (value == 501) return DIALOG_NOT_FINISH;
        if (value == 502) return DIALOG_HAS_FINISH;
        if (value == 503) return QUEST_STAGE_NOT_FINISHED;
        if (value == 504) return QUEST_NOT_DOING;
        if (value == 505) return QUEST_STAGE_NOT_DOING;
        if (value == 506) return QUEST_HAS_ACCEPTED;
        if (value == 600) return MAP_OBJECT_NOT_EXIST;
        if (value == 601) return INTERACTION_OBJECT_NOT_SUPPORT_OPERATION;
        if (value == 602) return HAS_NOT_EQUIP;
        if (value == 603) return HANDHELD_EQUIP_ID_NOT_MATCH;
        if (value == 604) return NOT_AVAILABLE_SUIT_ID;
        if (value == 605) return NO_INTERACTION_COMPONENT;
        if (value == 606) return HAS_INTERACTED;
        if (value == 607) return VIALITY_NOT_ENOUGH;
        if (value == 608) return PLAYER_SESSION_NOT_EXIST;
        if (value == 609) return PLAYER_SESSION_WORLD_PLAYER_NOT_INIT;
        if (value == 610) return MAP_NOT_EXIST;
        if (value == 700) return MAIL_TYPE_ERROR;
        if (value == 701) return MAIL_NOT_EXITST;
        if (value == 702) return MAIL_HAVE_DELETED;
        if (value == 703) return MAIL_AWARD_HAVE_RECEIVED;
        if (value == 704) return MAIL_OPERATE_TYPE_ERROR;
        if (value == 705) return MAIL_CONDITION_NOT_MEET;
        if (value == 706) return MAIL_STATE_ERROR;
        if (value == 707) return MAIL_NO_AWARD;
        if (value == 708) return MAIL_BOX_IS_FULL;
        if (value == 800) return PROP_SCORE_NOT_BIGGER_THAN;
        if (value == 801) return NOT_WEAR_CLOTHES;
        if (value == 802) return NOT_WEAR_SUIT;
        if (value == 900) return SUIT_NOT_UNLOCK;
        if (value == 901) return SUIT_COMPONENT_NOT_UNLOCK;
        if (value == 902) return SUIT_STATE_ERROR;
        if (value == 903) return SUIT_COMPONENT_STATE_ERROR;
        if (value == 904) return SUIT_COMPONENT_NO_NEED_LEARN;
        if (value == 1000) return STORE_NOT_ENABLED;
        if (value == 1001) return SHELF_NOT_ENABLED;
        if (value == 1002) return GOODS_NOT_ENABLED;
        if (value == 1003) return GOODS_NOT_IN_CUR_REFRESH;
        if (value == 1100) return RETRY;
        if (value == 1101) return NOT_COOLDOWN;
        if (value == 1200) return SELFIE_UNLOCK;
        if (value == 1201) return SELFIE_ALREADY_UNLOCK;
        if (value == 1202) return SELFIE_LACK_STARTS;
        if (value == 1203) return SELFIE_HAD_REWARD;
        throw new IllegalArgumentException("");
    }
}

