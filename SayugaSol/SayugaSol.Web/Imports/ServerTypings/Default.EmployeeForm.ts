namespace SayugaSol.Default {
    export interface EmployeeForm {
        Photo: Serenity.ImageUploadEditor;
        PhotoPath: Serenity.StringEditor;
        ReportsTo: Serenity.IntegerEditor;
        Title: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        Dob: Serenity.DateEditor;
        HireDate: Serenity.DateEditor;
        SkillId: Serenity.LookupEditor;
        CertificationId: Serenity.LookupEditor;
        Address: Serenity.StringEditor;
        City: Serenity.StringEditor;
        Region: Serenity.StringEditor;
        PostalCode: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        Phone1: Serenity.StringEditor;
        Phone1Type: Serenity.IntegerEditor;
        Phone2: Serenity.StringEditor;
        Phone2Type: Serenity.IntegerEditor;
        Notes: Serenity.TextAreaEditor;
    }

    export class EmployeeForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Employee';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmployeeForm.init)  {
                EmployeeForm.init = true;

                var s = Serenity;
                var w0 = s.ImageUploadEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;
                var w4 = s.LookupEditor;
                var w5 = s.EmailEditor;
                var w6 = s.TextAreaEditor;

                Q.initFormType(EmployeeForm, [
                    'Photo', w0,
                    'PhotoPath', w1,
                    'ReportsTo', w2,
                    'Title', w1,
                    'LastName', w1,
                    'FirstName', w1,
                    'Dob', w3,
                    'HireDate', w3,
                    'SkillId', w4,
                    'CertificationId', w4,
                    'Address', w1,
                    'City', w1,
                    'Region', w1,
                    'PostalCode', w1,
                    'Country', w1,
                    'Email', w5,
                    'Phone1', w1,
                    'Phone1Type', w2,
                    'Phone2', w1,
                    'Phone2Type', w2,
                    'Notes', w6
                ]);
            }
        }
    }
}

