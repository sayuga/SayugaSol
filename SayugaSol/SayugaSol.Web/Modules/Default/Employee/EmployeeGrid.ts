
namespace SayugaSol.Default {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.filterable()
    export class EmployeeGrid extends Serenity.EntityGrid<EmployeeRow, any> {
        protected getColumnsKey() { return 'Default.Employee'; }
        protected getDialogType() { return EmployeeDialog; }
        protected getIdProperty() { return EmployeeRow.idProperty; }
        protected getLocalTextPrefix() { return EmployeeRow.localTextPrefix; }
        protected getService() { return EmployeeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}