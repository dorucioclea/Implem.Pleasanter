﻿using Implem.DefinitionAccessor;
using Implem.Libraries.Classes;
using Implem.Libraries.DataSources.Interfaces;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.DataTypes;
using Implem.Pleasanter.Libraries.Extensions;
using Implem.Pleasanter.Libraries.General;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Models;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Resources;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Libraries.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using static Implem.Pleasanter.Libraries.ServerScripts.ServerScriptModel;
namespace Implem.Pleasanter.Models
{
    public static class WikiUtilities
    {
        public static HtmlBuilder TdValue(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            Column column,
            WikiModel wikiModel,
            int? tabIndex = null,
            ServerScriptModelColumn serverScriptValues = null)
        {
            if (serverScriptValues?.RawText.IsNullOrEmpty() == false)
            {
                return hb.Td(
                    context: context,
                    column: column,
                    action: () => hb.Raw(serverScriptValues?.RawText),
                    tabIndex: tabIndex,
                    serverScriptValues: serverScriptValues);
            }
            else if (!column.GridDesign.IsNullOrEmpty())
            {
                return hb.TdCustomValue(
                    context: context,
                    ss: ss,
                    gridDesign: column.GridDesign,
                    wikiModel: wikiModel);
            }
            else
            {
                var mine = wikiModel.Mine(context: context);
                switch (column.Name)
                {
                    case "SiteId":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.SiteId,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "UpdatedTime":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.UpdatedTime,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "WikiId":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.WikiId,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Ver":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Ver,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Title":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Title,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Body":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Body,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "TitleBody":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.TitleBody,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Locked":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Locked,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Comments":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Comments,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Creator":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Creator,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "Updator":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.Updator,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    case "CreatedTime":
                        return ss.ReadColumnAccessControls.Allowed(
                            context: context,
                            ss: ss,
                            column: column,
                            mine: mine)
                                ? hb.Td(
                                    context: context,
                                    column: column,
                                    value: wikiModel.CreatedTime,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues)
                                : hb.Td(
                                    context: context,
                                    column: column,
                                    value: string.Empty,
                                    tabIndex: tabIndex,
                                    serverScriptValues: serverScriptValues);
                    default:
                        switch (Def.ExtendedColumnTypes.Get(column.Name))
                        {
                            case "Class":
                                return ss.ReadColumnAccessControls.Allowed(
                                    context: context,
                                    ss: ss,
                                    column: column,
                                    mine: mine)
                                        ? hb.Td(
                                            context: context,
                                            column: column,
                                            value: wikiModel.Class(columnName: column.Name),
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues)
                                        : hb.Td(
                                            context: context,
                                            column: column,
                                            value: string.Empty,
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues);
                            case "Num":
                                return ss.ReadColumnAccessControls.Allowed(
                                    context: context,
                                    ss: ss,
                                    column: column,
                                    mine: mine)
                                        ? hb.Td(
                                            context: context,
                                            column: column,
                                            value: wikiModel.Num(columnName: column.Name),
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues)
                                        : hb.Td(
                                            context: context,
                                            column: column,
                                            value: string.Empty,
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues);
                            case "Date":
                                return ss.ReadColumnAccessControls.Allowed(
                                    context: context,
                                    ss: ss,
                                    column: column,
                                    mine: mine)
                                        ? hb.Td(
                                            context: context,
                                            column: column,
                                            value: wikiModel.Date(columnName: column.Name),
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues)
                                        : hb.Td(
                                            context: context,
                                            column: column,
                                            value: string.Empty,
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues);
                            case "Description":
                                return ss.ReadColumnAccessControls.Allowed(
                                    context: context,
                                    ss: ss,
                                    column: column,
                                    mine: mine)
                                        ? hb.Td(
                                            context: context,
                                            column: column,
                                            value: wikiModel.Description(columnName: column.Name),
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues)
                                        : hb.Td(
                                            context: context,
                                            column: column,
                                            value: string.Empty,
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues);
                            case "Check":
                                return ss.ReadColumnAccessControls.Allowed(
                                    context: context,
                                    ss: ss,
                                    column: column,
                                    mine: mine)
                                        ? hb.Td(
                                            context: context,
                                            column: column,
                                            value: wikiModel.Check(columnName: column.Name),
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues)
                                        : hb.Td(
                                            context: context,
                                            column: column,
                                            value: string.Empty,
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues);
                            case "Attachments":
                                return ss.ReadColumnAccessControls.Allowed(
                                    context: context,
                                    ss: ss,
                                    column: column,
                                    mine: mine)
                                        ? hb.Td(
                                            context: context,
                                            column: column,
                                            value: wikiModel.Attachments(columnName: column.Name),
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues)
                                        : hb.Td(
                                            context: context,
                                            column: column,
                                            value: string.Empty,
                                            tabIndex: tabIndex,
                                            serverScriptValues: serverScriptValues);
                            default:
                                return hb;
                        }
                }
            }
        }

