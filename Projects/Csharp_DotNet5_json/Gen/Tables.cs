
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Text.Json;

namespace cfg
{
   
public sealed class Tables
{
    public ai.TbBlackboard TbBlackboard {get; }
    public ai.TbBehaviorTree TbBehaviorTree {get; }
    public blueprint.TbClazz TbClazz {get; }
    public bonus.TbDrop TbDrop {get; }
    public common.TbGlobalConfig TbGlobalConfig {get; }
    public error.TbErrorInfo TbErrorInfo {get; }
    public error.TbCodeInfo TbCodeInfo {get; }
    /// <summary>
    /// 道具表
    /// </summary>
    public item.TbItem TbItem {get; }
    public item.TbItemFunc TbItemFunc {get; }
    public item.TbItemExtra TbItemExtra {get; }
    public l10n.TbL10NDemo TbL10NDemo {get; }
    public l10n.TbPatchDemo TbPatchDemo {get; }
    public mail.TbSystemMail TbSystemMail {get; }
    public mail.TbGlobalMail TbGlobalMail {get; }
    public role.TbRoleLevelExpAttr TbRoleLevelExpAttr {get; }
    public role.TbRoleLevelBonusCoefficient TbRoleLevelBonusCoefficient {get; }
    public tag.TbTestTag TbTestTag {get; }
    public test.TbFullTypes TbFullTypes {get; }
    public test.TbSingleton TbSingleton {get; }
    public test.TbNotIndexList TbNotIndexList {get; }
    public test.TbMultiUnionIndexList TbMultiUnionIndexList {get; }
    public test.TbMultiIndexList TbMultiIndexList {get; }
    public test.TbDataFromMisc TbDataFromMisc {get; }
    public test.TbMultiRowRecord TbMultiRowRecord {get; }
    public test.TbTestMultiColumn TbTestMultiColumn {get; }
    public test.TbMultiRowTitle TbMultiRowTitle {get; }
    public test.TbTestNull TbTestNull {get; }
    public test.TbDemoPrimitive TbDemoPrimitive {get; }
    public test.TbTestString TbTestString {get; }
    public test.TbDemoGroup TbDemoGroup {get; }
    public test.TbDemoGroup_C TbDemoGroup_C {get; }
    public test.TbDemoGroup_S TbDemoGroup_S {get; }
    public test.TbDemoGroup_E TbDemoGroup_E {get; }
    public test.TbTestGlobal TbTestGlobal {get; }
    public test.TbTestBeRef TbTestBeRef {get; }
    public test.TbTestBeRef2 TbTestBeRef2 {get; }
    public test.TbTestRef TbTestRef {get; }
    public test.TbTestSize TbTestSize {get; }
    public test.TbTestSet TbTestSet {get; }
    public test.TbDetectCsvEncoding TbDetectCsvEncoding {get; }
    public test.TbDefineFromExcel TbDefineFromExcel {get; }
    public test.TbDefineFromExcelOne TbDefineFromExcelOne {get; }
    public test.TbTestIndex TbTestIndex {get; }
    public test.TbTestMap TbTestMap {get; }
    public test.TbExcelFromJson TbExcelFromJson {get; }
    public test.TbCompositeJsonTable1 TbCompositeJsonTable1 {get; }
    public test.TbCompositeJsonTable2 TbCompositeJsonTable2 {get; }
    public test.TbCompositeJsonTable3 TbCompositeJsonTable3 {get; }
    public test.TbExcelFromJsonMultiRow TbExcelFromJsonMultiRow {get; }
    public test.TbTestSep TbTestSep {get; }
    public test.TbTestExternalType TbTestExternalType {get; }
    public test.TbDemoGroupDefineFromExcel TbDemoGroupDefineFromExcel {get; }
    public test.TbDefineFromExcel2 TbDefineFromExcel2 {get; }
    public test.TbTestExcelBean TbTestExcelBean {get; }
    public test.TbTestDesc TbTestDesc {get; }

