
namespace SayugaSol.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class EmployeeDialog extends Serenity.EntityDialog<EmployeeRow, any> {
        protected getFormKey() { return EmployeeForm.formKey; }
        protected getIdProperty() { return EmployeeRow.idProperty; }
        protected getLocalTextPrefix() { return EmployeeRow.localTextPrefix; }
        protected getNameProperty() { return EmployeeRow.nameProperty; }
        protected getService() { return EmployeeService.baseUrl; }

        protected form = new EmployeeForm(this.idPrefix);

    }
}