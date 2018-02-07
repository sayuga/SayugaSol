namespace SayugaSol.Default {
    export interface SkillForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class SkillForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Skill';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SkillForm.init)  {
                SkillForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;

                Q.initFormType(SkillForm, [
                    'Name', w0,
                    'Description', w1
                ]);
            }
        }
    }
}

