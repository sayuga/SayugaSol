
namespace SayugaSol.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ContactsDialog extends Serenity.EntityDialog<ContactsRow, any> {
        protected getFormKey() { return ContactsForm.formKey; }
        protected getIdProperty() { return ContactsRow.idProperty; }
        protected getLocalTextPrefix() { return ContactsRow.localTextPrefix; }
        protected getNameProperty() { return ContactsRow.nameProperty; }
        protected getService() { return ContactsService.baseUrl; }

        protected form = new ContactsForm(this.idPrefix);

    }
}