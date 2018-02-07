namespace SayugaSol.Default {
    export interface ContactsForm {
        CompanyName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        Title: Serenity.StringEditor;
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

    export class ContactsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Contacts';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ContactsForm.init)  {
                ContactsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.TextAreaEditor;

                Q.initFormType(ContactsForm, [
                    'CompanyName', w0,
                    'LastName', w0,
                    'FirstName', w0,
                    'Title', w0,
                    'Address', w0,
                    'City', w0,
                    'Region', w0,
                    'PostalCode', w0,
                    'Country', w0,
                    'Email', w1,
                    'Phone1', w0,
                    'Phone1Type', w2,
                    'Phone2', w0,
                    'Phone2Type', w2,
                    'Notes', w3
                ]);
            }
        }
    }
}

