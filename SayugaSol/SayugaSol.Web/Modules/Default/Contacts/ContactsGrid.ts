
namespace SayugaSol.Default {
    
    @Serenity.Decorators.registerClass()
    export class ContactsGrid extends Serenity.EntityGrid<ContactsRow, any> {
        protected getColumnsKey() { return 'Default.Contacts'; }
        protected getDialogType() { return ContactsDialog; }
        protected getIdProperty() { return ContactsRow.idProperty; }
        protected getLocalTextPrefix() { return ContactsRow.localTextPrefix; }
        protected getService() { return ContactsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}