    public Tables(System.Func<string, JsonElement> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbBlackboard = new ai.TbBlackboard(loader("ai_tbblackboard")); 
        tables.Add("ai.TbBlackboard", TbBlackboard);
        TbBehaviorTree = new ai.TbBehaviorTree(loader("ai_tbbehaviortree")); 
        tables.Add("ai.TbBehaviorTree", TbBehaviorTree);
        TbClazz = new blueprint.TbClazz(loader("blueprint_tbclazz")); 
        tables.Add("blueprint.TbClazz", TbClazz);
        TbDrop = new bonus.TbDrop(loader("bonus_tbdrop")); 
        tables.Add("bonus.TbDrop", TbDrop);
        TbGlobalConfig = new common.TbGlobalConfig(loader("common_tbglobalconfig")); 
        tables.Add("common.TbGlobalConfig", TbGlobalConfig);
        TbErrorInfo = new error.TbErrorInfo(loader("error_tberrorinfo")); 
        tables.Add("error.TbErrorInfo", TbErrorInfo);
        TbCodeInfo = new error.TbCodeInfo(loader("error_tbcodeinfo")); 
        tables.Add("error.TbCodeInfo", TbCodeInfo);
        TbItem = new item.TbItem(loader("item_tbitem")); 
        tables.Add("item.TbItem", TbItem);
        TbItemFunc = new item.TbItemFunc(loader("item_tbitemfunc")); 
        tables.Add("item.TbItemFunc", TbItemFunc);
        TbItemExtra = new item.TbItemExtra(loader("item_tbitemextra")); 
        tables.Add("item.TbItemExtra", TbItemExtra);
        TbL10NDemo = new l10n.TbL10NDemo(loader("l10n_tbl10ndemo")); 
        tables.Add("l10n.TbL10NDemo", TbL10NDemo);
        TbPatchDemo = new l10n.TbPatchDemo(loader("l10n_tbpatchdemo")); 
        tables.Add("l10n.TbPatchDemo", TbPatchDemo);
        TbSystemMail = new mail.TbSystemMail(loader("mail_tbsystemmail")); 
        tables.Add("mail.TbSystemMail", TbSystemMail);
        TbGlobalMail = new mail.TbGlobalMail(loader("mail_tbglobalmail")); 
        tables.Add("mail.TbGlobalMail", TbGlobalMail);
        TbRoleLevelExpAttr = new role.TbRoleLevelExpAttr(loader("role_tbrolelevelexpattr")); 
        tables.Add("role.TbRoleLevelExpAttr", TbRoleLevelExpAttr);
        TbRoleLevelBonusCoefficient = new role.TbRoleLevelBonusCoefficient(loader("role_tbrolelevelbonuscoefficient")); 
        tables.Add("role.TbRoleLevelBonusCoefficient", TbRoleLevelBonusCoefficient);
        TbTestTag = new tag.TbTestTag(loader("tag_tbtesttag")); 
        tables.Add("tag.TbTestTag", TbTestTag);
        TbFullTypes = new test.TbFullTypes(loader("test_tbfulltypes")); 
        tables.Add("test.TbFullTypes", TbFullTypes);
        TbSingleton = new test.TbSingleton(loader("test_tbsingleton")); 
        tables.Add("test.TbSingleton", TbSingleton);
        TbNotIndexList = new test.TbNotIndexList(loader("test_tbnotindexlist")); 
        tables.Add("test.TbNotIndexList", TbNotIndexList);
        TbMultiUnionIndexList = new test.TbMultiUnionIndexList(loader("test_tbmultiunionindexlist")); 
        tables.Add("test.TbMultiUnionIndexList", TbMultiUnionIndexList);
        TbMultiIndexList = new test.TbMultiIndexList(loader("test_tbmultiindexlist")); 
        tables.Add("test.TbMultiIndexList", TbMultiIndexList);
        TbDataFromMisc = new test.TbDataFromMisc(loader("test_tbdatafrommisc")); 
        tables.Add("test.TbDataFromMisc", TbDataFromMisc);
        TbMultiRowRecord = new test.TbMultiRowRecord(loader("test_tbmultirowrecord")); 
        tables.Add("test.TbMultiRowRecord", TbMultiRowRecord);
        TbTestMultiColumn = new test.TbTestMultiColumn(loader("test_tbtestmulticolumn")); 
        tables.Add("test.TbTestMultiColumn", TbTestMultiColumn);
        TbMultiRowTitle = new test.TbMultiRowTitle(loader("test_tbmultirowtitle")); 
        tables.Add("test.TbMultiRowTitle", TbMultiRowTitle);
        TbTestNull = new test.TbTestNull(loader("test_tbtestnull")); 
        tables.Add("test.TbTestNull", TbTestNull);
        TbDemoPrimitive = new test.TbDemoPrimitive(loader("test_tbdemoprimitive")); 
        tables.Add("test.TbDemoPrimitive", TbDemoPrimitive);
        TbTestString = new test.TbTestString(loader("test_tbteststring")); 
        tables.Add("test.TbTestString", TbTestString);
        TbDemoGroup = new test.TbDemoGroup(loader("test_tbdemogroup")); 
        tables.Add("test.TbDemoGroup", TbDemoGroup);
        TbDemoGroup_C = new test.TbDemoGroup_C(loader("test_tbdemogroup_c")); 
        tables.Add("test.TbDemoGroup_C", TbDemoGroup_C);
        TbDemoGroup_S = new test.TbDemoGroup_S(loader("test_tbdemogroup_s")); 
        tables.Add("test.TbDemoGroup_S", TbDemoGroup_S);
        TbDemoGroup_E = new test.TbDemoGroup_E(loader("test_tbdemogroup_e")); 
        tables.Add("test.TbDemoGroup_E", TbDemoGroup_E);
        TbTestGlobal = new test.TbTestGlobal(loader("test_tbtestglobal")); 
        tables.Add("test.TbTestGlobal", TbTestGlobal);
        TbTestBeRef = new test.TbTestBeRef(loader("test_tbtestberef")); 
        tables.Add("test.TbTestBeRef", TbTestBeRef);
        TbTestBeRef2 = new test.TbTestBeRef2(loader("test_tbtestberef2")); 
        tables.Add("test.TbTestBeRef2", TbTestBeRef2);
        TbTestRef = new test.TbTestRef(loader("test_tbtestref")); 
        tables.Add("test.TbTestRef", TbTestRef);
        TbTestSize = new test.TbTestSize(loader("test_tbtestsize")); 
        tables.Add("test.TbTestSize", TbTestSize);
        TbTestSet = new test.TbTestSet(loader("test_tbtestset")); 
        tables.Add("test.TbTestSet", TbTestSet);
        TbDetectCsvEncoding = new test.TbDetectCsvEncoding(loader("test_tbdetectcsvencoding")); 
        tables.Add("test.TbDetectCsvEncoding", TbDetectCsvEncoding);
        TbDefineFromExcel = new test.TbDefineFromExcel(loader("test_tbdefinefromexcel")); 
        tables.Add("test.TbDefineFromExcel", TbDefineFromExcel);
        TbDefineFromExcelOne = new test.TbDefineFromExcelOne(loader("test_tbdefinefromexcelone")); 
        tables.Add("test.TbDefineFromExcelOne", TbDefineFromExcelOne);
        TbTestIndex = new test.TbTestIndex(loader("test_tbtestindex")); 
        tables.Add("test.TbTestIndex", TbTestIndex);
        TbTestMap = new test.TbTestMap(loader("test_tbtestmap")); 
        tables.Add("test.TbTestMap", TbTestMap);
        TbExcelFromJson = new test.TbExcelFromJson(loader("test_tbexcelfromjson")); 
        tables.Add("test.TbExcelFromJson", TbExcelFromJson);
        TbCompositeJsonTable1 = new test.TbCompositeJsonTable1(loader("test_tbcompositejsontable1")); 
        tables.Add("test.TbCompositeJsonTable1", TbCompositeJsonTable1);
        TbCompositeJsonTable2 = new test.TbCompositeJsonTable2(loader("test_tbcompositejsontable2")); 
        tables.Add("test.TbCompositeJsonTable2", TbCompositeJsonTable2);
        TbCompositeJsonTable3 = new test.TbCompositeJsonTable3(loader("test_tbcompositejsontable3")); 
        tables.Add("test.TbCompositeJsonTable3", TbCompositeJsonTable3);
        TbExcelFromJsonMultiRow = new test.TbExcelFromJsonMultiRow(loader("test_tbexcelfromjsonmultirow")); 
        tables.Add("test.TbExcelFromJsonMultiRow", TbExcelFromJsonMultiRow);
        TbTestSep = new test.TbTestSep(loader("test_tbtestsep")); 
        tables.Add("test.TbTestSep", TbTestSep);
        TbTestExternalType = new test.TbTestExternalType(loader("test_tbtestexternaltype")); 
        tables.Add("test.TbTestExternalType", TbTestExternalType);
        TbDemoGroupDefineFromExcel = new test.TbDemoGroupDefineFromExcel(loader("test_tbdemogroupdefinefromexcel")); 
        tables.Add("test.TbDemoGroupDefineFromExcel", TbDemoGroupDefineFromExcel);
        TbDefineFromExcel2 = new test.TbDefineFromExcel2(loader("test_tbdefinefromexcel2")); 
        tables.Add("test.TbDefineFromExcel2", TbDefineFromExcel2);
        TbTestExcelBean = new test.TbTestExcelBean(loader("test_tbtestexcelbean")); 
        tables.Add("test.TbTestExcelBean", TbTestExcelBean);
        TbTestDesc = new test.TbTestDesc(loader("test_tbtestdesc")); 
        tables.Add("test.TbTestDesc", TbTestDesc);

        TbBlackboard.Resolve(tables); 
        TbBehaviorTree.Resolve(tables); 
        TbClazz.Resolve(tables); 
        TbDrop.Resolve(tables); 
        TbGlobalConfig.Resolve(tables); 
        TbErrorInfo.Resolve(tables); 
        TbCodeInfo.Resolve(tables); 
        TbItem.Resolve(tables); 
        TbItemFunc.Resolve(tables); 
        TbItemExtra.Resolve(tables); 
        TbL10NDemo.Resolve(tables); 
        TbPatchDemo.Resolve(tables); 
        TbSystemMail.Resolve(tables); 
        TbGlobalMail.Resolve(tables); 
        TbRoleLevelExpAttr.Resolve(tables); 
        TbRoleLevelBonusCoefficient.Resolve(tables); 
        TbTestTag.Resolve(tables); 
        TbFullTypes.Resolve(tables); 
        TbSingleton.Resolve(tables); 
        TbNotIndexList.Resolve(tables); 
        TbMultiUnionIndexList.Resolve(tables); 
        TbMultiIndexList.Resolve(tables); 
        TbDataFromMisc.Resolve(tables); 
        TbMultiRowRecord.Resolve(tables); 
        TbTestMultiColumn.Resolve(tables); 
        TbMultiRowTitle.Resolve(tables); 
        TbTestNull.Resolve(tables); 
        TbDemoPrimitive.Resolve(tables); 
        TbTestString.Resolve(tables); 
        TbDemoGroup.Resolve(tables); 
        TbDemoGroup_C.Resolve(tables); 
        TbDemoGroup_S.Resolve(tables); 
        TbDemoGroup_E.Resolve(tables); 
        TbTestGlobal.Resolve(tables); 
        TbTestBeRef.Resolve(tables); 
        TbTestBeRef2.Resolve(tables); 
        TbTestRef.Resolve(tables); 
        TbTestSize.Resolve(tables); 
        TbTestSet.Resolve(tables); 
        TbDetectCsvEncoding.Resolve(tables); 
        TbDefineFromExcel.Resolve(tables); 
        TbDefineFromExcelOne.Resolve(tables); 
        TbTestIndex.Resolve(tables); 
        TbTestMap.Resolve(tables); 
        TbExcelFromJson.Resolve(tables); 
        TbCompositeJsonTable1.Resolve(tables); 
        TbCompositeJsonTable2.Resolve(tables); 
        TbCompositeJsonTable3.Resolve(tables); 
        TbExcelFromJsonMultiRow.Resolve(tables); 
        TbTestSep.Resolve(tables); 
        TbTestExternalType.Resolve(tables); 
        TbDemoGroupDefineFromExcel.Resolve(tables); 
        TbDefineFromExcel2.Resolve(tables); 
        TbTestExcelBean.Resolve(tables); 
        TbTestDesc.Resolve(tables); 
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbBlackboard.TranslateText(translator); 
        TbBehaviorTree.TranslateText(translator); 
        TbClazz.TranslateText(translator); 
        TbDrop.TranslateText(translator); 
        TbGlobalConfig.TranslateText(translator); 
        TbErrorInfo.TranslateText(translator); 
        TbCodeInfo.TranslateText(translator); 
        TbItem.TranslateText(translator); 
        TbItemFunc.TranslateText(translator); 
        TbItemExtra.TranslateText(translator); 
        TbL10NDemo.TranslateText(translator); 
        TbPatchDemo.TranslateText(translator); 
        TbSystemMail.TranslateText(translator); 
        TbGlobalMail.TranslateText(translator); 
        TbRoleLevelExpAttr.TranslateText(translator); 
        TbRoleLevelBonusCoefficient.TranslateText(translator); 
        TbTestTag.TranslateText(translator); 
        TbFullTypes.TranslateText(translator); 
        TbSingleton.TranslateText(translator); 
        TbNotIndexList.TranslateText(translator); 
        TbMultiUnionIndexList.TranslateText(translator); 
        TbMultiIndexList.TranslateText(translator); 
        TbDataFromMisc.TranslateText(translator); 
        TbMultiRowRecord.TranslateText(translator); 
        TbTestMultiColumn.TranslateText(translator); 
        TbMultiRowTitle.TranslateText(translator); 
        TbTestNull.TranslateText(translator); 
        TbDemoPrimitive.TranslateText(translator); 
        TbTestString.TranslateText(translator); 
        TbDemoGroup.TranslateText(translator); 
        TbDemoGroup_C.TranslateText(translator); 
        TbDemoGroup_S.TranslateText(translator); 
        TbDemoGroup_E.TranslateText(translator); 
        TbTestGlobal.TranslateText(translator); 
        TbTestBeRef.TranslateText(translator); 
        TbTestBeRef2.TranslateText(translator); 
        TbTestRef.TranslateText(translator); 
        TbTestSize.TranslateText(translator); 
        TbTestSet.TranslateText(translator); 
        TbDetectCsvEncoding.TranslateText(translator); 
        TbDefineFromExcel.TranslateText(translator); 
        TbDefineFromExcelOne.TranslateText(translator); 
        TbTestIndex.TranslateText(translator); 
        TbTestMap.TranslateText(translator); 
        TbExcelFromJson.TranslateText(translator); 
        TbCompositeJsonTable1.TranslateText(translator); 
        TbCompositeJsonTable2.TranslateText(translator); 
        TbCompositeJsonTable3.TranslateText(translator); 
        TbExcelFromJsonMultiRow.TranslateText(translator); 
        TbTestSep.TranslateText(translator); 
        TbTestExternalType.TranslateText(translator); 
        TbDemoGroupDefineFromExcel.TranslateText(translator); 
        TbDefineFromExcel2.TranslateText(translator); 
        TbTestExcelBean.TranslateText(translator); 
        TbTestDesc.TranslateText(translator); 
    }
}

}