        private static HtmlBuilder TdCustomValue(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            string gridDesign,
            WikiModel wikiModel)
        {
            ss.IncludedColumns(gridDesign).ForEach(column =>
            {
                var value = string.Empty;
                switch (column.Name)
                {
                    case "SiteId": value = wikiModel.SiteId.GridText(
                        context: context,
                        column: column); break;
                    case "UpdatedTime": value = wikiModel.UpdatedTime.GridText(
                        context: context,
                        column: column); break;
                    case "WikiId": value = wikiModel.WikiId.GridText(
                        context: context,
                        column: column); break;
                    case "Ver": value = wikiModel.Ver.GridText(
                        context: context,
                        column: column); break;
                    case "Title": value = wikiModel.Title.GridText(
                        context: context,
                        column: column); break;
                    case "Body": value = wikiModel.Body.GridText(
                        context: context,
                        column: column); break;
                    case "TitleBody": value = wikiModel.TitleBody.GridText(
                        context: context,
                        column: column); break;
                    case "Locked": value = wikiModel.Locked.GridText(
                        context: context,
                        column: column); break;
                    case "Comments": value = wikiModel.Comments.GridText(
                        context: context,
                        column: column); break;
                    case "Creator": value = wikiModel.Creator.GridText(
                        context: context,
                        column: column); break;
                    case "Updator": value = wikiModel.Updator.GridText(
                        context: context,
                        column: column); break;
                    case "CreatedTime": value = wikiModel.CreatedTime.GridText(
                        context: context,
                        column: column); break;
                    default:
                        switch (Def.ExtendedColumnTypes.Get(column.Name))
                        {
                            case "Class":
                                value = wikiModel.Class(columnName: column.Name).GridText(
                                    context: context,
                                    column: column);
                                break;
                            case "Num":
                                value = wikiModel.Num(columnName: column.Name)?.Value?.GridText(
                                    context: context,
                                    column: column) ?? string.Empty;
                                break;
                            case "Date":
                                value = wikiModel.Date(columnName: column.Name).GridText(
                                    context: context,
                                    column: column);
                                break;
                            case "Description":
                                value = wikiModel.Description(columnName: column.Name).GridText(
                                    context: context,
                                    column: column);
                                break;
                            case "Check":
                                value = wikiModel.Check(columnName: column.Name).GridText(
                                    context: context,
                                    column: column);
                                break;
                            case "Attachments":
                                value = wikiModel.Attachments(columnName: column.Name).GridText(
                                    context: context,
                                    column: column);
                                break;
                        }
                        break;
                }
                gridDesign = gridDesign.Replace("[" + column.ColumnName + "]", value);
            });
            return hb.Td(action: () => hb
                .Div(css: "markup", action: () => hb
                    .Text(text: gridDesign)));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string EditorNew(Context context, SiteSettings ss)
        {
            var wikiId = Repository.ExecuteScalar_long(
                context: context,
                statements: Rds.SelectWikis(
                    column: Rds.WikisColumn().WikiId(),
                    where: Rds.WikisWhere().SiteId(ss.SiteId)));
            return Editor(
                context: context,
                ss: ss,
                wikiModel: new WikiModel(
                    context: context,
                    ss: ss,
                    methodType: BaseModel.MethodTypes.New));
        }

        public static string Editor(
            Context context, SiteSettings ss, long wikiId, bool clearSessions)
        {
            var wikiModel = new WikiModel(
                context: context,
                ss: ss,
                wikiId: wikiId,
                clearSessions: clearSessions,
                methodType: BaseModel.MethodTypes.Edit);
            return Editor(
                context: context,
                ss: ss,
                wikiModel: wikiModel);
        }

        public static string Editor(
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            bool editInDialog = false)
        {
            var invalid = WikiValidators.OnEditing(
                context: context,
                ss: ss,
                wikiModel: wikiModel);
            switch (invalid.Type)
            {
                case Error.Types.None: break;
                default: return HtmlTemplates.Error(
                    context: context,
                    errorData: invalid);
            }
            var hb = new HtmlBuilder();
            var scriptValues = wikiModel.SetByBeforeOpeningPageServerScript(
                context: context,
                ss: ss);
            return editInDialog
                ? hb.DialogEditorForm(
                    context: context,
                    ss: ss,
                    siteId: wikiModel.SiteId,
                    referenceId: wikiModel.WikiId,
                    isHistory: wikiModel.VerType == Versions.VerTypes.History,
                    action: () => hb.EditorInDialog(
                        context: context,
                        ss: ss,
                        wikiModel: wikiModel,
                        editInDialog: editInDialog))
                            .ToString()
                : hb.Template(
                    context: context,
                    ss: ss,
                    view: null,
                    verType: wikiModel.VerType,
                    methodType: wikiModel.MethodType,
                    siteId: wikiModel.SiteId,
                    parentId: ss.ParentId,
                    referenceType: "Wikis",
                    title: wikiModel.MethodType == BaseModel.MethodTypes.New
                        ? Displays.New(context: context)
                        : wikiModel.Title.DisplayValue,
                    body: wikiModel.Body,
                    useTitle: ss.TitleColumns?.Any(o => ss
                        .GetEditorColumnNames()
                        .Contains(o)) == true,
                    userScript: ss.EditorScripts(
                        context: context, methodType: wikiModel.MethodType),
                    userStyle: ss.EditorStyles(
                        context: context, methodType: wikiModel.MethodType),
                    scriptValues: scriptValues,
                    action: () => hb
                        .Editor(
                            context: context,
                            ss: ss,
                            wikiModel: wikiModel)
                        .Hidden(controlId: "DropDownSearchPageSize", value: Parameters.General.DropDownSearchPageSize.ToString()))
                            .ToString();
        }

        private static HtmlBuilder EditorInDialog(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            bool editInDialog)
        {
            return ss.Tabs?.Any() != true
                ? hb.FieldSetGeneral(
                    context: context,
                    ss: ss,
                    wikiModel: wikiModel,
                    editInDialog: editInDialog)
                : hb.Div(
                    id: "EditorTabsContainer",
                    css: "max",
                    attributes: new HtmlAttributes().TabActive(context: context),
                    action: () => hb
                        .EditorTabs(
                            context: context,
                            ss: ss,
                            wikiModel: wikiModel,
                            editInDialog: editInDialog)
                        .FieldSetGeneral(
                            context: context,
                            ss: ss,
                            wikiModel: wikiModel,
                            editInDialog: editInDialog)
                        .FieldSetTabs(
                            context: context,
                            ss: ss,
                            id: wikiModel.WikiId,
                            wikiModel: wikiModel,
                            editInDialog: editInDialog));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder Editor(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel)
        {
            var commentsColumn = ss.GetColumn(
                context: context,
                columnName: "Comments");
            var commentsColumnPermissionType = Permissions.ColumnPermissionType(
                context: context,
                ss: ss,
                column: commentsColumn,
                baseModel: wikiModel);
            var showComments = ss.ShowComments(commentsColumnPermissionType);
            var tabsCss = showComments ? null : "max";
            return hb.Div(id: "Editor", action: () => hb
                .Form(
                    attributes: new HtmlAttributes()
                        .Id("MainForm")
                        .Class("main-form")
                        .Action(Locations.ItemAction(
                            context: context,
                            id: wikiModel.WikiId != 0
                                ? wikiModel.WikiId
                                : wikiModel.SiteId)),
                    action: () => hb
                        .RecordHeader(
                            context: context,
                            ss: ss,
                            baseModel: wikiModel,
                            tableName: "Wikis")
                        .Div(
                            id: "EditorComments", action: () => hb
                                .Comments(
                                    context: context,
                                    ss: ss,
                                    comments: wikiModel.Comments,
                                    column: commentsColumn,
                                    verType: wikiModel.VerType,
                                    columnPermissionType: commentsColumnPermissionType),
                            _using: showComments)
                        .Div(id: "EditorTabsContainer", css: tabsCss, action: () => hb
                            .EditorTabs(
                                context: context,
                                ss: ss,
                                wikiModel: wikiModel)
                            .FieldSetGeneral(
                                context: context,
                                ss: ss,
                                wikiModel: wikiModel)
                            .FieldSet(
                                attributes: new HtmlAttributes()
                                    .Id("FieldSetHistories")
                                    .DataAction("Histories")
                                    .DataMethod("post"),
                                _using: wikiModel.MethodType != BaseModel.MethodTypes.New)
                            .FieldSet(
                                attributes: new HtmlAttributes()
                                    .Id("FieldSetRecordAccessControl")
                                    .DataAction("Permissions")
                                    .DataMethod("post"),
                                _using: context.CanManagePermission(ss: ss))
                            .MainCommands(
                                context: context,
                                ss: ss,
                                verType: wikiModel.VerType,
                                updateButton: true,
                                copyButton: false,
                                moveButton: false,
                                mailButton: true,
                                deleteButton: true))
                        .Hidden(
                            controlId: "BaseUrl",
                            value: Locations.BaseUrl(context: context))
                        .Hidden(
                            controlId: "Ver",
                            value: wikiModel.Ver.ToString())
                        .Hidden(
                            controlId: "MethodType",
                            value: "edit")
                        .Hidden(
                            controlId: "Wikis_Timestamp",
                            css: "always-send",
                            value: wikiModel.Timestamp)
                        .Hidden(
                            controlId: "SwitchTargets",
                            css: "always-send",
                            value: wikiModel.WikiId.ToString(),
                            _using: !context.Ajax || context.Action == "create")
                        .Hidden(
                            controlId: "TriggerRelatingColumns_Editor", 
                            value: Jsons.ToJson(ss.RelatingColumns)))
                .OutgoingMailsForm(
                    context: context,
                    ss: ss,
                    referenceType: "Wikis",
                    referenceId: wikiModel.WikiId,
                    referenceVer: wikiModel.Ver)
                .CopyDialog(
                    context: context,
                    referenceType: "items",
                    id: wikiModel.WikiId)
                .MoveDialog(context: context)
                .OutgoingMailDialog());
        }

        private static HtmlBuilder EditorTabs(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            bool editInDialog = false)
        {
            return hb.Ul(id: "EditorTabs", action: () => hb
                .Li(action: () => hb
                    .A(
                        href: "#FieldSetGeneral",
                        text: ss.GeneralTabLabelText))
                .Tabs(
                    context: context,
                    ss: ss)
                .Li(
                    _using: wikiModel.MethodType != BaseModel.MethodTypes.New
                        && !context.Publish
                        && !editInDialog,
                    action: () => hb
                        .A(
                            href: "#FieldSetHistories",
                            text: Displays.ChangeHistoryList(context: context)))
                .Li(
                    _using: context.CanManagePermission(ss: ss)
                        && !ss.Locked()
                        && wikiModel.MethodType != BaseModel.MethodTypes.New
                        && !editInDialog,
                    action: () => hb
                        .A(
                            href: "#FieldSetRecordAccessControl",
                            text: Displays.RecordAccessControl(context: context))));
        }

        private static HtmlBuilder FieldSetGeneral(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            DataSet dataSet = null,
            List<Link> links = null,
            bool editInDialog = false)
        {
            var mine = wikiModel.Mine(context: context);
            return hb.FieldSet(id: "FieldSetGeneral", action: () => hb
                .FieldSetGeneralColumns(
                    context: context,
                    ss: ss,
                    wikiModel: wikiModel,
                    dataSet: dataSet,
                    links: links,
                    editInDialog: editInDialog));
        }

        public static HtmlBuilder FieldSetGeneralColumns(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            DataSet dataSet = null,
            List<Link> links = null,
            bool preview = false,
            bool editInDialog = false)
        {
            hb.Fields(
                context: context,
                ss: ss,
                id: wikiModel.WikiId,
                wikiModel: wikiModel,
                dataSet: dataSet,
                links: links,
                preview: preview,
                editInDialog: editInDialog);
            if (!preview)
            {
                hb.VerUpCheckBox(
                    context: context,
                    ss: ss,
                    baseModel: wikiModel);
            }
            return hb;
        }

        public static HtmlBuilder Field(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            Column column,
            bool controlOnly = false,
            bool alwaysSend = false,
            string idSuffix = null,
            bool preview = false,
            bool disableSection = false)
        {
            var value = wikiModel.ControlValue(
                context: context,
                ss: ss,
                column: column);
            if (value != null)
            {
                hb.Field(
                    context: context,
                    ss: ss,
                    column: column,
                    serverScriptModelColumns: wikiModel
                        ?.ServerScriptModelRows
                        ?.Select(row => row.Columns.Get(column.ColumnName))
                        .ToArray(),
                    methodType: wikiModel.MethodType,
                    value: value,
                    columnPermissionType: Permissions.ColumnPermissionType(
                        context: context,
                        ss: ss,
                        column: column,
                        baseModel: wikiModel),
                    controlOnly: controlOnly,
                    alwaysSend: alwaysSend,
                    idSuffix: idSuffix,
                    preview: preview,
                    disableSection: disableSection);
            }
            return hb;
        }

        private static HtmlBuilder Tabs(this HtmlBuilder hb, Context context, SiteSettings ss)
        {
            ss.Tabs?.ForEach(tab => hb.Li(action: () => hb.A(
                href: $"#FieldSetTab{tab.Id}",
                action: () => hb.Label(action: () => hb.Text(tab.LabelText)))));
            return hb;
        }

        private static HtmlBuilder FieldSetTabs(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            long id,
            WikiModel wikiModel,
            DataSet dataSet = null,
            List<Link> links = null,
            bool preview = false,
            bool editInDialog = false)
        {
            dataSet = dataSet ?? HtmlLinks.DataSet(
                context: context,
                ss: ss,
                id: id);
            links = links ?? HtmlLinkCreations.Links(
                context: context,
                ss: ss);
            ss.Tabs?.Select((tab, index) => new { tab = tab, index = index + 1 })?.ForEach(data =>
            {
                hb.FieldSet(
                    id: $"FieldSetTab{data.tab.Id}",
                    css: " fieldset cf ui-tabs-panel ui-corner-bottom ui-widget-content ",
                    action: () => hb.Fields(
                        context: context,
                        ss: ss,
                        id: id,
                        tab: data.tab,
                        dataSet: dataSet,
                        links: links,
                        preview: preview,
                        editInDialog: editInDialog,
                        wikiModel: wikiModel,
                        tabIndex: data.index));
            });
            return hb;
        }

        private static HtmlBuilder Fields(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            long id,
            WikiModel wikiModel,
            DataSet dataSet = null,
            List<Link> links = null,
            bool preview = false,
            bool editInDialog = false)
        {
            return hb.Fields(
                context: context,
                ss: ss,
                id: id,
                tab: new Tab { Id = 0 },
                dataSet: !preview
                    ? dataSet ?? HtmlLinks.DataSet(
                        context: context,
                        ss: ss,
                        id: id)
                    : null,
                links: links ?? HtmlLinkCreations.Links(
                    context: context,
                    ss: ss),
                wikiModel: wikiModel,
                preview: preview,
                editInDialog: editInDialog);
        }

        private static HtmlBuilder Fields(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            long id,
            Tab tab,
            DataSet dataSet,
            List<Link> links,
            WikiModel wikiModel,
            bool preview = false,
            bool editInDialog = false,
            int tabIndex = 0)
        {
            ss
                .GetEditorColumns(
                    context: context,
                    tab: tab,
                    columnOnly: false)
                ?.Aggregate(new List<KeyValuePair<Section, List<string>>>(), (columns, column) =>
                {
                    var sectionId = ss.SectionId(column.ColumnName);
                    var section = ss
                        .Sections
                        ?.FirstOrDefault(o => o.Id == sectionId);
                    if (section != null)
                    {
                        columns.Add(new KeyValuePair<Section, List<string>>(
                            new Section
                            {
                                Id = section.Id,
                                LabelText = section.LabelText,
                                AllowExpand = section.AllowExpand,
                                Expand = section.Expand,
                                Hide = section.Hide
                            },
                            new List<string>()));
                    }
                    else
                    {
                        if (!columns.Any())
                        {
                            columns.Add(new KeyValuePair<Section, List<string>>(
                                null,
                                new List<string>()));
                        }
                        columns.Last().Value.Add(column.ColumnName);
                    }
                    return columns;
                }).ForEach(section =>
                {
                    if (section.Key == null)
                    {
                        hb.Fields(
                            context: context,
                            ss: ss,
                            id: id,
                            columnNames: section.Value,
                            dataSet: dataSet,
                            links: links,
                            wikiModel: wikiModel,
                            preview: preview,
                            editInDialog: editInDialog,
                            tabIndex: tabIndex);
                    }
                    else if (section.Key.Hide != true)
                    {
                        hb
                            .Div(
                                id: $"SectionFields{section.Key.Id}Container",
                                css: "section-fields-container",
                                action: () => hb
                                    .Div(action: () => hb.Label(
                                        css: "field-section" + (section.Key.AllowExpand == true
                                            ? " expand"
                                            : string.Empty),
                                        attributes: new HtmlAttributes()
                                            .For($"SectionFields{section.Key.Id}"),
                                        action: () => hb
                                            .Span(css: section.Key.AllowExpand == true
                                                ? section.Key.Expand == true
                                                    ? "ui-icon ui-icon-triangle-1-s"
                                                    : "ui-icon ui-icon-triangle-1-e"
                                                : string.Empty)
                                            .Text(text: section.Key.LabelText)))
                                    .Div(
                                        id: $"SectionFields{section.Key.Id}",
                                        css: section.Key.AllowExpand == true && section.Key.Expand != true
                                            ? "section-fields hidden"
                                            : "section-fields",
                                        action: () => hb.Fields(
                                            context: context,
                                            ss: ss,
                                            id: id,
                                            columnNames: section.Value,
                                            dataSet: dataSet,
                                            links: links,
                                            wikiModel: wikiModel,
                                            preview: preview,
                                            editInDialog: editInDialog,
                                            tabIndex: tabIndex)));
                    }
                });
            return hb;
        }

        private static HtmlBuilder Fields(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            long id,
            List<string> columnNames,
            DataSet dataSet,
            List<Link> links,
            WikiModel wikiModel,
            bool preview = false,
            bool editInDialog = false,
            int tabIndex = 0)
        {
            columnNames.ForEach(columnName => hb.Field(
                context: context,
                ss: ss,
                id: id,
                columnName: columnName,
                dataSet: dataSet,
                links: links,
                wikiModel: wikiModel,
                preview: preview,
                editInDialog: editInDialog,
                tabIndex: tabIndex));
            return hb;
        }

        private static HtmlBuilder Field(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            long id,
            string columnName,
            DataSet dataSet,
            List<Link> links,
            WikiModel wikiModel,
            bool preview = false,
            bool editInDialog = false,
            int tabIndex = 0)
        {
            var column = ss.GetColumn(
                context: context,
                columnName: columnName);
            var linkId = !preview && !editInDialog ? ss.LinkId(columnName) : 0;
            if (column != null)
            {
                hb.Field(
                    context: context,
                    ss: ss,
                    wikiModel: wikiModel,
                    column: column,
                    preview: preview);
            }
            else if (!editInDialog && linkId != 0)
            {
                hb.LinkField(
                    context: context,
                    ss: ss,
                    id: wikiModel.WikiId,
                    linkId: linkId,
                    links: links,
                    dataSet: dataSet,
                    methodType: wikiModel?.MethodType,
                    tabIndex: tabIndex);
            }
            return hb;
        }

        private static HtmlAttributes TabActive(
            this HtmlAttributes attributes,
            Context context)
        {
            var tabIndex = context.QueryStrings.Get("TabIndex").ToInt();
            return attributes.Add(
                name: "tab-active",
                value: tabIndex.ToString(),
                _using: tabIndex > 0);
        }

        public static string ControlValue(
            this WikiModel wikiModel,
            Context context,
            SiteSettings ss,
            Column column)
        {
            switch (column.Name)
            {
                case "WikiId":
                    return wikiModel.WikiId
                        .ToControl(
                            context: context,
                            ss: ss,
                            column: column);
                case "Ver":
                    return wikiModel.Ver
                        .ToControl(
                            context: context,
                            ss: ss,
                            column: column);
                case "Title":
                    return wikiModel.Title
                        .ToControl(
                            context: context,
                            ss: ss,
                            column: column);
                case "Body":
                    return wikiModel.Body
                        .ToControl(
                            context: context,
                            ss: ss,
                            column: column);
                case "Locked":
                    return wikiModel.Locked
                        .ToControl(
                            context: context,
                            ss: ss,
                            column: column);
                default:
                    switch (Def.ExtendedColumnTypes.Get(column.Name))
                    {
                        case "Class":
                            return wikiModel.Class(columnName: column.Name)
                                .ToControl(
                                    context: context,
                                    ss: ss,
                                    column: column);
                        case "Num":
                            return wikiModel.Num(columnName: column.Name)
                                .ToControl(
                                    context: context,
                                    ss: ss,
                                    column: column);
                        case "Date":
                            return wikiModel.Date(columnName: column.Name)
                                .ToControl(
                                    context: context,
                                    ss: ss,
                                    column: column);
                        case "Description":
                            return wikiModel.Description(columnName: column.Name)
                                .ToControl(
                                    context: context,
                                    ss: ss,
                                    column: column);
                        case "Check":
                            return wikiModel.Check(columnName: column.Name)
                                .ToControl(
                                    context: context,
                                    ss: ss,
                                    column: column);
                        case "Attachments":
                            return wikiModel.Attachments(columnName: column.Name)
                                .ToControl(
                                    context: context,
                                    ss: ss,
                                    column: column);
                        default: return null;
                    }
            }
        }

        private static HtmlBuilder MainCommandExtensions(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel)
        {
            return hb;
        }

        private static HtmlBuilder EditorExtensions(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel)
        {
            return hb;
        }

        public static string EditorJson(Context context, SiteSettings ss, long wikiId)
        {
            return EditorResponse(context, ss, new WikiModel(
                context, ss, wikiId,
                formData: context.QueryStrings.Bool("control-auto-postback") ? context.Forms : null)).ToJson();
        }

        private static ResponseCollection EditorResponse(
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            Message message = null,
            string switchTargets = null)
        {
            wikiModel.MethodType = wikiModel.WikiId == 0
                ? BaseModel.MethodTypes.New
                : BaseModel.MethodTypes.Edit;
            return new WikisResponseCollection(wikiModel)
                .Invoke("clearDialogs")
                .ReplaceAll("#MainContainer", Editor(context, ss, wikiModel))
                .Val("#SwitchTargets", switchTargets, _using: switchTargets != null)
                .SetMemory("formChanged", false)
                .Invoke("setCurrentIndex")
                .Message(message)
                .ClearFormData(_using: !context.QueryStrings.Bool("control-auto-postback"))
                .Log(context.GetLog());
        }

        public static ResponseCollection FieldResponse(
            this ResponseCollection res,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel,
            string idSuffix = null)
        {
            var serverScriptModelRow = wikiModel
                ?.ServerScriptModelRows
                ?.FirstOrDefault();
            var needReplaceHtml = serverScriptModelRow?.NeedReplaceHtml(
                context: context,
                ss: ss);
            res.Val(
                target: "#NeedReplaceHtml",
                value: needReplaceHtml?.ToJson());
            var columnNames = ss.GetEditorColumnNames(context.QueryStrings.Bool("control-auto-postback")
                ? ss.GetColumn(
                    context: context,
                    columnName: context.Forms.ControlId().Split_2nd('_'))
                : null);
            columnNames
                .Select(columnName => ss.GetColumn(
                    context: context,
                    columnName: columnName))
                .Where(column => column != null)
                .ForEach(column =>
                {
                    var serverScriptModelColumn = serverScriptModelRow
                        ?.Columns.Get(column.ColumnName);
                    if (needReplaceHtml?.Contains(column.ColumnName) == true)
                    {
                        res.ReplaceAll(
                            target: $"#Wikis_{column.Name}Field" + idSuffix,
                            value: new HtmlBuilder().Field(
                                context: context,
                                ss: ss,
                                wikiModel: wikiModel,
                                column: column,
                                idSuffix: idSuffix));
                    }
                    else
                    {
                        switch (column.Name)
                        {
                            case "WikiId":
                                res.Val(
                                    target: "#Wikis_WikiId" + idSuffix,
                                    value: wikiModel.WikiId.ToResponse(context: context, ss: ss, column: column),
                                    options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                break;
                            case "Title":
                                res.Val(
                                    target: "#Wikis_Title" + idSuffix,
                                    value: wikiModel.Title.ToResponse(context: context, ss: ss, column: column),
                                    options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                break;
                            case "Body":
                                res.Val(
                                    target: "#Wikis_Body" + idSuffix,
                                    value: wikiModel.Body.ToResponse(context: context, ss: ss, column: column),
                                    options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                break;
                            case "Locked":
                                res.Val(
                                    target: "#Wikis_Locked" + idSuffix,
                                    value: wikiModel.Locked,
                                    options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                break;
                            default:
                                switch (Def.ExtendedColumnTypes.Get(column.Name))
                                {
                                    case "Class":
                                        res.Val(
                                            target: $"#Wikis_{column.Name}{idSuffix}",
                                            value: wikiModel.Class(columnName: column.Name).ToResponse(
                                                context: context,
                                                ss: ss,
                                                column: column),
                                            options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                        break;
                                    case "Num":
                                        res.Val(
                                            target: $"#Wikis_{column.Name}{idSuffix}",
                                            value: wikiModel.Num(columnName: column.Name).ToResponse(
                                                context: context,
                                                ss: ss,
                                                column: column),
                                            options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                        break;
                                    case "Date":
                                        res.Val(
                                            target: $"#Wikis_{column.Name}{idSuffix}",
                                            value: wikiModel.Date(columnName: column.Name).ToResponse(
                                                context: context,
                                                ss: ss,
                                                column: column),
                                            options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                        break;
                                    case "Description":
                                        res.Val(
                                            target: $"#Wikis_{column.Name}{idSuffix}",
                                            value: wikiModel.Description(columnName: column.Name).ToResponse(
                                                context: context,
                                                ss: ss,
                                                column: column),
                                            options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                        break;
                                    case "Check":
                                        res.Val(
                                            target: $"#Wikis_{column.Name}{idSuffix}",
                                            value: wikiModel.Check(columnName: column.Name),
                                            options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                        break;
                                    case "Attachments":
                                        res.ReplaceAll(
                                            target: $"#Wikis_{column.Name}Field",
                                            value: new HtmlBuilder()
                                                .FieldAttachments(
                                                    context: context,
                                                    fieldId: $"Wikis_{column.Name}Field",
                                                    controlId: $"Wikis_{column.Name}",
                                                    columnName: column.ColumnName,
                                                    fieldCss: column.FieldCss
                                                        + (column.TextAlign == SiteSettings.TextAlignTypes.Right
                                                            ? " right-align"
                                                            : string.Empty),
                                                    fieldDescription: column.Description,
                                                    labelText: column.LabelText,
                                                    value: wikiModel.Attachments(columnName: column.Name).ToJson(),
                                                    readOnly: Permissions.ColumnPermissionType(
                                                        context: context,
                                                        ss: ss,
                                                        column: column,
                                                        baseModel: wikiModel)
                                                            != Permissions.ColumnPermissionTypes.Update),
                                            options: column.ResponseValOptions(serverScriptModelColumn: serverScriptModelColumn));
                                        break;
                                }
                                break;
                        }
                    }
                });
            return res;
        }

        public static string Update(Context context, SiteSettings ss, long wikiId, string previousTitle)
        {
            var wikiModel = new WikiModel(
                context: context,
                ss: ss,
                wikiId: wikiId,
                formData: context.Forms);
            var invalid = WikiValidators.OnUpdating(
                context: context,
                ss: ss,
                wikiModel: wikiModel);
            switch (invalid.Type)
            {
                case Error.Types.None: break;
                default: return invalid.MessageJson(context: context);
            }
            if (wikiModel.AccessStatus != Databases.AccessStatuses.Selected)
            {
                return Messages.ResponseDeleteConflicts(context: context).ToJson();
            }
            var errorData = wikiModel.Update(
                context: context,
                ss: ss,
                notice: true,
                previousTitle: previousTitle,
                permissions: context.Forms.List("CurrentPermissionsAll"),
                permissionChanged: context.Forms.Exists("CurrentPermissionsAll"));
            switch (errorData.Type)
            {
                case Error.Types.None:
                    var res = new WikisResponseCollection(wikiModel);
                    res.ReplaceAll("#Breadcrumb", new HtmlBuilder()
                        .Breadcrumb(context: context, ss: ss));
                    return ResponseByUpdate(res, context, ss, wikiModel)
                        .PrependComment(
                            context: context,
                            ss: ss,
                            column: ss.GetColumn(context: context, columnName: "Comments"),
                            comments: wikiModel.Comments,
                            verType: wikiModel.VerType)
                        .ToJson();
                case Error.Types.UpdateConflicts:
                    return Messages.ResponseUpdateConflicts(
                        context: context,
                        data: wikiModel.Updator.Name)
                            .ToJson();
                default:
                    return errorData.MessageJson(context: context);
            }
        }

        private static ResponseCollection ResponseByUpdate(
            WikisResponseCollection res,
            Context context,
            SiteSettings ss,
            WikiModel wikiModel)
        {
            ss.ClearColumnAccessControlCaches(baseModel: wikiModel);
            if (context.Forms.Bool("IsDialogEditorForm"))
            {
                var view = Views.GetBySession(
                    context: context,
                    ss: ss,
                    setSession: false);
                var gridData = new GridData(
                    context: context,
                    ss: ss,
                    view: view,
                    tableType: Sqls.TableTypes.Normal,
                    where: Rds.WikisWhere().WikiId(wikiModel.WikiId));
                var columns = ss.GetGridColumns(
                    context: context,
                    view: view,
                    checkPermission: true);
                return res
                    .ReplaceAll(
                        $"[data-id=\"{wikiModel.WikiId}\"][data-latest]",
                        new HtmlBuilder().GridRows(
                            context: context,
                            ss: ss,
                            dataRows: gridData.DataRows,
                            columns: columns))
                    .CloseDialog()
                    .Message(Messages.Updated(
                        context: context,
                        data: wikiModel.Title.DisplayValue));
            }
            else if (wikiModel.Locked)
            {
                ss.SetLockedRecord(
                    context: context,
                    time: wikiModel.UpdatedTime,
                    user: wikiModel.Updator);
                return EditorResponse(
                    context: context,
                    ss: ss,
                    wikiModel: wikiModel)
                        .SetMemory("formChanged", false)
                        .Message(Messages.Updated(
                            context: context,
                            data: wikiModel.Title.DisplayValue))
                        .ClearFormData();
            }
            else
            {
                var verUp = Versions.VerUp(
                    context: context,
                    ss: ss,
                    verUp: false);
                return res
                    .Ver(context: context, ss: ss)
                    .Timestamp(context: context, ss: ss)
                    .FieldResponse(context: context, ss: ss, wikiModel: wikiModel)
                    .Val("#VerUp", verUp)
                    .Val("#Ver", wikiModel.Ver)
                    .Disabled("#VerUp", verUp)
                    .Html("#HeaderTitle", HttpUtility.HtmlEncode(wikiModel.Title.DisplayValue))
                    .Html("#RecordInfo", new HtmlBuilder().RecordInfo(
                        context: context,
                        baseModel: wikiModel,
                        tableName: "Wikis"))
                    .Html("#Links", new HtmlBuilder().Links(
                        context: context,
                        ss: ss,
                        id: wikiModel.WikiId))
                    .Links(
                        context: context,
                        ss: ss,
                        id: wikiModel.WikiId,
                        methodType: wikiModel.MethodType)
                    .SetMemory("formChanged", false)
                    .Message(Messages.Updated(
                        context: context,
                        data: wikiModel.Title.DisplayValue))
                    .Comment(
                        context: context,
                        ss: ss,
                        column: ss.GetColumn(context: context, columnName: "Comments"),
                        comments: wikiModel.Comments,
                        deleteCommentId: wikiModel.DeleteCommentId)
                    .ClearFormData();
            }
        }

        public static string Delete(Context context, SiteSettings ss, long wikiId)
        {
            var wikiModel = new WikiModel(context, ss, wikiId);
            var invalid = WikiValidators.OnDeleting(
                context: context,
                ss: ss,
                wikiModel: wikiModel);
            switch (invalid.Type)
            {
                case Error.Types.None: break;
                default: return invalid.MessageJson(context: context);
            }
            var errorData = wikiModel.Delete(context: context, ss: ss, notice: true);
            switch (errorData.Type)
            {
                case Error.Types.None:
                    SessionUtilities.Set(
                        context: context,
                        message: Messages.Deleted(
                            context: context,
                            data: wikiModel.Title.Value));
                    var res = new WikisResponseCollection(wikiModel);
                    res
                        .SetMemory("formChanged", false)
                        .Invoke("back");
                    return res.ToJson();
                default:
                    return errorData.MessageJson(context: context);
            }
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string Restore(Context context, SiteSettings ss)
        {
            if (context.CanManageSite(ss: ss))
            {
                var selector = new RecordSelector(context: context);
                var count = 0;
                if (selector.All)
                {
                    count = Restore(
                        context: context,
                        ss: ss,
                        selected: selector.Selected,
                        negative: true);
                }
                else
                {
                    if (selector.Selected.Any())
                    {
                        count = Restore(
                            context: context,
                            ss: ss,
                            selected: selector.Selected);
                    }
                    else
                    {
                        return Messages.ResponseSelectTargets(context: context).ToJson();
                    }
                }
                Summaries.Synchronize(context: context, ss: ss);
                return "";
            }
            else
            {
                return Messages.ResponseHasNotPermission(context: context).ToJson();
            }
        }

        public static int Restore(
            Context context, SiteSettings ss, List<long> selected, bool negative = false)
        {
            var where = Rds.WikisWhere()
                .SiteId(
                    value: ss.SiteId,
                    tableName: "Wikis_Deleted")
                .WikiId_In(
                    value: selected,
                    tableName: "Wikis_Deleted",
                    negative: negative,
                    _using: selected.Any())
                .WikiId_In(
                    tableName: "Wikis_Deleted",
                    sub: Rds.SelectWikis(
                        tableType: Sqls.TableTypes.Deleted,
                        column: Rds.WikisColumn().WikiId(),
                        where: Views.GetBySession(
                            context: context,
                            ss: ss)
                                .Where(
                                    context: context,
                                    ss: ss,
                                    itemJoin: false)));
            var sub = Rds.SelectWikis(
                tableType: Sqls.TableTypes.Deleted,
                _as: "Wikis_Deleted",
                column: Rds.WikisColumn()
                    .WikiId(tableName: "Wikis_Deleted"),
                where: where);
            var column = new Rds.WikisColumnCollection();
                column.WikiId();
                ss.Columns
                    .Where(o => o.TypeCs == "Attachments")
                    .Select(o => o.ColumnName)
                    .ForEach(columnName =>
                        column.Add($"\"{columnName}\""));
            var attachments = Repository.ExecuteTable(
                context: context,
                statements: Rds.SelectWikis(
                    tableType: Sqls.TableTypes.Deleted,
                    column: column,
                    where: Rds.WikisWhere()
                        .SiteId(ss.SiteId)
                        .WikiId_In(sub: sub)))
                .AsEnumerable()
                .Select(dataRow => new
                {
                    wikiId = dataRow.Long("WikiId"),
                    attachments = dataRow
                        .Columns()
                        .Where(columnName => columnName.StartsWith("Attachments"))
                        .SelectMany(columnName => 
                            Jsons.Deserialize<IEnumerable<Attachment>>(dataRow.String(columnName)) 
                                ?? Enumerable.Empty<Attachment>())
                        .Where(o => o != null)
                        .Select(o => o.Guid)
                        .Distinct()
                        .ToArray()
                })
                .Where(o => o.attachments.Length > 0);
            var guid = Strings.NewGuid();
            var count = Repository.ExecuteScalar_response(
                context: context,
                connectionString: Parameters.Rds.OwnerConnectionString,
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.UpdateItems(
                        tableType: Sqls.TableTypes.Deleted,
                        where: Rds.ItemsWhere()
                            .SiteId(ss.SiteId)
                            .ReferenceId_In(sub: sub),
                        param: Rds.ItemsParam()
                            .ReferenceType(guid)),
                    Rds.RestoreWikis(
                        factory: context,
                        where: where),
                    Rds.RowCount(),
                    Rds.RestoreBinaries(
                        factory: context,
                        where: Rds.BinariesWhere()
                            .ReferenceId(sub: Rds.SelectItems(
                                tableType: Sqls.TableTypes.Deleted,
                                column: Rds.ItemsColumn().ReferenceId(),
                                where: Rds.ItemsWhere().ReferenceType(guid)))
                            .BinaryType("Images")),
                    Rds.RestoreItems(
                        factory: context,
                        where: Rds.ItemsWhere()
                            .SiteId(ss.SiteId)
                            .ReferenceType(guid)),
                    Rds.UpdateItems(
                        where: Rds.ItemsWhere()
                            .SiteId(ss.SiteId)
                            .ReferenceType(guid),
                        param: Rds.ItemsParam()
                            .ReferenceType(ss.ReferenceType))
                }).Count.ToInt();
            attachments.ForEach(o =>
            {
                RestoreAttachments(context, o.wikiId, o.attachments);
            });    
            return count;
        }

        private static void RestoreAttachments(Context context, long wikiId, IList<string> attachments)
        {
            var raw = $" ({string.Join(", ", attachments.Select(o => $"'{o}'"))}) ";
            Repository.ExecuteNonQuery(
                context: context,
                connectionString: Parameters.Rds.OwnerConnectionString,
                statements: new SqlStatement[] {
                    Rds.DeleteBinaries(
                        factory: context,
                        where: Rds.BinariesWhere()
                            .ReferenceId(wikiId)
                            .BinaryType("Attachments")
                            .Binaries_Guid(
                                _operator:" not in ",
                                raw: raw,
                                _using: attachments.Any())),
                    Rds.RestoreBinaries(
                        factory: context,
                        where: Rds.BinariesWhere()
                            .ReferenceId(wikiId)
                            .BinaryType("Attachments")
                            .Binaries_Guid(
                                _operator: $" in ",
                                raw: raw),
                        _using: attachments.Any())
            }, transactional: true);
        }

        public static string RestoreFromHistory(
            Context context, SiteSettings ss, long wikiId)
        {
            if (!Parameters.History.Restore)
            {
                return Error.Types.InvalidRequest.MessageJson(context: context);
            }
            var wikiModel = new WikiModel(context, ss, wikiId);
            var invalid = WikiValidators.OnUpdating(
                context: context,
                ss: ss,
                wikiModel: wikiModel);
            switch (invalid.Type)
            {
                case Error.Types.None: break;
                default: return invalid.MessageJson(context: context);
            }
            var ver = context.Forms.Data("GridCheckedItems")
                .Split(',')
                .Where(o => !o.IsNullOrEmpty())
                .ToList();
            if (ver.Count() != 1)
            {
                return Error.Types.SelectOne.MessageJson(context: context);
            }
            wikiModel.SetByModel(new WikiModel().Get(
                context: context,
                ss: ss,
                tableType: Sqls.TableTypes.History,
                where: Rds.WikisWhere()
                    .SiteId(ss.SiteId)
                    .WikiId(wikiId)
                    .Ver(ver.First().ToInt())));
            wikiModel.VerUp = true;
            var errorData = wikiModel.Update(
                context: context,
                ss: ss,
                otherInitValue: true);
            switch (errorData.Type)
            {
                case Error.Types.None:
                    RestoreAttachments(
                        context: context,
                        wikiId: wikiModel.WikiId,
                        attachments: wikiModel
                            .AttachmentsHash
                            .Values
                            .SelectMany(o => o.AsEnumerable())
                            .Select(o => o.Guid)
                            .Distinct().ToArray());
                    SessionUtilities.Set(
                        context: context,
                        message: Messages.RestoredFromHistory(
                            context: context,
                            data: ver.First().ToString()));
                    return new ResponseCollection()
                        .SetMemory("formChanged", false)
                        .Href(Locations.ItemEdit(
                            context: context,
                            id: wikiId))
                        .ToJson();
                default:
                    return errorData.MessageJson(context: context);
            }
        }

        public static string Histories(
            Context context, SiteSettings ss, long wikiId, Message message = null)
        {
            var wikiModel = new WikiModel(context: context, ss: ss, wikiId: wikiId);
            var columns = ss.GetHistoryColumns(context: context, checkPermission: true);
            if (!context.CanRead(ss: ss))
            {
                return Error.Types.HasNotPermission.MessageJson(context: context);
            }
            var hb = new HtmlBuilder();
            hb
                .HistoryCommands(context: context, ss: ss)
                .Table(
                    attributes: new HtmlAttributes().Class("grid history"),
                    action: () => hb
                        .THead(action: () => hb
                            .GridHeader(
                                context: context,
                                ss: ss,
                                columns: columns,
                                sort: false,
                                checkRow: true))
                        .TBody(action: () => hb
                            .HistoriesTableBody(
                                context: context,
                                ss: ss,
                                columns: columns,
                                wikiModel: wikiModel)));
            return new WikisResponseCollection(wikiModel)
                .Html("#FieldSetHistories", hb)
                .Message(message)
                .ToJson();
        }

        private static void HistoriesTableBody(
            this HtmlBuilder hb,
            Context context,
            SiteSettings ss,
            List<Column> columns,
            WikiModel wikiModel)
        {
            new WikiCollection(
                context: context,
                ss: ss,
                column: HistoryColumn(columns),
                where: Rds.WikisWhere().WikiId(wikiModel.WikiId),
                orderBy: Rds.WikisOrderBy().Ver(SqlOrderBy.Types.desc),
                tableType: Sqls.TableTypes.NormalAndHistory)
                    .ForEach(wikiModelHistory => hb
                        .Tr(
                            attributes: new HtmlAttributes()
                                .Class("grid-row")
                                .DataAction("History")
                                .DataMethod("post")
                                .DataVer(wikiModelHistory.Ver)
                                .DataLatest(
                                    value: 1,
                                    _using: wikiModelHistory.Ver == wikiModel.Ver),
                            action: () =>
                            {
                                hb.Td(
                                    css: "grid-check-td",
                                    action: () => hb
                                        .CheckBox(
                                            controlCss: "grid-check",
                                            _checked: false,
                                            dataId: wikiModelHistory.Ver.ToString(),
                                            _using: wikiModelHistory.Ver < wikiModel.Ver));
                                columns.ForEach(column => hb
                                    .TdValue(
                                        context: context,
                                        ss: ss,
                                        column: column,
                                        wikiModel: wikiModelHistory));
                            }));
        }

        private static SqlColumnCollection HistoryColumn(List<Column> columns)
        {
            var sqlColumn = new Rds.WikisColumnCollection()
                .WikiId()
                .Ver();
            columns.ForEach(column =>
                sqlColumn.WikisColumn(columnName: column.ColumnName));
            return sqlColumn;
        }

        public static string History(Context context, SiteSettings ss, long wikiId)
        {
            var wikiModel = new WikiModel(context: context, ss: ss, wikiId: wikiId);
            wikiModel.Get(
                context: context,
                ss: ss,
                where: Rds.WikisWhere()
                    .WikiId(wikiModel.WikiId)
                    .Ver(context.Forms.Int("Ver")),
                tableType: Sqls.TableTypes.NormalAndHistory);
            wikiModel.VerType = context.Forms.Bool("Latest")
                ? Versions.VerTypes.Latest
                : Versions.VerTypes.History;
            return EditorResponse(context, ss, wikiModel)
                .PushState("History", Locations.Get(
                    context: context,
                    parts: new string[]
                    {
                        "Items",
                        wikiId.ToString() 
                            + (wikiModel.VerType == Versions.VerTypes.History
                                ? "?ver=" + context.Forms.Int("Ver") 
                                : string.Empty)
                    }))
                .ToJson();
        }

        public static string DeleteHistory(Context context, SiteSettings ss, long wikiId)
        {
            var wikiModel = new WikiModel(
                context: context,
                ss: ss,
                wikiId: wikiId);
            var invalid = WikiValidators.OnDeleteHistory(
                context: context,
                ss: ss,
                wikiModel: wikiModel);
            switch (invalid.Type)
            {
                case Error.Types.None: break;
                default: return HtmlTemplates.Error(
                    context: context,
                    errorData: invalid);
            }
            var selector = new RecordSelector(context: context);
            var selected = selector
                .Selected
                .Select(o => o.ToInt())
                .ToList();
            var count = 0;
            if (selector.All)
            {
                count = DeleteHistory(
                    context: context,
                    ss: ss,
                    wikiId: wikiId,
                    selected: selected,
                    negative: true);
            }
            else
            {
                if (selector.Selected.Any())
                {
                    count = DeleteHistory(
                        context: context,
                        ss: ss,
                        wikiId: wikiId,
                        selected: selected);
                }
                else
                {
                    return Messages.ResponseSelectTargets(context: context).ToJson();
                }
            }
            return Histories(
                context: context,
                ss: ss,
                wikiId: wikiId,
                message: Messages.HistoryDeleted(
                    context: context,
                    data: count.ToString()));
        }

        private static int DeleteHistory(
            Context context,
            SiteSettings ss,
            long wikiId,
            List<int> selected,
            bool negative = false)
        {
            return Repository.ExecuteScalar_response(
                context: context,
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.PhysicalDeleteWikis(
                        tableType: Sqls.TableTypes.History,
                        where: Rds.WikisWhere()
                            .SiteId(
                                value: ss.SiteId,
                                tableName: "Wikis_History")
                            .WikiId(
                                value: wikiId,
                                tableName: "Wikis_History")
                            .Ver_In(
                                value: selected,
                                tableName: "Wikis_History",
                                negative: negative,
                                _using: selected.Any())
                            .WikiId_In(
                                tableName: "Wikis_History",
                                sub: Rds.SelectWikis(
                                    tableType: Sqls.TableTypes.History,
                                    column: Rds.WikisColumn().WikiId(),
                                    where: Views.GetBySession(
                                        context: context,
                                        ss: ss).Where(
                                            context: context,
                                            ss: ss)))),
                    Rds.RowCount()
                }).Count.ToInt();
        }

        public static string UnlockRecord(
            Context context, SiteSettings ss, long wikiId)
        {
            var wikiModel = new WikiModel(
                context: context,
                ss: ss,
                wikiId: wikiId,
                formData: context.Forms);
            var invalid = WikiValidators.OnUnlockRecord(
                context: context,
                ss: ss);
            switch (invalid.Type)
            {
                case Error.Types.None: break;
                default: return invalid.MessageJson(context: context);
            }
            wikiModel.Timestamp = context.Forms.Get("Timestamp");
            wikiModel.Locked = false;
            var errorData = wikiModel.Update(
                context: context,
                ss: ss,
                notice: true);
            switch (errorData.Type)
            {
                case Error.Types.None:
                    ss.LockedRecordTime = null;
                    ss.LockedRecordUser = null;
                    return EditorResponse(
                        context: context,
                        ss: ss,
                        wikiModel: wikiModel)
                            .SetMemory("formChanged", false)
                            .Message(Messages.UnlockedRecord(context: context))
                            .ClearFormData()
                            .ToJson();
                case Error.Types.UpdateConflicts:
                    return Messages.ResponseUpdateConflicts(
                        context: context,
                        data: wikiModel.Updator.Name)
                            .ToJson();
                default:
                    return errorData.MessageJson(context: context);
            }
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string PreviewTemplate(Context context, SiteSettings ss, string body)
        {
            var hb = new HtmlBuilder();
            var name = Strings.NewGuid();
            return hb
                .Div(css: "samples-displayed", action: () => hb
                    .Text(text: Displays.SamplesDisplayed(context: context)))
                .Div(css: "template-tab-container", action: () => hb
                    .Ul(action: () => hb
                        .Li(action: () => hb
                            .A(
                                href: "#" + name + "Editor",
                                text: Displays.Editor(context: context))))
                    .FieldSet(
                        id: name + "Editor",
                        action: () => hb
                            .FieldSetGeneralColumns(
                                context: context,
                                ss: ss,
                                wikiModel: new WikiModel() { Body = body },
                                preview: true)))
                                    .ToString();
        }
    }
}
