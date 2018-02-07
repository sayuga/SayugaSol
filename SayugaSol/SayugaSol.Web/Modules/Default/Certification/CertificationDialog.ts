
namespace SayugaSol.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CertificationDialog extends Serenity.EntityDialog<CertificationRow, any> {
        protected getFormKey() { return CertificationForm.formKey; }
        protected getIdProperty() { return CertificationRow.idProperty; }
        protected getLocalTextPrefix() { return CertificationRow.localTextPrefix; }
        protected getNameProperty() { return CertificationRow.nameProperty; }
        protected getService() { return CertificationService.baseUrl; }

        protected form = new CertificationForm(this.idPrefix);

    }
}