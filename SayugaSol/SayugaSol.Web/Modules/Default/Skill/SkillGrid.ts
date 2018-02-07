
namespace SayugaSol.Default {
    
    @Serenity.Decorators.registerClass()
    export class SkillGrid extends Serenity.EntityGrid<SkillRow, any> {
        protected getColumnsKey() { return 'Default.Skill'; }
        protected getDialogType() { return SkillDialog; }
        protected getIdProperty() { return SkillRow.idProperty; }
        protected getLocalTextPrefix() { return SkillRow.localTextPrefix; }
        protected getService() { return SkillService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}