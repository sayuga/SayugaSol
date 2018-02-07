namespace SayugaSol.Default {
    export interface CertificationForm {
        Name: Serenity.StringEditor;
        DateAcquired: Serenity.DateEditor;
        ExpirationDate: Serenity.DateEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class CertificationForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Certification';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CertificationForm.init)  {
                CertificationForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(CertificationForm, [
                    'Name', w0,
                    'DateAcquired', w1,
                    'ExpirationDate', w1,
                    'Description', w2
                ]);
            }
        }
    }
}

