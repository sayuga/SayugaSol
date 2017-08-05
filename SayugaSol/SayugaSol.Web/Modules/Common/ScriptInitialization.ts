/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace SayugaSol.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('SayugaSol');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}