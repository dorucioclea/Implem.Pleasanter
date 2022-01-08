﻿using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Settings;
using Implem.Pleasanter.Models;
using System.Web.Mvc;
namespace Implem.Pleasanter.Controllers
{
    public class Api_GroupsController
    {
        public ContentResult Get(Context context, int id)
        {
            var log = new SysLogModel(context: context);
            var result = context.Authenticated
                ? GroupUtilities.GetByApi(
                    context: context,
                    ss: SiteSettingsUtilities.ApiGroupsSiteSettings(context),
                    groupId: id)
                : ApiResults.Unauthorized(context: context);
            log.Finish(context: context, responseSize: result.Content.Length);
            return result;
        }
    }
}