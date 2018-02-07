
namespace SayugaSol.Default {
    
    @Serenity.Decorators.registerClass()
    export class CertificationGrid extends Serenity.EntityGrid<CertificationRow, any> {
        protected getColumnsKey() { return 'Default.Certification'; }
        protected getDialogType() { return CertificationDialog; }
        protected getIdProperty() { return CertificationRow.idProperty; }
        protected getLocalTextPrefix() { return CertificationRow.localTextPrefix; }
        protected getService() { return CertificationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}