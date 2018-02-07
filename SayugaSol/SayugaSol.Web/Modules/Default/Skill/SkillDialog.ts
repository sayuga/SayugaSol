
namespace SayugaSol.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class SkillDialog extends Serenity.EntityDialog<SkillRow, any> {
        protected getFormKey() { return SkillForm.formKey; }
        protected getIdProperty() { return SkillRow.idProperty; }
        protected getLocalTextPrefix() { return SkillRow.localTextPrefix; }
        protected getNameProperty() { return SkillRow.nameProperty; }
        protected getService() { return SkillService.baseUrl; }

        protected form = new SkillForm(this.idPrefix);

    }
}